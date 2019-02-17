using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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

        private readonly string ibanRegex = @"^[H]{1}[R]{1}[0-9]{19}$";
        private readonly string cardNumberRegex = @"^[0-9]{4}[ ]{1}[0-9]{4}[ ]{1}[0-9]{4}[ ]{1}[0-9]{4}$";
        private readonly string ibanPlaceholder = "HR1234567891234567891";
        private readonly string cardNumberPlaceholder = "1234 1234 1234 1234";
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
            var iban = ibanTb.Text;
            var cardNumber = cardNumberTb.Text;

            var matchIBAN = Regex.Match(iban, ibanRegex);
            var matchCardNumber = Regex.Match(cardNumber, cardNumberRegex);
            var checkIBAN = this.accountRepository.GetByIBAN(iban);
            var checkCardNumber = this.accountRepository.GetByCardNumber(cardNumber);

            if (!matchIBAN.Success)
            {
                MessageBox.Show(@"Pogrešan IBAN format", "Otvaranje računa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!matchCardNumber.Success)
            {
                MessageBox.Show(@"Pogrešan format broja kartice", @"Otvaranje računa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (checkIBAN != null)
            {
                MessageBox.Show(@"IBAN već postoji u bazi", @"Otvaranje računa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkCardNumber != null)
            {
                MessageBox.Show(@"Broj kartice već postoji u bazi", @"Otvaranje računa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Retrieves account
            var account = new Account()
            {
                IBAN = ibanTb.Text,
                CardNumber = cardNumberTb.Text,
                Balance = (double) paymentNum.Value,
                ClientId = Client.Id,
                AccountTypeId = AccountType.Id,
                EmployeeId = 3
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

            // IBAN text box placeholder
            ibanTb.Text = ibanPlaceholder;
            ibanTb.ForeColor = Color.Gray;

            // Card number text box placeholder
            cardNumberTb.Text = cardNumberPlaceholder;
            cardNumberTb.ForeColor = Color.Gray;
        }

        private void ibanTb_Enter(object sender, EventArgs e)
        {
            // Remove text if placeholder
            if (ibanTb.Text == ibanPlaceholder)
            {
                ibanTb.ForeColor = Color.Black;
                ibanTb.Text = "";
            }
        }

        private void ibanTb_Leave(object sender, EventArgs e)
        {
            // if empty, set placeholder
            if (ibanTb.Text == "")
            {
                ibanTb.ForeColor = Color.Gray;
                ibanTb.Text = ibanPlaceholder;
            }
        }

        private void cardNumberTb_Enter(object sender, EventArgs e)
        {
            // Remove text if placeholder
            if (cardNumberTb.Text == cardNumberPlaceholder)
            {
                cardNumberTb.ForeColor = Color.Black;
                cardNumberTb.Text = "";
            }
        }

        private void cardNumberTb_Leave(object sender, EventArgs e)
        {
            // if empty, set placeholder
            if (cardNumberTb.Text == "")
            {
                cardNumberTb.ForeColor = Color.Gray;
                cardNumberTb.Text = cardNumberPlaceholder;
            }
        }

        private void OpenAccountBankServiceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#261-otvaranje-usluge-ra%C4%8Dun");
            }
        }
    }
}
