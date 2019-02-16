using System;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services.Interfaces;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Open loan bank service form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="IOpenLoanBankServiceForm"/>
    public partial class OpenLoanBankServiceForm : TemplateForm, IOpenLoanBankServiceForm
    {
        /// <summary>
        /// Gets or sets the value indicating whether standing order is checked
        /// </summary>
        /// <value>
        /// <c>true</c> if standing order is checked, otherwise <c>false</c>
        /// </value>
        public bool IsStandingOrderChecked { get; set; } = false;

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        /// <value>
        /// The client
        /// </value>
        public Client Client { get; set; }

        /// <summary>
        /// Gets or sets the loan type
        /// </summary>
        /// <value>
        /// The loan type
        /// </value>
        public LoanType LoanType { get; set; }

        private readonly IAccountRepository accountRepository;
        private readonly ILoanRepository loanRepository;
        private readonly ILoanAssessment loanAssessment;

        /// <summary>
        /// Initializes new instance of open loan bank service form
        /// </summary>
        /// <param name="_accountRepository">Account repository</param>
        /// <param name="_loanRepository">Loan repository</param>
        public OpenLoanBankServiceForm
            (IAccountRepository _accountRepository, 
            ILoanRepository _loanRepository,
            ILoanAssessment _loanAssessment)
        {
            InitializeComponent();
            this.accountRepository = _accountRepository;
            this.loanRepository = _loanRepository;
            this.loanAssessment = _loanAssessment;
        }

        /// <summary>
        /// Hides base show method
        /// </summary>
        /// <param name="client">The client</param>
        /// <param name="loanType">Loan type</param>
        public new void Show(Client client, LoanType loanType)
        {
            this.Client = client;
            this.LoanType = loanType;

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

        private void OpenLoanBankServiceForm_Load(object sender, EventArgs e)
        {
            accountsDgv.Visible = false;

            firstNameLbl.Text = Client.FirstName;
            lastNameLbl.Text = Client.LastName;
            oibLbl.Text = Client.OIB;
            addressLbl.Text = Client.Address;
            incomeLbl.Text = Client.Income.ToString();

            accountNameLbl.Text = LoanType.Name;
            foreignCurrencyChb.Checked = LoanType.IsForeignCurrency;
            currencyLbl.Text = LoanType.Currency;
            interestRateLbl.Text = (LoanType.InterestRate * 100).ToString() + "%";
        }

        private void loanRequestButton_Click(object sender, EventArgs e)
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

            var loan = new Loan()
            {
                Account = account,
                Capital = (double)capitalNum.Value,
                IsStandingOrderActive = IsStandingOrderChecked,
                LoanStartDate = startDateDtp.Value, 
                LoanEndDate = startDateDtp.Value.AddYears((int)loanDurationNum.Value),
                Status = 0,
                LoanTypeId = LoanType.Id,
                EmployeeId = 1,
                ClientId = Client.Id
            };

            try
            {
                this.loanRepository.Add(loan);
                MessageBox.Show(@"Uspješno otvaranje kreditnog zahtjeva", @"Otvaranje kreditnog zahtjeva", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Neuspješno otvaranje kreditnog zahtjeva", @"Otvaranje kreditnog zahtjeva", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void makeAssessmentBtn_Click(object sender, EventArgs e)
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

            var loan = new Loan()
            {
                Account = account,
                Capital = (double)capitalNum.Value,
                IsStandingOrderActive = IsStandingOrderChecked,
                LoanStartDate = startDateDtp.Value,
                LoanEndDate = startDateDtp.Value.AddYears((int)loanDurationNum.Value),
                LoanDuration = (int)loanDurationNum.Value,
                Status = 0,
                LoanType = LoanType,
                EmployeeId = 1,
                ClientId = Client.Id
            };
            
            var assessment = loanAssessment.CalculateLoanAssessmentForPrivateClients(Client.Id, loan) * 100;

            var castAssessment = (int) assessment;
            if (castAssessment > 100) castAssessment = 100;
            
            assessmentProgressBar.Value = castAssessment;
        }
    }
}
