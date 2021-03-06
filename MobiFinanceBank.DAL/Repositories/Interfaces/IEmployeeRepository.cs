﻿using System;
using System.Collections.Generic;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Employee repository interface.
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">Employee</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created employee.</returns>
        Employee Add(Employee employee, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        Employee Get(long personId);
        /// <summary>
        /// Returns all employees
        /// </summary>
        /// <returns>Returns account </returns>
        IEnumerable<Employee> GetAll();

        /// <summary>
        /// Edits the specified employee.
        /// </summary>
        /// <param name="employee">Employee</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited employee.</returns>
        /// <exception cref="ArgumentNullException">Employee - employee is not instantiated or Id &lt;= 0</exception>
        Employee Edit(Employee employee, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified employee.
        /// </summary>
        /// <param name="employeeId">Employee identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long employeeId, bool shouldSaveChanges = true);

        /// <summary>
        /// Gets employee by name.
        /// </summary>
        Employee GetEmployeeByUserName(string username);
        /// <summary>
        /// Gets employee by OIB.
        /// </summary>
        Employee GetByOIB(string OIB);
        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();
        
        
    }
}
