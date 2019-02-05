using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Forms.Interfaces
{
    public interface IOpenAccountBankServiceForm
    {
        void Show(Client client, AccountType accountType);
    }
}
