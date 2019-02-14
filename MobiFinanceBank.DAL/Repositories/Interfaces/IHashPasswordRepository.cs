using MobiFinanceBank.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Employee repository interface.
    /// </summary>
    public interface IHashPasswordRepository
    {
        /// <summary>
        /// Adds the specified employee hash password
        /// </summary>
        /// <param name="employee">Employee</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created hash password</returns>
        HashedPassword Add(HashedPassword hashedPassword, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets the hash password for given person.
        /// </summary>
        /// <param name="hashID">The person identifier.</param>
        /// <returns>Returns hash password </returns>
        HashedPassword Get(long hashID);

        /// <summary>
        /// Edits the specified hash password.
        /// </summary>
        /// <param name="employee">Employee</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited hash password</returns>
        /// <exception cref="ArgumentNullException">Employee - hash password is not instantiated or Id &lt;= 0</exception>
        HashedPassword Edit(HashedPassword hashedPassword, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified hash password
        /// </summary>
        /// <param name="hashID">Employee identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long hashID, bool shouldSaveChanges = true);

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();



    }
}
