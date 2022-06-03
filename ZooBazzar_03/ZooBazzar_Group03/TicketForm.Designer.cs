namespace ZooBazzar_Group03
{
    partial class TicketForm
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
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTickets
            // 
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.ItemHeight = 20;
            this.lbTickets.Location = new System.Drawing.Point(405, 75);
            this.lbTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(441, 464);
            this.lbTickets.TabIndex = 0;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(110, 75);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBarcode.Multiline = true;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(158, 43);
            this.tbBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarcode.Location = new System.Drawing.Point(14, 79);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(85, 25);
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Text = "Barcode:";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTickets.Location = new System.Drawing.Point(405, 44);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(73, 25);
            this.lblTickets.TabIndex = 3;
            this.lblTickets.Text = "Tickets:";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.lbTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbTickets;
        private TextBox tbBarcode;
        private Label lblBarcode;
        private Label lblTickets;
    }
}