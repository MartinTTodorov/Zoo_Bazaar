using Entities;
using ZooBazzar_Group03.Employeee;

namespace ZooBazzar_Group03.Forms
{
    public partial class HomePage : Form
    {
        private List<Employee> employees;
        public HomePage(List<Employee> employees)
        {
            InitializeComponent();

            this.employees = employees;
            cbWorkPosition.DataSource = Enum.GetValues(typeof(Specialization));
            updateUX(employees);
        }

        private void updateUX(List<Employee> employees)
        {
            if (employees != null)
            {
                flpEmployees.Controls.Clear();
                foreach (Employee emp in employees)
                {
                    flpEmployees.Controls.Add(new ucEmployee(emp));
                }

            }
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            updateUX(employees);
        }

        private void btnWorkPosition_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbWorkPosition.SelectedText))
                updateUX(employees.FindAll(e => e.GetWorkingPosition() == cbWorkPosition.SelectedText));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
                updateUX(employees.FindAll(e => e.Name.Contains(tbSearch.Text) || e.Lastname.Contains(tbSearch.Text)));
        }
    }
}
