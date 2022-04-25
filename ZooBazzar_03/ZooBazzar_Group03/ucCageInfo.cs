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


namespace ZooBazzar_Group03
{
    public partial class ucCageInfo : UserControl
    {

        private Schedule schedule;
        public ucCageInfo(int cageNr, string date, DateTime currentDate, Schedule schedule, string timeSlot)
        {
            InitializeComponent();
            this.cageNr = cageNr;
            this.currentDate = currentDate;
            this.schedule = schedule;
            this.timeSlot = timeSlot;
            sm = new ScheduleManager(date);
        }



        ScheduleManager sm;
        EmployeeManagment em = new EmployeeManagment();
        CageManager cm = new CageManager();


        int cageNr;

        string timeSlot;

        DateTime currentDate;

        private void ucCageInfo_Click(object sender, EventArgs e)
        {
            Cage cage = cm.GetCageByCageNr(cageNr);
            schedule.lblAnimalType.Text = cage.Type.ToString();
            schedule.lblSpecies.Text = cage.Species.ToString();
            schedule.lblCageNumber.Text = cage.CageNumber.ToString();

            int caretakerId = sm.AssignedCaretaker(cageNr, timeSlot);

            if (sm.CheckDate(currentDate))
            {
                if (caretakerId == 0)
                {
                    schedule.cmbEmployees.Text = "";
                    schedule.cmbEmployees.Items.Clear();

                    foreach (Caretaker s in sm.GetCaretakers(cageNr))
                    {
                        schedule.cmbEmployees.Items.Add(s);
                    }
                    schedule.btnAssign.Enabled = true;
                    schedule.btnEditEmployee.Enabled = false;
                }
                else
                {
                    schedule.cmbEmployees.Items.Clear();

                    schedule.cmbEmployees.Text = em.GetCaretakerById(caretakerId).ToString();
                    foreach (Caretaker s in sm.GetCaretakers(cageNr))
                    {
                        schedule.cmbEmployees.Items.Add(s);
                    }
                    schedule.btnAssign.Enabled = false;
                    schedule.btnEditEmployee.Enabled = true;
                }
            }
            else
            {
                schedule.cmbEmployees.Enabled = false;
                schedule.cmbEmployees.Text = "";

                if (caretakerId != 0)
                {
                    schedule.cmbEmployees.Text = em.GetCaretakerById(caretakerId).ToString();
                }
                else
                {
                    schedule.cmbEmployees.Text = "No one fed the poor animal!";
                }
            }


        }

        private void ucCageInfo_Load_1(object sender, EventArgs e)
        {
            lblCageNr.Text = cageNr.ToString();
            lblSpecies.Text = cm.GetCageByCageNr(cageNr).Species;
        }
    }
}
