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
            this.btnCreateContract.Location = new System.Drawing.Point(70, 341);
            this.btnCreateContract.Name = "btnCreateContract";
            this.btnCreateContract.Size = new System.Drawing.Size(196, 49);
            this.btnCreateContract.TabIndex = 5;
            this.btnCreateContract.Text = "Create Contract";
            this.btnCreateContract.UseVisualStyleBackColor = true;
            this.btnCreateContract.Click += new System.EventHandler(this.btnCreateContract_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(70, 49);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(70, 122);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 7;
            // 
            // tbFte
            // 
            this.tbFte.Location = new System.Drawing.Point(87, 185);
            this.tbFte.Name = "tbFte";
            this.tbFte.Size = new System.Drawing.Size(161, 23);
            this.tbFte.TabIndex = 8;
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(87, 236);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(161, 81);
            this.tbReason.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(138, 31);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 15);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(138, 104);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(54, 15);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "End Date";
            // 
            // lblFTE
            // 
            this.lblFTE.AutoSize = true;
            this.lblFTE.Location = new System.Drawing.Point(138, 167);
            this.lblFTE.Name = "lblFTE";
            this.lblFTE.Size = new System.Drawing.Size(30, 15);
            this.lblFTE.TabIndex = 12;
            this.lblFTE.Text = "FTEs";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(138, 218);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(48, 15);
            this.lblReason.TabIndex = 13;
            this.lblReason.Text = "Reason:";
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 433);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblFTE);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.tbFte);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnCreateContract);
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