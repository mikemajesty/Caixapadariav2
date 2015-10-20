namespace View.UI.ViewProduto
{
    partial class frmCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarProduto));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.gpbProduto = new System.Windows.Forms.GroupBox();
            this.btnAdicionarCategoria = new System.Windows.Forms.Button();
            this.gpbDadosUnidade = new System.Windows.Forms.GroupBox();
            this.ptbPrecoVenda = new System.Windows.Forms.PictureBox();
            this.ptbPrecoCompra = new System.Windows.Forms.PictureBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblPrecoCompra = new System.Windows.Forms.Label();
            this.gpbDadosPeso = new System.Windows.Forms.GroupBox();
            this.ptbPorcentagem = new System.Windows.Forms.PictureBox();
            this.Porcentagem = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbEstoque = new System.Windows.Forms.GroupBox();
            this.txtQtdMaxima = new System.Windows.Forms.TextBox();
            this.txtQtdMinima = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblQuantidadeMaxima = new System.Windows.Forms.Label();
            this.lblQuantidadeMinima = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.gpbTipoCadastro = new System.Windows.Forms.GroupBox();
            this.cbbTipoCadastro = new System.Windows.Forms.ComboBox();
            this.ckbEstoque = new System.Windows.Forms.CheckBox();
            this.tlp2 = new System.Windows.Forms.ToolTip(this.components);
            this.gpbProduto.SuspendLayout();
            this.gpbDadosUnidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecoCompra)).BeginInit();
            this.gpbDadosPeso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPorcentagem)).BeginInit();
            this.gpbEstoque.SuspendLayout();
            this.gpbTipoCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(92, 30);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(559, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 467);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(657, 54);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 23);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(92, 115);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(208, 31);
            this.cbbCategoria.TabIndex = 3;
            this.cbbCategoria.TabStop = false;
            this.cbbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbbCategoria_SelectedIndexChanged);
            // 
            // gpbProduto
            // 
            this.gpbProduto.Controls.Add(this.btnAdicionarCategoria);
            this.gpbProduto.Controls.Add(this.gpbDadosUnidade);
            this.gpbProduto.Controls.Add(this.gpbDadosPeso);
            this.gpbProduto.Controls.Add(this.txtDescricao);
            this.gpbProduto.Controls.Add(this.lblDescricao);
            this.gpbProduto.Controls.Add(this.lblCategoria);
            this.gpbProduto.Controls.Add(this.lblNome);
            this.gpbProduto.Controls.Add(this.lblCodigo);
            this.gpbProduto.Controls.Add(this.cbbCategoria);
            this.gpbProduto.Controls.Add(this.txtNome);
            this.gpbProduto.Controls.Add(this.txtCodigo);
            this.gpbProduto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProduto.Location = new System.Drawing.Point(12, 77);
            this.gpbProduto.Name = "gpbProduto";
            this.gpbProduto.Size = new System.Drawing.Size(657, 302);
            this.gpbProduto.TabIndex = 4;
            this.gpbProduto.TabStop = false;
            this.gpbProduto.Text = "Dados do produto";
            // 
            // btnAdicionarCategoria
            // 
            this.btnAdicionarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarCategoria.Image")));
            this.btnAdicionarCategoria.Location = new System.Drawing.Point(306, 115);
            this.btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            this.btnAdicionarCategoria.Size = new System.Drawing.Size(34, 31);
            this.btnAdicionarCategoria.TabIndex = 9;
            this.btnAdicionarCategoria.TabStop = false;
            this.btnAdicionarCategoria.UseVisualStyleBackColor = true;
            this.btnAdicionarCategoria.Click += new System.EventHandler(this.btnAdicionarCategoria_Click);
            // 
            // gpbDadosUnidade
            // 
            this.gpbDadosUnidade.Controls.Add(this.ptbPrecoVenda);
            this.gpbDadosUnidade.Controls.Add(this.ptbPrecoCompra);
            this.gpbDadosUnidade.Controls.Add(this.txtPrecoVenda);
            this.gpbDadosUnidade.Controls.Add(this.txtPrecoCompra);
            this.gpbDadosUnidade.Controls.Add(this.lblPrecoVenda);
            this.gpbDadosUnidade.Controls.Add(this.lblPrecoCompra);
            this.gpbDadosUnidade.Location = new System.Drawing.Point(346, 178);
            this.gpbDadosUnidade.Name = "gpbDadosUnidade";
            this.gpbDadosUnidade.Size = new System.Drawing.Size(304, 113);
            this.gpbDadosUnidade.TabIndex = 8;
            this.gpbDadosUnidade.TabStop = false;
            this.gpbDadosUnidade.Text = "Dados de Unidade";
            // 
            // ptbPrecoVenda
            // 
            this.ptbPrecoVenda.Image = ((System.Drawing.Image)(resources.GetObject("ptbPrecoVenda.Image")));
            this.ptbPrecoVenda.Location = new System.Drawing.Point(264, 70);
            this.ptbPrecoVenda.Name = "ptbPrecoVenda";
            this.ptbPrecoVenda.Size = new System.Drawing.Size(35, 27);
            this.ptbPrecoVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPrecoVenda.TabIndex = 7;
            this.ptbPrecoVenda.TabStop = false;
            // 
            // ptbPrecoCompra
            // 
            this.ptbPrecoCompra.Image = ((System.Drawing.Image)(resources.GetObject("ptbPrecoCompra.Image")));
            this.ptbPrecoCompra.Location = new System.Drawing.Point(264, 29);
            this.ptbPrecoCompra.Name = "ptbPrecoCompra";
            this.ptbPrecoCompra.Size = new System.Drawing.Size(35, 27);
            this.ptbPrecoCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPrecoCompra.TabIndex = 7;
            this.ptbPrecoCompra.TabStop = false;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(145, 69);
            this.txtPrecoVenda.MaxLength = 7;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(117, 29);
            this.txtPrecoVenda.TabIndex = 6;
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecoVenda.TextChanged += new System.EventHandler(this.txtPrecoVenda_TextChanged);
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCompra.Location = new System.Drawing.Point(146, 29);
            this.txtPrecoCompra.MaxLength = 7;
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(117, 29);
            this.txtPrecoCompra.TabIndex = 5;
            this.txtPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecoCompra.TextChanged += new System.EventHandler(this.txtPrecoCompra_TextChanged);
            this.txtPrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoCompra_KeyPress);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoVenda.Location = new System.Drawing.Point(10, 71);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(124, 23);
            this.lblPrecoVenda.TabIndex = 8;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // lblPrecoCompra
            // 
            this.lblPrecoCompra.AutoSize = true;
            this.lblPrecoCompra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCompra.Location = new System.Drawing.Point(10, 32);
            this.lblPrecoCompra.Name = "lblPrecoCompra";
            this.lblPrecoCompra.Size = new System.Drawing.Size(133, 23);
            this.lblPrecoCompra.TabIndex = 9;
            this.lblPrecoCompra.Text = "Preço de Compra";
            // 
            // gpbDadosPeso
            // 
            this.gpbDadosPeso.Controls.Add(this.ptbPorcentagem);
            this.gpbDadosPeso.Controls.Add(this.Porcentagem);
            this.gpbDadosPeso.Controls.Add(this.txtPorcentagem);
            this.gpbDadosPeso.Location = new System.Drawing.Point(346, 105);
            this.gpbDadosPeso.Name = "gpbDadosPeso";
            this.gpbDadosPeso.Size = new System.Drawing.Size(304, 74);
            this.gpbDadosPeso.TabIndex = 8;
            this.gpbDadosPeso.TabStop = false;
            this.gpbDadosPeso.Text = "Dados do Lucro";
            // 
            // ptbPorcentagem
            // 
            this.ptbPorcentagem.Image = ((System.Drawing.Image)(resources.GetObject("ptbPorcentagem.Image")));
            this.ptbPorcentagem.Location = new System.Drawing.Point(264, 32);
            this.ptbPorcentagem.Name = "ptbPorcentagem";
            this.ptbPorcentagem.Size = new System.Drawing.Size(35, 27);
            this.ptbPorcentagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPorcentagem.TabIndex = 7;
            this.ptbPorcentagem.TabStop = false;
            // 
            // Porcentagem
            // 
            this.Porcentagem.AutoSize = true;
            this.Porcentagem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porcentagem.Location = new System.Drawing.Point(10, 35);
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Size = new System.Drawing.Size(103, 23);
            this.Porcentagem.TabIndex = 6;
            this.Porcentagem.Text = "Porcentagem";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagem.Location = new System.Drawing.Point(146, 32);
            this.txtPorcentagem.MaxLength = 5;
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(117, 29);
            this.txtPorcentagem.TabIndex = 4;
            this.txtPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(92, 185);
            this.txtDescricao.MaxLength = 70;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(248, 106);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(9, 185);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 23);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(9, 118);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 23);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(92, 70);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(559, 29);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // gpbEstoque
            // 
            this.gpbEstoque.Controls.Add(this.txtQtdMaxima);
            this.gpbEstoque.Controls.Add(this.txtQtdMinima);
            this.gpbEstoque.Controls.Add(this.txtEstoque);
            this.gpbEstoque.Controls.Add(this.lblQuantidadeMaxima);
            this.gpbEstoque.Controls.Add(this.lblQuantidadeMinima);
            this.gpbEstoque.Controls.Add(this.lblEstoque);
            this.gpbEstoque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEstoque.Location = new System.Drawing.Point(12, 379);
            this.gpbEstoque.Name = "gpbEstoque";
            this.gpbEstoque.Size = new System.Drawing.Size(657, 86);
            this.gpbEstoque.TabIndex = 5;
            this.gpbEstoque.TabStop = false;
            this.gpbEstoque.Text = "Dados no estoque";
            // 
            // txtQtdMaxima
            // 
            this.txtQtdMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdMaxima.Location = new System.Drawing.Point(582, 39);
            this.txtQtdMaxima.MaxLength = 20;
            this.txtQtdMaxima.Name = "txtQtdMaxima";
            this.txtQtdMaxima.Size = new System.Drawing.Size(69, 29);
            this.txtQtdMaxima.TabIndex = 9;
            this.txtQtdMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtdMaxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdMaxima_KeyPress);
            // 
            // txtQtdMinima
            // 
            this.txtQtdMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdMinima.Location = new System.Drawing.Point(338, 39);
            this.txtQtdMinima.MaxLength = 20;
            this.txtQtdMinima.Name = "txtQtdMinima";
            this.txtQtdMinima.Size = new System.Drawing.Size(69, 29);
            this.txtQtdMinima.TabIndex = 8;
            this.txtQtdMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtdMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdMinima_KeyPress);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(91, 39);
            this.txtEstoque.MaxLength = 20;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(69, 29);
            this.txtEstoque.TabIndex = 7;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            // 
            // lblQuantidadeMaxima
            // 
            this.lblQuantidadeMaxima.AutoSize = true;
            this.lblQuantidadeMaxima.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeMaxima.Location = new System.Drawing.Point(435, 42);
            this.lblQuantidadeMaxima.Name = "lblQuantidadeMaxima";
            this.lblQuantidadeMaxima.Size = new System.Drawing.Size(150, 23);
            this.lblQuantidadeMaxima.TabIndex = 2;
            this.lblQuantidadeMaxima.Text = "Quantidade Máxima";
            // 
            // lblQuantidadeMinima
            // 
            this.lblQuantidadeMinima.AutoSize = true;
            this.lblQuantidadeMinima.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeMinima.Location = new System.Drawing.Point(189, 42);
            this.lblQuantidadeMinima.Name = "lblQuantidadeMinima";
            this.lblQuantidadeMinima.Size = new System.Drawing.Size(145, 23);
            this.lblQuantidadeMinima.TabIndex = 2;
            this.lblQuantidadeMinima.Text = "Quantidade Mínima";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(10, 42);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(67, 23);
            this.lblEstoque.TabIndex = 2;
            this.lblEstoque.Text = "Estoque";
            // 
            // gpbTipoCadastro
            // 
            this.gpbTipoCadastro.Controls.Add(this.cbbTipoCadastro);
            this.gpbTipoCadastro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoCadastro.Location = new System.Drawing.Point(12, 4);
            this.gpbTipoCadastro.Name = "gpbTipoCadastro";
            this.gpbTipoCadastro.Size = new System.Drawing.Size(330, 74);
            this.gpbTipoCadastro.TabIndex = 12;
            this.gpbTipoCadastro.TabStop = false;
            this.gpbTipoCadastro.Text = "Tipo de cadastro do produto";
            // 
            // cbbTipoCadastro
            // 
            this.cbbTipoCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoCadastro.DropDownWidth = 2;
            this.cbbTipoCadastro.FormattingEnabled = true;
            this.cbbTipoCadastro.ItemHeight = 23;
            this.cbbTipoCadastro.Location = new System.Drawing.Point(6, 29);
            this.cbbTipoCadastro.Name = "cbbTipoCadastro";
            this.cbbTipoCadastro.Size = new System.Drawing.Size(315, 31);
            this.cbbTipoCadastro.TabIndex = 0;
            this.tlp2.SetToolTip(this.cbbTipoCadastro, "Selecione o tipo de cadastro, exemplo Unidade");
            this.cbbTipoCadastro.SelectedIndexChanged += new System.EventHandler(this.cbbTipoCadastro_SelectedIndexChanged);
            // 
            // ckbEstoque
            // 
            this.ckbEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEstoque.Image = ((System.Drawing.Image)(resources.GetObject("ckbEstoque.Image")));
            this.ckbEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbEstoque.Location = new System.Drawing.Point(358, 12);
            this.ckbEstoque.Name = "ckbEstoque";
            this.ckbEstoque.Size = new System.Drawing.Size(311, 66);
            this.ckbEstoque.TabIndex = 13;
            this.ckbEstoque.TabStop = false;
            this.ckbEstoque.Text = "Gerenciar Estoque";
            this.tlp2.SetToolTip(this.ckbEstoque, "Selecione se esse produto se o estoque desse produto será gerenciado.");
            this.ckbEstoque.UseVisualStyleBackColor = true;
            this.ckbEstoque.CheckedChanged += new System.EventHandler(this.ckbEstoque_CheckedChanged);
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 527);
            this.Controls.Add(this.ckbEstoque);
            this.Controls.Add(this.gpbTipoCadastro);
            this.Controls.Add(this.gpbEstoque);
            this.Controls.Add(this.gpbProduto);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            this.gpbProduto.ResumeLayout(false);
            this.gpbProduto.PerformLayout();
            this.gpbDadosUnidade.ResumeLayout(false);
            this.gpbDadosUnidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrecoCompra)).EndInit();
            this.gpbDadosPeso.ResumeLayout(false);
            this.gpbDadosPeso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPorcentagem)).EndInit();
            this.gpbEstoque.ResumeLayout(false);
            this.gpbEstoque.PerformLayout();
            this.gpbTipoCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.GroupBox gpbProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gpbEstoque;
        private System.Windows.Forms.TextBox txtQtdMaxima;
        private System.Windows.Forms.TextBox txtQtdMinima;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblQuantidadeMaxima;
        private System.Windows.Forms.Label lblQuantidadeMinima;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label Porcentagem;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.GroupBox gpbDadosPeso;
        private System.Windows.Forms.GroupBox gpbTipoCadastro;
        private System.Windows.Forms.ComboBox cbbTipoCadastro;
        private System.Windows.Forms.GroupBox gpbDadosUnidade;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Label lblPrecoCompra;
        private System.Windows.Forms.Button btnAdicionarCategoria;
        private System.Windows.Forms.CheckBox ckbEstoque;
        private System.Windows.Forms.ToolTip tlp2;
        private System.Windows.Forms.PictureBox ptbPrecoVenda;
        private System.Windows.Forms.PictureBox ptbPrecoCompra;
        private System.Windows.Forms.PictureBox ptbPorcentagem;
    }
}