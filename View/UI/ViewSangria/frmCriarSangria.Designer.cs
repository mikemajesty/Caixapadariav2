namespace View.UI.ViewSangria
{
    partial class frmCriarSangria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarSangria));
            this.txtValorSangria = new System.Windows.Forms.TextBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gpbDescricao = new System.Windows.Forms.GroupBox();
            this.gpbValores = new System.Windows.Forms.GroupBox();
            this.lblValorCaixa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbDescricao.SuspendLayout();
            this.gpbValores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorSangria
            // 
            this.txtValorSangria.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSangria.Location = new System.Drawing.Point(17, 43);
            this.txtValorSangria.MaxLength = 10;
            this.txtValorSangria.Name = "txtValorSangria";
            this.txtValorSangria.Size = new System.Drawing.Size(137, 35);
            this.txtValorSangria.TabIndex = 1;
            this.txtValorSangria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorSangria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorSangria_KeyPress);
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.LightCoral;
            this.btnRetirar.Image = ((System.Drawing.Image)(resources.GetObject("btnRetirar.Image")));
            this.btnRetirar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetirar.Location = new System.Drawing.Point(14, 286);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(367, 42);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDescricao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(17, 24);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(334, 126);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // gpbDescricao
            // 
            this.gpbDescricao.Controls.Add(this.txtDescricao);
            this.gpbDescricao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.gpbDescricao.Location = new System.Drawing.Point(14, 116);
            this.gpbDescricao.Name = "gpbDescricao";
            this.gpbDescricao.Size = new System.Drawing.Size(367, 164);
            this.gpbDescricao.TabIndex = 2;
            this.gpbDescricao.TabStop = false;
            this.gpbDescricao.Text = "Descrição";
            // 
            // gpbValores
            // 
            this.gpbValores.Controls.Add(this.txtValorSangria);
            this.gpbValores.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.gpbValores.Location = new System.Drawing.Point(14, 10);
            this.gpbValores.Name = "gpbValores";
            this.gpbValores.Size = new System.Drawing.Size(168, 100);
            this.gpbValores.TabIndex = 5;
            this.gpbValores.TabStop = false;
            this.gpbValores.Text = "Sangria";
            // 
            // lblValorCaixa
            // 
            this.lblValorCaixa.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCaixa.Location = new System.Drawing.Point(6, 22);
            this.lblValorCaixa.Name = "lblValorCaixa";
            this.lblValorCaixa.Size = new System.Drawing.Size(181, 67);
            this.lblValorCaixa.TabIndex = 6;
            this.lblValorCaixa.Text = "Caixa";
            this.lblValorCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValorCaixa);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor no Caixa";
            // 
            // frmCriarSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbValores);
            this.Controls.Add(this.gpbDescricao);
            this.Controls.Add(this.btnRetirar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCriarSangria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangria";
            this.Load += new System.EventHandler(this.frmSangria_Load);
            this.gpbDescricao.ResumeLayout(false);
            this.gpbDescricao.PerformLayout();
            this.gpbValores.ResumeLayout(false);
            this.gpbValores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorSangria;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gpbDescricao;
        private System.Windows.Forms.GroupBox gpbValores;
        private System.Windows.Forms.Label lblValorCaixa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}