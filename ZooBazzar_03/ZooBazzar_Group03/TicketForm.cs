using DataAccessLayer;
using Entities;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace ZooBazzar_Group03
{
    public partial class TicketForm : Form
    {
        private TicketManager tm;
        public TicketForm()
        {
            InitializeComponent();
            tm = new TicketManager(new TicketDB());
            BarcodeScanner barcodeScanner = new BarcodeScanner(tbBarcode);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            tbBarcode.Text = e.Barcode;
            int barcode = Convert.ToInt32(tbBarcode.Text);
            Ticket ticket = tm.GetTicket(barcode);
            lbTickets.Items.Add(ticket);
        }
    }
}
