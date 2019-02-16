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
        private readonly ILoanRepository loanRepository;

        private readonly double averageSalary = 6237;
        private readonly double fixedAmmountUnusualProfession = 4158;
        private readonly double fixedAmmount = 2500;

        public LoanAssessment(IClientRepository _clientRepository, ILoanRepository _loanRepository)
        {
            this.clientRepository = _clientRepository;
            this.loanRepository = _loanRepository;
        }

        public double CalculateLoanAssessmentForPrivateClients(long clientId, Loan requiredLoan)
        {
            // Get client and client loans
            var client = this.clientRepository.Get(clientId);
            var clientLoans = this.loanRepository.GetByClientId(client.Id);

            double currentLoansAmount = 0;
            var clientIncome = client.Income;

            // Calculate monthly loan amount from all client loans
            foreach (var loan in clientLoans)
            {
                var loanCapital = loan.Capital;
                var loanInterestRate = loan.LoanType.InterestRate;
                var loanDurationMonths = loan.LoanDuration * 12;
                currentLoansAmount += (loanCapital * loanInterestRate + loanCapital) / loanDurationMonths;
            }

            double assessment = 0;
            
            // if client is employed
            if (client.IsEmployed)
            {
                // If client income is higher than average salary, is on a fixed term contract and not risky profession
                if (client.Income >= averageSalary && client.IsFixedTermContract && !client.IsUnusualProfession)
                {
                    // Calculate assessment
                    var requiredLoanMonthlyAmount =
                        (requiredLoan.Capital * requiredLoan.LoanType.InterestRate + requiredLoan.Capital)/(requiredLoan.LoanDuration * 12);
                    assessment = (clientIncome - fixedAmmount - currentLoansAmount)/requiredLoanMonthlyAmount;
                }

                if (client.Income >= averageSalary && (client.IsFixedTermContract || client.IsUnusualProfession))
                {
                    // Calculate assessment
                    var requiredLoanMonthlyAmount =
                        (requiredLoan.Capital * requiredLoan.LoanType.InterestRate + requiredLoan.Capital) / (requiredLoan.LoanDuration * 12);
                    assessment = (clientIncome - fixedAmmountUnusualProfession - currentLoansAmount) / requiredLoanMonthlyAmount;
                }

                if (client.Income < averageSalary)
                {
                    // Calculate assessment
                    var requiredLoanMonthlyAmount =
                        (requiredLoan.Capital * requiredLoan.LoanType.InterestRate + requiredLoan.Capital) / (requiredLoan.LoanDuration * 12);
                    assessment = ((clientIncome / 3) - currentLoansAmount) / requiredLoanMonthlyAmount;
                }
            }

            return assessment/3;
        }
    }
}
