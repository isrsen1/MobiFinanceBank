using HashLibrary;
using MobiFinanceBank.DAL.Repositories;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobiFinanceBank.Services
{
    public class LoginService : ILoginService
    {
        private readonly IEmployeeRepository employeeRepository;
        private HashLibrary.HashedPassword hash;
        private string Hashed;
        private string Salted;



        public LoginService(IEmployeeRepository _employeeRepository)
        {          
              this.employeeRepository = _employeeRepository;
            
        }
        public Employee CheckCredentials(string username, string password)
        {
             //Employee employee=new Employee();
             var employee = this.employeeRepository.GetEmployeeByName(username);
            
            try
            {
               // hash = HashLibrary.HashedPassword.New(password);                
               // Hashed = "ÙDĸÓê;ĩďu.¯&ĉYěL{'ÌgÎÆÜ*ĮìÃy®ŀ¹¢";
               // Salted = "r_¯ß]Ĵŀ5ĻÕÔø«4-ê_ÜoHĕÐ`?ĩëý½Ġïİė";
                hash = new HashLibrary.HashedPassword(employee.PasswordHash, employee.PasswordSalt);                             
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            Console.WriteLine("hash: " + hash.Hash);
            Console.WriteLine("salt: " + hash.Salt);
            //System.IO.File.WriteAllText(@"C:\Users\Public\HashSalt.txt", hash.Hash+"\n"+hash.Salt);      
            try
            {
                if (hash.Check(password)==false)
                {
                    MessageBox.Show("Šifra je neispravna! Pokušajte ponovo.");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            if (employee != null && hash.Check(password))
            {
                return employee;              
            }
            else return null;
            
        }
    }
}
