namespace ZooBazzar_Group03
{
    partial class AnimalPicture
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
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnimal
            // 
            this.pbAnimal.Location = new System.Drawing.Point(0, 0);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(141, 141);
            this.pbAnimal.TabIndex = 0;
            this.pbAnimal.TabStop = false;
            this.pbAnimal.Click += new System.EventHandler(this.pbAnimal_Click);
            // 
            // AnimalPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbAnimal);
            this.Name = "AnimalPicture";
            this.Size = new System.Drawing.Size(141, 141);
            this.Load += new System.EventHandler(this.AnimalPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbAnimal;
    }
}
