using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
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
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">Employee</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created employee.</returns>
        public Employee Add(Employee employee, bool shouldSaveChanges = true)
        {
            // Checks if employee is instantiated
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), "Employee is not instantiated");

            try
            {
                // Adds employee instance to database 
                this.context.Employees.Add(employee);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return employee;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <returns>Asset</returns>
        public Employee Get(long employeeId)
        {
            return this.context.Employees.FirstOrDefault(employee => employee.Id == employeeId);
        }

        /// <summary>
        /// Edits the specified employee.
        /// </summary>
        /// <param name="employee">Employee</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited employee.</returns>
        /// <exception cref="ArgumentNullException">Employee - employee is not instantiated or Id &lt;= 0</exception>
        public Employee Edit(Employee employee, bool shouldSaveChanges = true)
        {
            // Checks if employee is instantiated
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), "Employee is not instantiated");

            try
            {
                // Modifies client
                this.context.Entry(employee).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return employee;
        }

        /// <summary>
        /// Removes the specified employee.
        /// </summary>
        /// <param name="employeeId">Employee identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long employeeId, bool shouldSaveChanges = true)
        {
            var employee = this.Get(employeeId);

            if (employee == null)
                throw new ArgumentException($"Cannot delete non existing employee with id {employeeId}");

            this.context.Employees.Remove(employee);

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

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
