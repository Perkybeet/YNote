
namespace blocnotas
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentanaNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConfigurarPagina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBuscarInternet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuscarSiguiente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuscarAnterior = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReemplazar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIrLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoraFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjusteLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlejar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPredeterminado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarraEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComentarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuMain.Size = new System.Drawing.Size(682, 28);
            this.menuMain.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevo,
            this.mnuVentanaNueva,
            this.mnuAbrir,
            this.mnuGuardar,
            this.mnuGuardarComo,
            this.toolStripSeparator1,
            this.mnuConfigurarPagina,
            this.mnuImprimir,
            this.toolStripSeparator2,
            this.mnuSalir});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.Size = new System.Drawing.Size(212, 26);
            this.mnuNuevo.Text = "Nuevo";
            this.mnuNuevo.Click += new System.EventHandler(this.mnuNuevo_Click);
            // 
            // mnuVentanaNueva
            // 
            this.mnuVentanaNueva.Name = "mnuVentanaNueva";
            this.mnuVentanaNueva.Size = new System.Drawing.Size(212, 26);
            this.mnuVentanaNueva.Text = "Ventana nueva";
            this.mnuVentanaNueva.Click += new System.EventHandler(this.mnuVentanaNueva_Click);
            // 
            // mnuAbrir
            // 
            this.mnuAbrir.Name = "mnuAbrir";
            this.mnuAbrir.Size = new System.Drawing.Size(212, 26);
            this.mnuAbrir.Text = "Abrir";
            this.mnuAbrir.Click += new System.EventHandler(this.mnuAbrir_Click);
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.Size = new System.Drawing.Size(212, 26);
            this.mnuGuardar.Text = "Guardar";
            this.mnuGuardar.Click += new System.EventHandler(this.mnuGuardar_Click);
            // 
            // mnuGuardarComo
            // 
            this.mnuGuardarComo.Name = "mnuGuardarComo";
            this.mnuGuardarComo.Size = new System.Drawing.Size(212, 26);
            this.mnuGuardarComo.Text = "Guardar como...";
            this.mnuGuardarComo.Click += new System.EventHandler(this.mnuGuardarComo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuConfigurarPagina
            // 
            this.mnuConfigurarPagina.Name = "mnuConfigurarPagina";
            this.mnuConfigurarPagina.Size = new System.Drawing.Size(212, 26);
            this.mnuConfigurarPagina.Text = "Configurar página";
            this.mnuConfigurarPagina.Click += new System.EventHandler(this.mnuConfigurarPagina_Click);
            // 
            // mnuImprimir
            // 
            this.mnuImprimir.Name = "mnuImprimir";
            this.mnuImprimir.Size = new System.Drawing.Size(212, 26);
            this.mnuImprimir.Text = "Imprimir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(212, 26);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeshacer,
            this.toolStripSeparator3,
            this.mnuCortar,
            this.mnuCopiar,
            this.mnuPegar,
            this.mnuEliminar,
            this.toolStripSeparator4,
            this.mnuBuscarInternet,
            this.mnuBuscar,
            this.mnuBuscarSiguiente,
            this.mnuBuscarAnterior,
            this.mnuReemplazar,
            this.mnuIrLinea,
            this.toolStripSeparator5,
            this.mnuSeleccionarTodo,
            this.mnuHoraFecha});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(72, 24);
            this.toolStripMenuItem2.Text = "Edición";
            // 
            // mnuDeshacer
            // 
            this.mnuDeshacer.Name = "mnuDeshacer";
            this.mnuDeshacer.Size = new System.Drawing.Size(208, 26);
            this.mnuDeshacer.Text = "Deshacer";
            this.mnuDeshacer.Click += new System.EventHandler(this.mnuDeshacer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // mnuCortar
            // 
            this.mnuCortar.Name = "mnuCortar";
            this.mnuCortar.Size = new System.Drawing.Size(208, 26);
            this.mnuCortar.Text = "Cortar";
            this.mnuCortar.Click += new System.EventHandler(this.mnuCortar_Click);
            // 
            // mnuCopiar
            // 
            this.mnuCopiar.Name = "mnuCopiar";
            this.mnuCopiar.Size = new System.Drawing.Size(208, 26);
            this.mnuCopiar.Text = "Copiar";
            this.mnuCopiar.Click += new System.EventHandler(this.mnuCopiar_Click);
            // 
            // mnuPegar
            // 
            this.mnuPegar.Name = "mnuPegar";
            this.mnuPegar.Size = new System.Drawing.Size(208, 26);
            this.mnuPegar.Text = "Pegar";
            this.mnuPegar.Click += new System.EventHandler(this.mnuPegar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(208, 26);
            this.mnuEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(205, 6);
            // 
            // mnuBuscarInternet
            // 
            this.mnuBuscarInternet.Name = "mnuBuscarInternet";
            this.mnuBuscarInternet.Size = new System.Drawing.Size(208, 26);
            this.mnuBuscarInternet.Text = "Buscar en Google";
            this.mnuBuscarInternet.Click += new System.EventHandler(this.mnuBuscarInternet_Click);
            // 
            // mnuBuscar
            // 
            this.mnuBuscar.Name = "mnuBuscar";
            this.mnuBuscar.Size = new System.Drawing.Size(208, 26);
            this.mnuBuscar.Text = "Buscar...";
            // 
            // mnuBuscarSiguiente
            // 
            this.mnuBuscarSiguiente.Name = "mnuBuscarSiguiente";
            this.mnuBuscarSiguiente.Size = new System.Drawing.Size(208, 26);
            this.mnuBuscarSiguiente.Text = "Buscar siguiente";
            // 
            // mnuBuscarAnterior
            // 
            this.mnuBuscarAnterior.Name = "mnuBuscarAnterior";
            this.mnuBuscarAnterior.Size = new System.Drawing.Size(208, 26);
            this.mnuBuscarAnterior.Text = "Buscar anterior";
            // 
            // mnuReemplazar
            // 
            this.mnuReemplazar.Name = "mnuReemplazar";
            this.mnuReemplazar.Size = new System.Drawing.Size(208, 26);
            this.mnuReemplazar.Text = "Reemplazar..";
            // 
            // mnuIrLinea
            // 
            this.mnuIrLinea.Name = "mnuIrLinea";
            this.mnuIrLinea.Size = new System.Drawing.Size(208, 26);
            this.mnuIrLinea.Text = "Ir a linea...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(205, 6);
            // 
            // mnuSeleccionarTodo
            // 
            this.mnuSeleccionarTodo.Name = "mnuSeleccionarTodo";
            this.mnuSeleccionarTodo.Size = new System.Drawing.Size(208, 26);
            this.mnuSeleccionarTodo.Text = "Seleccionar todo";
            // 
            // mnuHoraFecha
            // 
            this.mnuHoraFecha.Name = "mnuHoraFecha";
            this.mnuHoraFecha.Size = new System.Drawing.Size(208, 26);
            this.mnuHoraFecha.Text = "Hora y fecha";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjusteLinea,
            this.mnuFuente});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(79, 24);
            this.toolStripMenuItem3.Text = "Formato";
            // 
            // mnuAjusteLinea
            // 
            this.mnuAjusteLinea.Checked = true;
            this.mnuAjusteLinea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuAjusteLinea.Name = "mnuAjusteLinea";
            this.mnuAjusteLinea.Size = new System.Drawing.Size(196, 26);
            this.mnuAjusteLinea.Text = "Ajustes de línea";
            this.mnuAjusteLinea.Click += new System.EventHandler(this.mnuAjusteLinea_Click);
            // 
            // mnuFuente
            // 
            this.mnuFuente.Name = "mnuFuente";
            this.mnuFuente.Size = new System.Drawing.Size(196, 26);
            this.mnuFuente.Text = "Fuente";
            this.mnuFuente.Click += new System.EventHandler(this.mnuFuente_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuZoom,
            this.mnuBarraEstado});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem4.Text = "Ver";
            // 
            // mnuZoom
            // 
            this.mnuZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcercar,
            this.mnuAlejar,
            this.mnuPredeterminado});
            this.mnuZoom.Name = "mnuZoom";
            this.mnuZoom.Size = new System.Drawing.Size(197, 26);
            this.mnuZoom.Text = "Zoom";
            // 
            // mnuAcercar
            // 
            this.mnuAcercar.Name = "mnuAcercar";
            this.mnuAcercar.Size = new System.Drawing.Size(308, 26);
            this.mnuAcercar.Text = "Acercar";
            // 
            // mnuAlejar
            // 
            this.mnuAlejar.Name = "mnuAlejar";
            this.mnuAlejar.Size = new System.Drawing.Size(308, 26);
            this.mnuAlejar.Text = "Alejar";
            // 
            // mnuPredeterminado
            // 
            this.mnuPredeterminado.Name = "mnuPredeterminado";
            this.mnuPredeterminado.Size = new System.Drawing.Size(308, 26);
            this.mnuPredeterminado.Text = "Restaurar zoom predeterminado";
            // 
            // mnuBarraEstado
            // 
            this.mnuBarraEstado.Checked = true;
            this.mnuBarraEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuBarraEstado.Name = "mnuBarraEstado";
            this.mnuBarraEstado.Size = new System.Drawing.Size(197, 26);
            this.mnuBarraEstado.Text = "Barra de estado";
            this.mnuBarraEstado.Click += new System.EventHandler(this.mnuBarraEstado_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuComentarios,
            this.mnuAcercaDe});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem5.Text = "Ayuda";
            // 
            // mnuComentarios
            // 
            this.mnuComentarios.Name = "mnuComentarios";
            this.mnuComentarios.Size = new System.Drawing.Size(227, 26);
            this.mnuComentarios.Text = "Enviar comentarios...";
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(227, 26);
            this.mnuAcercaDe.Text = "Acerca de...";
            this.mnuAcercaDe.Click += new System.EventHandler(this.mnuAcercaDe_Click);
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTexto});
            this.statusMain.Location = new System.Drawing.Point(0, 327);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(682, 26);
            this.statusMain.TabIndex = 1;
            this.statusMain.Text = "©2021 Yago López Prado";
            // 
            // statusTexto
            // 
            this.statusTexto.Name = "statusTexto";
            this.statusTexto.Size = new System.Drawing.Size(178, 20);
            this.statusTexto.Text = "©2021 Yago López Prado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMain);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 299);
            this.panel1.TabIndex = 2;
            // 
            // txtMain
            // 
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.EnableAutoDragDrop = true;
            this.txtMain.Location = new System.Drawing.Point(0, 40);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(682, 259);
            this.txtMain.TabIndex = 3;
            this.txtMain.Text = "";
            this.txtMain.TextChanged += new System.EventHandler(this.txtMain_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 40);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Archivo de texto (*.txt)|*.txt|Documento de Texto Enrriquecido (*.rtf)|*.rtf";
            this.saveFileDialog.InitialDirectory = "C:\\";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Archivo de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.InitialDirectory = "C:\\";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // fontDialog
            // 
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ShowColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmMain";
            this.Text = "Bloc de notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_Unload);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuDeshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuCortar;
        private System.Windows.Forms.ToolStripMenuItem mnuCopiar;
        private System.Windows.Forms.ToolStripMenuItem mnuPegar;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuBuscarInternet;
        private System.Windows.Forms.ToolStripMenuItem mnuBuscar;
        private System.Windows.Forms.ToolStripMenuItem mnuBuscarSiguiente;
        private System.Windows.Forms.ToolStripMenuItem mnuBuscarAnterior;
        private System.Windows.Forms.ToolStripMenuItem mnuReemplazar;
        private System.Windows.Forms.ToolStripMenuItem mnuIrLinea;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuSeleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem mnuHoraFecha;
        private System.Windows.Forms.ToolStripMenuItem mnuAjusteLinea;
        private System.Windows.Forms.ToolStripMenuItem mnuFuente;
        private System.Windows.Forms.ToolStripMenuItem mnuZoom;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercar;
        private System.Windows.Forms.ToolStripMenuItem mnuAlejar;
        private System.Windows.Forms.ToolStripMenuItem mnuPredeterminado;
        private System.Windows.Forms.ToolStripMenuItem mnuBarraEstado;
        private System.Windows.Forms.ToolStripMenuItem mnuComentarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuImprimir;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigurarPagina;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardar;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnuVentanaNueva;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusTexto;
    }
}

