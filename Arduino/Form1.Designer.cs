namespace Arduino
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtReceber = new System.Windows.Forms.TextBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.cmbPortas = new System.Windows.Forms.ComboBox();
            this.tmrPortas = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 12);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(100, 28);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "&Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 57);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 26);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "&Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtReceber
            // 
            this.txtReceber.Location = new System.Drawing.Point(12, 100);
            this.txtReceber.Multiline = true;
            this.txtReceber.Name = "txtReceber";
            this.txtReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceber.Size = new System.Drawing.Size(765, 338);
            this.txtReceber.TabIndex = 3;
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(132, 57);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(558, 26);
            this.txtEnviar.TabIndex = 4;
            // 
            // cmbPortas
            // 
            this.cmbPortas.FormattingEnabled = true;
            this.cmbPortas.Location = new System.Drawing.Point(132, 12);
            this.cmbPortas.Name = "cmbPortas";
            this.cmbPortas.Size = new System.Drawing.Size(215, 28);
            this.cmbPortas.TabIndex = 5;
            // 
            // tmrPortas
            // 
            this.tmrPortas.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPortas);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.txtReceber);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEnviar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtReceber;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.ComboBox cmbPortas;
        private System.Windows.Forms.Timer tmrPortas;
    }
}

