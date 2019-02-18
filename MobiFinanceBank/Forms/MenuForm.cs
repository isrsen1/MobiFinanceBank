﻿using System;
using MobiFinanceBank.DAL.DbContexts;
using MobiFinanceBank.DAL.Repositories;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using System.Windows.Forms;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Helpers;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Services;
using MobiFinanceBank.Templates;
using MobiFinanceBank.VmService;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Menu form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="IMenuForm"/>
    public partial class MenuForm : TemplateForm, IMenuForm
    {
        private Employee employee;
        private IExchangeForm exchangeForm;
        private ICreateClientForm _createClientForm;
        private IClientOverviewForm _clientOverviewForm;
        private IBankServicesOverviewForm _bankServicesOverviewForm;
        private IAdminPanel _adminPanel;
        private ILoanRequestsForm loanRequestsForm;
        private IEmployeeTypeRepository employeeTypeRepository;

        /// <summary>
        /// Initializes new instance of menu form
        /// </summary>
        /// <param name="_exchangeForm">Exchange form</param>
        /// <param name="createClientForm">Create client form</param>
        /// <param name="clientOverviewForm">Client overview form</param>
        /// <param name="bankServicesOverviewForm">Bank services overview form</param>
        public MenuForm
            (IExchangeForm _exchangeForm, 
            ICreateClientForm createClientForm, 
            IClientOverviewForm clientOverviewForm,
            IBankServicesOverviewForm bankServicesOverviewForm,
            IAdminPanel adminPanel,
            ILoanRequestsForm _loanRequestsForm,
            IEmployeeTypeRepository _employeeTypeRepository,
            Employee _employee)
        {
            InitializeComponent();

            this.exchangeForm = _exchangeForm;
            this._createClientForm = createClientForm;
            this._clientOverviewForm = clientOverviewForm;
            this._bankServicesOverviewForm = bankServicesOverviewForm;
            this._adminPanel = adminPanel;
            this.loanRequestsForm = _loanRequestsForm;
            this.employeeTypeRepository = _employeeTypeRepository;

            //this.btnAdminPanel.Visible = false;
            btnAdminPanel.Enabled = true;
            this.btnAdminPanel.Visible = false;
     

        }
        public void GetEmployee(Employee _employee)
        {
            
            this.employee = _employee;
            lblImePrezime.Text = employee.FirstName + " " + employee.LastName;
            lblPrava.Text = employee.EmployeeType.Name;
            if (employee.EmployeeTypeId == 2)
            {
                btnAdminPanel.Visible = true;
                btnAdminPanel.Enabled = true;
            }
        }
        
        private void btnMjenjacnica_Click(object sender, EventArgs e)
        {
                exchangeForm.Show();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
                this._createClientForm.Show(null);
        }

        private void btnPregledKlijenata_Click(object sender, EventArgs e)
        {
                this._clientOverviewForm.Show();    
        }

        private void btnOtvaranjeUsluga_Click(object sender, EventArgs e)
        {
            
            this._bankServicesOverviewForm.Show(null);
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            this._adminPanel.Show();
        }

        private void loanRequestsBtn_Click(object sender, EventArgs e)
        {
            this.loanRequestsForm.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            var currentUser = CurrentUser.GetEmployee();
            var employeeType = this.employeeTypeRepository.Get(currentUser.EmployeeTypeId);
            if (employeeType.Name == Enum.GetName(typeof(EmployeeTypeEnum), EmployeeTypeEnum.Zaposlenik))
                loanRequestsBtn.Visible = false;
        }
        /// <summary>
        /// help file
        /// </summary>
        /// <seealso cref="sender"/>
        /// <seealso cref="e"/>
        private void MenuForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#13-po%C4%8Detni-prikaz");
            }
        }
        /// <summary>
        /// Dependency injection fix
        /// </summary>
        /// <seealso cref="TemplateForm"/>
        /// <seealso cref="IMenuForm"/>
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
