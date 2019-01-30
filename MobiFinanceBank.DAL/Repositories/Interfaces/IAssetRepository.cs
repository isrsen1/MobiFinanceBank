using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Asset repository interface.
    /// </summary>
    public interface IAssetRepository
    {
        /// <summary>
        /// Adds the specified asset.
        /// </summary>
        /// <param name="asset">Asset</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created asset.</returns>
        Asset Add(Asset asset, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets the asset.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        Asset Get(long personId);

        /// <summary>
        /// Edits the specified asset.
        /// </summary>
        /// <param name="asset">Asset</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited asset.</returns>
        /// <exception cref="ArgumentNullException">asset - asset is not instantiated or Id &lt;= 0</exception>
        Asset Edit(Asset asset, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified asset.
        /// </summary>
        /// <param name="assetId">Asset identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long assetId, bool shouldSaveChanges = true);

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void SaveChanges();
    }
}
