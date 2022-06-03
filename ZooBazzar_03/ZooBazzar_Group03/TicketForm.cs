using DataAccessLayer;
using Entities;
using LogicLayer;
using USB_Barcode_Scanner;

namespace ZooBazzar_Group03
{
    public partial class TicketForm : Form
    {
        private TicketManager tm;
        public TicketForm()
        {
            InitializeComponent();
            tm = new TicketManager(new TicketsDB(),new TicketsDB());
            BarcodeScanner barcodeScanner = new BarcodeScanner(tbBarcode);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            tbBarcode.Text = e.Barcode;
            int barcode = Convert.ToInt32(tbBarcode.Text);
            Ticket ticket = tm.GetTicket(barcode);
            GetTicket();
        }

        private void GetTicket()
        {
            int barcode = Convert.ToInt32(tbBarcode.Text);
            Ticket ticket = tm.GetTicket(barcode);
            if (ticket is null)
            {
                MessageBox.Show("Such ticket doesn't exist! PLease scan again!");
                return;
            }
            if (tm.ChangeTicketStatus(ticket) is false)
            {
                MessageBox.Show("This ticket has already been used");
                return;
            }

            lbTickets.Items.Add(ticket);
        }
    }
}
