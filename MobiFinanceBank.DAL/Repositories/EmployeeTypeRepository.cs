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
    /// Employee type repository.
    /// </summary>
    /// <seealso cref="IEmployeeTypeRepository"/>
    public class EmployeeTypeRepository: IEmployeeTypeRepository
    {
        public EmployeeType Add(EmployeeType employeeType, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public EmployeeType Get(long personId)
        {
            throw new NotImplementedException();
        }

        public EmployeeType Edit(EmployeeType employeeType, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long employeeTypeId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
