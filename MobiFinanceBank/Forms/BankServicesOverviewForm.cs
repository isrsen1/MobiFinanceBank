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
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService;
using MobiFinanceBank.VmService.Interfaces;

namespace MobiFinanceBank.Forms
{
    public partial class BankServicesOverviewForm : TemplateForm, IBankServicesOverviewForm
    {
        private IBankServicesVmService bankServicesVmService;
        public Client Client { get; set; }
        public Dictionary<BankServices, DataGridView> ServicesDictionary { get; set; }
        public BankServices CurrentServiceFilter { get; set; }
        
        public BankServicesOverviewForm
            (IBankServicesVmService _bankServicesVmService)
        {
            InitializeComponent();
            this.bankServicesVmService = _bankServicesVmService;
        }

        public new void Show(Client client)
        {
            this.Client = client;

            base.Show();
        }

        private void SavingAndAccountOverviewForm_Load(object sender, EventArgs e)
        {
            this.SetDataSources();
            this.SetDataGridViewSize(750, 300);

            ServicesDictionary = new Dictionary<BankServices, DataGridView>()
            {
                {BankServices.Kredit, loanDgv},
                {BankServices.Račun, accountDgv },
                {BankServices.Štednja, savingAccountDgv}
            };
        }

        private void bankServicesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var item = (BankServices) bankServicesCb.SelectedItem;
                if (item == CurrentServiceFilter)
                    return;
                var current = ServicesDictionary.FirstOrDefault(k => k.Key == item);
                current.Value.Visible = true;
                var past = ServicesDictionary.FirstOrDefault(k => k.Key == CurrentServiceFilter);
                past.Value.Visible = false;
                this.CurrentServiceFilter = item;
            }
            catch (Exception eas)
            {

            }
        }

        private void SetDataSources()
        {
            bankServicesCb.DataSource = Enum.GetValues(typeof(BankServices));
            loanDgv.Visible = false;
            savingAccountDgv.Visible = false;
            this.CurrentServiceFilter = BankServices.Račun;

            var accountFilter = new AccountOverviewFilter()
            {
                Client = this.Client
            };

            accountDgv.DataSource = this.bankServicesVmService.GetAccountsOverview(accountFilter);

            var savingAccoutFilter = new SavingOverviewFilter()
            {
                Client = this.Client
            };

            savingAccountDgv.DataSource = this.bankServicesVmService.GetSavingAccountsOverview(savingAccoutFilter);

            var loanFilter = new LoanOverviewFilter()
            {
                Client = this.Client
            };

            loanDgv.DataSource = this.bankServicesVmService.GetLoansOverview(loanFilter);
        }

        private void SetDataGridViewSize(int width, int height)
        {
            savingAccountDgv.Size = new Size(width, height);
            accountDgv.Size = new Size(width, height);
            loanDgv.Size = new Size(width, height);
        }
    }
}
