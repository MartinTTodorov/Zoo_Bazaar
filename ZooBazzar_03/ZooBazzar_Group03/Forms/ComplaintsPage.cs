using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataAccessLayer;

namespace ZooBazzar_Group03.Forms
{
    public partial class ComplaintsPage : Form
    {

        private ComplaintsManager complaintsManager = new ComplaintsManager(new ComplaintsDB());
        private Form activeForm;
        public ComplaintsPage()
        {
            InitializeComponent();
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            lblComplaints.DataSource = complaintsManager.Complaints;
        }

        private void lblComplaints_DoubleClick(object sender, EventArgs e)
        {
            openChildForm(new ShowComplaint(this.pContent), sender);
        }

        private void openChildForm(Form form, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }


            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pContent.Controls.Add(form);
            this.pContent.Tag = form;
            form.BringToFront();
            form.Show();

        }
    }
}
