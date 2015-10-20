namespace View.UI.ViewKeyGen
{
    partial class frmKeyGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeyGen));
            this.txt_Validacao = new System.Windows.Forms.TextBox();
            this.btn_Ativar = new System.Windows.Forms.Button();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Validacao
            // 
            this.txt_Validacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Validacao.Location = new System.Drawing.Point(9, 43);
            this.txt_Validacao.Name = "txt_Validacao";
            this.txt_Validacao.Size = new System.Drawing.Size(213, 38);
            this.txt_Validacao.TabIndex = 13;
            // 
            // btn_Ativar
            // 
            this.btn_Ativar.Location = new System.Drawing.Point(228, 43);
            this.btn_Ativar.Name = "btn_Ativar";
            this.btn_Ativar.Size = new System.Drawing.Size(75, 37);
            this.btn_Ativar.TabIndex = 12;
            this.btn_Ativar.Text = "Ativar";
            this.btn_Ativar.UseVisualStyleBackColor = true;
            this.btn_Ativar.Click += new System.EventHandler(this.btn_Ativar_Click);
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.Location = new System.Drawing.Point(6, 87);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(299, 16);
            this.lblAdministrador.TabIndex = 10;
            this.lblAdministrador.Text = "Licença expirada, contate o Administrador";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.ForeColor = System.Drawing.Color.Red;
            this.lbl_Numero.Location = new System.Drawing.Point(3, 9);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(302, 31);
            this.lbl_Numero.TabIndex = 11;
            this.lbl_Numero.Text = "*********";
            this.lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmKeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 114);
            this.Controls.Add(this.txt_Validacao);
            this.Controls.Add(this.btn_Ativar);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.lbl_Numero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKeyGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyGen";
            this.Load += new System.EventHandler(this.frmKeyGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Validacao;
        private System.Windows.Forms.Button btn_Ativar;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label lbl_Numero;
    }
}