using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Open saving account bank service form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="IOpenSavingAccountBankServiceForm"/>
    public partial class OpenSavingAccountBankServiceForm : TemplateForm, IOpenSavingAccountBankServiceForm
    {
        /// <summary>
        /// Gets or sets the value indicating whether standing order is checked
        /// </summary>
        /// <value>
        /// <c>true</c> if standing order is checked, otherwise <c>false</c>
        /// </value>
        public bool IsStandingOrderChecked { get; set; } = false;

        /// <summary>
        /// Gets or sets the saving account type
        /// </summary>
        /// <value>
        /// Saving account type
        /// </value>
        public SavingAccountType SavingAccountType { get; set; }

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        /// <value>
        /// The client
        /// </value>
        public Client Client { get; set; }

        private readonly IAccountRepository accountRepository;
        private readonly ISavingAccountRepository savingAccountRepository;
        private readonly ISavingAccountTypeRepository savingAccountTypeRepository;

        /// <summary>
        /// Initializes new instance of open saving account bank service form
        /// </summary>
        /// <param name="_accountRepository">Account repository</param>
        /// <param name="_savingAccountRepository">Saving account repository</param>
        public OpenSavingAccountBankServiceForm
            (IAccountRepository _accountRepository,
            ISavingAccountRepository _savingAccountRepository,
            ISavingAccountTypeRepository _savingAccountTypeRepository)
        {
            InitializeComponent();

            this.accountRepository = _accountRepository;
            this.savingAccountRepository = _savingAccountRepository;
            this.savingAccountTypeRepository = _savingAccountTypeRepository;
        }

        /// <summary>
        /// Hides base show method
        /// </summary>
        /// <param name="client">The client</param>
        /// <param name="savingAccountType">Saving account type</param>
        public new void Show(Client client, SavingAccountType savingAccountType)
        {
            this.Client = client;
            this.SavingAccountType = savingAccountType;

            // Calls base show method
            base.Show();
        }

        /// <summary>
        /// On standing order checkbox click
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void standingOrderChb_CheckedChanged(object sender, EventArgs e)
        {
            // Show additional UI if standing order is checked
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

        /// <summary>
        /// On open saving account bank service form load
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void OpenSavingAccountBankServiceForm_Load(object sender, EventArgs e)
        {
            accountsDgv.Visible = false;

            firstNameLbl.Text = Client.FirstName;
            lastNameLbl.Text = Client.LastName;
            oibLbl.Text = Client.OIB;
            addressLbl.Text = Client.Address;
            incomeLbl.Text = Client.Income.ToString();

            accountNameLbl.Text = SavingAccountType.Name;
            foreignCurrencyChb.Checked = SavingAccountType.IsForeignCurrency;
            currencyLbl.Text = SavingAccountType.Currency;
            interestRateLbl.Text = (SavingAccountType.InterestRate * 100).ToString() + "%";
            fixedTermChb.Checked = SavingAccountType.IsFixedTerm;
            fixedTermPeriodLbl.Text = SavingAccountType.FixedTermDepositingPeriod.ToString();
        }

        /// <summary>
        /// On open saving account button click
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void openSavingAccountBtn_Click(object sender, EventArgs e)
        {
            Account account = null;

            // If row is selected
            if (accountsDgv.SelectedRows.Count != 0)
            {
                // Retrieve row data and cast to account object
                var row = this.accountsDgv.SelectedRows[0];
                account = (Account)row.DataBoundItem;
            }

            if (startDateDtp.Value < DateTime.Now.Date)
            {
                MessageBox.Show($@"Datum ne smije biti manji od {DateTime.Now.Date}");
                return;
            }

            if (IsStandingOrderChecked && account == null)
            {
                MessageBox.Show(@"Niste izabrali račun koji će se trajno teretiti", "Otvaranje štednje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var savingAccount = new SavingAccount()
            {
                Account = account,
                Capital = (double)capitalNum.Value,
                IsStandingOrderActive = IsStandingOrderChecked,
                FixedTermDepositingStartDate = startDateDtp.Value,
                SavingAccountTypeId = this.SavingAccountType.Id,
                FixedTermDepositingEndDate = startDateDtp.Value.AddYears(SavingAccountType.FixedTermDepositingPeriod),
                EmployeeId = 3,
                ClientId = Client.Id
            };

            try
            {
                this.savingAccountRepository.Add(savingAccount);
                MessageBox.Show(@"Uspješno otvaranje štednog računa", "Otvaranje štednje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Neuspješno otvaranje štednog računa", "Otvaranje štednje", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
