using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Menu form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="IMenuPanel"/>
    public partial class AdminPanel : TemplateForm, IAdminPanel
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
    }
}
