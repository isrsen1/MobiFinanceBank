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
    /// Saving account type repository.
    /// </summary>
    /// <seealso cref="ISavingAccountTypeRepository"/>
    public class SavingAccountTypeRepository: ISavingAccountTypeRepository
    {
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Adds the specified saving account type.
        /// </summary>
        /// <param name="savingAccountType">Saving account type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created saving account type.</returns>
        public SavingAccountType Add(SavingAccountType savingAccountType, bool shouldSaveChanges = true)
        {
            // Checks if saving account type is instantiated
            if (savingAccountType == null)
                throw new ArgumentNullException(nameof(savingAccountType), "Saving account type is not instantiated");

            try
            {
                // Adds saving account type instance to database 
                this.context.SavingAccountTypes.Add(savingAccountType);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return savingAccountType;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="liabilityId">Liability id</param>
        /// <returns>Asset</returns>
        public SavingAccountType Get(long savingAccountTypeId)
        {
            return this.context.SavingAccountTypes.FirstOrDefault(savingAccountType => savingAccountType.Id == savingAccountTypeId);
        }

        /// <summary>
        /// Edits the specified saving account type.
        /// </summary>
        /// <param name="savingAccountType">Saving account type</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited saving account type.</returns>
        /// <exception cref="ArgumentNullException">Saving account type - saving account type is not instantiated or Id &lt;= 0</exception>
        public SavingAccountType Edit(SavingAccountType savingAccountType, bool shouldSaveChanges = true)
        {
            // Checks if saving account type is instantiated
            if (savingAccountType == null)
                throw new ArgumentNullException(nameof(savingAccountType), "Saving account type is not instantiated");

            try
            {
                // Modifies saving account type
                this.context.Entry(savingAccountType).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return savingAccountType;
        }

        /// <summary>
        /// Removes the specified saving account type.
        /// </summary>
        /// <param name="savingAccountTypeId">Saving account type identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long savingAccountTypeId, bool shouldSaveChanges = true)
        {
            var savingAccountType = this.Get(savingAccountTypeId);

            if (savingAccountType == null)
                throw new ArgumentException($"Cannot delete non existing saving account type with id {savingAccountTypeId}");

            this.context.SavingAccountTypes.Remove(savingAccountType);

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
