namespace ZooBazzar_Group03.Employeee
{
    partial class ContractForm
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
            this.btnCreateContract = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbFte = new System.Windows.Forms.TextBox();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblFTE = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateContract
            // 
            this.btnCreateContract.Location = new System.Drawing.Point(80, 455);
            this.btnCreateContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateContract.Name = "btnCreateContract";
            this.btnCreateContract.Size = new System.Drawing.Size(224, 65);
            this.btnCreateContract.TabIndex = 5;
            this.btnCreateContract.Text = "Create Contract";
            this.btnCreateContract.UseVisualStyleBackColor = true;
            this.btnCreateContract.Click += new System.EventHandler(this.btnCreateContract_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(80, 65);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(228, 27);
            this.dtpStartDate.TabIndex = 6;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(80, 163);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(228, 27);
            this.dtpEndDate.TabIndex = 7;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // tbFte
            // 
            this.tbFte.Location = new System.Drawing.Point(99, 247);
            this.tbFte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFte.Name = "tbFte";
            this.tbFte.Size = new System.Drawing.Size(183, 27);
            this.tbFte.TabIndex = 8;
            this.tbFte.TextChanged += new System.EventHandler(this.tbFte_TextChanged);
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(99, 315);
            this.tbReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(183, 107);
            this.tbReason.TabIndex = 9;
            this.tbReason.TextChanged += new System.EventHandler(this.tbReason_TextChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(158, 41);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 20);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(158, 139);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 20);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // lblFTE
            // 
            this.lblFTE.AutoSize = true;
            this.lblFTE.Location = new System.Drawing.Point(158, 223);
            this.lblFTE.Name = "lblFTE";
            this.lblFTE.Size = new System.Drawing.Size(38, 20);
            this.lblFTE.TabIndex = 12;
            this.lblFTE.Text = "FTEs";
            this.lblFTE.Click += new System.EventHandler(this.lblFTE_Click);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(158, 291);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(60, 20);
            this.lblReason.TabIndex = 13;
            this.lblReason.Text = "Reason:";
            this.lblReason.Click += new System.EventHandler(this.lblReason_Click);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 577);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblFTE);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.tbFte);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnCreateContract);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ContractForm";
            this.Text = "ContractForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCreateContract;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TextBox tbFte;
        private TextBox tbReason;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblFTE;
        private Label lblReason;
    }
}