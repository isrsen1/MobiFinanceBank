using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Forms.Interfaces
{
    public interface IOpenSavingAccountBankServiceForm
    {
        void Show(Client client, SavingAccountType savingAccountType);
    }
}
