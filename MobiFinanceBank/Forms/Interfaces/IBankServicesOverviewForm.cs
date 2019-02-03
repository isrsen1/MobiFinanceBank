using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Forms.Interfaces
{
    /// <summary>
    /// Saving and account overview form interface
    /// </summary>
    public interface IBankServicesOverviewForm
    {
        void Show(Client client);
    }
}
