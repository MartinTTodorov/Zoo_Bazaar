namespace ZooBazzar_Group03.Forms
{
    partial class Animals
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
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAnimalName = new System.Windows.Forms.Button();
            this.tbAnimalName = new System.Windows.Forms.TextBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnShowAllAnimals = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.BackColor = System.Drawing.Color.Ivory;
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Location = new System.Drawing.Point(49, 171);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(161, 28);
            this.cbAnimalType.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Ivory;
            this.button2.Location = new System.Drawing.Point(216, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "By type";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAnimalName
            // 
            this.btnAnimalName.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAnimalName.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnimalName.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnimalName.Location = new System.Drawing.Point(216, 117);
            this.btnAnimalName.Name = "btnAnimalName";
            this.btnAnimalName.Size = new System.Drawing.Size(161, 29);
            this.btnAnimalName.TabIndex = 14;
            this.btnAnimalName.Text = "Search by name";
            this.btnAnimalName.UseVisualStyleBackColor = false;
            // 
            // tbAnimalName
            // 
            this.tbAnimalName.BackColor = System.Drawing.Color.Ivory;
            this.tbAnimalName.Location = new System.Drawing.Point(49, 120);
            this.tbAnimalName.Name = "tbAnimalName";
            this.tbAnimalName.Size = new System.Drawing.Size(161, 27);
            this.tbAnimalName.TabIndex = 13;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddAnimal.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAnimal.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddAnimal.Location = new System.Drawing.Point(49, 320);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(328, 29);
            this.btnAddAnimal.TabIndex = 12;
            this.btnAddAnimal.Text = "Add an animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            // 
            // btnShowAllAnimals
            // 
            this.btnShowAllAnimals.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAllAnimals.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllAnimals.ForeColor = System.Drawing.Color.Ivory;
            this.btnShowAllAnimals.Location = new System.Drawing.Point(49, 285);
            this.btnShowAllAnimals.Name = "btnShowAllAnimals";
            this.btnShowAllAnimals.Size = new System.Drawing.Size(328, 29);
            this.btnShowAllAnimals.TabIndex = 11;
            this.btnShowAllAnimals.Text = "Show all animals";
            this.btnShowAllAnimals.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(457, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(469, 430);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // Animals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 430);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbAnimalType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAnimalName);
            this.Controls.Add(this.tbAnimalName);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.btnShowAllAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Animals";
            this.Text = "Animals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbAnimalType;
        private Button button2;
        private Button btnAnimalName;
        private TextBox tbAnimalName;
        private Button btnAddAnimal;
        private Button btnShowAllAnimals;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}