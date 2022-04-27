
namespace Multi_Tornillos.Views.Caja
{
    public partial class FrmMenu
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuListaCajas = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeDiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new JacksiroKe.MdiTabCtrl.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCajaNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCajaId = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldoCaja = new System.Windows.Forms.TextBox();
            this.mnuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListaCajas,
            this.usuariosToolStripMenuItem,
            this.saldoInicialToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(98, 450);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuListaCajas
            // 
            this.mnuListaCajas.Name = "mnuListaCajas";
            this.mnuListaCajas.Size = new System.Drawing.Size(85, 19);
            this.mnuListaCajas.Text = "Lista cajas";
            this.mnuListaCajas.Click += new System.EventHandler(this.mnuListaCajas_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // saldoInicialToolStripMenuItem
            // 
            this.saldoInicialToolStripMenuItem.Name = "saldoInicialToolStripMenuItem";
            this.saldoInicialToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.saldoInicialToolStripMenuItem.Text = "Saldo Inicial";
            this.saldoInicialToolStripMenuItem.Click += new System.EventHandler(this.saldoInicialToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositosToolStripMenuItem,
            this.retirosToolStripMenuItem,
            this.cierreDeDiasToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // depositosToolStripMenuItem
            // 
            this.depositosToolStripMenuItem.Name = "depositosToolStripMenuItem";
            this.depositosToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.depositosToolStripMenuItem.Text = "Depositos";
            this.depositosToolStripMenuItem.Click += new System.EventHandler(this.depositosToolStripMenuItem_Click);
            // 
            // retirosToolStripMenuItem
            // 
            this.retirosToolStripMenuItem.Name = "retirosToolStripMenuItem";
            this.retirosToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.retirosToolStripMenuItem.Text = "Retiros";
            // 
            // cierreDeDiasToolStripMenuItem
            // 
            this.cierreDeDiasToolStripMenuItem.Name = "cierreDeDiasToolStripMenuItem";
            this.cierreDeDiasToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cierreDeDiasToolStripMenuItem.Text = "Cierre de Dias";
            this.cierreDeDiasToolStripMenuItem.Click += new System.EventHandler(this.cierreDeDiasToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(98, 0);
            this.tabControl1.MenuRenderer = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(702, 450);
            this.tabControl1.TabCloseButtonImage = null;
            this.tabControl1.TabCloseButtonImageDisabled = null;
            this.tabControl1.TabCloseButtonImageHot = null;
            this.tabControl1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.lblCajaNumero,
            this.lblCajaId});
            this.statusStrip1.Location = new System.Drawing.Point(98, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 31);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(33, 26);
            this.toolStripStatusLabel3.Text = "Caja:";
            // 
            // lblCajaNumero
            // 
            this.lblCajaNumero.Name = "lblCajaNumero";
            this.lblCajaNumero.Size = new System.Drawing.Size(16, 26);
            this.lblCajaNumero.Text = "...";
            // 
            // lblCajaId
            // 
            this.lblCajaId.Name = "lblCajaId";
            this.lblCajaId.Size = new System.Drawing.Size(16, 26);
            this.lblCajaId.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo:";
            // 
            // txtSaldoCaja
            // 
            this.txtSaldoCaja.Enabled = false;
            this.txtSaldoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoCaja.Location = new System.Drawing.Point(618, 425);
            this.txtSaldoCaja.Name = "txtSaldoCaja";
            this.txtSaldoCaja.Size = new System.Drawing.Size(100, 22);
            this.txtSaldoCaja.TabIndex = 5;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSaldoCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnuPrincipal);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private JacksiroKe.MdiTabCtrl.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem mnuListaCajas;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoInicialToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblCajaNumero;
        private System.Windows.Forms.ToolStripStatusLabel lblCajaId;
        private System.Windows.Forms.ToolStripMenuItem cierreDeDiasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSaldoCaja;
    }
}