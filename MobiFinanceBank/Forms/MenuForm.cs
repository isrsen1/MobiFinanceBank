using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    public partial class MenuForm : TemplateForm, IMenuForm
    {
        private readonly IExchangeForm exchangeForm;
        private readonly ICreateClientForm _createClientForm;
        private readonly IClientOverviewForm _clientOverviewForm;
        private readonly IBankServicesOverviewForm _bankServicesOverviewForm;
        public MenuForm
            (IExchangeForm _exchangeForm, 
            ICreateClientForm createClientForm, 
            IClientOverviewForm clientOverviewForm,
            IBankServicesOverviewForm bankServicesOverviewForm)
        {
            InitializeComponent();
            this.exchangeForm = _exchangeForm;
            this._createClientForm = createClientForm;
            this._clientOverviewForm = clientOverviewForm;
            this._bankServicesOverviewForm = bankServicesOverviewForm;
        }

        private void btnMjenjacnica_Click(object sender, EventArgs e)
        {
            exchangeForm.Show();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            this._createClientForm.Show();
        }

        private void btnPregledKlijenata_Click(object sender, EventArgs e)
        {
            this._clientOverviewForm.Show();
        }

        private void btnOtvaranjeUsluga_Click(object sender, EventArgs e)
        {
            this._bankServicesOverviewForm.Show(null);
        }
    }
}
