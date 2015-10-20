namespace View.UI.ViewCaixa
{
    partial class frmAdicionarCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarCaixa));
            this.gpbTotalNocaixa = new System.Windows.Forms.GroupBox();
            this.lblTotalNoCaixa = new System.Windows.Forms.Label();
            this.gpbAdicionarNoCaixa = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdicionarNoCaixa = new System.Windows.Forms.Button();
            this.txtAdicionarNoCaixa = new System.Windows.Forms.TextBox();
            this.gpbTotalNocaixa.SuspendLayout();
            this.gpbAdicionarNoCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTotalNocaixa
            // 
            this.gpbTotalNocaixa.Controls.Add(this.lblTotalNoCaixa);
            this.gpbTotalNocaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotalNocaixa.Location = new System.Drawing.Point(12, 75);
            this.gpbTotalNocaixa.Name = "gpbTotalNocaixa";
            this.gpbTotalNocaixa.Size = new System.Drawing.Size(210, 71);
            this.gpbTotalNocaixa.TabIndex = 5;
            this.gpbTotalNocaixa.TabStop = false;
            this.gpbTotalNocaixa.Text = "Total  no caixa";
            // 
            // lblTotalNoCaixa
            // 
            this.lblTotalNoCaixa.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalNoCaixa.Location = new System.Drawing.Point(2, 16);
            this.lblTotalNoCaixa.Name = "lblTotalNoCaixa";
            this.lblTotalNoCaixa.Size = new System.Drawing.Size(201, 52);
            this.lblTotalNoCaixa.TabIndex = 0;
            this.lblTotalNoCaixa.Text = "00 R$";
            this.lblTotalNoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbAdicionarNoCaixa
            // 
            this.gpbAdicionarNoCaixa.Controls.Add(this.btnFechar);
            this.gpbAdicionarNoCaixa.Controls.Add(this.btnAdicionarNoCaixa);
            this.gpbAdicionarNoCaixa.Controls.Add(this.txtAdicionarNoCaixa);
            this.gpbAdicionarNoCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAdicionarNoCaixa.Location = new System.Drawing.Point(12, 12);
            this.gpbAdicionarNoCaixa.Name = "gpbAdicionarNoCaixa";
            this.gpbAdicionarNoCaixa.Size = new System.Drawing.Size(210, 62);
            this.gpbAdicionarNoCaixa.TabIndex = 7;
            this.gpbAdicionarNoCaixa.TabStop = false;
            this.gpbAdicionarNoCaixa.Text = "Adionar no Caixa";
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(6, 17);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(197, 36);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "\r\n";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionarNoCaixa
            // 
            this.btnAdicionarNoCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarNoCaixa.Image")));
            this.btnAdicionarNoCaixa.Location = new System.Drawing.Point(165, 18);
            this.btnAdicionarNoCaixa.Name = "btnAdicionarNoCaixa";
            this.btnAdicionarNoCaixa.Size = new System.Drawing.Size(38, 36);
            this.btnAdicionarNoCaixa.TabIndex = 9;
            this.btnAdicionarNoCaixa.Text = "\r\n";
            this.btnAdicionarNoCaixa.UseVisualStyleBackColor = true;
            this.btnAdicionarNoCaixa.Click += new System.EventHandler(this.btnAdicionarNoCaixa_Click);
            // 
            // txtAdicionarNoCaixa
            // 
            this.txtAdicionarNoCaixa.BackColor = System.Drawing.Color.Yellow;
            this.txtAdicionarNoCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionarNoCaixa.Location = new System.Drawing.Point(6, 21);
            this.txtAdicionarNoCaixa.MaxLength = 10;
            this.txtAdicionarNoCaixa.Name = "txtAdicionarNoCaixa";
            this.txtAdicionarNoCaixa.Size = new System.Drawing.Size(153, 31);
            this.txtAdicionarNoCaixa.TabIndex = 5;
            this.txtAdicionarNoCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdicionarNoCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdicionarNoCaixa_KeyPress);
            // 
            // frmAdicionarCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(229, 148);
            this.Controls.Add(this.gpbAdicionarNoCaixa);
            this.Controls.Add(this.gpbTotalNocaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Caixa";
            this.Load += new System.EventHandler(this.frmAdicionarCaixa_Load);
            this.gpbTotalNocaixa.ResumeLayout(false);
            this.gpbAdicionarNoCaixa.ResumeLayout(false);
            this.gpbAdicionarNoCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTotalNocaixa;
        private System.Windows.Forms.Label lblTotalNoCaixa;
        private System.Windows.Forms.GroupBox gpbAdicionarNoCaixa;
        private System.Windows.Forms.Button btnAdicionarNoCaixa;
        private System.Windows.Forms.TextBox txtAdicionarNoCaixa;
        private System.Windows.Forms.Button btnFechar;
    }
}