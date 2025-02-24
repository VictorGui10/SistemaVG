namespace SistemaVG.Relatorios
{
    partial class Relusuarios
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
            this.components = new System.ComponentModel.Container();
            this.fmrcadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fmrcadastroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fmrcadastroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmrcadastroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // fmrcadastroBindingSource
            // 
            this.fmrcadastroBindingSource.DataSource = typeof(SistemaVG.Fmrcadastro);
            // 
            // fmrcadastroBindingSource1
            // 
            this.fmrcadastroBindingSource1.DataSource = typeof(SistemaVG.Fmrcadastro);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(39, 29);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(1299, 695);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // Relusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 736);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "Relusuarios";
            this.Text = "Relusuarios";
            this.Load += new System.EventHandler(this.Relusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fmrcadastroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmrcadastroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fmrcadastroBindingSource;
        private System.Windows.Forms.BindingSource fmrcadastroBindingSource1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}