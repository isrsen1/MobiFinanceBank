using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms;
using MobiFinanceBank.Forms.Interfaces;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<LoginForm>());
        }
    }
}
