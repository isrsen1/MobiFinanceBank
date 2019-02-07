using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services.Interfaces;

namespace MobiFinanceBank.Services
{
    /// <summary>
    /// Loan assessment class
    /// </summary>
    /// <seealso cref="ILoanAssessment"/>
    public class LoanAssessment: ILoanAssessment
    {
        private readonly IClientRepository clientRepository;

        private readonly double averageSalary = 6237;
        private readonly double fixedAmmountUnusualProfession = 4158;
        private readonly double fixedAmmount = 2500;

        public LoanAssessment(IClientRepository _clientRepository)
        {
            this.clientRepository = _clientRepository;
        }

        public double CalculateLoanAssessmentForPrivateClients(long clientId, Loan requiredLoan)
        {
            // Get client and client loans
            var client = this.clientRepository.Get(clientId);
            var clientLoans = client.Loans;

            double currentLoansAmount = 0;
            var clientIncome = client.Income;
            // Calculate monthly loan amount from all client loans
            foreach (var loan in clientLoans)
            {
                var loanCapital = loan.Capital;
                var loanInterestRate = loan.LoanType.InterestRate;
                var loanDurationMonths = loan.LoanType.LoanDuration * 12;
                currentLoansAmount += (loanCapital * loanInterestRate + loanCapital) / 12;
            }

            if (client.IsEmployed)
            {
                if (client.Income >= averageSalary && client.IsFixedTermContract && !client.IsUnusualProfession)
                {
                    var requiredLoanMonthlyAmount =
                        (requiredLoan.Capital * requiredLoan.LoanType.InterestRate + requiredLoan.Capital)/12;
                    var assessment = (clientIncome - fixedAmmount - currentLoansAmount)/requiredLoanMonthlyAmount;
                }
            }

            return 0;
        }

        public double CalculateLoanAssessmentForBusinessClients(long clientId)
        {
            return 0;
        }
    }
}
