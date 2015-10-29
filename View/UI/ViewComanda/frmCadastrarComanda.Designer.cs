namespace View.UI.ViewComanda
{
    partial class frmCadastrarComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarComanda));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.gpbCodigoDaComanda = new System.Windows.Forms.GroupBox();
            this.gpbCodigoDaComanda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 104);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(274, 50);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtComanda
            // 
            this.txtComanda.BackColor = System.Drawing.Color.Yellow;
            this.txtComanda.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComanda.Location = new System.Drawing.Point(6, 30);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(262, 31);
            this.txtComanda.TabIndex = 1;
            this.txtComanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComanda_KeyPress);
            // 
            // gpbCodigoDaComanda
            // 
            this.gpbCodigoDaComanda.Controls.Add(this.txtComanda);
            this.gpbCodigoDaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodigoDaComanda.Location = new System.Drawing.Point(12, 12);
            this.gpbCodigoDaComanda.Name = "gpbCodigoDaComanda";
            this.gpbCodigoDaComanda.Size = new System.Drawing.Size(274, 86);
            this.gpbCodigoDaComanda.TabIndex = 2;
            this.gpbCodigoDaComanda.TabStop = false;
            this.gpbCodigoDaComanda.Text = "Codigo da comanda";
            // 
            // frmCadastrarComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 170);
            this.Controls.Add(this.gpbCodigoDaComanda);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Comanda";
            this.Load += new System.EventHandler(this.frmCadastrarComanda_Load);
            this.gpbCodigoDaComanda.ResumeLayout(false);
            this.gpbCodigoDaComanda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.GroupBox gpbCodigoDaComanda;
    }
}