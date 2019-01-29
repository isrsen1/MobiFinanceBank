using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Employee repository.
    /// </summary>
    /// <seealso cref="IEmployeeRepository"/>
    public class EmployeeRepository: IEmployeeRepository
    {
        public Employee Add(Employee employee, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Employee Get(long personId)
        {
            throw new NotImplementedException();
        }

        public Employee Edit(Employee employee, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long employeeId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
