using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
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
        public EmployeeRepository(IMobiFinanceContext _context)
        {
            this.context = _context;
        }

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

               // string Sql = "INSERT INTO [dbo].[Employee] VALUES ('"+employee.FirstName+"','"+employee.LastName+"','"+employee.Email+"','"+employee.Address+"',"+employee.PhoneNumber+",'"+employee.UserName+"',"+employee.EmployeeTypeId+","+employee.OIB+",N'"+employee.PasswordSalt+"',N'"+employee.PasswordHash+"')";
               // System.IO.File.WriteAllText(@"C:\Users\Public\HashSaltRepo.txt", employee.PasswordHash + "\n" + employee.PasswordSalt);
                //var zaposlenik = new List<Employee>(context.Employees.SqlQuery(Sql));
                
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
                // Modifies employee
                var employeeToModify = this.GetByOIB(employee.OIB);
                //Console.WriteLine(employeeToModify.UserName);
                if (employeeToModify == null)
                { 
                    throw new NullReferenceException("Employee not found in database");
                }
                    

                employeeToModify.FirstName = employee.FirstName;
                employeeToModify.LastName = employee.LastName;
                employeeToModify.OIB = employee.OIB;
                employeeToModify.UserName = employee.UserName;
                employeeToModify.Email = employee.Email;
                employeeToModify.PhoneNumber = employee.PhoneNumber;
                employeeToModify.Address = employee.Address;
                employeeToModify.EmployeeTypeId = employee.EmployeeTypeId;
                employeeToModify.IsActive = employee.IsActive;
                if (employee.PasswordHash!=null)
                {
                    employeeToModify.PasswordHash = employee.PasswordHash;
                    employeeToModify.PasswordSalt = employee.PasswordSalt;
                }

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
        /// Returns Employee by username attribute.
        /// </summary>
        public Employee GetEmployeeByUserName(string username)
        { 
            return this.context.Employees.FirstOrDefault(employee => employee.UserName == username);

        }
        /// <summary>
        /// Finds specified employee by OIB
        /// </summary>
        /// <param name="OIB">OIB</param>
        public Employee GetByOIB(string OIB)
        {
            return this.context.Employees.FirstOrDefault(employee => employee.OIB == OIB);
        }
        /// <summary>
        /// Gets all employeed
        /// </summary>
        public IEnumerable<Employee> GetAll()
        {
            return this.context.Employees.ToList();
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
