using System;
using System.Drawing;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;

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
        /// Gets or sets the client
        /// </summary>
        /// <value>
        /// Client to modify
        /// </value>
        public Client ClientToModify { get; set; }

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

            if (ClientToModify != null)
            {
                firstNameTb.Text = ClientToModify.FirstName;
                lastNameTb.Text = ClientToModify.LastName;
                oibTb.Text = ClientToModify.OIB;
                companyTb.Text = ClientToModify.CompanyName;
                emailTb.Text = ClientToModify.Email;
                monthlyIncomeNum.Value = (decimal)ClientToModify.Income;
                contactTb.Text = ClientToModify.PhoneNumber;
                addressTb.Text = ClientToModify.Address;
                employedChb.Checked = ClientToModify.IsEmployed;
                fixedTermContractChb.Checked = ClientToModify.IsFixedTermContract;
                riskProfessionChb.Checked = ClientToModify.IsUnusualProfession;
                addClientBtn.Text = @"Uredi klijenta";
            }

        }

        /// <summary>
        /// Hides base show method
        /// </summary>
        /// <param name="client">The client</param>
        /// <param name="accountType">Account type</param>
        public new void Show(Client client)
        {
            this.ClientToModify = client;

            // Calls base show method
            base.Show();
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
                emailTb.ForeColor = Color.Black;
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
                emailTb.ForeColor = Color.Gray;
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
            var clientType = (ClientType)clientTypeCb.SelectedItem;
            var isPrivateClient = clientType.Name == Model.Enums.ClientType.Privatni.ToString() ? true : false;

            // Hide/show items based on client type
            firstNameLbl.Visible = isPrivateClient;
            firstNameTb.Visible = isPrivateClient;
            lastNameLbl.Visible = isPrivateClient;
            lastNameTb.Visible = isPrivateClient;

            employedLbl.Visible = isPrivateClient;
            employedChb.Visible = isPrivateClient;
            fixedTermContractLbl.Visible = isPrivateClient;
            fixedTermContractChb.Visible = isPrivateClient;
            riskProfessionLbl.Visible = isPrivateClient;
            riskProfessionChb.Visible = isPrivateClient;

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

            var isValid = !string.IsNullOrEmpty(oibTb.Text)
                          && !string.IsNullOrEmpty(emailTb.Text)
                          && !string.IsNullOrEmpty(contactTb.Text)
                          && !string.IsNullOrEmpty(addressTb.Text);

            if (clientType.Name == Model.Enums.ClientType.Privatni.ToString())
                isValid = isValid && !string.IsNullOrEmpty(firstNameTb.Text)
                                  && !string.IsNullOrEmpty(lastNameTb.Text);
            else
            {
                isValid = isValid && !string.IsNullOrEmpty(companyTb.Text);
            }

            if (!string.IsNullOrEmpty(oibTb.Text))
            {
                var clientByOib = this.clientRepository.GetByOIB(oibTb.Text);
                if (clientByOib != null && ClientToModify == null)
                {
                    isValid = false;
                    MessageBox.Show(@"Klijent s upisanim osobnim identifikacijskim brojem vec postoji");
                }
            }

            if (isValid)
            {
                try
                {
                    var client = new Client()
                    {
                        FirstName = firstNameTb.Text,
                        LastName = lastNameTb.Text,
                        OIB = oibTb.Text,
                        CompanyName = companyTb.Text,
                        Email = emailTb.Text,
                        Income = (double)monthlyIncomeNum.Value,
                        PhoneNumber = contactTb.Text,
                        Address = addressTb.Text,
                        ClientTypeId = clientType.Id,
                        IsEmployed = employedChb.Checked,
                        IsFixedTermContract = fixedTermContractChb.Checked,
                        IsUnusualProfession = riskProfessionChb.Checked
                    };

                    if (ClientToModify == null)
                    {
                        // Add client
                        this.clientRepository.Add(client);
                    }
                    else
                    {
                        ClientToModify.FirstName = firstNameTb.Text;
                        ClientToModify.LastName = lastNameTb.Text;
                        ClientToModify.OIB = oibTb.Text;
                        ClientToModify.CompanyName = companyTb.Text;
                        ClientToModify.Email = emailTb.Text;
                        ClientToModify.Income = (double)monthlyIncomeNum.Value;
                        ClientToModify.PhoneNumber = contactTb.Text;
                        ClientToModify.Address = addressTb.Text;
                        ClientToModify.ClientTypeId = clientType.Id;
                        ClientToModify.IsEmployed = employedChb.Checked;
                        ClientToModify.IsFixedTermContract = fixedTermContractChb.Checked;
                        ClientToModify.IsUnusualProfession = riskProfessionChb.Checked;

                        this.clientRepository.Edit(ClientToModify);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Neuspješan unos klijenta");
                    return;
                }

                MessageBox.Show(@"Klijent uspješno kreiran");
            }
            else
            {
                MessageBox.Show(@"Morate unijeti sve podatke");
            }
        }
    }
}
