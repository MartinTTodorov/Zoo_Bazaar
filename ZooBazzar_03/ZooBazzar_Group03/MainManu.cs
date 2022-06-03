using ZooBazzar_Group03;
using LogicLayer;
using Entities;
using DataAccessLayer;

namespace ZooBazzar_Group03
{
    public partial class MainManu : Form
    {
        private Account currentAccount;
        private string workingPosition;

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private EmployeeManagment employeeManagment = new EmployeeManagment(new EmployeeDB());
        private AccountManager accountManager = new AccountManager(new AccountManagerDB(), new AccountManagerDB());
        private AnimalManager animalManager = new AnimalManager(new AnimalDB());
        private ContractManager cm = new ContractManager(new ContractDB());
        private RequestManager rm = new RequestManager(new RequestedEmployeeDB());

        public MainManu(Account account)
        {
            InitializeComponent();
            workingPosition = accountManager.GetWorkPositionByAccount(account.Username);
            accessability(workingPosition);
            this.currentAccount = account;
            lblGreeting.Text = $"Hello, {account.Username}!";
            lblTime.Text = $"{DateTime.UtcNow.TimeOfDay.Hours}:{DateTime.UtcNow.TimeOfDay.Minutes} o'clock"; 
            random = new Random();
            
        }
       
        private void accessability(string workingPosition)
        {

            if (workingPosition == "Manager")
            {

            }
            else if (workingPosition == "Resourceplanner")
            {
               
            }
            else
            {
                
            }
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ColorThemeHandler.Colors.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColorThemeHandler.Colors.Count);
            }
            tempIndex = index;
            string color = ColorThemeHandler.Colors[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    Color secColor = ColorThemeHandler.ChangeColorBrightness(color, -0.3d);

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pTitle.BackColor = color;
                    pLogo.BackColor = secColor;
                    ColorThemeHandler.PrimaryColor = color;
                    ColorThemeHandler.SecondaryColor = secColor;
                }
            }
        }
        private void openChildForm(Form form, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pContent.Controls.Add(form);
            this.pContent.Tag = form;
            form.BringToFront();
            form.Show();
            lblTitle.Text = form.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.ScheduleForm(), sender);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.EmployeesPage(employeeManagment.GetEmployees(),cm.GetContracts()), sender);
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Contracts(employeeManagment.GetEmployees()), sender);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Request(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Settings(currentAccount), sender);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Statistics(), sender);
        }

        private void btnScanning_Click(object sender, EventArgs e)
        {
            openChildForm(new TicketForm(), sender);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Tickets(), sender);
        }
    }
}
