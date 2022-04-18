namespace ZooBazzar_Group03
{
    partial class Schedule
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
            this.lblTimeSloth = new System.Windows.Forms.Label();
            this.panelAnimals = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAnimalType = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTimeSloth = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblCageNumber = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTimeSloth
            // 
            this.lblTimeSloth.AutoSize = true;
            this.lblTimeSloth.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeSloth.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeSloth.Location = new System.Drawing.Point(12, 37);
            this.lblTimeSloth.Name = "lblTimeSloth";
            this.lblTimeSloth.Size = new System.Drawing.Size(117, 32);
            this.lblTimeSloth.TabIndex = 0;
            this.lblTimeSloth.Text = "Time slot:";
            // 
            // panelAnimals
            // 
            this.panelAnimals.AutoScroll = true;
            this.panelAnimals.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimals.Location = new System.Drawing.Point(12, 150);
            this.panelAnimals.Name = "panelAnimals";
            this.panelAnimals.Size = new System.Drawing.Size(348, 272);
            this.panelAnimals.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(593, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Employees:";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(593, 190);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(217, 28);
            this.cmbEmployees.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(405, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Animal type:";
            // 
            // lblAnimalType
            // 
            this.lblAnimalType.AutoSize = true;
            this.lblAnimalType.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblAnimalType.Location = new System.Drawing.Point(411, 193);
            this.lblAnimalType.Name = "lblAnimalType";
            this.lblAnimalType.Size = new System.Drawing.Size(0, 20);
            this.lblAnimalType.TabIndex = 14;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblSpecies.Location = new System.Drawing.Point(411, 285);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(0, 20);
            this.lblSpecies.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(405, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Species:";
            // 
            // cmbTimeSloth
            // 
            this.cmbTimeSloth.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbTimeSloth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cmbTimeSloth.FormattingEnabled = true;
            this.cmbTimeSloth.Items.AddRange(new object[] {
            "6:00 - 8:00",
            "12:00 - 14:00",
            "20:00 - 22:00"});
            this.cmbTimeSloth.Location = new System.Drawing.Point(12, 72);
            this.cmbTimeSloth.Name = "cmbTimeSloth";
            this.cmbTimeSloth.Size = new System.Drawing.Size(260, 28);
            this.cmbTimeSloth.TabIndex = 17;
            this.cmbTimeSloth.SelectedIndexChanged += new System.EventHandler(this.cmbTimeSloth_SelectedIndexChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(593, 248);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(203, 57);
            this.btnAssign.TabIndex = 18;
            this.btnAssign.Text = "Assign employee";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblCageNumber
            // 
            this.lblCageNumber.AutoSize = true;
            this.lblCageNumber.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblCageNumber.Location = new System.Drawing.Point(411, 400);
            this.lblCageNumber.Name = "lblCageNumber";
            this.lblCageNumber.Size = new System.Drawing.Size(0, 20);
            this.lblCageNumber.TabIndex = 20;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.Color.Transparent;
            this.lbl9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl9.Location = new System.Drawing.Point(405, 359);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(133, 28);
            this.lbl9.TabIndex = 19;
            this.lbl9.Text = "Cage number:";
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(593, 330);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(203, 57);
            this.btnEditEmployee.TabIndex = 21;
            this.btnEditEmployee.Text = "Edit employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(865, 515);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.lblCageNumber);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cmbTimeSloth);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAnimalType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelAnimals);
            this.Controls.Add(this.lblTimeSloth);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTimeSloth;
        private FlowLayoutPanel panelAnimals;
        private Label label7;
        private Label label8;
        private Label label5;
        private ComboBox cmbTimeSloth;
        public ComboBox cmbEmployees;
        public Button btnAssign;
        private Label lbl9;
        public Label lblCageNumber;
        public Button btnEditEmployee;
        public Label lblAnimalType;
        public Label lblSpecies;
    }
}