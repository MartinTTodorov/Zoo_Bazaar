using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazzar_Group03.Properties;

namespace ZooBazzar_Group03.Employeee
{
    public partial class ucEmployee : UserControl
    {
        
        public ucEmployee(Employee employee)
        {
            InitializeComponent();           
            this.pbEmployee.Image = getImage(employee);
            this.lblName.Text = $"{employee.Name} {employee.Lastname}";
            this.lblSpecialization.Text = getSpecialization(employee);
            this.lblEmail.Text = employee.Email;
        }

        private void pbEmployee_Click(object sender, EventArgs e)
        {

        }

        private Image getImage(Employee employee)
        {
            if (employee is Caretaker caretaker)
            {
                return getImageCareTaker(caretaker.GetSpecialization());
            }
            else if (employee is ResourcePlanner)
            {
                return Resources.schedule;
            }
            else
            {
                return Resources.manager;
            }          
        }

        private Image getImageCareTaker(Specialization specialization)
        {
            switch (specialization)
            {
                case Specialization.Mammalogist:
                    return Resources.monkey;
                    
                case Specialization.Ornithologist:
                    return Resources.bird;
                    
                case Specialization.Ichthyologist:
                    return Resources.fish;
                   
                case Specialization.Herprtologist:
                    return Resources.chamelion;

                case Specialization.Entomologist:
                    return Resources.butterfly;
                
            }

            return null;
        }

        private string getSpecialization(Employee employee)
        {
            if(employee is Caretaker caretaker)
            {

                return caretaker.GetSpecialization().ToString();
            }
           else if(employee is ResourcePlanner)
            {
                return "Resource planner";
            }
            else
            {
                return "Manager";
            }
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
