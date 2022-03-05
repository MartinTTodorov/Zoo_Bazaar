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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnFindByFirstName = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.cbSpecialization = new System.Windows.Forms.ComboBox();
            this.btnFindBySpecialization = new System.Windows.Forms.Button();
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblHello = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEmployees);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tpEmployees
            // 
            this.tpEmployees.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.BackgroundEmployee;
            this.tpEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpEmployees.Controls.Add(this.groupBox1);
            this.tpEmployees.Controls.Add(this.gbEmployee);
            this.tpEmployees.Controls.Add(this.flpEmployees);
            this.tpEmployees.Location = new System.Drawing.Point(4, 29);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(794, 367);
            this.tpEmployees.TabIndex = 0;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.btnNewEmployee);
            this.groupBox1.Controls.Add(this.btnRemoveEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(8, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNewEmployee.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewEmployee.ForeColor = System.Drawing.Color.Ivory;
            this.btnNewEmployee.Location = new System.Drawing.Point(38, 35);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(142, 29);
            this.btnNewEmployee.TabIndex = 5;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = false;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEmployee.ForeColor = System.Drawing.Color.Ivory;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(234, 35);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(142, 29);
            this.btnRemoveEmployee.TabIndex = 4;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
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
            this.gbEmployee.Location = new System.Drawing.Point(8, 35);
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
            this.tbFirstName.Location = new System.Drawing.Point(23, 70);
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
            this.flpEmployees.Location = new System.Drawing.Point(425, 6);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(366, 355);
            this.flpEmployees.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // MainManu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "MainManu";
            this.Text = "MainManu";
            this.Load += new System.EventHandler(this.MainManu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpEmployees;
        private GroupBox groupBox1;
        private Button btnNewEmployee;
        private Button btnRemoveEmployee;
        private GroupBox gbEmployee;
        private Button btnFindByFirstName;
        private TextBox tbFirstName;
        private ComboBox cbSpecialization;
        private Button btnFindBySpecialization;
        private FlowLayoutPanel flpEmployees;
        private TabPage tabPage2;
        private Button btnShowAll;
        private Label lblHello;
    }
}