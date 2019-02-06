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
        /// <param name="currencies">Collection of currencies</param>
        /// <param name="fromDate">From date filter</param>
        /// <param name="toDate">To date filter</param>
        /// <returns></returns>
        public IEnumerable<Employee> GetLoginData(LoginEmployeeData loginEmployee)
        {
            return null;
        }
    }
}
