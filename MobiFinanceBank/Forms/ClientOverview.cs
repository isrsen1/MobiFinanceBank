using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService;
using MobiFinanceBank.VmService.Interfaces;

namespace MobiFinanceBank.Forms
{
    public partial class ClientOverview : TemplateForm, IClientOverview
    {
        private readonly IClientTypeRepository clientTypeRepository;
        private readonly IClientOverviewVmService clientOverviewVmService;
        public ClientOverview(IClientTypeRepository _clientTypeRepository, IClientOverviewVmService _clientOverviewVmService)
        {
            InitializeComponent();
            this.clientTypeRepository = _clientTypeRepository;
            this.clientOverviewVmService = _clientOverviewVmService;
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
            var isPrivateClient = clientType.Name == Model.Enums.ClientType.Privatni.ToString() ? true : false;

            Model.Enums.ClientType.TryParse(clientType.Name, true, out Model.Enums.ClientType selectedClientType);

            var filter = new ClientOverviewFilter()
            {
                ClientType = selectedClientType
            };

            clientOverviewDgv.DataSource = this.clientOverviewVmService.GetClientOverview(filter);
        }
    }
}
