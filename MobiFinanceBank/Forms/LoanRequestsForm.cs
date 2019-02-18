using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services.Interfaces;
using MobiFinanceBank.Templates;
using ClientType = MobiFinanceBank.Model.Enums.ClientType;

namespace MobiFinanceBank.Forms
{
    public partial class LoanRequestsForm : TemplateForm, ILoanRequestsForm
    {
        private readonly ILoanRepository loanRepository;
        private readonly IClientRepository clientRepository;
        private readonly ILoanTypeRepository loanTypeRepository;
        private readonly ILoanAssessment loanAssessment;

        public LoanRequestsForm
            (ILoanRepository _loanRepository, 
            IClientRepository _clientRepository, 
            ILoanTypeRepository _loanTypeRepository,
            ILoanAssessment _loanAssessment)
        {
            InitializeComponent();

            this.loanRepository = _loanRepository;
            this.clientRepository = _clientRepository;
            this.loanTypeRepository = _loanTypeRepository;
            this.loanAssessment = _loanAssessment;

            loanRequestsDgv.DataSource = this.loanRepository.GetAllLoanRequests().ToList();
        }

        private void loanRequestsDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (loanRequestsDgv.SelectedRows.Count != 0)
            {
                // Cast row data to account type object
                var row = this.loanRequestsDgv.SelectedRows[0];
                var loan = (Loan) row.DataBoundItem;

                var client = this.clientRepository.Get(loan.ClientId);
                var loanType = this.loanTypeRepository.GetById(loan.LoanTypeId);

                firstNameLbl.Text = client.FirstName;
                lastNameLbl.Text = client.LastName;
                oibLbl.Text = client.OIB;
                addressLbl.Text = client.Address;
                incomeLbl.Text = client.Income.ToString(CultureInfo.InvariantCulture);

                accountNameLbl.Text = loanType.Name;
                foreignCurrencyChb.Checked = loanType.IsForeignCurrency;
                currencyLbl.Text = loanType.Currency;
                interestRateLbl.Text = (loanType.InterestRate * 100) + "%";

                ChangeAssessmentVisibility(client.ClientTypeId == (int) ClientType.Privatni);

                if (client.ClientTypeId == (int) ClientType.Privatni)
                {
                    var assessment = loanAssessment.CalculateLoanAssessmentForPrivateClients(client.Id, loan) * 100;

                    var castAssessment = (int) assessment;
                    if (castAssessment > 100) castAssessment = 100;
                    if (castAssessment < 0) castAssessment = 0;

                    assessmentProgressBar.Value = castAssessment;
                }
            }
        }

        private void ChangeAssessmentVisibility(bool shouldShow)
        {
            assessmentProgressBar.Visible = shouldShow;
            makeAssessmentLbl.Visible = shouldShow;
        }

        private void approveLoanRequestBtn_Click(object sender, EventArgs e)
        {
            if (loanRequestsDgv.SelectedRows.Count != 0)
            {
                // Cast row data to account type object
                var row = this.loanRequestsDgv.SelectedRows[0];
                var loan = (Loan) row.DataBoundItem;

                loan.Status = (int) LoanStatus.Odobren;

                this.loanRepository.Edit(loan);

                this.RefreshLoanRequests();
            }
        }

        private void declineLoanRequest_Click(object sender, EventArgs e)
        {
            if (loanRequestsDgv.SelectedRows.Count != 0)
            {
                // Cast row data to account type object
                var row = this.loanRequestsDgv.SelectedRows[0];
                var loan = (Loan)row.DataBoundItem;

                loan.Status = (int)LoanStatus.Odbijen;

                this.loanRepository.Edit(loan);
                this.RefreshLoanRequests();
            }
        }

        private void RefreshLoanRequests()
        {
            loanRequestsDgv.DataSource = this.loanRepository.GetAllLoanRequests().ToList();
        }

        private void LoanRequestsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#28-odobravanje-zahtjeva-za-kreditom");
            }
            
        }

        private void LoanRequestsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
