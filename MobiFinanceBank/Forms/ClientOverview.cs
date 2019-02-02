using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    public partial class ClientOverview : TemplateForm, IClientOverview
    {
        private readonly IClientTypeRepository clientTypeRepository;
        public ClientOverview(IClientTypeRepository _clientTypeRepository)
        {
            InitializeComponent();
            this.clientTypeRepository = _clientTypeRepository;
        }

        private void ClientOverview_Load(object sender, EventArgs e)
        {
            clientTypeCb.ValueMember = "Id";
            clientTypeCb.DisplayMember = "Name";
            clientTypeCb.DataSource = new BindingSource(this.clientTypeRepository.GetAll(), null);
        }

        private void clientTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clientType = (ClientType)clientTypeCb.SelectedItem;
            var isPrivateClient = clientType.Name == "Privatni" ? true : false;

            clientOverviewDgv.DataSource = clientType.Clients.Where(client => client.ClientType == clientType).ToList();
        }
    }
}
