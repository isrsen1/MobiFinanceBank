using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services.Interfaces;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiFinanceBank.VmService
{
    class LoginVmService : ILoginVmService
    {
        /// <summary>
        /// Gets or sets the login service
        /// </summary>
        /// <value>
        /// The login service
        /// </value>
        public ILoginService LoginService { get; set; }

        /// <summary>
        /// Initializes a new instance of login view model service
        /// </summary>
        /// <param name="_loginService">Login service</param>
        public LoginVmService(ILoginService _loginService)
        {
            this.LoginService = _loginService;
        }

        /// <summary>
        /// Retrieves the collection of exchange rates
        /// </summary>
        /// <param name="loginEmployee">Login information of the employee </param>
        /// <returns></returns>
        public Employee GetLoginData(LoginEmployeeData loginEmployee)
        {
            try
            {
                string userName = loginEmployee.Username;
                string password = loginEmployee.Password;
               var result = LoginService.CheckCredentials(userName,password);
               

                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
