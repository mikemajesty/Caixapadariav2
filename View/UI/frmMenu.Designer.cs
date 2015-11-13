namespace View
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComanda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarComanda = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesuisarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovimentacaoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovimentacaoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovimentacaoProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnomalias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatorioCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodape = new System.Windows.Forms.StatusStrip();
            this.lblProfissao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.rodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogin,
            this.menuUsuario,
            this.menuComanda,
            this.categoriaMenu,
            this.produtoMenu,
            this.menuCliente,
            this.menuEstoque,
            this.menuCaixa,
            this.menuMovimentacao,
            this.menuRelatorios,
            this.btnSair,
            this.toolStripMenuItem1,
            this.fffToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1238, 54);
            this.menu.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(0);
            this.btnLogin.Size = new System.Drawing.Size(68, 50);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menuUsuario
            // 
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarLogin});
            this.menuUsuario.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuario.Image = ((System.Drawing.Image)(resources.GetObject("menuUsuario.Image")));
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Padding = new System.Windows.Forms.Padding(0);
            this.menuUsuario.Size = new System.Drawing.Size(84, 50);
            this.menuUsuario.Text = "Usuário";
            // 
            // btnGerenciarLogin
            // 
            this.btnGerenciarLogin.Name = "btnGerenciarLogin";
            this.btnGerenciarLogin.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarLogin.Text = "Gerenciar";
            this.btnGerenciarLogin.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // menuComanda
            // 
            this.menuComanda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarComanda});
            this.menuComanda.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuComanda.Image = ((System.Drawing.Image)(resources.GetObject("menuComanda.Image")));
            this.menuComanda.Name = "menuComanda";
            this.menuComanda.Padding = new System.Windows.Forms.Padding(0);
            this.menuComanda.Size = new System.Drawing.Size(96, 50);
            this.menuComanda.Text = "Comanda";
            // 
            // btnGerenciarComanda
            // 
            this.btnGerenciarComanda.Name = "btnGerenciarComanda";
            this.btnGerenciarComanda.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarComanda.Text = "Gerenciar";
            this.btnGerenciarComanda.Click += new System.EventHandler(this.btnGerenciarComanda_Click);
            // 
            // categoriaMenu
            // 
            this.categoriaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarCategoria});
            this.categoriaMenu.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaMenu.Image = ((System.Drawing.Image)(resources.GetObject("categoriaMenu.Image")));
            this.categoriaMenu.Name = "categoriaMenu";
            this.categoriaMenu.Padding = new System.Windows.Forms.Padding(0);
            this.categoriaMenu.Size = new System.Drawing.Size(99, 50);
            this.categoriaMenu.Text = "Categoria";
            // 
            // btnGerenciarCategoria
            // 
            this.btnGerenciarCategoria.Name = "btnGerenciarCategoria";
            this.btnGerenciarCategoria.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarCategoria.Text = "Gerenciar";
            this.btnGerenciarCategoria.Click += new System.EventHandler(this.btnGerenciarCategoria_Click);
            // 
            // produtoMenu
            // 
            this.produtoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarProduto,
            this.btnPesuisarProduto});
            this.produtoMenu.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoMenu.Image = ((System.Drawing.Image)(resources.GetObject("produtoMenu.Image")));
            this.produtoMenu.Name = "produtoMenu";
            this.produtoMenu.Padding = new System.Windows.Forms.Padding(0);
            this.produtoMenu.Size = new System.Drawing.Size(85, 50);
            this.produtoMenu.Text = "Produto";
            // 
            // btnGerenciarProduto
            // 
            this.btnGerenciarProduto.Name = "btnGerenciarProduto";
            this.btnGerenciarProduto.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarProduto.Text = "Gerenciar";
            this.btnGerenciarProduto.Click += new System.EventHandler(this.btnGerenciarProduto_Click);
            // 
            // btnPesuisarProduto
            // 
            this.btnPesuisarProduto.Name = "btnPesuisarProduto";
            this.btnPesuisarProduto.Size = new System.Drawing.Size(148, 22);
            this.btnPesuisarProduto.Text = "Pesquisar";
            this.btnPesuisarProduto.Click += new System.EventHandler(this.btnPesuisarProduto_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarCliente});
            this.menuCliente.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.Image = ((System.Drawing.Image)(resources.GetObject("menuCliente.Image")));
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Padding = new System.Windows.Forms.Padding(0);
            this.menuCliente.Size = new System.Drawing.Size(79, 50);
            this.menuCliente.Text = "Cliente";
            // 
            // btnGerenciarCliente
            // 
            this.btnGerenciarCliente.Name = "btnGerenciarCliente";
            this.btnGerenciarCliente.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarCliente.Text = "Gerenciar";
            this.btnGerenciarCliente.Click += new System.EventHandler(this.btnGerenciarCliente_Click);
            // 
            // menuEstoque
            // 
            this.menuEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarEstoque});
            this.menuEstoque.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEstoque.Image = ((System.Drawing.Image)(resources.GetObject("menuEstoque.Image")));
            this.menuEstoque.Name = "menuEstoque";
            this.menuEstoque.Padding = new System.Windows.Forms.Padding(0);
            this.menuEstoque.Size = new System.Drawing.Size(87, 50);
            this.menuEstoque.Text = "Estoque";
            // 
            // btnGerenciarEstoque
            // 
            this.btnGerenciarEstoque.Name = "btnGerenciarEstoque";
            this.btnGerenciarEstoque.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarEstoque.Text = "Gerenciar";
            this.btnGerenciarEstoque.Click += new System.EventHandler(this.btnGerenciarEstoque_Click);
            // 
            // menuCaixa
            // 
            this.menuCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCaixa});
            this.menuCaixa.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCaixa.Image = ((System.Drawing.Image)(resources.GetObject("menuCaixa.Image")));
            this.menuCaixa.Name = "menuCaixa";
            this.menuCaixa.Padding = new System.Windows.Forms.Padding(0);
            this.menuCaixa.Size = new System.Drawing.Size(69, 50);
            this.menuCaixa.Text = "Caixa";
            // 
            // btnCaixa
            // 
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(117, 22);
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // menuMovimentacao
            // 
            this.menuMovimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMovimentacaoVenda,
            this.btnMovimentacaoCaixa,
            this.btnMovimentacaoProduto,
            this.btnAnomalias});
            this.menuMovimentacao.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMovimentacao.Image = ((System.Drawing.Image)(resources.GetObject("menuMovimentacao.Image")));
            this.menuMovimentacao.Name = "menuMovimentacao";
            this.menuMovimentacao.Padding = new System.Windows.Forms.Padding(0);
            this.menuMovimentacao.Size = new System.Drawing.Size(134, 50);
            this.menuMovimentacao.Text = "Movimentação";
            // 
            // btnMovimentacaoVenda
            // 
            this.btnMovimentacaoVenda.Name = "btnMovimentacaoVenda";
            this.btnMovimentacaoVenda.Size = new System.Drawing.Size(151, 22);
            this.btnMovimentacaoVenda.Text = "Venda";
            this.btnMovimentacaoVenda.Click += new System.EventHandler(this.btnMovimentacaoCaixa_Click);
            // 
            // btnMovimentacaoCaixa
            // 
            this.btnMovimentacaoCaixa.Name = "btnMovimentacaoCaixa";
            this.btnMovimentacaoCaixa.Size = new System.Drawing.Size(151, 22);
            this.btnMovimentacaoCaixa.Text = "Caixa";
            this.btnMovimentacaoCaixa.Click += new System.EventHandler(this.btnMovimentacaoCaixa_Click_1);
            // 
            // btnMovimentacaoProduto
            // 
            this.btnMovimentacaoProduto.Name = "btnMovimentacaoProduto";
            this.btnMovimentacaoProduto.Size = new System.Drawing.Size(151, 22);
            this.btnMovimentacaoProduto.Text = "Produto";
            this.btnMovimentacaoProduto.Click += new System.EventHandler(this.btnMovimentacaoProduto_Click);
            // 
            // btnAnomalias
            // 
            this.btnAnomalias.Name = "btnAnomalias";
            this.btnAnomalias.Size = new System.Drawing.Size(151, 22);
            this.btnAnomalias.Text = "Anomalias";
            this.btnAnomalias.Click += new System.EventHandler(this.btnAnomalias_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRelatorioCompra});
            this.menuRelatorios.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("menuRelatorios.Image")));
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Padding = new System.Windows.Forms.Padding(0);
            this.menuRelatorios.Size = new System.Drawing.Size(94, 50);
            this.menuRelatorios.Text = "Relatorio";
            // 
            // btnRelatorioCompra
            // 
            this.btnRelatorioCompra.Name = "btnRelatorioCompra";
            this.btnRelatorioCompra.Size = new System.Drawing.Size(152, 22);
            this.btnRelatorioCompra.Text = "Compras";
            this.btnRelatorioCompra.Click += new System.EventHandler(this.btnRelatorioCompra_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(0);
            this.btnSair.Size = new System.Drawing.Size(56, 50);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(4, 50);
            // 
            // fffToolStripMenuItem
            // 
            this.fffToolStripMenuItem.Name = "fffToolStripMenuItem";
            this.fffToolStripMenuItem.Size = new System.Drawing.Size(12, 50);
            // 
            // rodape
            // 
            this.rodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProfissao,
            this.lblUsuarioLogado});
            this.rodape.Location = new System.Drawing.Point(0, 399);
            this.rodape.Name = "rodape";
            this.rodape.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.rodape.Size = new System.Drawing.Size(1238, 25);
            this.rodape.TabIndex = 2;
            this.rodape.Text = "statusStrip1";
            // 
            // lblProfissao
            // 
            this.lblProfissao.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(126, 20);
            this.lblProfissao.Text = "Funcionario: ";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(56, 20);
            this.lblUsuarioLogado.Text = "Nome";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 424);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.rodape.ResumeLayout(false);
            this.rodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarLogin;
        private System.Windows.Forms.ToolStripMenuItem btnLogin;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem menuComanda;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarComanda;
        private System.Windows.Forms.ToolStripMenuItem categoriaMenu;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarCategoria;
        private System.Windows.Forms.ToolStripMenuItem produtoMenu;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarProduto;
        private System.Windows.Forms.ToolStripMenuItem btnPesuisarProduto;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarCliente;
        private System.Windows.Forms.ToolStripMenuItem menuEstoque;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuCaixa;
        private System.Windows.Forms.ToolStripMenuItem btnCaixa;
        private System.Windows.Forms.StatusStrip rodape;
        private System.Windows.Forms.ToolStripStatusLabel lblProfissao;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem btnMovimentacaoVenda;
        private System.Windows.Forms.ToolStripMenuItem btnMovimentacaoCaixa;
        private System.Windows.Forms.ToolStripMenuItem btnMovimentacaoProduto;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem btnRelatorioCompra;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAnomalias;
    }
}