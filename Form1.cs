using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace blocnotas
{
    public partial class frmMain : Form
    {
        bool DocumentoModificado = false;
        bool AcercaDeAbierto = false;

        

        public frmMain()
        {
            InitializeComponent();
            

        }

        //Hace comprobaciones antes de salir del programa
        private void frmMain_Unload(object sender, CancelEventArgs e)
        {
            if (DocumentoModificado == true)
            {
                switch (MessageBox.Show("El documento ha sido modificado.\n\n¿Desea guardar los cambios antes de salir?", "Cambios realizados",MessageBoxButtons.YesNoCancel))
                { 
                    case DialogResult.Yes:
                        mnuGuardar.PerformClick();    
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.No:
                        break;
                };

            }
        }

        //Menu Archivo
        private void mnuNuevo_Click(object sender, EventArgs e)
        {
            if (DocumentoModificado == true)
            {
                switch (MessageBox.Show("El documento ha sido modificado.\n\n¿Desea guardar los cambios antes de crear uno nuevo?", "Cambios realizados", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        mnuGuardar.PerformClick();
                        txtMain.Clear();
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.No:
                        txtMain.Clear();
                        break;
                }

            }
        }

        private void mnuVentanaNueva_Click(object sender, EventArgs e)
                    {
                        frmMain frmMain = new frmMain();
                        frmMain.Show();
                    }
        
        private void mnuAbrir_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                txtMain.Text = reader.ReadToEnd();
                reader.Close();

                DocumentoModificado = false;
            }
        }

        private void mnuGuardar_Click(object sender, EventArgs e)
        {


            try
            {

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter Fichero = new StreamWriter(saveFileDialog.FileName);
                    //Write a line of text
                    Fichero.Write(txtMain.Text);
                    //Write a second line of text
                    Fichero.Close();
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("Exception: " + a.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        private void mnuGuardarComo_Click(object sender, EventArgs e)
        {


                try
                {
                
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter Fichero = new StreamWriter(saveFileDialog.FileName);
                        //Write a line of text
                        Fichero.Write(txtMain.Text);
                        //Write a second line of text
                        Fichero.Close();
                    }
                }
                catch (Exception a)
                {
                    Console.WriteLine("Exception: " + a.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            
        }

        private void mnuConfigurarPagina_Click(object sender, EventArgs e)
        {
            frmConfigurarPagina frmConfigurarPagina = new frmConfigurarPagina();
            frmConfigurarPagina.Show();
            

        }
        //Realiza una busqueda en Google con el texto selecionado
        private void mnuBuscarInternet_Click(object sender, EventArgs e)
        {

            if (txtMain.SelectedText.Trim() != "")
            {

                //Asigna a la variable target la cadena de la búsqueda
                string target = "www.google.com/search?q=" + txtMain.SelectedText;

                //Reemplaza los espacios por signo '+', para que Google entienda la búsqueda
                target = target.Replace(" ", "+");

                //Inicia el comando de DOS, CMD.EXE y a su vez este inicia el programa Start.exe que se
                //encarga de abrir el programa asociado al protocolo http
                Process.Start(new ProcessStartInfo("cmd", $"/c start {target}") { CreateNoWindow = true });


            }
        }

        //Activa o desactiva el ajuste de linea
        private void mnuAjusteLinea_Click(object sender, EventArgs e)
        {
            if (mnuAjusteLinea.Checked == true)
            {
                txtMain.WordWrap = false;
                mnuAjusteLinea.Checked = false;
            }
            else
            {
                txtMain.WordWrap = true;
                mnuAjusteLinea.Checked = true;
            }
        }

        //Cambia la tipografía del texto
        private void mnuFuente_Click(object sender, EventArgs e)
        {

            fontDialog.Font = txtMain.Font;
            fontDialog.Color = txtMain.ForeColor;

            if (fontDialog.ShowDialog() == DialogResult.OK) {

                txtMain.Font = fontDialog.Font;
                txtMain.ForeColor = fontDialog.Color;

            }
        }

        //Muestra u oculta la barra de estado
        private void mnuBarraEstado_Click(object sender, EventArgs e)
        {

            if (mnuBarraEstado.Checked == true)
            {
                mnuBarraEstado.Checked = false;
                statusMain.Visible = false;
            }
            else
            {
                mnuBarraEstado.Checked = true;
                statusMain.Visible = true;
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        //Menu Edición

        private void mnuDeshacer_Click(object sender, EventArgs e)
        {

            txtMain.Undo();

        }

        private void mnuCortar_Click(object sender, EventArgs e)
        {

            txtMain.Cut();

        }

        private void mnuCopiar_Click(object sender, EventArgs e)
        {

            txtMain.Copy();

        }

        private void mnuPegar_Click(object sender, EventArgs e)
        {

            txtMain.Paste();

        }



        //Menu Formato





        //Menu Ver





        //Menu Ayuda

        private void mnuAcercaDe_Click(object sender, EventArgs e)
            {

                frmAcercaDe frmAcercaDe = new frmAcercaDe();
                frmAcercaDe.Show();
            AcercaDeAbierto = true;
            
            }

        private void txtMain_TextChanged(object sender, EventArgs e)
        {
            DocumentoModificado = true;
        }
    }
}
