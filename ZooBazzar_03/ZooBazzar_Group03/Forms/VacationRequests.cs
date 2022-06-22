﻿using System;
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
using Entities;

namespace ZooBazzar_Group03.Forms
{
    public partial class VacationRequests : Form
    {

        private VacationManager vacationManager = new VacationManager(new VacationsDB());
        public VacationRequests()
        {
            InitializeComponent();
            vacationManager.ReadRequests();
            UpdateUI();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lbVacations.SelectedIndex==-1)
            {
                MessageBox.Show("Please select a vacation first");
            }
            else
            {
                try
                {
                    vacationManager.AcceptVacation((Vacation)lbVacations.SelectedItem);
                    MessageBox.Show("Vacation acepted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (lbVacations.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vacation first");
            }
            else
            {
                try
                {
                    vacationManager.DenyVacation((Vacation)lbVacations.SelectedItem);
                    MessageBox.Show("Vacation denied successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateUI()
        {
            lbVacations.Items.Clear();
            foreach (Vacation vacation in vacationManager.Vacations)
            {
                lbVacations.Items.Add(vacation);
            }
        }
    }
}
