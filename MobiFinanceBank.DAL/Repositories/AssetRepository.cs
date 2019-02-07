using System;
using System.Data.Entity;
using System.Linq;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Asset repository.
    /// </summary>
    /// <seealso cref="IAssetRepository"/>
    public class AssetRepository: IAssetRepository
    {
        private readonly IMobiFinanceContext context;

        /// <summary>
        /// Adds the specified asset.
        /// </summary>
        /// <param name="asset">Asset</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created asset.</returns>
        public Asset Add(Asset asset, bool shouldSaveChanges = true)
        {
            // Checks if asset is instantiated
            if (asset == null)
                throw new ArgumentNullException(nameof(asset), "Asset is not instantiated");

            try
            {
                // Adds asset instance to database 
                this.context.Assets.Add(asset);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return asset;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <returns>Asset</returns>
        public Asset Get(long assetId)
        {
            return this.context.Assets.FirstOrDefault(asset => asset.Id == assetId);
        }

        /// <summary>
        /// Edits the specified asset.
        /// </summary>
        /// <param name="asset">Asset</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited asset.</returns>
        /// <exception cref="ArgumentNullException">asset - asset is not instantiated or Id &lt;= 0</exception>
        public Asset Edit(Asset asset, bool shouldSaveChanges = true)
        {
            // Checks if asset is instantiated
            if (asset == null)
                throw new ArgumentNullException(nameof(asset), "Asset is not instantiated");

            try
            {
                // Modifies asset
                this.context.Entry(asset).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return asset;
        }

        /// <summary>
        /// Removes the specified asset.
        /// </summary>
        /// <param name="assetId">Asset identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long assetId, bool shouldSaveChanges = true)
        {
            var asset = this.Get(assetId);

            if (asset == null)
                throw new ArgumentException($"Cannot delete non existing asset with id {assetId}");

            this.context.Assets.Remove(asset);

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
