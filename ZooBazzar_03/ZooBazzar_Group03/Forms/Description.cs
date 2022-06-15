using DataAccessLayer;
using Entities;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03.Forms
{
    public partial class Description : Form
    {
        private ZooDescriptionManager zm;
        public Description()
        {
            InitializeComponent();
            zm = new ZooDescriptionManager(new ZooDescriptionDB(), new ZooDescriptionDB());
        }

        private void LoadDescriptions(bool IsActive)
        {
            lbDescriptions.Items.Clear();
            foreach (ZooDescription zd in zm.GetDescriptions())
            {
                if (zd.IsActive == IsActive)
                {
                    lbDescriptions.Items.Add(zd);
                }
            }
        }

        private void LoadAllDescriptions()
        {
            lbDescriptions.Items.Clear();
            foreach (ZooDescription zd in zm.GetDescriptions())
            {
                lbDescriptions.Items.Add(zd);
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadAllDescriptions();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            bool isActive = true;
            LoadDescriptions(isActive);
        }

        private void rbDisabled_CheckedChanged(object sender, EventArgs e)
        {
            bool isActive = false;
            LoadDescriptions(isActive);
        }

        private void btnAddDescription_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescription.Text) == true)
            {
                MessageBox.Show("No description entered!");
                return;
            }
            try
            {
                ZooDescription zd = new ZooDescription(tbDescription.Text, true, DateTime.Today);
                zm.AddDescription(zd);
                LoadAllDescriptions();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ZooDescription zd = (ZooDescription)lbDescriptions.SelectedItem;
            if (zd is null)
            {
                MessageBox.Show("No description selected!");
                return;

            }
            try
            {
                zm.DisablePreviousDescription(zd);
                MessageBox.Show("Description disabled!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
