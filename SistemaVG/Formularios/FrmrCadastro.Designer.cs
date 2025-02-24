namespace SistemaVG
{
    partial class Fmrcadastro
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelsenha = new System.Windows.Forms.Label();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labeldtnasc = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.Label_nome = new System.Windows.Forms.Label();
            this.labelcpf = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.txbdatanasc = new System.Windows.Forms.TextBox();
            this.txbcpf = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(12, 3);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(81, 32);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelsenha);
            this.groupBox1.Controls.Add(this.labelusuario);
            this.groupBox1.Controls.Add(this.labeldtnasc);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.Label_nome);
            this.groupBox1.Controls.Add(this.labelcpf);
            this.groupBox1.Controls.Add(this.btnlimpar);
            this.groupBox1.Controls.Add(this.btnsalvar);
            this.groupBox1.Controls.Add(this.txbsenha);
            this.groupBox1.Controls.Add(this.txbusuario);
            this.groupBox1.Controls.Add(this.txbdatanasc);
            this.groupBox1.Controls.Add(this.txbcpf);
            this.groupBox1.Controls.Add(this.txbemail);
            this.groupBox1.Controls.Add(this.txbnome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 406);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Location = new System.Drawing.Point(305, 276);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(54, 16);
            this.labelsenha.TabIndex = 20;
            this.labelsenha.Text = "SENHA";
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Location = new System.Drawing.Point(305, 226);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(68, 16);
            this.labelusuario.TabIndex = 19;
            this.labelusuario.Text = "USUARIO";
            // 
            // labeldtnasc
            // 
            this.labeldtnasc.AutoSize = true;
            this.labeldtnasc.Location = new System.Drawing.Point(305, 172);
            this.labeldtnasc.Name = "labeldtnasc";
            this.labeldtnasc.Size = new System.Drawing.Size(136, 16);
            this.labeldtnasc.TabIndex = 18;
            this.labeldtnasc.Text = "DATA NASCIMENTO";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(305, 121);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(46, 16);
            this.label_email.TabIndex = 17;
            this.label_email.Text = "EMAIL";
            // 
            // Label_nome
            // 
            this.Label_nome.AutoSize = true;
            this.Label_nome.Location = new System.Drawing.Point(305, 18);
            this.Label_nome.Name = "Label_nome";
            this.Label_nome.Size = new System.Drawing.Size(124, 16);
            this.Label_nome.TabIndex = 16;
            this.Label_nome.Text = "NOME COMPLETO";
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Location = new System.Drawing.Point(305, 70);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(33, 16);
            this.labelcpf.TabIndex = 15;
            this.labelcpf.Text = "CPF";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpar.Location = new System.Drawing.Point(276, 344);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(85, 33);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(401, 344);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(89, 33);
            this.btnsalvar.TabIndex = 8;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(308, 292);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(156, 22);
            this.txbsenha.TabIndex = 6;
            this.txbsenha.UseSystemPasswordChar = true;
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(308, 242);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(156, 22);
            this.txbusuario.TabIndex = 5;
            // 
            // txbdatanasc
            // 
            this.txbdatanasc.Location = new System.Drawing.Point(308, 188);
            this.txbdatanasc.Name = "txbdatanasc";
            this.txbdatanasc.Size = new System.Drawing.Size(156, 22);
            this.txbdatanasc.TabIndex = 4;
            // 
            // txbcpf
            // 
            this.txbcpf.Location = new System.Drawing.Point(308, 86);
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(156, 22);
            this.txbcpf.TabIndex = 2;
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(308, 137);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(156, 22);
            this.txbemail.TabIndex = 3;
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(308, 34);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(156, 22);
            this.txbnome.TabIndex = 1;
            // 
            // Fmrcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fmrcadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fmrcadastro_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label labeldtnasc;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label Label_nome;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.TextBox txbdatanasc;
        private System.Windows.Forms.TextBox txbcpf;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbnome;
    }
}

