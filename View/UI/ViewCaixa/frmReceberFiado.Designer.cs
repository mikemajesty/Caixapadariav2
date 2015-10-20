namespace View.UI.ViewCaixa
{
    partial class frmReceberFiado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceberFiado));
            this.gpbTipoDePagamento = new System.Windows.Forms.GroupBox();
            this.cbbTipoDePagamento = new System.Windows.Forms.ComboBox();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.gpbValorPago = new System.Windows.Forms.GroupBox();
            this.ptbValorTotalPago = new System.Windows.Forms.PictureBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.gpbTroco = new System.Windows.Forms.GroupBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.ptbTroco = new System.Windows.Forms.PictureBox();
            this.gpbTipoDePagamento.SuspendLayout();
            this.gpbValorPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbValorTotalPago)).BeginInit();
            this.gpbTotal.SuspendLayout();
            this.gpbTroco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroco)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbTipoDePagamento
            // 
            this.gpbTipoDePagamento.Controls.Add(this.cbbTipoDePagamento);
            this.gpbTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoDePagamento.Location = new System.Drawing.Point(10, 11);
            this.gpbTipoDePagamento.Name = "gpbTipoDePagamento";
            this.gpbTipoDePagamento.Size = new System.Drawing.Size(356, 65);
            this.gpbTipoDePagamento.TabIndex = 9;
            this.gpbTipoDePagamento.TabStop = false;
            this.gpbTipoDePagamento.Text = "Tipo de pagamento";
            // 
            // cbbTipoDePagamento
            // 
            this.cbbTipoDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoDePagamento.FormattingEnabled = true;
            this.cbbTipoDePagamento.Location = new System.Drawing.Point(5, 21);
            this.cbbTipoDePagamento.Name = "cbbTipoDePagamento";
            this.cbbTipoDePagamento.Size = new System.Drawing.Size(345, 39);
            this.cbbTipoDePagamento.TabIndex = 7;
            this.cbbTipoDePagamento.TabStop = false;
            this.cbbTipoDePagamento.SelectedIndexChanged += new System.EventHandler(this.cbbTipoDePagamento_SelectedIndexChanged);
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnConcluirVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnConcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluirVenda.Image")));
            this.btnConcluirVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConcluirVenda.Location = new System.Drawing.Point(10, 164);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(356, 63);
            this.btnConcluirVenda.TabIndex = 10;
            this.btnConcluirVenda.Text = "Concluir Pagamento";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // gpbValorPago
            // 
            this.gpbValorPago.Controls.Add(this.ptbValorTotalPago);
            this.gpbValorPago.Controls.Add(this.txtValorPago);
            this.gpbValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValorPago.Location = new System.Drawing.Point(10, 82);
            this.gpbValorPago.Name = "gpbValorPago";
            this.gpbValorPago.Size = new System.Drawing.Size(168, 72);
            this.gpbValorPago.TabIndex = 7;
            this.gpbValorPago.TabStop = false;
            this.gpbValorPago.Text = "Valor pago pelo cliente";
            // 
            // ptbValorTotalPago
            // 
            this.ptbValorTotalPago.Image = ((System.Drawing.Image)(resources.GetObject("ptbValorTotalPago.Image")));
            this.ptbValorTotalPago.Location = new System.Drawing.Point(5, 21);
            this.ptbValorTotalPago.Name = "ptbValorTotalPago";
            this.ptbValorTotalPago.Size = new System.Drawing.Size(31, 38);
            this.ptbValorTotalPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbValorTotalPago.TabIndex = 13;
            this.ptbValorTotalPago.TabStop = false;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(41, 21);
            this.txtValorPago.MaxLength = 7;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(110, 38);
            this.txtValorPago.TabIndex = 4;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // gpbTotal
            // 
            this.gpbTotal.BackColor = System.Drawing.Color.White;
            this.gpbTotal.Controls.Add(this.lblTotalVenda);
            this.gpbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotal.Location = new System.Drawing.Point(372, 12);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(186, 219);
            this.gpbTotal.TabIndex = 11;
            this.gpbTotal.TabStop = false;
            this.gpbTotal.Text = "Total da dívida";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalVenda.Location = new System.Drawing.Point(6, 18);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(185, 197);
            this.lblTotalVenda.TabIndex = 1;
            this.lblTotalVenda.Text = "00 R$";
            this.lblTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbTroco
            // 
            this.gpbTroco.Controls.Add(this.ptbTroco);
            this.gpbTroco.Controls.Add(this.txtTroco);
            this.gpbTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTroco.Location = new System.Drawing.Point(184, 82);
            this.gpbTroco.Name = "gpbTroco";
            this.gpbTroco.Size = new System.Drawing.Size(182, 72);
            this.gpbTroco.TabIndex = 12;
            this.gpbTroco.TabStop = false;
            this.gpbTroco.Text = "Troco";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.Yellow;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(6, 21);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(129, 38);
            this.txtTroco.TabIndex = 0;
            // 
            // ptbTroco
            // 
            this.ptbTroco.Image = ((System.Drawing.Image)(resources.GetObject("ptbTroco.Image")));
            this.ptbTroco.Location = new System.Drawing.Point(141, 21);
            this.ptbTroco.Name = "ptbTroco";
            this.ptbTroco.Size = new System.Drawing.Size(35, 38);
            this.ptbTroco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTroco.TabIndex = 1;
            this.ptbTroco.TabStop = false;
            // 
            // frmReceberFiado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 239);
            this.Controls.Add(this.gpbTroco);
            this.Controls.Add(this.gpbTotal);
            this.Controls.Add(this.gpbTipoDePagamento);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.gpbValorPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceberFiado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber dinheiro creditado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReceberFiado_FormClosing);
            this.Load += new System.EventHandler(this.frmReceberFiado_Load);
            this.gpbTipoDePagamento.ResumeLayout(false);
            this.gpbValorPago.ResumeLayout(false);
            this.gpbValorPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbValorTotalPago)).EndInit();
            this.gpbTotal.ResumeLayout(false);
            this.gpbTroco.ResumeLayout(false);
            this.gpbTroco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTipoDePagamento;
        private System.Windows.Forms.ComboBox cbbTipoDePagamento;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.GroupBox gpbValorPago;
        private System.Windows.Forms.PictureBox ptbValorTotalPago;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.GroupBox gpbTroco;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.PictureBox ptbTroco;
    }
}