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
        public OpenAccountBankServiceForm(IAccountRepository _accountRepository)
        {
            InitializeComponent();
            this.accountRepository = _accountRepository;
        }

        public new void Show(Client client, AccountType accountType)
        {
            this.Client = client;
            this.AccountType = accountType;

            base.Show();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
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
    }
}
