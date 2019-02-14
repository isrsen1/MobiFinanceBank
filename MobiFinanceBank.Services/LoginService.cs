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
        

        public LoginService(IEmployeeRepository _employeeRepository)
        {          
              this.employeeRepository = _employeeRepository;
            
        }
        public Employee CheckCredentials(string username, string password)
        {         
            
            var employee = this.employeeRepository.GetEmployeeByName(username);
            
            //hash = employee.hashPassword.hash;
            //&& hash.Check(password)
            MessageBox.Show(employee.hashPassword);

            if (employee != null && employee.hashPassword==password)
            {
                MessageBox.Show("prošlo");
                return employee;
                
            }
            else return null;
            
        }
    }
}
