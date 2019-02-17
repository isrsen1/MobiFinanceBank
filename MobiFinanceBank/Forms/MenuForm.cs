using System;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Helpers;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;

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
        private readonly IExchangeForm exchangeForm;
        private readonly ICreateClientForm _createClientForm;
        private readonly IClientOverviewForm _clientOverviewForm;
        private readonly IBankServicesOverviewForm _bankServicesOverviewForm;
        private readonly IAdminPanel _adminPanel;
        private readonly ILoanRequestsForm loanRequestsForm;
        private readonly IEmployeeTypeRepository employeeTypeRepository;

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
    }
}
