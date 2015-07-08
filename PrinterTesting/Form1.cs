using System;
using System.Windows.Forms;
using System.IO;

namespace PrinterTesting
{
    public partial class Form1 : Form
    {
        /*
         * Author: Rigoberto Ramírez Cruz
         *          @zoket_spider
         *       github.com/marzurk
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchPrinters();
        }

        void SearchPrinters()
        {
            foreach (string printerName in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                lsbPrinters.Items.Add(printerName);
            }
        }

        private void lsbPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbPrinters.SelectedIndex > -1)
                txtPrinterName.Text = lsbPrinters.Items[lsbPrinters.SelectedIndex].ToString();
        }

        private void btnSavePrinterName_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            if (path == string.Empty)
            {
                using (StreamWriter sWriter = new StreamWriter(Application.StartupPath + "\\printers.txt"))
                {
                    sWriter.Write(txtPrinterName.Text);
                }
            }
            else
            {
                using (StreamWriter sWriter = new StreamWriter(path + "\\printers.txt"))
                {
                    sWriter.Write(txtPrinterName.Text);
                }
            }
        }
    }
}
