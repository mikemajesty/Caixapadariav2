using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.BO;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewCetegoria;
using View.UI.ViewEstoque;

namespace View.UI.ViewProduto
{
    public partial class frmCadastrarProduto : Form
    {
        private Produto _produto;
        private EnumTipoOperacao _tipoOperacao;
        private CategoriaRepositorio _categoriaRepositorio;
        private ProdutoRepositorio _produtoRepositorio;
        private TipoCadastroRepositorio _tipoCadastroRepositorio;
        private const int Sucesso = 1;
        public frmCadastrarProduto(Produto produto, EnumTipoOperacao tipoOperacao)
        {
            _produto = produto;
            _tipoOperacao = tipoOperacao;
            InitializeComponent();

        }

        private void MudarAnchorDoBotao(AnchorStyles anchorStyles)
        {
            btnCadastrar.Anchor = anchorStyles;
        }
        private void CarregarTextoDePermissao()
        {

            try
            {
                switch (Usuarios.PermissaoStatic)
                {
                    case "Caixa":
                        txtQtdMinima.ReadOnly = true;
                        txtQtdMaxima.ReadOnly = true;
                        ckbEstoque.Enabled = false;
                        gpbDadosPeso.Visible = false;
                        gpbDadosUnidade.Visible = false;
                        btnAdicionarCategoria.Visible = false;
                        MudarTamanhoDoComboBoxCategoria(new Size(558, 31));
                        MudarTamanhoDotxtDescricao(new Size(558, 106));
                        break;
                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void MudarTamanhoDoComboBoxCategoria(Size size)
        {
            cbbCategoria.Size = size;
        }
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {


            try
            {

                FocarNoTxt(txt: txtCodigo);
                CarregarCategoria();
                CarregarTipoDeCadastro();
                CarregarTextoDePermissao();
                switch (_tipoOperacao)
                {
                    case EnumTipoOperacao.Salvar:
                        ComboBoxCheckado();
                        break;
                    case EnumTipoOperacao.Alterar:
                        PopulaTxt();
                        MudarCorDoBotao(Color.LightGreen);
                        MudarTextoDoForm("Alterar Produto");
                        MudarTextoDoBotao("Alterar");
                        DesabilitarGroupBoxDeTipoDeCadastro();
                        break;
                    case EnumTipoOperacao.Deletar:
                        PopulaTxt();
                        MudarCorDoBotao(Color.LightCoral);
                        MudarTextoDoForm("Deletar Produto");
                        MudarTextoDoBotao("Deletar");
                        DesabilitarCampos();
                        DesabilitarGroupBoxDeTipoDeCadastro();
                        DesabilitarGroupBoxDadosDoPeso(gpbDadosPeso);
                        DesabilitarCheckBox();

                        break;
                    case EnumTipoOperacao.Detalhes:
                        PopulaTxt();
                        MudarCorDoBotao(Color.Silver);
                        MudarTextoDoForm("Detalhes do Produto");
                        MudarTextoDoBotao("Sair");
                        DesabilitarCampos();
                        DesabilitarGroupBoxDeTipoDeCadastro();
                        DesabilitarGroupBoxDadosDoPeso(gpbDadosPeso);
                        DesabilitarCheckBox();

                        break;
                    case EnumTipoOperacao.Estoque:
                        PopulaTxt();
                        MudarCorDoBotao(Color.LightGreen);
                        DeixarTxtComoNaoObrigatorio();
                        MudarTextoDoForm("Alterar Estoque");
                        MudarTextoDoBotao("Alterar");
                        DesabilitarGroupBox(new GroupBox[] { gpbDadosUnidade, gpbDadosPeso, gpbTipoCadastro, gpbProduto });
                        FocarNoTxt(txt: txtEstoque);
                        DeixarTxtComoObrigatorio(new TextBox[] { txtEstoque });

                        break;
                    case EnumTipoOperacao.ListView:
                        DesabilitarCheckBox();
                        EsconderButton(btnAdicionarCategoria);
                        PopulaTxt();
                        MudarCorDoBotao(Color.LightCoral);
                        MudarTextoDoForm("Deletar produto da comanda");
                        MudarTextoDoBotao("Deletar");
                        DesabilitarCampos();
                        DesabilitarGroupBoxDeTipoDeCadastro();
                        DesabilitarGroupBoxDadosDoPeso(gpbDadosPeso);
                        if (Usuarios.PermissaoStatic != ("Administrador"))
                        {
                            MudarTamanhoDoComboBoxCategoria(new Size(558, 31));
                            MudarPosicaoDaLabel(posicao: new Point(13, 46), lbl: lblPrecoVenda);
                            MudarPosicaoDoTextBox(posicao: new Point(146, 44), txt: txtPrecoVenda);
                            lblPrecoCompra.Visible = false;
                            txtPrecoCompra.Visible = false;
                            gpbDadosPeso.Visible = false;
                        }

                        break;

                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void MudarPosicaoDaLabel(Point posicao, Label lbl)
        {
            lbl.Location = posicao;
        }

        private void MudarPosicaoDoTextBox(Point posicao, TextBox txt)
        {
            txt.Location = posicao;
        }

        private void ComboBoxCheckado()
        {
            if (ckbEstoque.Checked == false)
            {
                EsconderGruopBox(gpbEstoque);
            }
        }



        private void DesabilitarCheckBox()
        {
            ckbEstoque.Enabled = false;
        }

        private void EsconderButton(Button btn)
        {
            btn.Hide();
        }
        private void DesabilitarGroupBoxDeTipoDeCadastro()
        {
            gpbTipoCadastro.Enabled = false;
        }
        private void CarregarTipoDeCadastro()
        {

            try
            {
                InstanciarTipoCadastroRepositorio();
                _tipoCadastroRepositorio.Cadastrar();
                _tipoCadastroRepositorio.Listar(cbbTipoCadastro);

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }



        private void InstanciarTipoCadastroRepositorio()
        {
            _tipoCadastroRepositorio = new TipoCadastroRepositorio();
        }




        private void MudarTextoDoBotao(string texto)
        {
            btnCadastrar.Text = texto;
        }

        private void DesabilitarCampos()
        {
            foreach (Control gpb in this.Controls)
            {
                if (gpb is GroupBox)
                {
                    gpb.Enabled = false;
                }
            }
        }

        private void MudarTextoDoForm(string texto)
        {
            this.Text = texto;
        }

        private void MudarCorDoBotao(Color color)
        {
            btnCadastrar.BackColor = color;
        }

        private void PopulaTxt()
        {
            try
            {
                CarregarComboBoxDeAcordoComTipoDeCadastro();
                switch (cbbTipoCadastro.Text)
                {
                    case "Unidade":
                        PopulartxtPadrao();
                        PopulatxtUnidade();
                        break;
                    case "Peso":
                        PopulartxtPadrao();
                        break;

                }


            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        private void CarregarComboBoxDeAcordoComTipoDeCadastro()
        {

            try
            {
                cbbTipoCadastro.Text = _tipoCadastroRepositorio.GetNomePeloID(_produto.TipoCadastro);
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void PopulatxtUnidade()
        {

            try
            {

                txtEstoque.Text = _produto.Quantidade.ToString();
                txtEstoque.Text = _produto.Quantidade.ToString();
                txtQtdMaxima.Text = _produto.QuantidadeMaxima.ToString();
                txtQtdMinima.Text = _produto.QuantidadeMinima.ToString();
                ckbEstoque.Checked = _produto.GerenciarEstoque;

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void PopulartxtPadrao()
        {

            txtNome.Text = _produto.Nome;
            txtCodigo.Text = _produto.Codigo;
            txtDescricao.Text = _produto.Descricao;
            txtPorcentagem.Text = _produto.Porcentagem == null ? "0 %" : _produto.Porcentagem.ToString();
            cbbCategoria.Text = _categoriaRepositorio.GetCategoriaNomePeloID(_produto.Categoria);
            txtPrecoCompra.Text = _produto.PrecoCompra.ToString();
            txtPrecoVenda.Text = _produto.PrecoVenda.ToString();
            if (_produto.GerenciarEstoque == false)
            {
                EsconderGruopBox(gpbEstoque);
            }
            ckbEstoque.Checked = _produto.GerenciarEstoque;
        }

        private void CarregarCategoria()
        {

            try
            {

                InstanciarCategoriaRepositorio();
                _categoriaRepositorio.CarregaCategoria(cbbCategoria);

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }
        private void CarregarCategoriaComSelecao()
        {

            try
            {

                InstanciarCategoriaRepositorio();
                _categoriaRepositorio.CarregaCategoriaSelecionada(cbbCategoria);

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmAlertaEstoque formAlertEstoque = null;

            try
            {
                formAlertEstoque = new frmAlertaEstoque();
                GerenciarGerenciamentoDeEstoque.FecharForm(formAlertEstoque);
                switch (_tipoOperacao)
                {
                    case EnumTipoOperacao.Salvar:
                        if (VerificarTxtNulos() == 0)
                        {

                            InstanciarProdutoRepositorio();
                            Produto prod = PupularProduto();
                            if (prod.Categoria == 0)
                            {
                                MyErro.MyCustomException("Categoria é obrigatório.");
                            }
                            else
                            {
                                if (_produtoRepositorio.Salvar(prod) == Sucesso)
                                {
                                    MensagemDeAviso("Produto salvo com sucesso.");
                                    PosSalvamento();
                                }
                            }

                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }
                        break;
                    case EnumTipoOperacao.Alterar:

                        if (VerificarTxtNulos() == 0)
                        {
                            InstanciarProdutoRepositorio();
                            if (_produtoRepositorio.Alterar(PupularProduto()) == Sucesso)
                            {
                                MensagemDeAviso("Produto alterado com sucesso.");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }
                        break;
                    case EnumTipoOperacao.Deletar:
                        if (VerificarTxtNulos() == 0)
                        {
                            InstanciarProdutoRepositorio();
                            if (_produtoRepositorio.Deletar(PupularProduto()) == Sucesso)
                            {
                                MensagemDeAviso("Produto deletado com sucesso.");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }
                        break;
                    case EnumTipoOperacao.Detalhes:
                        FecharForm();
                        break;
                    case EnumTipoOperacao.Estoque:
                        if (VerificarTxtNulos() == 0)
                        {
                            InstanciarProdutoRepositorio();
                            if (Usuarios.PermissaoStatic == "Caixa")
                            {
                                if (_produtoRepositorio.GetQuantidadeNoEstoque(_produto) > Convert.ToInt32(txtEstoque.Text))
                                {
                                    txtEstoque.LimparTxt();
                                    txtEstoque.Text = _produtoRepositorio.GetQuantidadeNoEstoque(_produto).ToString();
                                    FocarNoTxt(txtEstoque);
                                    MyErro.MyCustomException("Usuário com a Permissão CAIXA não pode retirar produtos do estoque");

                                }
                            }

                            if (_produtoRepositorio.Alterar(PupularProduto()) == Sucesso)
                            {
                                MensagemDeAviso("Estoque alterado com sucesso.");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }
                        break;
                    case EnumTipoOperacao.ListView:
                        if (DialogMessage.MessageFullQuestion("Deseja deletar esse item da comanda?", "Aviso") == DialogResult.Yes)
                        {
                            PosSalvamento();
                        }
                        break;
                }
                
            }
            catch (CustomException erro)
            {                
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
            finally { GerenciarGerenciamentoDeEstoque.AbrirForm(formAlertEstoque); }


        }

        private void FecharForm()
        {
            this.Close();
        }

        private void MensagemDeAviso(string texto)
        {
            DialogMessage.MessageFullComButtonOkIconeDeInformacao(texto, "Aviso");
        }



        private void PosSalvamento()
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void InstanciarProdutoRepositorio()
        {
            _produtoRepositorio = new ProdutoRepositorio();
        }

        private void InstanciarCategoriaRepositorio()
        {
            _categoriaRepositorio = new CategoriaRepositorio();
        }

        private Produto PupularProduto()
        {

            try
            {

                InstanciarTipoCadastroRepositorio();
                Produto produto = new Produto();
                switch (cbbTipoCadastro.Text)
                {
                    case "Unidade":
                        PreenchimentoDoProdutoPadrao(produto);
                        PreenchimentoDoProdutoPorUnidade(produto);
                        break;
                    case "Peso":
                        PreenchimentoDoProdutoPadrao(produto);
                        break;
                }
                return produto;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
        private int VerificarTxtNulos()
        {

            try
            {


                int retorno = 0;
                if (ckbEstoque.Checked == true)
                {
                    switch (cbbTipoCadastro.Text)
                    {
                        case "Unidade":
                            TextBox[] txtListUnidade = ListaTxtUnidade();
                            foreach (TextBox txt in txtListUnidade)
                            {
                                if (txt.Text == "" || txt.Text == null)
                                {
                                    retorno = 1;
                                    break;
                                }
                            }
                            break;


                    }
                }
                else if (ckbEstoque.Checked == false)
                {
                    switch (cbbTipoCadastro.Text)
                    {
                        case "Unidade":
                            TextBox[] txtListUnidade = ListaTxtUnidadeSemEstoque();
                            foreach (TextBox txt in txtListUnidade)
                            {
                                if (txt.Text == "" || txt.Text == null)
                                {
                                    retorno = 1;
                                    break;
                                }
                            }
                            break;
                        case "Peso":
                            TextBox[] txtListPeso = ListaTxtPeso();
                            foreach (TextBox txt in txtListPeso)
                            {
                                if (txt.Text == "" || txt.Text == null)
                                {
                                    retorno = 1;
                                    break;
                                }
                            }
                            break;
                    }
                }


                return retorno;

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new CustomException(erro.Message);
            }

        }

        private TextBox[] ListaTxtUnidadeSemEstoque()
        {

            TextBox[] txtListUnidade = { txtCodigo, txtNome, txtPrecoCompra, txtPrecoVenda };
            return txtListUnidade;

        }

        private TextBox[] ListaTxtPeso()
        {
            TextBox[] txtListPeso = { txtCodigo, txtNome, txtDescricao, txtPrecoCompra, txtPrecoVenda };
            return txtListPeso;
        }

        private TextBox[] ListaTxtUnidade()
        {
            TextBox[] txtListUnidade = { txtCodigo, txtNome, txtPrecoCompra, txtPrecoVenda, txtQtdMaxima, txtQtdMinima, txtEstoque };
            return txtListUnidade;
        }
        private void PreenchimentoDoProdutoPorUnidade(Produto produto)
        {

            try
            {

                if (ckbEstoque.Checked)
                {
                    produto.Quantidade = Convert.ToInt32(txtEstoque.Text.Length == 0 ? 0 : Convert.ToInt32(txtEstoque.Text));
                    produto.QuantidadeMaxima = Convert.ToInt32(txtQtdMaxima.Text.Length == 0 ? 0 : Convert.ToInt32(txtQtdMaxima.Text));
                    produto.QuantidadeMinima = Convert.ToInt32(txtQtdMinima.Text.Length == 0 ? 0 : Convert.ToInt32(txtQtdMinima.Text));
                }
                else
                {
                    produto.Quantidade = null;
                    produto.QuantidadeMaxima = null;
                    produto.QuantidadeMinima = null;
                }


            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }

        private void PreenchimentoDoProdutoPadrao(Produto produto)
        {

            try
            {


                if (_categoriaRepositorio.GetIdDaCategoriaPeloNome(cbbCategoria.Text) != 0)
                {
                    produto.Categoria = _categoriaRepositorio.GetIdDaCategoriaPeloNome(cbbCategoria.Text);
                    produto.ID = _produto.ID;
                    produto.Nome = txtNome.Text.UpperCaseOnlyFirst();
                    produto.TipoCadastro = _tipoCadastroRepositorio.GetIDPeloNome(cbbTipoCadastro.Text);
                    produto.Descricao = txtDescricao.Text != null && txtDescricao.Text != "" ? txtDescricao.Text.UpperCaseOnlyFirst() : "";
                    produto.Codigo = txtCodigo.Text;
                    produto.GerenciarEstoque = ckbEstoque.Checked;
                    produto.PrecoCompra = Convert.ToDecimal(txtPrecoCompra.Text.Length == 0 ? 0 : Convert.ToDecimal(txtPrecoCompra.Text));
                    produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text.Length == 0 ? 0 : Convert.ToDecimal(txtPrecoVenda.Text));
                    switch (cbbTipoCadastro.Text)
                    {
                        case "Unidade":
                            produto.Porcentagem = Calcular.TratarStringDePorcentagem(txtPorcentagem);
                            break;
                        case "Peso":
                            produto.Porcentagem = Convert.ToInt32(txtPorcentagem.Text.Length == 0 ? 0 : Convert.ToInt32(txtPorcentagem.Text));
                            break;
                    }

                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                FocarNoTxt(txtCodigo);
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }



        private void cbbTipoCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                LimparTodosOsTxt();
                FocarNoTxt(txt: txtCodigo);
                DeixarTxtComoNaoObrigatorio();
                switch (cbbTipoCadastro.Text)
                {
                    case "Unidade":
                        if (ckbEstoque.Checked)
                        {
                            MudarTamanhoDoform(new Size(701, 572));
                            MudarPosicaoDoBotao(new Point(12, 471));
                        }
                        else
                        {
                            MudarTamanhoDoform(new Size(701, 485));
                            MudarPosicaoDoBotao(new Point(12, 385));
                        }
                        MudarTamanhoDotxtDescricao(new Size(248, 106));
                        AparecerGruopBox(gpbEstoque);
                        AparecerGruopBox(gpbDadosUnidade);
                        DesabilitarGroupBoxDadosDoPeso(gpbDadosPeso);
                        DeixarTxtComoObrigatorio(ListaTxtUnidade());
                        MudarPosicaoDoGroupBoxTipoCadastro(new Point(12, 4));
                        MostrarCheck();
                        LimparCheckBox();
                        ComboBoxCheckado();
                        MudarTextoDoComboBox(gpb: gpbDadosPeso, texto: "Porcentagem do Lucro do Produto");
                        MudarTextoDoComboBox(gpb: gpbDadosUnidade, texto: "Dados da venda por Unidade");
                        MudarTextoDaLabel(lbl: lblPrecoCompra, texto: "Preço de Compra");
                        MudarTextoDaLabel(lbl: lblPrecoVenda, texto: "Preço de Venda");
                        MudarTamanhoDotxt(txt: txtPrecoVenda, size: new Size(117, 29));
                        MudarTamanhoDotxt(txt: txtPrecoCompra, size: new Size(117, 29));
                        MudarPosicaoDoTextBox(new Point(146, 29), txtPrecoCompra);
                        MudarPosicaoDoTextBox(new Point(145, 69), txtPrecoVenda);

                        break;
                    case "Peso":
                        MudarTamanhoDoform(new Size(701, 485));
                        EsconderGruopBox(gpbEstoque);
                        DesabilitarGroupBoxDadosDoPeso(gpbDadosPeso);
                        MudarPosicaoDoBotao(new Point(12, 385));
                        MudarTamanhoDotxt(txt: txtPrecoVenda, size: new Size(164, 29));
                        MudarTamanhoDotxt(txt: txtPrecoCompra, size: new Size(164, 29));
                        MudarPosicaoDoTextBox(new Point(100, 29), txtPrecoCompra);
                        MudarPosicaoDoTextBox(new Point(100, 69), txtPrecoVenda);
                        DeixarTxtComoObrigatorio(ListaTxtPeso());
                        DefinirMaxLenghtDoTxtEstoque(tamanho: 3);
                        EsconderCheckBox();
                        MudarPosicaoDoGroupBoxTipoCadastro(new Point(174, 4));
                        LimparCheckBox();
                        MudarTextoDoComboBox(gpb: gpbDadosUnidade, texto: "Dados da venda por Peso");
                        MudarTextoDoComboBox(gpb: gpbDadosPeso, texto: "Porcentagem do lucro da venda");
                        MudarTextoDaLabel(lbl: lblPrecoCompra, texto: "Custo kilo");
                        MudarTextoDaLabel(lbl: lblPrecoVenda, texto: "Preço kilo");
                        //LimparTodosOsTxt();
                        break;


                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void MudarTamanhoDotxt(TextBox txt, Size size)
        {
            txt.Size = size;
        }

        private void MudarTextoDaLabel(Label lbl, string texto)
        {
            lbl.Text = texto;
        }



        private void MudarTextoDoComboBox(GroupBox gpb, string texto)
        {
            gpb.Text = texto;
        }

        private void FocarNoTxt(TextBox txt)
        {
            this.FocoNoTxt(txt);
        }



        private void LimparCheckBox()
        {
            ckbEstoque.Checked = false;
        }

        private void MostrarCheck()
        {
            ckbEstoque.Visible = true;
        }

        private void MudarPosicaoDoGroupBoxTipoCadastro(Point point)
        {
            gpbTipoCadastro.Location = point;
        }

        private void DefinirMaxLenghtDoTxtEstoque(int tamanho)
        {
            txtPorcentagem.MaxLength = tamanho;
        }

        private void EsconderCheckBox()
        {
            ckbEstoque.Visible = false;
        }

        private void DesabilitarGroupBox(GroupBox[] groupBox)
        {
            foreach (GroupBox gpb in groupBox)
            {
                gpb.Enabled = false;
            }
        }

        private void DeixarTxtComoNaoObrigatorio()
        {
            foreach (TextBox txt in TodosOsTxt())
            {
                if (txt.BackColor != Color.White)
                {
                    txt.BackColor = Color.White;
                }
            }
        }

        private void DeixarTxtComoObrigatorio(TextBox[] txtList)
        {

            try
            {

                foreach (TextBox txt in txtList)
                {
                    txt.BackColor = Color.Yellow;
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void DesabilitarGroupBoxDadosDoPeso(GroupBox gpb)
        {
            switch (cbbTipoCadastro.Text)
            {
                case "Unidade":
                    gpb.Enabled = false;
                    break;
                case "Peso":
                    gpb.Enabled = false;
                    break;

            }


        }


        private void LimparTodosOsTxt()
        {
            txtPrecoVenda.TextChanged -= txtPrecoVenda_TextChanged;
            txtPrecoCompra.TextChanged -= txtPrecoCompra_TextChanged;
            TextBox[] textBoxList = TodosOsTxt();
            foreach (TextBox txt in textBoxList)
            {
                txt.Text = string.Empty;
            }
            txtPrecoVenda.TextChanged += txtPrecoVenda_TextChanged;
            txtPrecoCompra.TextChanged += txtPrecoCompra_TextChanged;

        }

        private TextBox[] TodosOsTxt()
        {

            TextBox[] textBoxList = { txtCodigo, txtDescricao, txtEstoque, txtNome, txtPorcentagem, txtPrecoCompra, txtPrecoVenda, txtQtdMaxima, txtQtdMinima };

            return textBoxList;
        }

        private void MudarPosicaoDoBotao(Point point)
        {
            btnCadastrar.Location = point;
        }


        private void AparecerGruopBox(GroupBox gpb)
        {
            gpb.Visible = true;
        }

        private void MudarTamanhoDotxtDescricao(Size size)
        {
            txtDescricao.Size = size;
        }

        private void EsconderGruopBox(GroupBox gpb)
        {
            gpb.Visible = false;
        }

        private void MudarTamanhoDoform(Size size)
        {
            this.Size = size;
        }


        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {

            try
            {
                CalcularPorcentagem();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void txtPrecoCompra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularPorcentagem();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void CalcularPorcentagem()
        {

            try
            {

                txtPorcentagem.Text = Calcular.CalcularPorcentagem(txtPrecoCompra: txtPrecoCompra, txtPrecoVenda: txtPrecoVenda);

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {

            try
            {

                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCategoria(new Categoria(), EnumTipoOperacao.Salvar)) == DialogResult.Yes)
                {
                    CarregarCategoriaComSelecao();
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            ValidatorField.NoSpace(e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoTxt(txtNome);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoTxt(txtDescricao);
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoTxt(txtPrecoCompra);
            }
        }



        private void txtPrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidatorField.NoVirgula(e: e, sender: sender);
            ValidatorField.Money(e: e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoTxt(txtPrecoVenda);
            }
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.NoVirgula(e: e, sender: sender);
            ValidatorField.Money(e: e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoBotao();
            }
        }

        private void FocarNoBotao()
        {
            this.FocoNoBotao(btnCadastrar);
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.NoVirgula(e: e, sender: sender);
            ValidatorField.Integer(e: e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoTxt(txtQtdMinima);
            }
        }

        private void txtQtdMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoTxt(txtQtdMaxima);
            }
        }

        private void txtQtdMaxima_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoBotao();
            }
        }

        private void cbbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FocarNoTxt(txt: txtDescricao);
        }



        private void LimparTxt(List<TextBox> txtList)
        {

            try
            {

                foreach (var txt in txtList)
                {
                    if (txt is TextBox)
                    {
                        txt.Text = string.Empty;
                    }
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void ckbEstoque_CheckedChanged(object sender, EventArgs e)
        {

            try
            {

                if (ckbEstoque.Checked)
                {
                    AparecerGruopBox(gpbEstoque);
                    MudarTamanhoDoform(new Size(701, 572));
                    MudarPosicaoDoBotao(new Point(12, 471));
                    FocarNoTxt(txt: txtEstoque);
                }
                else if (ckbEstoque.Checked == false)
                {
                    EsconderGruopBox(gpbEstoque);
                    FocarNoTxt(txt: txtCodigo);
                    MudarTamanhoDoform(new Size(701, 485));
                    MudarPosicaoDoBotao(new Point(12, 385));
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }
    }
}
