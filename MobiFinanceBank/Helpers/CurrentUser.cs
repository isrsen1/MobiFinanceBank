using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Helpers
{
    public static class CurrentUser
    {
        private static Employee userEmployee;

        public static void SetEmployee(Employee _userEmployee)
        {
            userEmployee = _userEmployee;
        }

        public static Employee GetEmployee()
        {
            return userEmployee;
        }
    }
}
