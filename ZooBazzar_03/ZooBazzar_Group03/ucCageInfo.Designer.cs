namespace ZooBazzar_Group03
{
    partial class ucCageInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCageNr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cage number:";
            // 
            // lblCageNr
            // 
            this.lblCageNr.AutoSize = true;
            this.lblCageNr.Location = new System.Drawing.Point(25, 38);
            this.lblCageNr.Name = "lblCageNr";
            this.lblCageNr.Size = new System.Drawing.Size(13, 20);
            this.lblCageNr.TabIndex = 1;
            this.lblCageNr.Text = "!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Species:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(25, 78);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(13, 20);
            this.lblSpecies.TabIndex = 3;
            this.lblSpecies.Text = "!";
            // 
            // ucCageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCageNr);
            this.Controls.Add(this.label1);
            this.Name = "ucCageInfo";
            this.Size = new System.Drawing.Size(160, 118);
            this.Load += new System.EventHandler(this.ucCageInfo_Load);
            this.Click += new System.EventHandler(this.ucCageInfo_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblCageNr;
        private Label label2;
        private Label lblSpecies;
    }
}
