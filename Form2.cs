using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace blocnotas
{
    public partial class frmAcercaDe : Form
    {
        frmMain frmMain = new frmMain();
        

        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("cmd", $"/c start https://raw.githubusercontent.com/Perkybeet/YNotes/main/LICENSE%3A%20Ms.SS ");
        }

        private void frmAcercaDe_Load(object sender, EventArgs e)
        {
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            
            frmMain.Enabled = true;
            frmMain.Focus();
            this.Close();
        }
    }
}
