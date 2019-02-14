using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Hash password repository.
    /// </summary>
    /// <seealso cref="IHashPasswordRepository"/>
    public class HashPasswordRepository : IHashPasswordRepository

    {
        private readonly IMobiFinanceContext context;

        public HashedPassword Add(HashedPassword hashPassword, bool shouldSaveChanges = true)
        {
            // Checks if hash passowrd is instantiated
            if (hashPassword == null)
                throw new ArgumentNullException(nameof(hashPassword), "Hashed password is not instantiated");

            try
            {
                // Adds employee type instance to database 
                this.context.HashedPasswords.Add(hashPassword);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return hashPassword;
        }

        public HashedPassword Edit(HashedPassword hashedPassword, bool shouldSaveChanges = true)
        {
            // Checks if employee type is instantiated
            if (hashedPassword == null)
                throw new ArgumentNullException(nameof(hashedPassword), "Employee type is not instantiated");

            try
            {
                // Modifies employee type
                this.context.Entry(hashedPassword).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return hashedPassword;
        }

        public HashedPassword Get(long hashID)
        {
            return this.context.HashedPasswords.FirstOrDefault(HashedPassword => HashedPassword.Id == hashID);
        }

        public void Remove(long hashID, bool shouldSaveChanges = true)
        {
            var hashedPassword = this.Get(hashID);

            if (hashedPassword == null)
                throw new ArgumentException($"Cannot delete non existing employee type with id {hashID}");

            this.context.HashedPasswords.Remove(hashedPassword);

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

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
