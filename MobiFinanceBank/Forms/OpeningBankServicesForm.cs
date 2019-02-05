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

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Opening bank services form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="IOpeningBankServicesForm"/>
    public partial class OpeningBankServicesForm : TemplateForm, IOpeningBankServicesForm
    {
        private readonly ISavingAccountTypeRepository savingAccountTypeRepository;
        private readonly IAccountTypeRepository accountTypeRepository;
        private readonly ILoanTypeRepository loanTypeRepository;

        private readonly IOpenAccountBankServiceForm openAccountBankServiceForm;
        private readonly IOpenSavingAccountBankServiceForm openSavingAccountBankServiceForm;

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        /// <value>
        /// The client
        /// </value>
        public Client Client { get; set; }

        /// <summary>
        /// Gets or sets services dictionary
        /// </summary>
        /// <value>
        /// Key value pair of bank services and corresponding data grid views
        /// </value>
        public Dictionary<BankServices, DataGridView> ServicesDictionary { get; set; }

        /// <summary>
        /// Gets or sets the current service filter
        /// </summary>
        /// <value>
        /// Bank service enum value filter
        /// </value>
        public BankServices CurrentServiceFilter { get; set; }

        /// <summary>
        /// Initializes new instance of opening bank services form
        /// </summary>
        /// <param name="_savingAccountTypeRepository">Saving account type repository</param>
        /// <param name="_accountTypeRepository">Account type repository</param>
        /// <param name="_loanTypeRepository">Loan type repository</param>
        /// <param name="_openAccountBankServiceForm">Open account bank service form</param>
        /// <param name="_openSavingAccountBankServiceForm">Open saving account bank service form</param>
        public OpeningBankServicesForm
            (ISavingAccountTypeRepository _savingAccountTypeRepository, 
            IAccountTypeRepository _accountTypeRepository,
            ILoanTypeRepository _loanTypeRepository,
            IOpenAccountBankServiceForm _openAccountBankServiceForm,
            IOpenSavingAccountBankServiceForm _openSavingAccountBankServiceForm)
        {
            InitializeComponent();

            this.savingAccountTypeRepository = _savingAccountTypeRepository;
            this.accountTypeRepository = _accountTypeRepository;
            this.loanTypeRepository = _loanTypeRepository;
            this.openAccountBankServiceForm = _openAccountBankServiceForm;
            this.openSavingAccountBankServiceForm = _openSavingAccountBankServiceForm;
        }

        /// <summary>
        /// Hides base show method
        /// </summary>
        /// <param name="client">The client</param>
        public new void Show(Client client)
        {
            this.Client = client;

            // Calls base show method
            base.Show();
        }
        
        /// <summary>
        /// On opening bank services form load
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void OpeningBankServicesForm_Load(object sender, EventArgs e)
        {
            this.SetDataSources();
            this.SetDataGridViewSize(900, 300);

            ServicesDictionary = new Dictionary<BankServices, DataGridView>()
            {
                {BankServices.Kredit, loanDgv},
                {BankServices.Račun, accountDgv },
                {BankServices.Štednja, savingAccountDgv}
            };
        }
        
        /// <summary>
        /// On bank services combo box selected index change
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void bankServicesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var item = (BankServices)bankServicesCb.SelectedItem;
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
        
        /// <summary>
        /// Sets data sources for this form
        /// </summary>
        private void SetDataSources()
        {
            bankServicesCb.DataSource = Enum.GetValues(typeof(BankServices));

            loanDgv.Visible = false;
            savingAccountDgv.Visible = false;
            
            this.CurrentServiceFilter = BankServices.Račun;

            savingAccountDgv.DataSource = this.savingAccountTypeRepository.GetAll();
            accountDgv.DataSource = this.accountTypeRepository.GetAll();
            loanDgv.DataSource = this.loanTypeRepository.GetAll();
        }

        private void SetDataGridViewSize(int width, int height)
        {
            savingAccountDgv.Size = new Size(width, height);
            accountDgv.Size = new Size(width, height);
            loanDgv.Size = new Size(width, height);
        }

        /// <summary>
        /// On create account button click
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            if (accountDgv.SelectedRows.Count != 0)
            {
                var row = this.accountDgv.SelectedRows[0];
                var accountType = (AccountType)row.DataBoundItem;
                this.openAccountBankServiceForm.Show(this.Client, accountType);
            }
        }

        private void createSavingAccountBtn_Click(object sender, EventArgs e)
        {
            this.openSavingAccountBankServiceForm.Show(this.Client);
        }
    }
}
