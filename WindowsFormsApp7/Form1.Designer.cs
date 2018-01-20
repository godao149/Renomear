namespace Renomear
{
    partial class Form1
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtPrefixo = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnRenomear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.lbldesc = new System.Windows.Forms.Label();
            this.rdoDominio = new System.Windows.Forms.RadioButton();
            this.rdoSemDominio = new System.Windows.Forms.RadioButton();
            this.richMensagem = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(12, 199);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(108, 23);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Lista de IPs";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.button_Procurar);
            // 
            // txtPrefixo
            // 
            this.txtPrefixo.Location = new System.Drawing.Point(115, 31);
            this.txtPrefixo.Name = "txtPrefixo";
            this.txtPrefixo.Size = new System.Drawing.Size(75, 22);
            this.txtPrefixo.TabIndex = 1;
            this.txtPrefixo.TextChanged += new System.EventHandler(this.txtPrefixo_TextChanged);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(115, 78);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.ReadOnly = true;
            this.txtQtd.Size = new System.Drawing.Size(75, 22);
            this.txtQtd.TabIndex = 2;
            // 
            // btnRenomear
            // 
            this.btnRenomear.Location = new System.Drawing.Point(427, 199);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Size = new System.Drawing.Size(118, 23);
            this.btnRenomear.TabIndex = 3;
            this.btnRenomear.Text = "Desligar";
            this.btnRenomear.UseVisualStyleBackColor = true;
            this.btnRenomear.Click += new System.EventHandler(this.button_Shutdown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prefixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Configuracoes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.ForestGreen;
            this.progressBar1.Location = new System.Drawing.Point(12, 132);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(724, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Renomear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Renomear);
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(12, 158);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(16, 17);
            this.lbldesc.TabIndex = 9;
            this.lbldesc.Text = "..";
            this.lbldesc.Click += new System.EventHandler(this.lbldesc_Click);
            // 
            // rdoDominio
            // 
            this.rdoDominio.AutoSize = true;
            this.rdoDominio.Location = new System.Drawing.Point(240, 31);
            this.rdoDominio.Name = "rdoDominio";
            this.rdoDominio.Size = new System.Drawing.Size(80, 21);
            this.rdoDominio.TabIndex = 10;
            this.rdoDominio.Text = "Dominio";
            this.rdoDominio.UseVisualStyleBackColor = true;
            // 
            // rdoSemDominio
            // 
            this.rdoSemDominio.AutoSize = true;
            this.rdoSemDominio.Checked = true;
            this.rdoSemDominio.Location = new System.Drawing.Point(240, 79);
            this.rdoSemDominio.Name = "rdoSemDominio";
            this.rdoSemDominio.Size = new System.Drawing.Size(112, 21);
            this.rdoSemDominio.TabIndex = 11;
            this.rdoSemDominio.TabStop = true;
            this.rdoSemDominio.Text = "Sem Dominio";
            this.rdoSemDominio.UseVisualStyleBackColor = true;
            // 
            // richMensagem
            // 
            this.richMensagem.Location = new System.Drawing.Point(358, 30);
            this.richMensagem.Name = "richMensagem";
            this.richMensagem.Size = new System.Drawing.Size(275, 96);
            this.richMensagem.TabIndex = 12;
            this.richMensagem.Text = "Por motivos de manutenção, seu computador sera Desligado/Reinicializado.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Comentario do Desligamento ou Reinicializacao";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Reiniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Reiniciar);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(657, 76);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(79, 22);
            this.txtTempo.TabIndex = 15;
            this.txtTempo.Text = "60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Segundos para desligar";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(693, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Anular Desl.";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Abortar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 253);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richMensagem);
            this.Controls.Add(this.rdoSemDominio);
            this.Controls.Add(this.rdoDominio);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenomear);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtPrefixo);
            this.Controls.Add(this.btnProcurar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPrefixo;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.RadioButton rdoDominio;
        private System.Windows.Forms.RadioButton rdoSemDominio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.RichTextBox richMensagem;
        public System.Windows.Forms.TextBox txtTempo;
    }
}

