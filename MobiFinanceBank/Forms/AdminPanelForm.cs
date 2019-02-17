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
        private Employee newEmployee;

        public AdminPanelForm(IEmployeeTypeRepository _employeeTypeRepository,
            IEmployeeRepository _employeeRepository)
        {
            this.employeeTypeRepository = _employeeTypeRepository;
            this.employeeRepository = _employeeRepository;

            InitializeComponent();
        }
        /// <summary>
        /// On admin panel load refresh elements
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            RefreshElements();
        }
        /// <summary>
        /// Refreshes the elements on the page
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void RefreshElements()
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
        /// <summary>
        /// Executes when dataGridView is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void employeeDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeDgv.SelectedRows.Count != 0)
            {
                var row = this.employeeDgv.SelectedRows[0];
                var employee = (Employee)row.DataBoundItem;
                this.aktivanChb.Checked = employee.IsActive;
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
        /// <summary>
        /// Checks if page input is valid
        /// </summary>
        private bool checkValid()
        {
            var employeeType = (EmployeeType)employeeTypeCb.SelectedItem;

            var isValid = !string.IsNullOrEmpty(oibTb.Text)
                          && !string.IsNullOrEmpty(emailTb.Text)
                          && !string.IsNullOrEmpty(contactTb.Text)
                          && !string.IsNullOrEmpty(addressTb.Text)
                          && !string.IsNullOrEmpty(firstNameTb.Text)
                          && !string.IsNullOrEmpty(lastNameTb.Text);                         

            return isValid;
        }
        /// <summary>
        /// Base64 encoder used to convert the hash to a more managable character set for the database
        /// </summary>
        /// <param name="hash">Sender</param>
        public static string Base64Encode(string hash)
        {
            var hashBytes = System.Text.Encoding.UTF8.GetBytes(hash);
            return System.Convert.ToBase64String(hashBytes);
        }
        /// <summary>
        /// Adds or edits employee
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void newBtn_Click(object sender, EventArgs e)
        {     

            if (checkValid())
            {

                try
                {
                    //creates employee object and populates it with values
                    newEmployee = new Employee();
                    newEmployee.FirstName = firstNameTb.Text;
                    newEmployee.LastName = lastNameTb.Text;
                    newEmployee.OIB = (oibTb.Text);
                    newEmployee.UserName = usernameTb.Text;
                    newEmployee.Email = emailTb.Text;
                    newEmployee.PhoneNumber = contactTb.Text;
                    newEmployee.Address = addressTb.Text;
                    newEmployee.EmployeeTypeId = Convert.ToInt32(employeeTypeCb.SelectedValue);
                    newEmployee.IsActive = aktivanChb.Checked;



                    if (!string.IsNullOrEmpty(passwordTb.Text))
                    {
                        //generates new password hash and salt from the entered plaintext password
                        var hashedPassword = HashedPassword.New(passwordTb.Text);
                        //encodes the hash and salt for storage in the database
                        var encodedHash = Base64Encode(hashedPassword.Hash);
                        var encodedSalt = Base64Encode(hashedPassword.Salt);

                        newEmployee.PasswordHash = encodedHash;
                        newEmployee.PasswordSalt = encodedSalt;
                    }
                                
                    //checks if employee already exists, edits if it does
                    if (!string.IsNullOrEmpty(oibTb.Text))
                    {
                        var employeeByOib = this.employeeRepository.GetByOIB(oibTb.Text);
                        if (employeeByOib != null)
                        {

                            this.employeeRepository.Edit(newEmployee);
                            employeeDgv.Update();
                            employeeDgv.Refresh();
                            RefreshElements();
                            MessageBox.Show("Zaposlenik izmjenjen");

                        }
                        else
                        {
                            //if we are adding a new employee, the password must be entered as well
                            if (!string.IsNullOrEmpty(passwordTb.Text))
                            {
                                //adds new employee to database
                                this.employeeRepository.Add(newEmployee);
                                employeeDgv.Update();
                                employeeDgv.Refresh();
                                RefreshElements();
                                MessageBox.Show(@"Zaposlenik uspješno unesen");

                            }
                        }
                    }


                }                                                   
                catch (Exception)
                {
                    MessageBox.Show(@"Neuspješan unos zaposlenika");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show(@"Morate unijeti sve podatke");
            }
        }
        /// <summary>
        /// help file
        /// </summary>
        /// <seealso cref="sender"/>
        /// <seealso cref="e"/>
        private void AdminPanelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#210-administratorski-panel");
            }
        }
        /// <summary>
        /// For dependency injection 
        /// </summary>
        /// <seealso cref="sender"/>
        /// <seealso cref="e"/>
        private void AdminPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

    }
}
