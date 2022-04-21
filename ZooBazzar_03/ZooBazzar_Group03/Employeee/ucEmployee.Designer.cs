namespace ZooBazzar_Group03.Employeee
{
    partial class ucEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEmployee
            // 
            this.pbEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmployee.Location = new System.Drawing.Point(3, 9);
            this.pbEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(88, 62);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 0;
            this.pbEmployee.TabStop = false;
            this.pbEmployee.Click += new System.EventHandler(this.pbEmployee_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(133, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "lblName";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Footlight MT Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpecialization.Location = new System.Drawing.Point(133, 32);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(108, 15);
            this.lblSpecialization.TabIndex = 2;
            this.lblSpecialization.Text = "lblSpecialization";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(104, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(161, 14);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "name.familyname@gmail.com";
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(287, 74);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbEmployee;
        private Label lblName;
        private Label lblSpecialization;
        private Label lblEmail;
    }
}
