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

namespace MobiFinanceBank.Services
{
    public class LoginService : ILoginService
    {
        private IEmployeeRepository employeeRepository { get; set; }
        public Employee employee;
        private HashedPassword hash;
        

        public LoginService(IEmployeeRepository _employeeRepository)
        {
            this.employeeRepository = _employeeRepository;
            employee = new Employee();
            

        }
        public Employee CheckCredentials(string username, string password)
        {
            employee = employeeRepository.GetEmployeeByName(username);
            hash = HashedPassword.New(password);
            

            if (employee != null)
            {
                
                return employee;
            }
            else return null;
            
        }
    }
}
