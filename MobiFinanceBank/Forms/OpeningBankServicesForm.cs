using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Helpers;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;

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
        private readonly IOpenLoanBankServiceForm openLoanBankServiceForm;

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
        public Dictionary<BankServices, GridButton> ServicesDictionary { get; set; }

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
        /// <param name="_openLoanBankServiceForm">Open loan bank service form</param>
        public OpeningBankServicesForm
            (ISavingAccountTypeRepository _savingAccountTypeRepository, 
            IAccountTypeRepository _accountTypeRepository,
            ILoanTypeRepository _loanTypeRepository,
            IOpenAccountBankServiceForm _openAccountBankServiceForm,
            IOpenSavingAccountBankServiceForm _openSavingAccountBankServiceForm,
            IOpenLoanBankServiceForm _openLoanBankServiceForm)
        {
            InitializeComponent();

            this.savingAccountTypeRepository = _savingAccountTypeRepository;
            this.accountTypeRepository = _accountTypeRepository;
            this.loanTypeRepository = _loanTypeRepository;
            this.openAccountBankServiceForm = _openAccountBankServiceForm;
            this.openSavingAccountBankServiceForm = _openSavingAccountBankServiceForm;
            this.openLoanBankServiceForm = _openLoanBankServiceForm;
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

            var serviceButton = new Dictionary<DataGridView, Button>()
            {
                {loanDgv, createLoanBtn},
                {accountDgv, createAccountBtn },
                {savingAccountDgv, createSavingAccountBtn }
            };

            ServicesDictionary = new Dictionary<BankServices, GridButton>()
            {
                {BankServices.Kredit, new GridButton(){Button = createLoanBtn, DataGridView = loanDgv}},
                {BankServices.Račun, new GridButton(){Button = createAccountBtn, DataGridView = accountDgv}},
                {BankServices.Štednja, new GridButton(){Button = createSavingAccountBtn, DataGridView = savingAccountDgv}}
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
                // Retrieve selected bank service from combo box
                var item = (BankServices)bankServicesCb.SelectedItem;
                if (item == CurrentServiceFilter)
                    return;

                // Remember filter for future use
                var current = ServicesDictionary.FirstOrDefault(k => k.Key == item);
                var past = ServicesDictionary.FirstOrDefault(k => k.Key == CurrentServiceFilter);
                this.CurrentServiceFilter = item;

                // Hide based on filter
                current.Value.Button.Visible = true;
                current.Value.DataGridView.Visible = true;

                past.Value.DataGridView.Visible = false;
                past.Value.Button.Visible = false;
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
            // Set initial filter data
            bankServicesCb.DataSource = Enum.GetValues(typeof(BankServices));
            this.CurrentServiceFilter = BankServices.Račun;

            // Initial hide
            loanDgv.Visible = false;
            savingAccountDgv.Visible = false;

            createLoanBtn.Visible = false;
            createSavingAccountBtn.Visible = false;

            // Set data sources for all grid views
            savingAccountDgv.DataSource = this.savingAccountTypeRepository.GetAll();
            accountDgv.DataSource = this.accountTypeRepository.GetAll();
            loanDgv.DataSource = this.loanTypeRepository.GetAll();
        }

        /// <summary>
        /// Sets the data grid view size
        /// </summary>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
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
            // If row is selected
            if (accountDgv.SelectedRows.Count != 0)
            {
                // Cast row data to account type object
                var row = this.accountDgv.SelectedRows[0];
                var accountType = (AccountType)row.DataBoundItem;

                if (Client.Income < accountType.IncomeBottomLimit)
                {
                    MessageBox.Show(@"Korisnikovi prihodi nisu dovoljni za otvaranje ovog tipa računa",
                        @"Otvaranje usluga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.openAccountBankServiceForm.Show(this.Client, accountType);
            }
            else
            {
                MessageBox.Show("Odaberite tip računa", "Otvaranje usluga", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// On create saving account button click
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void createSavingAccountBtn_Click(object sender, EventArgs e)
        {
            // If row is selected
            if (savingAccountDgv.SelectedRows.Count != 0)
            {
                // Cast row data to account type object
                var row = this.savingAccountDgv.SelectedRows[0];
                var savingAccountType = (SavingAccountType)row.DataBoundItem;
                this.openSavingAccountBankServiceForm.Show(this.Client, savingAccountType);
            }
            else
            {
                MessageBox.Show("Odaberite tip štednog računa", "Otvaranje usluga", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void createLoanBtn_Click(object sender, EventArgs e)
        {
            // If row is selected
            if (loanDgv.SelectedRows.Count != 0)
            {
                // Cast row data to account type object
                var row = this.loanDgv.SelectedRows[0];
                var loanType = (LoanType)row.DataBoundItem;
                this.openLoanBankServiceForm.Show(this.Client, loanType);
            }
            else
            {
                MessageBox.Show("Odaberite tip kredita", "Otvaranje usluga", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
