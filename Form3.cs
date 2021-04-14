using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blocnotas
{
    public partial class frmConfigurarPagina : Form
    {
        public frmConfigurarPagina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PageSetupDialog1.PageSettings =
                new System.Drawing.Printing.PageSettings();

            
            PageSetupDialog1.PrinterSettings =
                new System.Drawing.Printing.PrinterSettings();

            PageSetupDialog1.ShowNetwork = true;

            DialogResult result = PageSetupDialog1.ShowDialog();

            
            if (result == DialogResult.OK)
            {
                object[] results = new object[]{
            PageSetupDialog1.PageSettings.Margins,
            PageSetupDialog1.PageSettings.PaperSize,
            PageSetupDialog1.PageSettings.Landscape,
            PageSetupDialog1.PrinterSettings.PrinterName,
            PageSetupDialog1.PrinterSettings.PrintRange};
                listBox1.Items.AddRange(results);
            }
        }
    }
}
