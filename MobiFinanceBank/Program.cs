using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            container.RegisterType<IMenuForm, MenuForm>();
            container.RegisterType<IExchangeForm, ExchangeForm>();
            container.RegisterType<IExchangeService, ExchangeService>();
            container.RegisterType<IExchangeVmService, ExchangeVmService>();
            container.RegisterType<ICreateClient, CreateClient>();
            container.RegisterType<IClientTypeRepository, ClientTypeRepository>();
            container.RegisterType<IMobiFinanceContext, MobiFinanceContext>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<LoginForm>());
        }
    }
}
