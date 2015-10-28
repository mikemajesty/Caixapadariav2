using System.Windows.Forms;

namespace View.UI.ViewLogin
{
    partial class frmCadastrarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarLogin));
            this.gpbNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbDadosDoUsuario = new System.Windows.Forms.GroupBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.gpbPermicao = new System.Windows.Forms.GroupBox();
            this.cbbPermissao = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbUltimoAcesso = new System.Windows.Forms.GroupBox();
            this.txtUltimoAcesso = new System.Windows.Forms.TextBox();
            this.ltbDadosDoAcesso = new System.Windows.Forms.ListBox();
            this.gpbNome.SuspendLayout();
            this.gpbDadosDoUsuario.SuspendLayout();
            this.gpbPermicao.SuspendLayout();
            this.gpbUltimoAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNome
            // 
            this.gpbNome.Controls.Add(this.txtNome);
            this.gpbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNome.Location = new System.Drawing.Point(12, 12);
            this.gpbNome.Name = "gpbNome";
            this.gpbNome.Size = new System.Drawing.Size(315, 70);
            this.gpbNome.TabIndex = 6;
            this.gpbNome.TabStop = false;
            this.gpbNome.Text = "Nome do Usuário";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Yellow;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(5, 19);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 35);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // gpbDadosDoUsuario
            // 
            this.gpbDadosDoUsuario.Controls.Add(this.lblLogin);
            this.gpbDadosDoUsuario.Controls.Add(this.lblConfirmarSenha);
            this.gpbDadosDoUsuario.Controls.Add(this.txtConfirmarSenha);
            this.gpbDadosDoUsuario.Controls.Add(this.lblSenha);
            this.gpbDadosDoUsuario.Controls.Add(this.txtSenha);
            this.gpbDadosDoUsuario.Controls.Add(this.txtLogin);
            this.gpbDadosDoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosDoUsuario.Location = new System.Drawing.Point(12, 88);
            this.gpbDadosDoUsuario.Name = "gpbDadosDoUsuario";
            this.gpbDadosDoUsuario.Size = new System.Drawing.Size(315, 151);
            this.gpbDadosDoUsuario.TabIndex = 7;
            this.gpbDadosDoUsuario.TabStop = false;
            this.gpbDadosDoUsuario.Text = "Dados para Login";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(26, 27);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 16);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(3, 115);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(65, 16);
            this.lblConfirmarSenha.TabIndex = 5;
            this.lblConfirmarSenha.Text = "Confirmar";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.Yellow;
            this.txtConfirmarSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(70, 107);
            this.txtConfirmarSenha.MaxLength = 20;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(224, 31);
            this.txtConfirmarSenha.TabIndex = 4;
            this.txtConfirmarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(21, 71);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 16);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Yellow;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(70, 63);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(224, 31);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Yellow;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(70, 19);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(224, 31);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // gpbPermicao
            // 
            this.gpbPermicao.Controls.Add(this.cbbPermissao);
            this.gpbPermicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPermicao.Location = new System.Drawing.Point(12, 245);
            this.gpbPermicao.Name = "gpbPermicao";
            this.gpbPermicao.Size = new System.Drawing.Size(315, 68);
            this.gpbPermicao.TabIndex = 8;
            this.gpbPermicao.TabStop = false;
            this.gpbPermicao.Text = "Permissão do Usuário";
            // 
            // cbbPermissao
            // 
            this.cbbPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPermissao.FormattingEnabled = true;
            this.cbbPermissao.Location = new System.Drawing.Point(24, 21);
            this.cbbPermissao.Name = "cbbPermissao";
            this.cbbPermissao.Size = new System.Drawing.Size(270, 33);
            this.cbbPermissao.TabIndex = 5;
            this.cbbPermissao.SelectedIndexChanged += new System.EventHandler(this.cbbPermissao_SelectedIndexChanged);
            this.cbbPermissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbPermissao_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 322);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(315, 60);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbUltimoAcesso
            // 
            this.gpbUltimoAcesso.Controls.Add(this.txtUltimoAcesso);
            this.gpbUltimoAcesso.Location = new System.Drawing.Point(12, 248);
            this.gpbUltimoAcesso.Name = "gpbUltimoAcesso";
            this.gpbUltimoAcesso.Size = new System.Drawing.Size(315, 68);
            this.gpbUltimoAcesso.TabIndex = 6;
            this.gpbUltimoAcesso.TabStop = false;
            this.gpbUltimoAcesso.Text = "Último acesso do Usuário";
            // 
            // txtUltimoAcesso
            // 
            this.txtUltimoAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoAcesso.Location = new System.Drawing.Point(6, 24);
            this.txtUltimoAcesso.MaxLength = 50;
            this.txtUltimoAcesso.Name = "txtUltimoAcesso";
            this.txtUltimoAcesso.Size = new System.Drawing.Size(303, 35);
            this.txtUltimoAcesso.TabIndex = 1;
            this.txtUltimoAcesso.TabStop = false;
            this.txtUltimoAcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ltbDadosDoAcesso
            // 
            this.ltbDadosDoAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbDadosDoAcesso.BackColor = System.Drawing.Color.White;
            this.ltbDadosDoAcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltbDadosDoAcesso.Enabled = false;
            this.ltbDadosDoAcesso.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbDadosDoAcesso.FormattingEnabled = true;
            this.ltbDadosDoAcesso.ItemHeight = 18;
            this.ltbDadosDoAcesso.Location = new System.Drawing.Point(12, 388);
            this.ltbDadosDoAcesso.Name = "ltbDadosDoAcesso";
            this.ltbDadosDoAcesso.Size = new System.Drawing.Size(315, 74);
            this.ltbDadosDoAcesso.TabIndex = 9;
            this.ltbDadosDoAcesso.TabStop = false;
            // 
            // frmCadastrarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 475);
            this.Controls.Add(this.ltbDadosDoAcesso);
            this.Controls.Add(this.gpbUltimoAcesso);
            this.Controls.Add(this.gpbPermicao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbDadosDoUsuario);
            this.Controls.Add(this.gpbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gpbNome.ResumeLayout(false);
            this.gpbNome.PerformLayout();
            this.gpbDadosDoUsuario.ResumeLayout(false);
            this.gpbDadosDoUsuario.PerformLayout();
            this.gpbPermicao.ResumeLayout(false);
            this.gpbUltimoAcesso.ResumeLayout(false);
            this.gpbUltimoAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbDadosDoUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox gpbPermicao;
        private System.Windows.Forms.ComboBox cbbPermissao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbUltimoAcesso;
        private System.Windows.Forms.TextBox txtUltimoAcesso;
        private System.Windows.Forms.ListBox ltbDadosDoAcesso;
    }
}