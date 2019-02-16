using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;
using System;
using HashLibrary;
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
    public partial class AdminPanelForm : TemplateForm, IAdminPanel
    {
        private readonly IEmployeeTypeRepository employeeTypeRepository;
        private readonly IEmployeeRepository employeeRepository;

        public AdminPanelForm(IEmployeeTypeRepository _employeeTypeRepository,
            IEmployeeRepository _employeeRepository)
        {
            this.employeeTypeRepository = _employeeTypeRepository;
            this.employeeRepository = _employeeRepository;

            InitializeComponent();
        }
        /// <summary>
        /// On admin panel load
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            // Sets data source of the employee type combo box, its display member and the value member
            employeeTypeCb.ValueMember = "Id";
            employeeTypeCb.DisplayMember = "Name";
            this.employeeDgv.DefaultCellStyle.ForeColor = Color.Black;
            employeeTypeCb.DataSource = new BindingSource(this.employeeTypeRepository.GetAll(), null);
            employeeDgv.DataSource = new BindingSource(this.employeeRepository.GetAll(), null);
            this.employeeDgv.Columns["Id"].Visible = false;
            this.employeeDgv.Columns["Loans"].Visible = false;
            this.employeeDgv.Columns["EmployeeTypeId"].Visible = false;
            this.employeeDgv.Columns["EmployeeType"].Visible = false;
            this.employeeDgv.Columns["SavingAccounts"].Visible = false;

        }

        private void employeeDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeDgv.SelectedRows.Count != 0)
            {
                var row = this.employeeDgv.SelectedRows[0];
                var employee = (Employee)row.DataBoundItem;
                if (employee!=null)
                {
                    firstNameTb.Text = employee.FirstName;
                    usernameTb.Text = employee.UserName;
                    lastNameTb.Text = employee.LastName;
                    oibTb.Text = employee.OIB.ToString();
                    emailTb.Text = employee.Email;
                    contactTb.Text = employee.PhoneNumber;
                    addressTb.Text = employee.Address;
                    employeeTypeCb.SelectedValue = employee.EmployeeTypeId;
                }              
            }
            else
            {
                MessageBox.Show("Odaberite klijenta", "Pregled klijenata", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //moze isto provjera opet dali postoji
            //this.employeeRepository.Edit;

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            //this.employeeRepository.GetbyOIB
            //if postoji then ne mozes editat samo unjet
            //also input provjera
            //else
            var isValid = true;
            if (isValid)
            {
                try
                {
                    //creates employee object and populates it with values
                    var newEmployee = new Employee();
                    newEmployee.FirstName = firstNameTb.Text;
                    newEmployee.LastName = lastNameTb.Text;
                    newEmployee.OIB = Convert.ToInt32(oibTb.Text);
                    newEmployee.UserName = usernameTb.Text;
                    newEmployee.Email = emailTb.Text;
                    newEmployee.PhoneNumber = contactTb.Text;
                    newEmployee.Address = addressTb.Text;
                    newEmployee.EmployeeTypeId = Convert.ToInt32(employeeTypeCb.SelectedValue);

                    //generates new password hash and salt from the entered plaintext password
                    var hashedPassword = HashedPassword.New(passwordTb.ToString());
                    newEmployee.PasswordHash = hashedPassword.Hash;
                    newEmployee.PasswordSalt = hashedPassword.Salt;
                    //adds new employee to database

                   // this.employeeRepository.Add(newEmployee);
                   
                }                                                   
                catch (Exception)
                {
                    MessageBox.Show(@"Neuspješan unos zaposlenika");
                    return;
                }

                MessageBox.Show(@"Zaposlenik uspješno unesen");
            }
            else
            {
                MessageBox.Show(@"Morate unijeti sve podatke");
            }
        }
    }
}
