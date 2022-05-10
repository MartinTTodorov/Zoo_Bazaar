namespace Entities
{
    partial class ucDate
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
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.AutoSize = true;
            this.lblWeekDay.Location = new System.Drawing.Point(20, 33);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(13, 20);
            this.lblWeekDay.TabIndex = 0;
            this.lblWeekDay.Text = "!";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 71);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(13, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "!";
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWeekDay);
            this.Name = "Date";
            this.Size = new System.Drawing.Size(142, 134);
            this.Load += new System.EventHandler(this.Date_Load);
            this.Click += new System.EventHandler(this.Date_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWeekDay;
        private Label lblDate;
    }
}
