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
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public Employee CheckCredentials(string username, string password)
        {
             
             var employee = this.employeeRepository.GetEmployeeByUserName(username);
            var hashy = Base64Decode(employee.PasswordHash);
            var salty = Base64Decode(employee.PasswordSalt);
            
            try
            {
                // hash = HashLibrary.HashedPassword.New(password);                
                 Hashed = "O_¸¯°íó7ÚS§ÊįāĨkÙZµį4g}BÞo.óDxßT";
                 Salted = "¥ĎP¢ċÎ³ðsĤĩçÍĴÃČðp×}õĐ­£ŀ_`ð?îy=";
                hash = new HashLibrary.HashedPassword(hashy, salty);    
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

            System.IO.File.WriteAllText(@"C:\Users\Public\HashSaltLogin.txt", hash.Hash+"\n"+hash.Salt);      
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
