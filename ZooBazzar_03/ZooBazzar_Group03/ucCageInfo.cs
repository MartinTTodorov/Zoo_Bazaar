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
using Entities;
using DataAccessLayer;

namespace ZooBazzar_Group03
{
    public partial class ucCageInfo : UserControl
    {

        private Schedule schedule;
        public ucCageInfo(Cage cage, string date, DateTime currentDate, Schedule schedule, string timeSlot)
        {
            InitializeComponent();
            this.cage = cage;
            this.currentDate = currentDate;
            this.schedule = schedule;
            this.timeSlot = timeSlot;
        }

        ScheduleManager sm = new ScheduleManager(new ScheduleDB(), new EmployeeDB(), new CageDB(), new ContractDB());

        Cage cage;

        string timeSlot;

        DateTime currentDate;

        private void ucCageInfo_Click(object sender, EventArgs e)
        {

            //schedule.lblAnimalType.Text = cage.Type.ToString();
            //schedule.lblSpecies.Text = cage.Species.ToString();
            //schedule.lblCageNumber.Text = cage.CageNumber.ToString();

           // Caretaker caretakerId = sm.AssignedCaretaker(cage, timeSlot);

            //if (sm.CheckDate(currentDate))
            //{
            //    if (caretakerId == null)
            //    {
            //        schedule.cmbFirstCaretaker.Text = "";
            //        schedule.cmbFirstCaretaker.Items.Clear();

            //        //foreach (Caretaker s in sm.GetCaretaker(cage))
            //        //{
            //        //    schedule.cmbFirstCaretaker.Items.Add(s);
            //        //}

            //        schedule.btnAssign.Enabled = true;
            //        schedule.btnEditEmployee.Enabled = false;
            //    }
            //    else
            //    {
            //        schedule.cmbFirstCaretaker.Items.Clear();

            //        schedule.cmbFirstCaretaker.Text = caretakerId.ToString();
            //        //foreach (Caretaker s in sm.GetCaretaker(cage))
            //        //{
            //        //    schedule.cmbFirstCaretaker.Items.Add(s);
            //        //}
            //        schedule.btnAssign.Enabled = false;
            //        schedule.btnEditEmployee.Enabled = true;
            //    }
            //}
            //else
            //{
            //    schedule.cmbFirstCaretaker.Enabled = false;
            //    schedule.cmbFirstCaretaker.Text = "";

            //    if (caretakerId != null)
            //    {
            //        schedule.cmbFirstCaretaker.Text = caretakerId.ToString();
            //    }
            //    else
            //    {
            //        schedule.cmbFirstCaretaker.Text = "No one fed the poor animal!";
            //    }
            //}


        }

        private void ucCageInfo_Load_1(object sender, EventArgs e)
        {
            lblCageNr.Text = cage.ToString();
            lblSpecies.Text = cage.CageNumber.ToString();
        }
    }
}
