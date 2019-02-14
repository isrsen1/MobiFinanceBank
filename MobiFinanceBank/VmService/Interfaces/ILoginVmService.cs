using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiFinanceBank.VmService.Interfaces
{
    public interface ILoginVmService
    {
        /// <summary>
        /// Gets employee login data
        /// </summary>
        /// <param name="loginEmployee">Login Employee</param>
        /// <returns> Login data </returns>
        Employee GetLoginData(LoginEmployeeData loginEmployee);
    }
}
