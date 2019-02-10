using MobiFinanceBank;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MobiFinanceBank.Services.Interfaces
{
    public interface ILoginService
    {
        
        /// <summary>
        /// Get currency exchange rates
        /// </summary>
        /// <param name="currencies">List of filtered currencies</param>
        /// <returns>
        /// JSON result
        /// </returns>
        /// 
         Employee CheckCredentials(string username, string password);
    }
}
