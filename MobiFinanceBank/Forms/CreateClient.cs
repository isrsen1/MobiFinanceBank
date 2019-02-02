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
    public partial class CreateClient : TemplateForm, ICreateClient
    {
        private IClientTypeRepository clientTypeRepository;
        private string emailPlaceholder = "e.g. isrsen1@foi.hr";
        public CreateClient(IClientTypeRepository _clientTypeRepository)
        {
            InitializeComponent();
            this.clientTypeRepository = _clientTypeRepository;
        }

        private void CreateClient_Load(object sender, EventArgs e)
        {
            clientTypeCb.DataSource = new BindingSource(this.clientTypeRepository.GetAll(), null);
            clientTypeCb.DisplayMember = "Name";
            clientTypeCb.ValueMember = "Id";
            emailTb.Text = emailPlaceholder;
            emailTb.ForeColor = Color.Gray;
        }

        private void emailTb_Enter(object sender, EventArgs e)
        {
            if (emailTb.Text == emailPlaceholder)
            {
                emailTb.Text = "";
            }
        }

        private void emailTb_Leave(object sender, EventArgs e)
        {
            if (emailTb.Text == "")
            {
                emailTb.Text = emailPlaceholder;
            }
        }

        private void clientTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = (ClientType) clientTypeCb.SelectedItem;
            var isPrivateClient = result.Name == "Privatni" ? true : false;

            firstNameLbl.Visible = isPrivateClient;
            firstNameTb.Visible = isPrivateClient;

            lastNameLbl.Visible = isPrivateClient;
            lastNameTb.Visible = isPrivateClient;

            companyLbl.Visible = !isPrivateClient;
            companyTb.Visible = !isPrivateClient;
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
