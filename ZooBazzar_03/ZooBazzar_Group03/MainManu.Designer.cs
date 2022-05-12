namespace ZooBazzar_Group03
{
    partial class MainManu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnFindByFirstName = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.cbSpecialization = new System.Windows.Forms.ComboBox();
            this.btnFindBySpecialization = new System.Windows.Forms.Button();
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.FlowLayoutPanel();
            this.tpAnimals = new System.Windows.Forms.TabPage();
            this.flpAnimals = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnShowAllAnimals = new System.Windows.Forms.Button();
            this.tpEmployeeManagment = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.tbPasswordSettings = new System.Windows.Forms.TextBox();
            this.tbUsernameSettings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpContracts = new System.Windows.Forms.TabPage();
            this.btnDisableContract = new System.Windows.Forms.Button();
            this.lbContracts = new System.Windows.Forms.ListBox();
            this.tpEmployeeCredentials = new System.Windows.Forms.TabPage();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lbEmployeesWithNewCredentials = new System.Windows.Forms.ListBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calendar2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            this.gbEmployee.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.tpAnimals.SuspendLayout();
            this.tpEmployeeManagment.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpContracts.SuspendLayout();
            this.tpEmployeeCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEmployees);
            this.tabControl1.Controls.Add(this.tpSchedule);
            this.tabControl1.Controls.Add(this.tpAnimals);
            this.tabControl1.Controls.Add(this.tpEmployeeManagment);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Controls.Add(this.tpContracts);
            this.tabControl1.Controls.Add(this.tpEmployeeCredentials);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tpEmployees
            // 
            this.tpEmployees.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.LandingPage;
            this.tpEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpEmployees.Controls.Add(this.gbEmployee);
            this.tpEmployees.Controls.Add(this.flpEmployees);
            this.tpEmployees.Location = new System.Drawing.Point(4, 29);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpEmployees.Size = new System.Drawing.Size(794, 367);
            this.tpEmployees.TabIndex = 0;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // gbEmployee
            // 
            this.gbEmployee.BackColor = System.Drawing.Color.DarkGreen;
            this.gbEmployee.Controls.Add(this.btnShowAll);
            this.gbEmployee.Controls.Add(this.btnFindByFirstName);
            this.gbEmployee.Controls.Add(this.tbFirstName);
            this.gbEmployee.Controls.Add(this.cbSpecialization);
            this.gbEmployee.Controls.Add(this.btnFindBySpecialization);
            this.gbEmployee.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbEmployee.Location = new System.Drawing.Point(8, 104);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(399, 156);
            this.gbEmployee.TabIndex = 0;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Find";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAll.Location = new System.Drawing.Point(23, 112);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(353, 29);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnFindByFirstName
            // 
            this.btnFindByFirstName.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFindByFirstName.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindByFirstName.ForeColor = System.Drawing.Color.Ivory;
            this.btnFindByFirstName.Location = new System.Drawing.Point(215, 68);
            this.btnFindByFirstName.Name = "btnFindByFirstName";
            this.btnFindByFirstName.Size = new System.Drawing.Size(161, 29);
            this.btnFindByFirstName.TabIndex = 3;
            this.btnFindByFirstName.Text = "By first name";
            this.btnFindByFirstName.UseVisualStyleBackColor = false;
            this.btnFindByFirstName.Click += new System.EventHandler(this.btnFindByFirstName_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.Ivory;
            this.tbFirstName.Location = new System.Drawing.Point(23, 69);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(186, 29);
            this.tbFirstName.TabIndex = 2;
            // 
            // cbSpecialization
            // 
            this.cbSpecialization.BackColor = System.Drawing.Color.Ivory;
            this.cbSpecialization.FormattingEnabled = true;
            this.cbSpecialization.Location = new System.Drawing.Point(23, 27);
            this.cbSpecialization.Name = "cbSpecialization";
            this.cbSpecialization.Size = new System.Drawing.Size(186, 28);
            this.cbSpecialization.TabIndex = 1;
            // 
            // btnFindBySpecialization
            // 
            this.btnFindBySpecialization.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFindBySpecialization.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindBySpecialization.ForeColor = System.Drawing.Color.Ivory;
            this.btnFindBySpecialization.Location = new System.Drawing.Point(215, 27);
            this.btnFindBySpecialization.Name = "btnFindBySpecialization";
            this.btnFindBySpecialization.Size = new System.Drawing.Size(161, 29);
            this.btnFindBySpecialization.TabIndex = 0;
            this.btnFindBySpecialization.Text = "By specialization";
            this.btnFindBySpecialization.UseVisualStyleBackColor = false;
            this.btnFindBySpecialization.Click += new System.EventHandler(this.btnFindBySpecialization_Click);
            // 
            // flpEmployees
            // 
            this.flpEmployees.AutoScroll = true;
            this.flpEmployees.Location = new System.Drawing.Point(425, 5);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(366, 355);
            this.flpEmployees.TabIndex = 0;
            // 
            // tpSchedule
            // 
            this.tpSchedule.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.BackgroundTimetables;
            this.tpSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpSchedule.Controls.Add(this.label9);
            this.tpSchedule.Controls.Add(this.label8);
            this.tpSchedule.Controls.Add(this.label7);
            this.tpSchedule.Controls.Add(this.label6);
            this.tpSchedule.Controls.Add(this.label5);
            this.tpSchedule.Controls.Add(this.label4);
            this.tpSchedule.Controls.Add(this.label3);
            this.tpSchedule.Controls.Add(this.calendar2);
            this.tpSchedule.Controls.Add(this.btnNext);
            this.tpSchedule.Controls.Add(this.btnPrevious);
            this.tpSchedule.Controls.Add(this.calendar);
            this.tpSchedule.Location = new System.Drawing.Point(4, 29);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSchedule.Size = new System.Drawing.Size(794, 367);
            this.tpSchedule.TabIndex = 1;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            this.tpSchedule.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(585, 332);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(469, 332);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 29);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(21, 44);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(677, 102);
            this.calendar.TabIndex = 0;
            // 
            // tpAnimals
            // 
            this.tpAnimals.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.rhinoceros_g4cd4a45ea_1920;
            this.tpAnimals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpAnimals.Controls.Add(this.flpAnimals);
            this.tpAnimals.Controls.Add(this.btnAddAnimal);
            this.tpAnimals.Controls.Add(this.btnShowAllAnimals);
            this.tpAnimals.Location = new System.Drawing.Point(4, 29);
            this.tpAnimals.Name = "tpAnimals";
            this.tpAnimals.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpAnimals.Size = new System.Drawing.Size(794, 367);
            this.tpAnimals.TabIndex = 2;
            this.tpAnimals.Text = "Animals";
            this.tpAnimals.UseVisualStyleBackColor = true;
            // 
            // flpAnimals
            // 
            this.flpAnimals.AutoScroll = true;
            this.flpAnimals.Location = new System.Drawing.Point(293, 21);
            this.flpAnimals.Name = "flpAnimals";
            this.flpAnimals.Size = new System.Drawing.Size(333, 323);
            this.flpAnimals.TabIndex = 5;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddAnimal.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAnimal.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddAnimal.Location = new System.Drawing.Point(38, 205);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(161, 29);
            this.btnAddAnimal.TabIndex = 4;
            this.btnAddAnimal.Text = "Add an animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnShowAllAnimals
            // 
            this.btnShowAllAnimals.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAllAnimals.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllAnimals.ForeColor = System.Drawing.Color.Ivory;
            this.btnShowAllAnimals.Location = new System.Drawing.Point(38, 131);
            this.btnShowAllAnimals.Name = "btnShowAllAnimals";
            this.btnShowAllAnimals.Size = new System.Drawing.Size(161, 29);
            this.btnShowAllAnimals.TabIndex = 1;
            this.btnShowAllAnimals.Text = "Show all animals";
            this.btnShowAllAnimals.UseVisualStyleBackColor = false;
            this.btnShowAllAnimals.Click += new System.EventHandler(this.btnShowAllAnimals_Click);
            // 
            // tpEmployeeManagment
            // 
            this.tpEmployeeManagment.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.EmployeeManagmentBackground;
            this.tpEmployeeManagment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpEmployeeManagment.Controls.Add(this.groupBox2);
            this.tpEmployeeManagment.Controls.Add(this.lbEmployees);
            this.tpEmployeeManagment.Location = new System.Drawing.Point(4, 29);
            this.tpEmployeeManagment.Name = "tpEmployeeManagment";
            this.tpEmployeeManagment.Size = new System.Drawing.Size(794, 367);
            this.tpEmployeeManagment.TabIndex = 3;
            this.tpEmployeeManagment.Text = "Employee Managment";
            this.tpEmployeeManagment.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveEmployee);
            this.groupBox2.Controls.Add(this.btnUpdateEmployee);
            this.groupBox2.Controls.Add(this.btnAddEmployee);
            this.groupBox2.Location = new System.Drawing.Point(21, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 227);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(53, 95);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(141, 45);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click_1);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(53, 147);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(141, 45);
            this.btnUpdateEmployee.TabIndex = 3;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(53, 48);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(141, 41);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 20;
            this.lbEmployees.Location = new System.Drawing.Point(350, 63);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(434, 224);
            this.lbEmployees.TabIndex = 0;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            this.lbEmployees.DoubleClick += new System.EventHandler(this.lbEmployees_DoubleClick);
            // 
            // tpSettings
            // 
            this.tpSettings.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.SettingsBackground;
            this.tpSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpSettings.Controls.Add(this.groupBox3);
            this.tpSettings.Location = new System.Drawing.Point(4, 29);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(794, 367);
            this.tpSettings.TabIndex = 4;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSavePassword);
            this.groupBox3.Controls.Add(this.tbPasswordSettings);
            this.groupBox3.Controls.Add(this.tbUsernameSettings);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 356);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSavePassword.Location = new System.Drawing.Point(130, 221);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(165, 33);
            this.btnSavePassword.TabIndex = 5;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.UseVisualStyleBackColor = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // tbPasswordSettings
            // 
            this.tbPasswordSettings.Location = new System.Drawing.Point(43, 163);
            this.tbPasswordSettings.Name = "tbPasswordSettings";
            this.tbPasswordSettings.Size = new System.Drawing.Size(251, 27);
            this.tbPasswordSettings.TabIndex = 3;
            // 
            // tbUsernameSettings
            // 
            this.tbUsernameSettings.Location = new System.Drawing.Point(43, 77);
            this.tbUsernameSettings.Name = "tbUsernameSettings";
            this.tbUsernameSettings.ReadOnly = true;
            this.tbUsernameSettings.Size = new System.Drawing.Size(251, 27);
            this.tbUsernameSettings.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "username:";
            // 
            // tpContracts
            // 
            this.tpContracts.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.cows_g2d73e9cad_1920;
            this.tpContracts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpContracts.Controls.Add(this.btnDisableContract);
            this.tpContracts.Controls.Add(this.lbContracts);
            this.tpContracts.Location = new System.Drawing.Point(4, 29);
            this.tpContracts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpContracts.Name = "tpContracts";
            this.tpContracts.Size = new System.Drawing.Size(794, 367);
            this.tpContracts.TabIndex = 5;
            this.tpContracts.Text = "Contracts";
            this.tpContracts.UseVisualStyleBackColor = true;
            // 
            // btnDisableContract
            // 
            this.btnDisableContract.Location = new System.Drawing.Point(333, 313);
            this.btnDisableContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisableContract.Name = "btnDisableContract";
            this.btnDisableContract.Size = new System.Drawing.Size(102, 31);
            this.btnDisableContract.TabIndex = 1;
            this.btnDisableContract.Text = "Disable";
            this.btnDisableContract.UseVisualStyleBackColor = true;
            this.btnDisableContract.Click += new System.EventHandler(this.btnDisableContract_Click);
            // 
            // lbContracts
            // 
            this.lbContracts.FormattingEnabled = true;
            this.lbContracts.ItemHeight = 20;
            this.lbContracts.Location = new System.Drawing.Point(57, 31);
            this.lbContracts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbContracts.Name = "lbContracts";
            this.lbContracts.Size = new System.Drawing.Size(686, 244);
            this.lbContracts.TabIndex = 0;
            // 
            // tpEmployeeCredentials
            // 
            this.tpEmployeeCredentials.Controls.Add(this.btnDecline);
            this.tpEmployeeCredentials.Controls.Add(this.btnAccept);
            this.tpEmployeeCredentials.Controls.Add(this.lbEmployeesWithNewCredentials);
            this.tpEmployeeCredentials.Location = new System.Drawing.Point(4, 29);
            this.tpEmployeeCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpEmployeeCredentials.Name = "tpEmployeeCredentials";
            this.tpEmployeeCredentials.Size = new System.Drawing.Size(794, 367);
            this.tpEmployeeCredentials.TabIndex = 6;
            this.tpEmployeeCredentials.Text = "Employee Credentials";
            this.tpEmployeeCredentials.UseVisualStyleBackColor = true;
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(505, 299);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(86, 31);
            this.btnDecline.TabIndex = 2;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(200, 297);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(86, 31);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lbEmployeesWithNewCredentials
            // 
            this.lbEmployeesWithNewCredentials.FormattingEnabled = true;
            this.lbEmployeesWithNewCredentials.ItemHeight = 20;
            this.lbEmployeesWithNewCredentials.Location = new System.Drawing.Point(122, 40);
            this.lbEmployeesWithNewCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbEmployeesWithNewCredentials.Name = "lbEmployeesWithNewCredentials";
            this.lbEmployeesWithNewCredentials.Size = new System.Drawing.Size(572, 204);
            this.lbEmployeesWithNewCredentials.TabIndex = 0;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Location = new System.Drawing.Point(687, 421);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(69, 20);
            this.lblHello.TabIndex = 5;
            this.lblHello.Text = "Hello, ... !";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(11, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(67, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "SUNDAY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(208, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "MONDAY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Location = new System.Drawing.Point(357, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "TUESDAY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Location = new System.Drawing.Point(496, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "WEDNESDAY";
            // 
            // calendar2
            // 
            this.calendar2.Location = new System.Drawing.Point(21, 182);
            this.calendar2.Name = "calendar2";
            this.calendar2.Size = new System.Drawing.Size(677, 102);
            this.calendar2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Location = new System.Drawing.Point(67, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "THURSDAY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Location = new System.Drawing.Point(208, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "FRIDAY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Location = new System.Drawing.Point(357, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "SATURDAY";
            // 
            // MainManu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.BackgroundEmployee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "MainManu";
            this.Text = "MainManu";
            this.tabControl1.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.tpSchedule.ResumeLayout(false);
            this.tpSchedule.PerformLayout();
            this.tpAnimals.ResumeLayout(false);
            this.tpEmployeeManagment.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpContracts.ResumeLayout(false);
            this.tpEmployeeCredentials.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpEmployees;
        private GroupBox gbEmployee;
        private Button btnFindByFirstName;
        private TextBox tbFirstName;
        private ComboBox cbSpecialization;
        private Button btnFindBySpecialization;
        private FlowLayoutPanel flpEmployees;
        private TabPage tpSchedule;
        private Button btnShowAll;
        private Label lblHello;
        private FlowLayoutPanel calendar;
        private Button btnNext;
        private Button btnPrevious;
        private TabPage tpAnimals;
        private Button btnAddAnimal;
        private Button btnShowAllAnimals;
        private FlowLayoutPanel flpAnimals;
        private TabPage tpEmployeeManagment;
        private GroupBox groupBox2;
        private Button btnRemoveEmployee;
        private Button btnUpdateEmployee;
        private Button btnAddEmployee;
        private ListBox lbEmployees;
        private TabPage tpSettings;
        private GroupBox groupBox3;
        private Button btnSavePassword;
        private TextBox tbPasswordSettings;
        private TextBox tbUsernameSettings;
        private Label label2;
        private Label label1;
        private Button button1;
        private TabPage tpContracts;
        private ListBox lbContracts;
        private Button btnDisableContract;
        private TabPage tpEmployeeCredentials;
        private Button btnDecline;
        private Button btnAccept;
        private ListBox lbEmployeesWithNewCredentials;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private FlowLayoutPanel calendar2;
    }
}