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
using MobiFinanceBank.Vm;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Create client form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="ICreateClientForm"/>
    public partial class CreateClientForm : TemplateForm, ICreateClientForm
    {
        private IClientTypeRepository clientTypeRepository;
        private IClientRepository clientRepository;
        private string emailPlaceholder = "e.g. isrsen1@foi.hr";

        /// <summary>
        /// Initializes new instance of create client form
        /// </summary>
        /// <param name="_clientTypeRepository">Client type repository</param>
        /// <param name="_clientRepository">Client repository</param>
        public CreateClientForm
            (IClientTypeRepository _clientTypeRepository, 
            IClientRepository _clientRepository)
        {
            InitializeComponent();

            this.clientTypeRepository = _clientTypeRepository;
            this.clientRepository = _clientRepository;
        }

        /// <summary>
        /// Create client on load
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void CreateClient_Load(object sender, EventArgs e)
        {
            // Set display and value combobox values and data source
            clientTypeCb.ValueMember = "Id";
            clientTypeCb.DisplayMember = "Name";
            clientTypeCb.DataSource = new BindingSource(this.clientTypeRepository.GetAll(), null);

            // Email text box placeholder
            emailTb.Text = emailPlaceholder;
            emailTb.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Email text box on enter
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void emailTb_Enter(object sender, EventArgs e)
        {
            // Remove text if placeholder
            if (emailTb.Text == emailPlaceholder)
            {
                emailTb.Text = "";
            }
        }

        /// <summary>
        /// Email text box on leave
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void emailTb_Leave(object sender, EventArgs e)
        {
            // if empty, set placeholder
            if (emailTb.Text == "")
            {
                emailTb.Text = emailPlaceholder;
            }
        }

        /// <summary>
        /// On client type combo box selected index changed
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void clientTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve selected client type and set state
            var clientType = (ClientType) clientTypeCb.SelectedItem;
            var isPrivateClient = clientType.Name == "Privatni" ? true : false;

            // Hide/show items based on client type
            firstNameLbl.Visible = isPrivateClient;
            firstNameTb.Visible = isPrivateClient;
            lastNameLbl.Visible = isPrivateClient;
            lastNameTb.Visible = isPrivateClient;
            companyLbl.Visible = !isPrivateClient;
            companyTb.Visible = !isPrivateClient;
        }

        /// <summary>
        /// On add client button click
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void addClientBtn_Click(object sender, EventArgs e)
        {
            // Retrieve selected client type
            var clientType = (ClientType)clientTypeCb.SelectedItem;

            // Add client
            this.clientRepository.Add(new Client()
            {
                FirstName = firstNameTb.Text,
                LastName = lastNameTb.Text,
                OIB = oibTb.Text,
                CompanyName = companyTb.Text,
                Email = emailTb.Text,
                Income = double.Parse(monthlyIncomeTb.Text),
                PhoneNumber = contactTb.Text,
                Address = addressTb.Text,
                ClientTypeId = clientType.Id
            });
        }
    }
}
