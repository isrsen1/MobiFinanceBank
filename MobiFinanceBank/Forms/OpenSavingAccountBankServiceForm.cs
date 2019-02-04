using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    public partial class OpenSavingAccountBankServiceForm : TemplateForm, IOpenSavingAccountBankServiceForm
    {
        public bool IsStandingOrderChecked { get; set; } = false;
        public Client Client { get; set; }

        private readonly IAccountRepository accountRepository;
        private readonly ISavingAccountRepository savingAccountRepository;

        public OpenSavingAccountBankServiceForm
            (IAccountRepository _accountRepository,
            ISavingAccountRepository _savingAccountRepository)
        {
            InitializeComponent();
            this.accountRepository = _accountRepository;
            this.savingAccountRepository = _savingAccountRepository;
        }

        public new void Show(Client client)
        {
            this.Client = client;

            base.Show();
        }

        private void standingOrderChb_CheckedChanged(object sender, EventArgs e)
        {
            this.IsStandingOrderChecked = !this.IsStandingOrderChecked;
            if (this.IsStandingOrderChecked)
            {
                accountsDgv.Visible = true;
                accountsDgv.DataSource = this.accountRepository.GetByClient(this.Client.Id);
            }
            else
            {
                accountsDgv.Visible = false;
            }
        }

        private void OpenSavingAccountBankServiceForm_Load(object sender, EventArgs e)
        {
            accountsDgv.Visible = false;
        }

        private void openSavingAccountBtn_Click(object sender, EventArgs e)
        {
            if (accountsDgv.SelectedRows.Count != 0)
            {
                var row = this.accountsDgv.SelectedRows[0];
                var account = (Account)row.DataBoundItem;
                var savingAccount = new SavingAccount()
                {
                    Account = account,
                    Capital = (double) capitalNum.Value,
                    IsStandingOrderActive = IsStandingOrderChecked,
                    FixedTermDepositingStartDate = startDateDtp.Value
                };

                this.savingAccountRepository.Add(savingAccount);
            }
        }
    }
}
