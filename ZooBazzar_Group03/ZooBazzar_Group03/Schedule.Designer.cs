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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMorning = new System.Windows.Forms.FlowLayoutPanel();
            this.panemNoon = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEvening = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "6:00 - 8:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(465, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "12:00 - 14:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(813, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "20:00 - 22:00";
            // 
            // panelMorning
            // 
            this.panelMorning.BackColor = System.Drawing.Color.Transparent;
            this.panelMorning.Location = new System.Drawing.Point(12, 56);
            this.panelMorning.Name = "panelMorning";
            this.panelMorning.Size = new System.Drawing.Size(348, 317);
            this.panelMorning.TabIndex = 3;
            // 
            // panemNoon
            // 
            this.panemNoon.BackColor = System.Drawing.Color.Transparent;
            this.panemNoon.Location = new System.Drawing.Point(366, 56);
            this.panemNoon.Name = "panemNoon";
            this.panemNoon.Size = new System.Drawing.Size(339, 317);
            this.panemNoon.TabIndex = 4;
            // 
            // panelEvening
            // 
            this.panelEvening.AutoScroll = true;
            this.panelEvening.BackColor = System.Drawing.Color.Transparent;
            this.panelEvening.Location = new System.Drawing.Point(711, 56);
            this.panelEvening.Name = "panelEvening";
            this.panelEvening.Size = new System.Drawing.Size(348, 317);
            this.panelEvening.TabIndex = 4;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.panemNoon);
            this.Controls.Add(this.panelEvening);
            this.Controls.Add(this.panelMorning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel panelMorning;
        private FlowLayoutPanel panemNoon;
        private FlowLayoutPanel panelEvening;
    }
}