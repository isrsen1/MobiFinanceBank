using System;
using System.Collections.Generic;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Employee type repository interface.
    /// </summary>
    public interface IEmployeeTypeRepository
    {
        /// <summary>
        /// Adds the specified employee type.
        /// </summary>
        /// <param name="employeeType">Employee type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created employee type.</returns>
        EmployeeType Add(EmployeeType employeeType, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        EmployeeType Get(long personId);

        /// <summary>
        /// Edits the specified employee type.
        /// </summary>
        /// <param name="employeeType">Employee type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited employee type.</returns>
        /// <exception cref="ArgumentNullException">Employee type - employee type is not instantiated or Id &lt;= 0</exception>
        EmployeeType Edit(EmployeeType employeeType, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified employee type.
        /// </summary>
        /// <param name="employeeTypeId">Employee type identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long employeeTypeId, bool shouldSaveChanges = true);

        IEnumerable<EmployeeType> GetAll();
        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();
    }
}
