using System;
using System.Windows.Forms;
using MobiFinanceBank.DAL.DbContexts;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.DAL.Repositories;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Services;
using MobiFinanceBank.Services.Interfaces;
using MobiFinanceBank.VmService;
using MobiFinanceBank.VmService.Interfaces;
using Unity;

namespace MobiFinanceBank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new UnityContainer();
            container.RegisterType<ILoginForm, LoginForm>();
            container.RegisterType<ILoginVmService, LoginVmService>();
            container.RegisterType<ILoginService, LoginService>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IMenuForm, MenuForm>();
            container.RegisterType<IAdminPanel, AdminPanel>();
            container.RegisterType<IExchangeForm, ExchangeForm>();
            container.RegisterType<IExchangeService, ExchangeService>();
            container.RegisterType<IExchangeVmService, ExchangeVmService>();
            container.RegisterType<ICreateClientForm, CreateClientForm>();
            container.RegisterType<IClientTypeRepository, ClientTypeRepository>();
            container.RegisterType<IClientRepository, ClientRepository>();
            container.RegisterType<IMobiFinanceContext, MobiFinanceContext>();
            container.RegisterType<IClientOverviewForm, ClientOverviewForm>();
            container.RegisterType<IClientOverviewVmService, ClientOverviewVmService>();
            container.RegisterType<IBankServicesVmService, BankServicesVmService>();
            container.RegisterType<IBankServicesOverviewForm, BankServicesOverviewForm>();
            container.RegisterType<IAccountRepository, AccountRepository>();
            container.RegisterType<ISavingAccountRepository, SavingAccountRepository>();          
            container.RegisterType<ILoanRepository, LoanRepository>();
            container.RegisterType<ILoanTypeRepository, LoanTypeRepository>();
            container.RegisterType<ISavingAccountTypeRepository, SavingAccountTypeRepository>();
            container.RegisterType<IAccountTypeRepository, AccountTypeRepository>();
            container.RegisterType<IOpeningBankServicesForm, OpeningBankServicesForm>();
            container.RegisterType<IOpenAccountBankServiceForm, OpenAccountBankServiceForm>();
            container.RegisterType<IOpenSavingAccountBankServiceForm, OpenSavingAccountBankServiceForm>();
            container.RegisterType<IOpenLoanBankServiceForm, OpenLoanBankServiceForm>();
            container.RegisterType<ILoanAssessment, LoanAssessment>();
            container.RegisterType<ILoanRequestsForm, LoanRequestsForm>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<LoginForm>());
        }
    }
}
