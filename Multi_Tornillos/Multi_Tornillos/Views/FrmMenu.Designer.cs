
namespace Multi_Tornillos.Views
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
            this.cierresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new JacksiroKe.MdiTabCtrl.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCajaNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldoCaja = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lblCajaId = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.DarkKhaki;
            this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListaCajas,
            this.usuariosToolStripMenuItem,
            this.saldoInicialToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(98, 471);
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
            this.cierreDeDiasToolStripMenuItem,
            this.cierresToolStripMenuItem});
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
            this.retirosToolStripMenuItem.Click += new System.EventHandler(this.retirosToolStripMenuItem_Click);
            // 
            // cierreDeDiasToolStripMenuItem
            // 
            this.cierreDeDiasToolStripMenuItem.Name = "cierreDeDiasToolStripMenuItem";
            this.cierreDeDiasToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cierreDeDiasToolStripMenuItem.Text = "Cierre de Dias";
            this.cierreDeDiasToolStripMenuItem.Click += new System.EventHandler(this.cierreDeDiasToolStripMenuItem_Click);
            // 
            // cierresToolStripMenuItem
            // 
            this.cierresToolStripMenuItem.Name = "cierresToolStripMenuItem";
            this.cierresToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cierresToolStripMenuItem.Text = "Cierres";
            this.cierresToolStripMenuItem.Click += new System.EventHandler(this.cierresToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MenuRenderer = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(705, 450);
            this.tabControl1.TabCloseButtonImage = null;
            this.tabControl1.TabCloseButtonImageDisabled = null;
            this.tabControl1.TabCloseButtonImageHot = null;
            this.tabControl1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.DarkKhaki;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.lblCajaNumero,
            this.lblCajaId});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel3.Text = "Caja:";
            // 
            // lblCajaNumero
            // 
            this.lblCajaNumero.Name = "lblCajaNumero";
            this.lblCajaNumero.Size = new System.Drawing.Size(16, 17);
            this.lblCajaNumero.Text = "...";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo:";
            // 
            // txtSaldoCaja
            // 
            this.txtSaldoCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoCaja.Enabled = false;
            this.txtSaldoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoCaja.Location = new System.Drawing.Point(680, 449);
            this.txtSaldoCaja.Name = "txtSaldoCaja";
            this.txtSaldoCaja.Size = new System.Drawing.Size(100, 22);
            this.txtSaldoCaja.TabIndex = 5;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.Location = new System.Drawing.Point(522, 448);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(705, 449);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(98, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(705, 471);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // lblCajaId
            // 
            this.lblCajaId.Name = "lblCajaId";
            this.lblCajaId.Size = new System.Drawing.Size(16, 17);
            this.lblCajaId.Text = "...";
            this.lblCajaId.Visible = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaldoCaja);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.mnuPrincipal);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip mnuPrincipal;
        public JacksiroKe.MdiTabCtrl.TabControl tabControl1;
        public System.Windows.Forms.ToolStripMenuItem mnuListaCajas;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saldoInicialToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem depositosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem retirosToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel lblCajaNumero;
        public System.Windows.Forms.ToolStripMenuItem cierreDeDiasToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSaldoCaja;
        public System.Windows.Forms.ToolStripMenuItem cierresToolStripMenuItem;
        public System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        public System.Windows.Forms.ToolStripStatusLabel lblCajaId;
    }
}