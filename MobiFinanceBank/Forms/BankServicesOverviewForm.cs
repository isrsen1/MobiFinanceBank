﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Bank services overview form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="IBankServicesOverviewForm"/>
    public partial class BankServicesOverviewForm : TemplateForm, IBankServicesOverviewForm
    {
        private readonly IBankServicesVmService bankServicesVmService;
        private readonly IEmployeeRepository employeeRepository;

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        /// <value>
        /// The client
        /// </value>
        public Client Client { get; set; }
        public Dictionary<BankServices, DataGridView> ServicesDictionary { get; set; }

        /// <summary>
        /// Bank services enum
        /// </summary>
        /// <value>
        /// Current service filter
        /// </value>
        public BankServices CurrentServiceFilter { get; set; }
        
        /// <summary>
        /// Initializes new instance of bank services overview model
        /// </summary>
        /// <param name="_bankServicesVmService">Bank services view model service</param>
        public BankServicesOverviewForm
            (IBankServicesVmService _bankServicesVmService, IEmployeeRepository _employeeRepository)
        {
            InitializeComponent();
            this.bankServicesVmService = _bankServicesVmService;
            this.employeeRepository = _employeeRepository;
        }

        /// <summary>
        /// Hides base show method
        /// </summary>
        /// <param name="client">The client</param>
        public new void Show(Client client)
        {
            // Gets client from previous form
            this.Client = client;

            // Calling base show
            base.Show();
        }

        /// <summary>
        /// On saving and account overview form load
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void SavingAndAccountOverviewForm_Load(object sender, EventArgs e)
        {
            
            // Set data sources and windows size
            this.SetDataSources();
            this.SetDataGridViewSize(750, 300);
            
            // Connect services with data grid views - necessary for hiding data grid views
            ServicesDictionary = new Dictionary<BankServices, DataGridView>()
            {
                {BankServices.Kredit, loanDgv},
                {BankServices.Račun, accountDgv },
                {BankServices.Štednja, savingAccountDgv}
            };
        }
        /// <summary>
        /// Gets employee that was in charge of approving the service
        /// </summary>
        /// <seealso cref="account"/>
        /// <seealso cref="loan"/>
        /// <seealso cref="savingAccount"/>
        private void GetEmployee(Account account, Loan loan,SavingAccount savingAccount)
        {
            //var account = (Account)accountDgv.SelectedRows[0].DataBoundItem;
            //var loan = (Loan)loanDgv.SelectedRows[0].DataBoundItem;
            //var savingAccount = (SavingAccount)savingAccountDgv.SelectedRows[0].DataBoundItem;

            this.employeeDgv.DefaultCellStyle.ForeColor = Color.Black;

            if (savingAccountDgv.Visible==true)
            {
                this.employeeDgv.DataSource = new BindingSource(this.employeeRepository.Get(savingAccount.EmployeeId), null);
            }
            if (accountDgv.Visible == true)
            {
                this.employeeDgv.DataSource = new BindingSource(this.employeeRepository.Get(account.EmployeeId), null);
            }
            if (loanDgv.Visible == true)
            {
                this.employeeDgv.DataSource = new BindingSource(this.employeeRepository.Get(loan.EmployeeId), null);
            }
            this.employeeDgv.Columns["Id"].Visible = false;
            this.employeeDgv.Columns["Loans"].Visible = false;
            this.employeeDgv.Columns["EmployeeTypeId"].Visible = false;
            this.employeeDgv.Columns["EmployeeType"].Visible = false;
            this.employeeDgv.Columns["SavingAccounts"].Visible = false;


        }
        /// <summary>
        /// On bank services combobox selected index change
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void bankServicesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Selected filter item 
                var item = (BankServices) bankServicesCb.SelectedItem;

                // If selected item is as same as previous, skip
                if (item == CurrentServiceFilter)
                    return;

                // Save filter states
                var current = ServicesDictionary.FirstOrDefault(k => k.Key == item);
                var past = ServicesDictionary.FirstOrDefault(k => k.Key == CurrentServiceFilter);
                this.CurrentServiceFilter = item;

                // Hide/show based on filter
                current.Value.Visible = true;
                past.Value.Visible = false;
            }
            catch (Exception eas)
            {

            }
        }
        /// <summary>
        /// Sets the data sources for the comboBox and dataGridViews
        /// </summary>
        private void SetDataSources()
        {
            bankServicesCb.DataSource = Enum.GetValues(typeof(BankServices));
            this.CurrentServiceFilter = BankServices.Račun;

            // Hide data grid views
            loanDgv.Visible = false;
            savingAccountDgv.Visible = false;

            // Sets bank services filters
            var accountFilter = new AccountOverviewFilter() { Client = this.Client };
            var savingAccountFilter = new SavingOverviewFilter() { Client = this.Client };
            var loanFilter = new LoanOverviewFilter() { Client = this.Client };

            // Sets bank services data sources
            accountDgv.DataSource = this.bankServicesVmService.GetAccountsOverview(accountFilter);
            savingAccountDgv.DataSource = this.bankServicesVmService.GetSavingAccountsOverview(savingAccountFilter);
            loanDgv.DataSource = this.bankServicesVmService.GetLoansOverview(loanFilter);
        }

        /// <summary>
        /// Set data grid views size
        /// </summary>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        private void SetDataGridViewSize(int width, int height)
        {
            savingAccountDgv.Size = new Size(width, height);
            accountDgv.Size = new Size(width, height);
            loanDgv.Size = new Size(width, height);
        }
        /// <summary>
        /// Performs action to get employee for accountDataGrid
        /// </summary>

        private void accountDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var account = (Account)accountDgv.SelectedRows[0].DataBoundItem;
            GetEmployee(account, null, null);


        }
        /// <summary>
        /// Performs action to get employee for savingAccountDgv 
        /// </summary>
        private void savingAccountDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var savingAccount = (SavingAccount)savingAccountDgv.SelectedRows[0].DataBoundItem;
            GetEmployee(null, null, savingAccount);
        }
        /// <summary>
        /// Performs action to get employee for loanDgv
        /// </summary>
        private void loanDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var loan = (Loan)loanDgv.SelectedRows[0].DataBoundItem;
            GetEmployee(null, loan, null);
        }
        /// <summary>
        /// Dependency injection fix
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void BankServicesOverviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        /// <summary>
        /// Help file
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void BankServicesOverviewForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#252-pregled-usluga");
            }
        }
    }
}
