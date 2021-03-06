﻿namespace Veterinaria
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vermifugosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAnimalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yConsultarVermifugosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMascotasConVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVermifugosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.BackgroundImage = global::Veterinaria.Properties.Resources.ANIMAL_PROYECT;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cerrarSeccionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.animalesToolStripMenuItem,
            this.vacunasToolStripMenuItem,
            this.vermifugosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.almacenToolStripMenuItem});
            this.datosToolStripMenuItem.Image = global::Veterinaria.Properties.Resources.registro;
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.datosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Veterinaria.Properties.Resources._1396472001_teacher;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // animalesToolStripMenuItem
            // 
            this.animalesToolStripMenuItem.Name = "animalesToolStripMenuItem";
            this.animalesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.animalesToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.animalesToolStripMenuItem.Text = "Animales";
            this.animalesToolStripMenuItem.Click += new System.EventHandler(this.animalesToolStripMenuItem_Click);
            // 
            // vermifugosToolStripMenuItem
            // 
            this.vermifugosToolStripMenuItem.Name = "vermifugosToolStripMenuItem";
            this.vermifugosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.vermifugosToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.vermifugosToolStripMenuItem.Text = "Vermifugos";
            this.vermifugosToolStripMenuItem.Click += new System.EventHandler(this.vermifugosToolStripMenuItem_Click);
            // 
            // vacunasToolStripMenuItem
            // 
            this.vacunasToolStripMenuItem.Name = "vacunasToolStripMenuItem";
            this.vacunasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.V)));
            this.vacunasToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.vacunasToolStripMenuItem.Text = "Vacunas";
            this.vacunasToolStripMenuItem.Click += new System.EventHandler(this.vacunasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClientesToolStripMenuItem,
            this.consultarProductosToolStripMenuItem,
            this.consultarVentasToolStripMenuItem,
            this.consultarAnimalesToolStripMenuItem,
            this.consultarVacunasToolStripMenuItem,
            this.yConsultarVermifugosToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = global::Veterinaria.Properties.Resources.BUSCAR_EN_ICONO;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // consultarProductosToolStripMenuItem
            // 
            this.consultarProductosToolStripMenuItem.Name = "consultarProductosToolStripMenuItem";
            this.consultarProductosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultarProductosToolStripMenuItem.Text = "Consultar Productos";
            this.consultarProductosToolStripMenuItem.Click += new System.EventHandler(this.consultarProductosToolStripMenuItem_Click);
            // 
            // consultarVentasToolStripMenuItem
            // 
            this.consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            this.consultarVentasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultarVentasToolStripMenuItem.Text = "Consultar Ventas";
            this.consultarVentasToolStripMenuItem.Click += new System.EventHandler(this.consultarVentasToolStripMenuItem_Click);
            // 
            // consultarAnimalesToolStripMenuItem
            // 
            this.consultarAnimalesToolStripMenuItem.Name = "consultarAnimalesToolStripMenuItem";
            this.consultarAnimalesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultarAnimalesToolStripMenuItem.Text = "Consultar Animales";
            this.consultarAnimalesToolStripMenuItem.Click += new System.EventHandler(this.consultarAnimalesToolStripMenuItem_Click);
            // 
            // consultarVacunasToolStripMenuItem
            // 
            this.consultarVacunasToolStripMenuItem.Name = "consultarVacunasToolStripMenuItem";
            this.consultarVacunasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultarVacunasToolStripMenuItem.Text = "Consultar Vacunas";
            this.consultarVacunasToolStripMenuItem.Click += new System.EventHandler(this.consultarVacunasToolStripMenuItem_Click);
            // 
            // yConsultarVermifugosToolStripMenuItem
            // 
            this.yConsultarVermifugosToolStripMenuItem.Name = "yConsultarVermifugosToolStripMenuItem";
            this.yConsultarVermifugosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.yConsultarVermifugosToolStripMenuItem.Text = "Consultar Vermifugos";
            this.yConsultarVermifugosToolStripMenuItem.Click += new System.EventHandler(this.yConsultarVermifugosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeClientesToolStripMenuItem,
            this.reporteDeMascotasToolStripMenuItem,
            this.reporteDeMascotasConVacunasToolStripMenuItem,
            this.reporteDeVacunasToolStripMenuItem,
            this.reporteDeVermifugosToolStripMenuItem,
            this.reporteDeProductosToolStripMenuItem,
            this.reporteDeVentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::Veterinaria.Properties.Resources.ICONO_REPORTES_MEDIDA;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            this.reporteDeClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClientesToolStripMenuItem_Click);
            // 
            // reporteDeMascotasToolStripMenuItem
            // 
            this.reporteDeMascotasToolStripMenuItem.Name = "reporteDeMascotasToolStripMenuItem";
            this.reporteDeMascotasToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.reporteDeMascotasToolStripMenuItem.Text = "Reporte de Mascotas";
            this.reporteDeMascotasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeMascotasToolStripMenuItem_Click);
            // 
            // reporteDeMascotasConVacunasToolStripMenuItem
            // 
            this.reporteDeMascotasConVacunasToolStripMenuItem.Name = "reporteDeMascotasConVacunasToolStripMenuItem";
            this.reporteDeMascotasConVacunasToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.reporteDeMascotasConVacunasToolStripMenuItem.Text = "Reporte de Mascotas con Vacunas";
            this.reporteDeMascotasConVacunasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeMascotasConVacunasToolStripMenuItem_Click);
            // 
            // reporteDeVacunasToolStripMenuItem
            // 
            this.reporteDeVacunasToolStripMenuItem.Name = "reporteDeVacunasToolStripMenuItem";
            this.reporteDeVacunasToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.reporteDeVacunasToolStripMenuItem.Text = "Reporte de Vacunas";
            this.reporteDeVacunasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVacunasToolStripMenuItem_Click);
            // 
            // reporteDeVermifugosToolStripMenuItem
            // 
            this.reporteDeVermifugosToolStripMenuItem.Name = "reporteDeVermifugosToolStripMenuItem";
            this.reporteDeVermifugosToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.reporteDeVermifugosToolStripMenuItem.Text = "Reporte de Vermifugos";
            this.reporteDeVermifugosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVermifugosToolStripMenuItem_Click);
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            this.reporteDeProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductosToolStripMenuItem_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosDelSistemaToolStripMenuItem,
            this.rolesDeUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = global::Veterinaria.Properties.Resources.user_man_and_woman_icona;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // usuariosDelSistemaToolStripMenuItem
            // 
            this.usuariosDelSistemaToolStripMenuItem.Image = global::Veterinaria.Properties.Resources._1396474153_Student_id_128;
            this.usuariosDelSistemaToolStripMenuItem.Name = "usuariosDelSistemaToolStripMenuItem";
            this.usuariosDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.usuariosDelSistemaToolStripMenuItem.Text = "Usuarios del Sistema";
            this.usuariosDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.usuariosDelSistemaToolStripMenuItem_Click);
            // 
            // rolesDeUsuarioToolStripMenuItem
            // 
            this.rolesDeUsuarioToolStripMenuItem.Name = "rolesDeUsuarioToolStripMenuItem";
            this.rolesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.rolesDeUsuarioToolStripMenuItem.Text = "Roles de Usuario";
            this.rolesDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.rolesDeUsuarioToolStripMenuItem_Click);
            // 
            // cerrarSeccionToolStripMenuItem
            // 
            this.cerrarSeccionToolStripMenuItem.Image = global::Veterinaria.Properties.Resources.salir_de_mi_perfil_icono_3964_96;
            this.cerrarSeccionToolStripMenuItem.Name = "cerrarSeccionToolStripMenuItem";
            this.cerrarSeccionToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.cerrarSeccionToolStripMenuItem.Text = "Cerrar seccion";
            this.cerrarSeccionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeccionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Veterinaria.Properties.Resources.cerrar_las_ventanas_de_programa_icono_9765_96;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripUsuario
            // 
            this.toolStripUsuario.Name = "toolStripUsuario";
            this.toolStripUsuario.Size = new System.Drawing.Size(110, 17);
            this.toolStripUsuario.Text = "Nombre de Usuario";
            this.toolStripUsuario.Click += new System.EventHandler(this.toolStripUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veterinaria Rudolf";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.almacenToolStripMenuItem.Text = "Almacen";
            this.almacenToolStripMenuItem.Click += new System.EventHandler(this.almacenToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veterinaria.Properties.Resources.fondoo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Veterinaria Rudolf";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vermifugosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAnimalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yConsultarVermifugosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeMascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVermifugosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem reporteDeMascotasConVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
    }
}