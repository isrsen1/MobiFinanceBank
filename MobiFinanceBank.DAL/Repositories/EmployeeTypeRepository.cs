using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
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
        private readonly IMobiFinanceContext context;

        public EmployeeTypeRepository(IMobiFinanceContext _context)
        {
            this.context = _context;
        }
        /// <summary>
        /// Adds the specified employee type.
        /// </summary>
        /// <param name="employeeType">Employee type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created employee type.</returns>
        public EmployeeType Add(EmployeeType employeeType, bool shouldSaveChanges = true)
        {
            // Checks if employee type is instantiated
            if (employeeType == null)
                throw new ArgumentNullException(nameof(employeeType), "Employee type is not instantiated");

            try
            {
                // Adds employee type instance to database 
                this.context.EmployeeTypes.Add(employeeType);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return employeeType;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <returns>Asset</returns>
        public EmployeeType Get(long employeeTypeId)
        {
            return this.context.EmployeeTypes.FirstOrDefault(employeeType => employeeType.Id == employeeTypeId);
        }

        /// <summary>
        /// Edits the specified employee type.
        /// </summary>
        /// <param name="employeeType">Employee type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited employee type.</returns>
        /// <exception cref="ArgumentNullException">Employee type - employee type is not instantiated or Id &lt;= 0</exception>
        public EmployeeType Edit(EmployeeType employeeType, bool shouldSaveChanges = true)
        {
            // Checks if employee type is instantiated
            if (employeeType == null)
                throw new ArgumentNullException(nameof(employeeType), "Employee type is not instantiated");

            try
            {
                // Modifies employee type
                this.context.Entry(employeeType).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return employeeType;
        }

        /// <summary>
        /// Removes the specified employee type.
        /// </summary>
        /// <param name="employeeTypeId">Employee type identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long employeeTypeId, bool shouldSaveChanges = true)
        {
            var employeeType = this.Get(employeeTypeId);

            if (employeeType == null)
                throw new ArgumentException($"Cannot delete non existing employee type with id {employeeTypeId}");

            this.context.EmployeeTypes.Remove(employeeType);

            if (shouldSaveChanges)
            {
                try
                {
                    this.SaveChanges();
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
        public IEnumerable<EmployeeType> GetAll()
        {
            return this.context.EmployeeTypes.ToList();
        }

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
