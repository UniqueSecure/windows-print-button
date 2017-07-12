using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.uniquesecure.meposconnect;

namespace Print_button
{
    public partial class Form1 : Form
    {
        private MePOS mepos;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnectUSB_Click(object sender, EventArgs e)
        {
            mepos = new MePOS(MePOSConnectionType.USB);
        }

        private void buttonConnectWIFI_Click(object sender, EventArgs e)
        {
            mepos = new MePOS(MePOSConnectionType.WIFI);
            String ipAddress = textBoxIP.Text;
            mepos.getConnectionManager().setConnectionIPAddress(ipAddress);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MePOSReceipt receipt = new MePOSReceipt();
            MePOSReceiptTextLine receiptLine = new MePOSReceiptTextLine();
            receiptLine.setText("----Start of test receipt----", MePOS.TEXT_STYLE_NONE, MePOS.TEXT_SIZE_NORMAL, MePOS.TEXT_POSITION_CENTER);
            receipt.addLine(receiptLine);

            receipt.addLine(new MePOSReceiptFeedLine(2));

            receipt.addLine(new MePOSReceiptSingleCharLine('t'));
            receipt.addLine(new MePOSReceiptSingleCharLine('e'));
            receipt.addLine(new MePOSReceiptSingleCharLine('s'));
            receipt.addLine(new MePOSReceiptSingleCharLine('t'));
            receipt.addLine(new MePOSReceiptSingleCharLine('-'));
            receipt.addLine(new MePOSReceiptFeedLine(1));
            receipt.addLine(new MePOSReceiptSingleCharLine('£'));
            receipt.addLine(new MePOSReceiptSingleCharLine('€'));
            receipt.addLine(new MePOSReceiptSingleCharLine('$'));
            receipt.addLine(new MePOSReceiptSingleCharLine('¥'));
            receipt.addLine(new MePOSReceiptSingleCharLine('-'));
            receipt.addLine(new MePOSReceiptFeedLine(2));

            receiptLine = new MePOSReceiptTextLine();
            receiptLine.setText("----End of test receipt----", MePOS.TEXT_STYLE_NONE, MePOS.TEXT_SIZE_NORMAL, MePOS.TEXT_POSITION_CENTER);
            receipt.addLine(receiptLine);
            try
            {
                Task task = Task.Run(() => 
                {
                    mepos.print(receipt);
                }
                );
                task.Wait();
                
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex);
            }
        }
    }
}
