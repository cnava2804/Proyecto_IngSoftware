
namespace Multi_Tornillos.Views.Cierres
{
    partial class FrmCierresInsert
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
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblfechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dgDatosFechas = new System.Windows.Forms.DataGridView();
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoCierre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFechaCierres = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCajaNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIdCaja = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusuarioid = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosFechas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(50, 80);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(216, 20);
            this.dtFechaInicial.TabIndex = 0;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Location = new System.Drawing.Point(338, 80);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(216, 20);
            this.dtFechaFinal.TabIndex = 1;
            // 
            // lblfechaInicial
            // 
            this.lblfechaInicial.AutoSize = true;
            this.lblfechaInicial.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaInicial.Location = new System.Drawing.Point(108, 49);
            this.lblfechaInicial.Name = "lblfechaInicial";
            this.lblfechaInicial.Size = new System.Drawing.Size(94, 19);
            this.lblfechaInicial.TabIndex = 2;
            this.lblfechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(406, 49);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(86, 19);
            this.lblFechaFinal.TabIndex = 3;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // dgDatosFechas
            // 
            this.dgDatosFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosFechas.Location = new System.Drawing.Point(34, 150);
            this.dgDatosFechas.Name = "dgDatosFechas";
            this.dgDatosFechas.Size = new System.Drawing.Size(535, 176);
            this.dgDatosFechas.TabIndex = 4;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(261, 332);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(129, 374);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Resultado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de Cierre:";
            // 
            // txtTipoCierre
            // 
            this.txtTipoCierre.Location = new System.Drawing.Point(390, 374);
            this.txtTipoCierre.Name = "txtTipoCierre";
            this.txtTipoCierre.Size = new System.Drawing.Size(164, 20);
            this.txtTipoCierre.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(191, 437);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(338, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFechaCierres
            // 
            this.lblFechaCierres.AutoSize = true;
            this.lblFechaCierres.Location = new System.Drawing.Point(539, 13);
            this.lblFechaCierres.Name = "lblFechaCierres";
            this.lblFechaCierres.Size = new System.Drawing.Size(16, 13);
            this.lblFechaCierres.TabIndex = 12;
            this.lblFechaCierres.Text = "...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(261, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCajaNumero,
            this.lblIdCaja});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
            this.statusStrip1.TabIndex = 58;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "Caja:";
            // 
            // lblCajaNumero
            // 
            this.lblCajaNumero.Name = "lblCajaNumero";
            this.lblCajaNumero.Size = new System.Drawing.Size(16, 17);
            this.lblCajaNumero.Text = "...";
            // 
            // lblIdCaja
            // 
            this.lblIdCaja.Name = "lblIdCaja";
            this.lblIdCaja.Size = new System.Drawing.Size(16, 17);
            this.lblIdCaja.Text = "...";
            // 
            // lblusuarioid
            // 
            this.lblusuarioid.AutoSize = true;
            this.lblusuarioid.Location = new System.Drawing.Point(308, 9);
            this.lblusuarioid.Name = "lblusuarioid";
            this.lblusuarioid.Size = new System.Drawing.Size(16, 13);
            this.lblusuarioid.TabIndex = 60;
            this.lblusuarioid.Text = "...";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(14, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(16, 13);
            this.lblusuario.TabIndex = 59;
            this.lblusuario.Text = "...";
            // 
            // FrmCierresInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 499);
            this.Controls.Add(this.lblusuarioid);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFechaCierres);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTipoCierre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.dgDatosFechas);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblfechaInicial);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.dtFechaInicial);
            this.Name = "FrmCierresInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cierre";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosFechas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label lblfechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DataGridView dgDatosFechas;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoCierre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaCierres;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCajaNumero;
        private System.Windows.Forms.ToolStripStatusLabel lblIdCaja;
        private System.Windows.Forms.Label lblusuarioid;
        private System.Windows.Forms.Label lblusuario;
    }
}