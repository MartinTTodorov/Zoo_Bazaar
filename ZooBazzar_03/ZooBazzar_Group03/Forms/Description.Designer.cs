namespace ZooBazzar_Group03.Forms
{
    partial class Description
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAddDescription = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lbDescriptions = new System.Windows.Forms.ListBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbDisabled = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(116, 108);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(281, 219);
            this.tbDescription.TabIndex = 0;
            // 
            // btnAddDescription
            // 
            this.btnAddDescription.Location = new System.Drawing.Point(24, 147);
            this.btnAddDescription.Name = "btnAddDescription";
            this.btnAddDescription.Size = new System.Drawing.Size(75, 49);
            this.btnAddDescription.TabIndex = 1;
            this.btnAddDescription.Text = "Add Description";
            this.btnAddDescription.UseVisualStyleBackColor = true;
            this.btnAddDescription.Click += new System.EventHandler(this.btnAddDescription_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(24, 252);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 49);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "Disable Description";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lbDescriptions
            // 
            this.lbDescriptions.FormattingEnabled = true;
            this.lbDescriptions.ItemHeight = 15;
            this.lbDescriptions.Location = new System.Drawing.Point(521, 44);
            this.lbDescriptions.Name = "lbDescriptions";
            this.lbDescriptions.ScrollAlwaysVisible = true;
            this.lbDescriptions.Size = new System.Drawing.Size(234, 349);
            this.lbDescriptions.TabIndex = 3;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(421, 66);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(39, 19);
            this.rbAll.TabIndex = 4;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(421, 190);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(58, 19);
            this.rbActive.TabIndex = 5;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // rbDisabled
            // 
            this.rbDisabled.AutoSize = true;
            this.rbDisabled.Location = new System.Drawing.Point(421, 325);
            this.rbDisabled.Name = "rbDisabled";
            this.rbDisabled.Size = new System.Drawing.Size(70, 19);
            this.rbDisabled.TabIndex = 6;
            this.rbDisabled.TabStop = true;
            this.rbDisabled.Text = "Disabled";
            this.rbDisabled.UseVisualStyleBackColor = true;
            this.rbDisabled.CheckedChanged += new System.EventHandler(this.rbDisabled_CheckedChanged);
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbDisabled);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.lbDescriptions);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnAddDescription);
            this.Controls.Add(this.tbDescription);
            this.Name = "Description";
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbDescription;
        private Button btnAddDescription;
        private Button btnDisable;
        private ListBox lbDescriptions;
        private RadioButton rbAll;
        private RadioButton rbActive;
        private RadioButton rbDisabled;
    }
}