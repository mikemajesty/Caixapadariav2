namespace View.UI.ViewCaixa
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.gpbCodigoDaComanda = new System.Windows.Forms.GroupBox();
            this.lblF1 = new System.Windows.Forms.Label();
            this.ptbCodigo = new System.Windows.Forms.PictureBox();
            this.txtCodigoDaComanda = new System.Windows.Forms.TextBox();
            this.gpbCodigoDoProduto = new System.Windows.Forms.GroupBox();
            this.lblF4 = new System.Windows.Forms.Label();
            this.ptbCodigoDoProduto = new System.Windows.Forms.PictureBox();
            this.txtCodigoDoProduto = new System.Windows.Forms.TextBox();
            this.gpbValorPago = new System.Windows.Forms.GroupBox();
            this.lblF6 = new System.Windows.Forms.Label();
            this.ptbValorTotalPago = new System.Windows.Forms.PictureBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.gpbGerarTroco = new System.Windows.Forms.GroupBox();
            this.ptbTroco = new System.Windows.Forms.PictureBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.gpbTotalNocaixa = new System.Windows.Forms.GroupBox();
            this.lblTotalNoCaixa = new System.Windows.Forms.Label();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.gpbQuantidadeDoProduto = new System.Windows.Forms.GroupBox();
            this.lblF3 = new System.Windows.Forms.Label();
            this.ptbQuantidade = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.gpbTipoDePagamento = new System.Windows.Forms.GroupBox();
            this.lblF5 = new System.Windows.Forms.Label();
            this.cbbTipoDePagamento = new System.Windows.Forms.ComboBox();
            this.gpbValorPorPeso = new System.Windows.Forms.GroupBox();
            this.ptbKilograma = new System.Windows.Forms.PictureBox();
            this.txtPesoDoProduto = new System.Windows.Forms.TextBox();
            this.ckbPorPeso = new System.Windows.Forms.CheckBox();
            this.ltvProdutos = new System.Windows.Forms.ListView();
            this.MenuCaixa = new System.Windows.Forms.MenuStrip();
            this.btnOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReceberCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDividirComanda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrirCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFecharCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimparVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSairDoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSangria = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbCodigoDaComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigo)).BeginInit();
            this.gpbCodigoDoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigoDoProduto)).BeginInit();
            this.gpbValorPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbValorTotalPago)).BeginInit();
            this.gpbGerarTroco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroco)).BeginInit();
            this.gpbTotal.SuspendLayout();
            this.gpbTotalNocaixa.SuspendLayout();
            this.gpbQuantidadeDoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuantidade)).BeginInit();
            this.gpbTipoDePagamento.SuspendLayout();
            this.gpbValorPorPeso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKilograma)).BeginInit();
            this.MenuCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCodigoDaComanda
            // 
            this.gpbCodigoDaComanda.Controls.Add(this.lblF1);
            this.gpbCodigoDaComanda.Controls.Add(this.ptbCodigo);
            this.gpbCodigoDaComanda.Controls.Add(this.txtCodigoDaComanda);
            this.gpbCodigoDaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodigoDaComanda.Location = new System.Drawing.Point(8, 38);
            this.gpbCodigoDaComanda.Name = "gpbCodigoDaComanda";
            this.gpbCodigoDaComanda.Size = new System.Drawing.Size(441, 78);
            this.gpbCodigoDaComanda.TabIndex = 1;
            this.gpbCodigoDaComanda.TabStop = false;
            this.gpbCodigoDaComanda.Text = "Código da comanda";
            // 
            // lblF1
            // 
            this.lblF1.Location = new System.Drawing.Point(401, 32);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(37, 38);
            this.lblF1.TabIndex = 14;
            this.lblF1.Text = "[F1]";
            this.lblF1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbCodigo
            // 
            this.ptbCodigo.Image = ((System.Drawing.Image)(resources.GetObject("ptbCodigo.Image")));
            this.ptbCodigo.Location = new System.Drawing.Point(4, 34);
            this.ptbCodigo.Name = "ptbCodigo";
            this.ptbCodigo.Size = new System.Drawing.Size(31, 38);
            this.ptbCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCodigo.TabIndex = 13;
            this.ptbCodigo.TabStop = false;
            // 
            // txtCodigoDaComanda
            // 
            this.txtCodigoDaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDaComanda.Location = new System.Drawing.Point(40, 34);
            this.txtCodigoDaComanda.MaxLength = 20;
            this.txtCodigoDaComanda.Name = "txtCodigoDaComanda";
            this.txtCodigoDaComanda.Size = new System.Drawing.Size(360, 38);
            this.txtCodigoDaComanda.TabIndex = 1;
            this.txtCodigoDaComanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtCodigoDaComanda, "Digite o código de barra da comanda\r\n");
            this.txtCodigoDaComanda.DoubleClick += new System.EventHandler(this.txtCodigoDaComanda_DoubleClick);
            this.txtCodigoDaComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDaComanda_KeyPress);
            // 
            // gpbCodigoDoProduto
            // 
            this.gpbCodigoDoProduto.Controls.Add(this.lblF4);
            this.gpbCodigoDoProduto.Controls.Add(this.ptbCodigoDoProduto);
            this.gpbCodigoDoProduto.Controls.Add(this.txtCodigoDoProduto);
            this.gpbCodigoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodigoDoProduto.Location = new System.Drawing.Point(158, 200);
            this.gpbCodigoDoProduto.Name = "gpbCodigoDoProduto";
            this.gpbCodigoDoProduto.Size = new System.Drawing.Size(291, 78);
            this.gpbCodigoDoProduto.TabIndex = 3;
            this.gpbCodigoDoProduto.TabStop = false;
            this.gpbCodigoDoProduto.Text = "Código do produto";
            // 
            // lblF4
            // 
            this.lblF4.Location = new System.Drawing.Point(251, 31);
            this.lblF4.Name = "lblF4";
            this.lblF4.Size = new System.Drawing.Size(37, 38);
            this.lblF4.TabIndex = 14;
            this.lblF4.Text = "[F4]";
            this.lblF4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbCodigoDoProduto
            // 
            this.ptbCodigoDoProduto.Image = ((System.Drawing.Image)(resources.GetObject("ptbCodigoDoProduto.Image")));
            this.ptbCodigoDoProduto.Location = new System.Drawing.Point(6, 33);
            this.ptbCodigoDoProduto.Name = "ptbCodigoDoProduto";
            this.ptbCodigoDoProduto.Size = new System.Drawing.Size(43, 38);
            this.ptbCodigoDoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCodigoDoProduto.TabIndex = 13;
            this.ptbCodigoDoProduto.TabStop = false;
            // 
            // txtCodigoDoProduto
            // 
            this.txtCodigoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDoProduto.Location = new System.Drawing.Point(50, 33);
            this.txtCodigoDoProduto.MaxLength = 20;
            this.txtCodigoDoProduto.Name = "txtCodigoDoProduto";
            this.txtCodigoDoProduto.Size = new System.Drawing.Size(200, 38);
            this.txtCodigoDoProduto.TabIndex = 3;
            this.txtCodigoDoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtCodigoDoProduto, "Digite o código de barra do produto");
            this.txtCodigoDoProduto.TextChanged += new System.EventHandler(this.txtCodigoDoProduto_TextChanged);
            this.txtCodigoDoProduto.DoubleClick += new System.EventHandler(this.txtCodigoDoProduto_DoubleClick);
            this.txtCodigoDoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDoProduto_KeyPress);
            // 
            // gpbValorPago
            // 
            this.gpbValorPago.Controls.Add(this.lblF6);
            this.gpbValorPago.Controls.Add(this.ptbValorTotalPago);
            this.gpbValorPago.Controls.Add(this.txtValorPago);
            this.gpbValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValorPago.Location = new System.Drawing.Point(8, 355);
            this.gpbValorPago.Name = "gpbValorPago";
            this.gpbValorPago.Size = new System.Drawing.Size(230, 72);
            this.gpbValorPago.TabIndex = 4;
            this.gpbValorPago.TabStop = false;
            this.gpbValorPago.Text = "Valor pago pelo cliente";
            // 
            // lblF6
            // 
            this.lblF6.Location = new System.Drawing.Point(189, 27);
            this.lblF6.Name = "lblF6";
            this.lblF6.Size = new System.Drawing.Size(37, 38);
            this.lblF6.TabIndex = 14;
            this.lblF6.Text = "[F6]";
            this.lblF6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbValorTotalPago
            // 
            this.ptbValorTotalPago.Image = ((System.Drawing.Image)(resources.GetObject("ptbValorTotalPago.Image")));
            this.ptbValorTotalPago.Location = new System.Drawing.Point(5, 27);
            this.ptbValorTotalPago.Name = "ptbValorTotalPago";
            this.ptbValorTotalPago.Size = new System.Drawing.Size(31, 38);
            this.ptbValorTotalPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbValorTotalPago.TabIndex = 13;
            this.ptbValorTotalPago.TabStop = false;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(41, 27);
            this.txtValorPago.MaxLength = 7;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(146, 38);
            this.txtValorPago.TabIndex = 4;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtValorPago, "Digite o Valor pago pelo cliente");
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // gpbGerarTroco
            // 
            this.gpbGerarTroco.Controls.Add(this.ptbTroco);
            this.gpbGerarTroco.Controls.Add(this.txtTroco);
            this.gpbGerarTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGerarTroco.Location = new System.Drawing.Point(244, 355);
            this.gpbGerarTroco.Name = "gpbGerarTroco";
            this.gpbGerarTroco.Size = new System.Drawing.Size(204, 72);
            this.gpbGerarTroco.TabIndex = 5;
            this.gpbGerarTroco.TabStop = false;
            this.gpbGerarTroco.Text = "Troco";
            // 
            // ptbTroco
            // 
            this.ptbTroco.Image = ((System.Drawing.Image)(resources.GetObject("ptbTroco.Image")));
            this.ptbTroco.Location = new System.Drawing.Point(6, 28);
            this.ptbTroco.Name = "ptbTroco";
            this.ptbTroco.Size = new System.Drawing.Size(31, 38);
            this.ptbTroco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTroco.TabIndex = 13;
            this.ptbTroco.TabStop = false;
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.Yellow;
            this.txtTroco.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.Black;
            this.txtTroco.Location = new System.Drawing.Point(43, 28);
            this.txtTroco.MaxLength = 20;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(155, 39);
            this.txtTroco.TabIndex = 0;
            this.txtTroco.TabStop = false;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtTroco, "Valor do troco para cliente");
            // 
            // gpbTotal
            // 
            this.gpbTotal.BackColor = System.Drawing.Color.White;
            this.gpbTotal.Controls.Add(this.lblTotalVenda);
            this.gpbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotal.Location = new System.Drawing.Point(454, 427);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(416, 71);
            this.gpbTotal.TabIndex = 4;
            this.gpbTotal.TabStop = false;
            this.gpbTotal.Text = "Total da venda";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalVenda.Location = new System.Drawing.Point(5, 16);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(404, 49);
            this.lblTotalVenda.TabIndex = 1;
            this.lblTotalVenda.Text = "00 R$";
            this.lblTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlp.SetToolTip(this.lblTotalVenda, "Valor total da venda");
            // 
            // gpbTotalNocaixa
            // 
            this.gpbTotalNocaixa.Controls.Add(this.lblTotalNoCaixa);
            this.gpbTotalNocaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotalNocaixa.Location = new System.Drawing.Point(8, 427);
            this.gpbTotalNocaixa.Name = "gpbTotalNocaixa";
            this.gpbTotalNocaixa.Size = new System.Drawing.Size(230, 71);
            this.gpbTotalNocaixa.TabIndex = 4;
            this.gpbTotalNocaixa.TabStop = false;
            this.gpbTotalNocaixa.Text = "Total  no caixa";
            // 
            // lblTotalNoCaixa
            // 
            this.lblTotalNoCaixa.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalNoCaixa.Location = new System.Drawing.Point(2, 16);
            this.lblTotalNoCaixa.Name = "lblTotalNoCaixa";
            this.lblTotalNoCaixa.Size = new System.Drawing.Size(219, 52);
            this.lblTotalNoCaixa.TabIndex = 0;
            this.lblTotalNoCaixa.Text = "00 R$";
            this.lblTotalNoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlp.SetToolTip(this.lblTotalNoCaixa, "Valor total no Caixa");
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.BackColor = System.Drawing.Color.LightGray;
            this.btnConcluirVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnConcluirVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnConcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluirVenda.Image")));
            this.btnConcluirVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConcluirVenda.Location = new System.Drawing.Point(243, 435);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(204, 63);
            this.btnConcluirVenda.TabIndex = 6;
            this.btnConcluirVenda.Text = "\r\nConcluir Venda\r\n  [F12]";
            this.tlp.SetToolTip(this.btnConcluirVenda, "\r\n\r\n");
            this.btnConcluirVenda.UseVisualStyleBackColor = false;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // gpbQuantidadeDoProduto
            // 
            this.gpbQuantidadeDoProduto.Controls.Add(this.lblF3);
            this.gpbQuantidadeDoProduto.Controls.Add(this.ptbQuantidade);
            this.gpbQuantidadeDoProduto.Controls.Add(this.txtQuantidade);
            this.gpbQuantidadeDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbQuantidadeDoProduto.Location = new System.Drawing.Point(8, 200);
            this.gpbQuantidadeDoProduto.Name = "gpbQuantidadeDoProduto";
            this.gpbQuantidadeDoProduto.Size = new System.Drawing.Size(144, 78);
            this.gpbQuantidadeDoProduto.TabIndex = 2;
            this.gpbQuantidadeDoProduto.TabStop = false;
            this.gpbQuantidadeDoProduto.Text = "Quantidade";
            // 
            // lblF3
            // 
            this.lblF3.Location = new System.Drawing.Point(100, 31);
            this.lblF3.Name = "lblF3";
            this.lblF3.Size = new System.Drawing.Size(37, 38);
            this.lblF3.TabIndex = 14;
            this.lblF3.Text = "[F3]";
            this.lblF3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbQuantidade
            // 
            this.ptbQuantidade.Image = ((System.Drawing.Image)(resources.GetObject("ptbQuantidade.Image")));
            this.ptbQuantidade.Location = new System.Drawing.Point(6, 34);
            this.ptbQuantidade.Name = "ptbQuantidade";
            this.ptbQuantidade.Size = new System.Drawing.Size(24, 38);
            this.ptbQuantidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbQuantidade.TabIndex = 13;
            this.ptbQuantidade.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(32, 34);
            this.txtQuantidade.MaxLength = 3;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(62, 38);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtQuantidade, "Digite a quantidade do produto vendido");
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // gpbTipoDePagamento
            // 
            this.gpbTipoDePagamento.Controls.Add(this.lblF5);
            this.gpbTipoDePagamento.Controls.Add(this.cbbTipoDePagamento);
            this.gpbTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoDePagamento.Location = new System.Drawing.Point(8, 280);
            this.gpbTipoDePagamento.Name = "gpbTipoDePagamento";
            this.gpbTipoDePagamento.Size = new System.Drawing.Size(441, 74);
            this.gpbTipoDePagamento.TabIndex = 6;
            this.gpbTipoDePagamento.TabStop = false;
            this.gpbTipoDePagamento.Text = "Tipo de pagamento";
            // 
            // lblF5
            // 
            this.lblF5.Location = new System.Drawing.Point(401, 30);
            this.lblF5.Name = "lblF5";
            this.lblF5.Size = new System.Drawing.Size(37, 38);
            this.lblF5.TabIndex = 14;
            this.lblF5.Text = "[F5]";
            this.lblF5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbTipoDePagamento
            // 
            this.cbbTipoDePagamento.BackColor = System.Drawing.Color.LightGray;
            this.cbbTipoDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoDePagamento.FormattingEnabled = true;
            this.cbbTipoDePagamento.Location = new System.Drawing.Point(6, 30);
            this.cbbTipoDePagamento.Name = "cbbTipoDePagamento";
            this.cbbTipoDePagamento.Size = new System.Drawing.Size(394, 39);
            this.cbbTipoDePagamento.TabIndex = 7;
            this.cbbTipoDePagamento.TabStop = false;
            this.tlp.SetToolTip(this.cbbTipoDePagamento, "Escolha a forma de pagamento\r\n");
            this.cbbTipoDePagamento.SelectedIndexChanged += new System.EventHandler(this.cbbTipoDePagamento_SelectedIndexChanged);
            this.cbbTipoDePagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbTipoDePagamento_KeyPress);
            // 
            // gpbValorPorPeso
            // 
            this.gpbValorPorPeso.Controls.Add(this.ptbKilograma);
            this.gpbValorPorPeso.Controls.Add(this.txtPesoDoProduto);
            this.gpbValorPorPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValorPorPeso.Location = new System.Drawing.Point(158, 122);
            this.gpbValorPorPeso.Name = "gpbValorPorPeso";
            this.gpbValorPorPeso.Size = new System.Drawing.Size(291, 78);
            this.gpbValorPorPeso.TabIndex = 3;
            this.gpbValorPorPeso.TabStop = false;
            this.gpbValorPorPeso.Text = "Peso do produto";
            // 
            // ptbKilograma
            // 
            this.ptbKilograma.Image = ((System.Drawing.Image)(resources.GetObject("ptbKilograma.Image")));
            this.ptbKilograma.Location = new System.Drawing.Point(227, 33);
            this.ptbKilograma.Name = "ptbKilograma";
            this.ptbKilograma.Size = new System.Drawing.Size(55, 38);
            this.ptbKilograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbKilograma.TabIndex = 14;
            this.ptbKilograma.TabStop = false;
            // 
            // txtPesoDoProduto
            // 
            this.txtPesoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoDoProduto.Location = new System.Drawing.Point(5, 33);
            this.txtPesoDoProduto.MaxLength = 6;
            this.txtPesoDoProduto.Name = "txtPesoDoProduto";
            this.txtPesoDoProduto.Size = new System.Drawing.Size(218, 38);
            this.txtPesoDoProduto.TabIndex = 3;
            this.txtPesoDoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlp.SetToolTip(this.txtPesoDoProduto, "Digite o valor do produto");
            this.txtPesoDoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDoProdutoPorpeso_KeyPress);
            // 
            // ckbPorPeso
            // 
            this.ckbPorPeso.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbPorPeso.BackColor = System.Drawing.Color.LightGray;
            this.ckbPorPeso.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPorPeso.Image = ((System.Drawing.Image)(resources.GetObject("ckbPorPeso.Image")));
            this.ckbPorPeso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbPorPeso.Location = new System.Drawing.Point(8, 128);
            this.ckbPorPeso.Name = "ckbPorPeso";
            this.ckbPorPeso.Size = new System.Drawing.Size(144, 72);
            this.ckbPorPeso.TabIndex = 12;
            this.ckbPorPeso.TabStop = false;
            this.ckbPorPeso.Text = "Peso [F2]";
            this.tlp.SetToolTip(this.ckbPorPeso, "Digitar o preço manualmente para produtos não vendidos por unidade");
            this.ckbPorPeso.UseVisualStyleBackColor = false;
            this.ckbPorPeso.CheckedChanged += new System.EventHandler(this.ckbPorPeso_CheckedChanged);
            // 
            // ltvProdutos
            // 
            this.ltvProdutos.BackColor = System.Drawing.Color.White;
            this.ltvProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvProdutos.FullRowSelect = true;
            this.ltvProdutos.GridLines = true;
            this.ltvProdutos.Location = new System.Drawing.Point(455, 49);
            this.ltvProdutos.MultiSelect = false;
            this.ltvProdutos.Name = "ltvProdutos";
            this.ltvProdutos.Size = new System.Drawing.Size(416, 378);
            this.ltvProdutos.TabIndex = 8;
            this.ltvProdutos.TabStop = false;
            this.tlp.SetToolTip(this.ltvProdutos, "Detalhes dos produtos vendidos");
            this.ltvProdutos.UseCompatibleStateImageBehavior = false;
            this.ltvProdutos.View = System.Windows.Forms.View.Details;
            this.ltvProdutos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ltvProdutos_ColumnWidthChanging);
            this.ltvProdutos.Click += new System.EventHandler(this.ltvProdutos_Click);
            this.ltvProdutos.DoubleClick += new System.EventHandler(this.ltvProdutos_DoubleClick);
            // 
            // MenuCaixa
            // 
            this.MenuCaixa.AllowMerge = false;
            this.MenuCaixa.AutoSize = false;
            this.MenuCaixa.BackColor = System.Drawing.Color.White;
            this.MenuCaixa.GripMargin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.MenuCaixa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOperacoes,
            this.btnCalculadora});
            this.MenuCaixa.Location = new System.Drawing.Point(0, 0);
            this.MenuCaixa.Name = "MenuCaixa";
            this.MenuCaixa.Size = new System.Drawing.Size(882, 35);
            this.MenuCaixa.TabIndex = 14;
            this.MenuCaixa.TabStop = true;
            this.MenuCaixa.Text = "Menu";
            // 
            // btnOperacoes
            // 
            this.btnOperacoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOperacoes.BackColor = System.Drawing.Color.LightGray;
            this.btnOperacoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOperacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReceberCredito,
            this.btnDividirComanda,
            this.btnAbrirCaixa,
            this.btnSangria,
            this.btnFecharCaixa,
            this.btnLimparVenda,
            this.btnSairDoMenu});
            this.btnOperacoes.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacoes.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnOperacoes.Name = "btnOperacoes";
            this.btnOperacoes.Size = new System.Drawing.Size(186, 31);
            this.btnOperacoes.Text = "Operações extras  [F8]";
            this.btnOperacoes.ToolTipText = "Operações extras\r\n";
            // 
            // btnReceberCredito
            // 
            this.btnReceberCredito.Name = "btnReceberCredito";
            this.btnReceberCredito.Size = new System.Drawing.Size(229, 22);
            this.btnReceberCredito.Text = "Receber Credito";
            this.btnReceberCredito.Click += new System.EventHandler(this.btnReceberCredito_Click);
            // 
            // btnDividirComanda
            // 
            this.btnDividirComanda.Name = "btnDividirComanda";
            this.btnDividirComanda.Size = new System.Drawing.Size(229, 22);
            this.btnDividirComanda.Text = "Dividir a Comanda";
            this.btnDividirComanda.Click += new System.EventHandler(this.btnDividirComanda_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(229, 22);
            this.btnAbrirCaixa.Text = "Abrir\\Adicionar Caixa";
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(229, 22);
            this.btnFecharCaixa.Text = "Fechar Caixa";
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnLimparVenda
            // 
            this.btnLimparVenda.Name = "btnLimparVenda";
            this.btnLimparVenda.Size = new System.Drawing.Size(229, 22);
            this.btnLimparVenda.Text = "Limpar Venda";
            this.btnLimparVenda.Click += new System.EventHandler(this.btnLimparVenda_Click);
            // 
            // btnSairDoMenu
            // 
            this.btnSairDoMenu.Name = "btnSairDoMenu";
            this.btnSairDoMenu.Size = new System.Drawing.Size(229, 22);
            this.btnSairDoMenu.Text = "Sair";
            this.btnSairDoMenu.Click += new System.EventHandler(this.btnSairDoMenu_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.Color.LightGray;
            this.btnCalculadora.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(139, 31);
            this.btnCalculadora.Text = "Calculadora [F7]";
            this.btnCalculadora.ToolTipText = "Calculadora\r\n";
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // tlp
            // 
            this.tlp.AutomaticDelay = 100;
            this.tlp.AutoPopDelay = 1000;
            this.tlp.InitialDelay = 500;
            this.tlp.ReshowDelay = 200;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSangria
            // 
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(229, 22);
            this.btnSangria.Text = "Sangria";
            this.btnSangria.Click += new System.EventHandler(this.btnSangria_Click);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 507);
            this.Controls.Add(this.ckbPorPeso);
            this.Controls.Add(this.MenuCaixa);
            this.Controls.Add(this.ltvProdutos);
            this.Controls.Add(this.gpbTipoDePagamento);
            this.Controls.Add(this.gpbQuantidadeDoProduto);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.gpbTotalNocaixa);
            this.Controls.Add(this.gpbTotal);
            this.Controls.Add(this.gpbGerarTroco);
            this.Controls.Add(this.gpbValorPago);
            this.Controls.Add(this.gpbValorPorPeso);
            this.Controls.Add(this.gpbCodigoDoProduto);
            this.Controls.Add(this.gpbCodigoDaComanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuCaixa;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.gpbCodigoDaComanda.ResumeLayout(false);
            this.gpbCodigoDaComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigo)).EndInit();
            this.gpbCodigoDoProduto.ResumeLayout(false);
            this.gpbCodigoDoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCodigoDoProduto)).EndInit();
            this.gpbValorPago.ResumeLayout(false);
            this.gpbValorPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbValorTotalPago)).EndInit();
            this.gpbGerarTroco.ResumeLayout(false);
            this.gpbGerarTroco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroco)).EndInit();
            this.gpbTotal.ResumeLayout(false);
            this.gpbTotalNocaixa.ResumeLayout(false);
            this.gpbQuantidadeDoProduto.ResumeLayout(false);
            this.gpbQuantidadeDoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuantidade)).EndInit();
            this.gpbTipoDePagamento.ResumeLayout(false);
            this.gpbValorPorPeso.ResumeLayout(false);
            this.gpbValorPorPeso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKilograma)).EndInit();
            this.MenuCaixa.ResumeLayout(false);
            this.MenuCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCodigoDaComanda;
        private System.Windows.Forms.TextBox txtCodigoDaComanda;
        private System.Windows.Forms.GroupBox gpbCodigoDoProduto;
        private System.Windows.Forms.TextBox txtCodigoDoProduto;
        private System.Windows.Forms.GroupBox gpbValorPago;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.GroupBox gpbGerarTroco;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.GroupBox gpbTotalNocaixa;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Label lblTotalNoCaixa;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.GroupBox gpbQuantidadeDoProduto;
        private System.Windows.Forms.GroupBox gpbTipoDePagamento;
        private System.Windows.Forms.ComboBox cbbTipoDePagamento;
        private System.Windows.Forms.TextBox txtQuantidade;
       // private System.Windows.Forms.ToolStripStatusLabel lblProfissao;
        //private System.Windows.Forms.ToolStripStatusLabel lblUsuarioLogado;
        private System.Windows.Forms.GroupBox gpbValorPorPeso;
        private System.Windows.Forms.TextBox txtPesoDoProduto;
        private System.Windows.Forms.CheckBox ckbPorPeso;
        private System.Windows.Forms.ListView ltvProdutos;
        private System.Windows.Forms.PictureBox ptbValorTotalPago;
        private System.Windows.Forms.PictureBox ptbTroco;
        private System.Windows.Forms.PictureBox ptbCodigo;
        private System.Windows.Forms.PictureBox ptbCodigoDoProduto;
        private System.Windows.Forms.PictureBox ptbQuantidade;
        private System.Windows.Forms.MenuStrip MenuCaixa;
        private System.Windows.Forms.ToolStripMenuItem btnOperacoes;
        private System.Windows.Forms.ToolStripMenuItem btnReceberCredito;
        private System.Windows.Forms.ToolStripMenuItem btnDividirComanda;
        private System.Windows.Forms.ToolStripMenuItem btnCalculadora;
        private System.Windows.Forms.ToolTip tlp;
        private System.Windows.Forms.ToolStripMenuItem btnAbrirCaixa;
        private System.Windows.Forms.ToolStripMenuItem btnFecharCaixa;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox ptbKilograma;
        private System.Windows.Forms.ToolStripMenuItem btnSairDoMenu;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Label lblF4;
        private System.Windows.Forms.Label lblF3;
        private System.Windows.Forms.Label lblF5;
        private System.Windows.Forms.Label lblF6;
        private System.Windows.Forms.ToolStripMenuItem btnLimparVenda;
        private System.Windows.Forms.ToolStripMenuItem btnSangria;
    }
}