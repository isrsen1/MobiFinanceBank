using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Services.Interfaces;

namespace MobiFinanceBank.Services
{
    /// <summary>
    /// Loan assessment class
    /// </summary>
    public class LoanAssessment: ILoanAssessment
    {
        private readonly IClientRepository clientRepository;

        private readonly double averageSalary = 6237;
        private readonly double fixedAmount = 4158;
        private readonly double fixedAmountUnusualProfession = 2500;

        public LoanAssessment(IClientRepository _clientRepository)
        {
            this.clientRepository = _clientRepository;
        }

        public double CalculateLoanAssessmentForPrivateClients(long clientId)
        {
            var client = this.clientRepository.Get(clientId);
            var clientLoans = client.Loans;
            
            foreach (var loan in clientLoans)
            {
                
            }
            
            if (client.IsEmployed)
            {
                if (client.Income >= averageSalary && client.IsFixedTermContract && !client.IsUnusualProfession)
                {
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
