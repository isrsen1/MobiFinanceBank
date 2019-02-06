﻿using System;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;
using ClientType = MobiFinanceBank.Model.Enums.ClientType;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Client overview form
    /// </summary>
    public partial class ClientOverviewForm : TemplateForm, IClientOverviewForm
    {
        private readonly IClientTypeRepository clientTypeRepository;
        private readonly IClientOverviewVmService clientOverviewVmService;
        private readonly IBankServicesOverviewForm _bankServicesOverviewForm;
        private readonly IOpeningBankServicesForm openingBankServicesForm;

        /// <summary>
        /// Initializes new instance of client overview form
        /// </summary>
        /// <param name="_clientTypeRepository">The client type repository</param>
        /// <param name="_clientOverviewVmService">The client overview view model service</param>
        /// <param name="bankServicesOverviewForm">Bank services overview form</param>
        /// <param name="_openingBankServicesForm">Opening bank services form</param>
        public ClientOverviewForm
            (IClientTypeRepository _clientTypeRepository, 
            IClientOverviewVmService _clientOverviewVmService,
            IBankServicesOverviewForm bankServicesOverviewForm,
            IOpeningBankServicesForm _openingBankServicesForm)
        {
            InitializeComponent();

            this.clientTypeRepository = _clientTypeRepository;
            this.clientOverviewVmService = _clientOverviewVmService;
            this._bankServicesOverviewForm = bankServicesOverviewForm;
            this.openingBankServicesForm = _openingBankServicesForm;
        }

        /// <summary>
        /// On client overview load
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void ClientOverview_Load(object sender, EventArgs e)
        {
            // Sets value, display members and data source
            clientTypeCb.ValueMember = "Id";
            clientTypeCb.DisplayMember = "Name";
            clientTypeCb.DataSource = new BindingSource(this.clientTypeRepository.GetAll(), null);
        }

        /// <summary>
        /// On client type combobox index change
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void clientTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parses client type combo box selected item into client type enum
            var clientType = this.clientTypeCb.GetItemText(this.clientTypeCb.SelectedItem);
            Enum.TryParse(clientType, true, out ClientType selectedClientType);

            // Client overview filter
            var filter = new ClientOverviewFilter()
            {
                ClientType = selectedClientType
            };

            // Sets client overview data grid view data source
            clientOverviewDgv.DataSource = this.clientOverviewVmService.GetClientOverview(filter);
        }

        /// <summary>
        /// Bank services overview button click
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void bankServicesOverview_Click(object sender, EventArgs e)
        {
            // Retrieve client from selected data grid view row
            if (clientOverviewDgv.SelectedRows.Count != 0)
            {
                var row = this.clientOverviewDgv.SelectedRows[0];
                var client = (Client)row.DataBoundItem;
                this._bankServicesOverviewForm.Show(client);
            }
        }

        /// <summary>
        /// Opening bank services button click
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void openingBankServicesBtn_Click(object sender, EventArgs e)
        {
            // Retrieve client from selected data grid view row
            if (clientOverviewDgv.SelectedRows.Count != 0)
            {
                var row = this.clientOverviewDgv.SelectedRows[0];
                var client = (Client)row.DataBoundItem;
                this.openingBankServicesForm.Show(client);
            }
        }
    }
}