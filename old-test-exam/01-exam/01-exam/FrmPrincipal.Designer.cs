namespace _01_exam
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.toolTipPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.BtnJugar = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LstNombres = new System.Windows.Forms.ListBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJugar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.LblResultados = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnJugar
            // 
            this.BtnJugar.Location = new System.Drawing.Point(551, 39);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(75, 23);
            this.BtnJugar.TabIndex = 0;
            this.BtnJugar.Text = "Jugar";
            this.BtnJugar.UseVisualStyleBackColor = true;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(632, 39);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(713, 39);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LstNombres
            // 
            this.LstNombres.FormattingEnabled = true;
            this.LstNombres.ItemHeight = 15;
            this.LstNombres.Location = new System.Drawing.Point(551, 89);
            this.LstNombres.Name = "LstNombres";
            this.LstNombres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstNombres.Size = new System.Drawing.Size(238, 94);
            this.LstNombres.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(551, 210);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAcciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAcciones
            // 
            this.tsmiAcciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJugar,
            this.tsmiReset,
            this.toolStripSeparator1,
            this.tsmiSalir});
            this.tsmiAcciones.Name = "tsmiAcciones";
            this.tsmiAcciones.Size = new System.Drawing.Size(67, 20);
            this.tsmiAcciones.Text = "&Acciones";
            // 
            // tsmiJugar
            // 
            this.tsmiJugar.Name = "tsmiJugar";
            this.tsmiJugar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiJugar.Size = new System.Drawing.Size(136, 22);
            this.tsmiJugar.Text = "&Jugar";
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmiReset.Size = new System.Drawing.Size(136, 22);
            this.tsmiReset.Text = "&Reset";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSalir.Size = new System.Drawing.Size(136, 22);
            this.tsmiSalir.Text = "&Salir";
            // 
            // LblResultados
            // 
            this.LblResultados.AutoSize = true;
            this.LblResultados.Location = new System.Drawing.Point(551, 257);
            this.LblResultados.Name = "LblResultados";
            this.LblResultados.Size = new System.Drawing.Size(64, 15);
            this.LblResultados.TabIndex = 6;
            this.LblResultados.Text = "Resultados";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblResultados);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.LstNombres);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Lotería simple";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolTip toolTipPrincipal;
        private Button BtnJugar;
        private Button BtnReset;
        private Button BtnSalir;
        private ListBox LstNombres;
        private Button BtnEliminar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiAcciones;
        private ToolStripMenuItem tsmiJugar;
        private ToolStripMenuItem tsmiReset;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiSalir;
        private Label LblResultados;
    }
}