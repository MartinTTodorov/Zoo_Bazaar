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
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "6:00 - 8:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "12:00 - 14:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "20:00 - 22:00";
            // 
            // panelMorning
            // 
            this.panelMorning.Location = new System.Drawing.Point(138, 7);
            this.panelMorning.Name = "panelMorning";
            this.panelMorning.Size = new System.Drawing.Size(293, 144);
            this.panelMorning.TabIndex = 3;
            // 
            // panemNoon
            // 
            this.panemNoon.Location = new System.Drawing.Point(138, 157);
            this.panemNoon.Name = "panemNoon";
            this.panemNoon.Size = new System.Drawing.Size(293, 144);
            this.panemNoon.TabIndex = 4;
            // 
            // panelEvening
            // 
            this.panelEvening.Location = new System.Drawing.Point(138, 307);
            this.panelEvening.Name = "panelEvening";
            this.panelEvening.Size = new System.Drawing.Size(293, 138);
            this.panelEvening.TabIndex = 4;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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