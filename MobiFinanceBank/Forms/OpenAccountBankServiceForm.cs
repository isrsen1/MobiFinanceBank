using System;
using System.Globalization;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    public partial class OpenAccountBankServiceForm : TemplateForm, IOpenAccountBankServiceForm
    {
        /// <summary>
        /// Gets or sets the client
        /// </summary>
        /// <value>
        /// The client
        /// </value>
        public Client Client { get; set; }

        /// <summary>
        /// Gets or sets the account type
        /// </summary>
        /// <value>
        /// The account type
        /// </value>
        public AccountType AccountType { get; set; }

        private readonly IAccountRepository accountRepository;

        /// <summary>
        /// Initializes new instance of open account bank service form
        /// </summary>
        /// <param name="_accountRepository">Account repository</param>
        public OpenAccountBankServiceForm(IAccountRepository _accountRepository)
        {
            InitializeComponent();
            this.accountRepository = _accountRepository;
        }

        /// <summary>
        /// Hides base show method
        /// </summary>
        /// <param name="client">The client</param>
        /// <param name="accountType">Account type</param>
        public new void Show(Client client, AccountType accountType)
        {
            this.Client = client;
            this.AccountType = accountType;

            // Calls base show method
            base.Show();
        }

        /// <summary>
        /// On create account button click
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            // Retrieves account
            var account = new Account()
            {
                IBAN = ibanTb.Text,
                CardNumber = cardNumberTb.Text,
                Balance = (double) paymentNum.Value,
                ClientId = Client.Id,
                AccountTypeId = AccountType.Id,
                EmployeeId = 1
            };

            this.accountRepository.Add(account);
        }

        private void OpenAccountBankServiceForm_Load(object sender, EventArgs e)
        {
            firstNameLbl.Text = Client.FirstName;
            lastNameLbl.Text = Client.LastName;
            oibLbl.Text = Client.OIB;
            addressLbl.Text = Client.Address;
            incomeLbl.Text = Client.Income.ToString();

            accountNameLbl.Text = AccountType.Name;
            foreignCurrencyLbl.Checked = AccountType.IsForeignCurrency;
            currencyLbl.Text = AccountType.Currency;
            negativeBalanceLbl.Text = AccountType.NegativeBalanceLimit.ToString(CultureInfo.InvariantCulture);
            incomeBottomLineLbl.Text = AccountType.IncomeBottomLimit.ToString(CultureInfo.CurrentCulture);
            negativeBalanceMonthlyFeeLbl.Text = (AccountType.NegativeBalanceMonthlyFee * 100).ToString() + "%";
        }
    }
}
