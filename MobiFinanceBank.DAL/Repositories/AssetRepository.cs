using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Asset Add(Asset asset, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Asset Get(long personId)
        {
            throw new NotImplementedException();
        }

        public Asset Edit(Asset asset, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long assetId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
