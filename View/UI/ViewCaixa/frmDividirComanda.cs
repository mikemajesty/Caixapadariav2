using Controller.Enum;
using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewComanda;

namespace View.UI.ViewCaixa
{
    public partial class frmDividirComanda : Form
    {
        private int _parcelas = 2;
        List<BaixarEstoque> _listaProdutos;
        private TipoPagamentoRepositorio _tipoPagamentoRepositorio;
        private VendaRepositorio _vendaRepositorio;
        private CaixaRepositorio _caixaRepositorio;
        private ProdutoRepositorio _produtoRepositorio;
        private EstoqueRepositorio _estoqueRepositorio;
        private FiadoRepositorio _fiadoRepositorio;
        private MovimentacaoCaixaRepositorio _movimentacaoCaixaRepositorio;
        private const int Sucesso = 1;
        private decimal totalParaAutalizar = 0;
        private VendaComComandaAtivaRepositorio _vendaComComandaAtivaRepositorio;

        public frmDividirComanda(List<BaixarEstoque> listaProdutos)
        {
            _listaProdutos = listaProdutos;
            InitializeComponent();
        }
        private void InstanciarVendaComComandaAtivaRepositorio()
        {
            _vendaComComandaAtivaRepositorio = new VendaComComandaAtivaRepositorio();
        }
        private void InstanciarVendaRepositorio()
        {
            _vendaRepositorio = new VendaRepositorio();
        }
        private void InstanciarMovimentacaoCaixaRepositorio()
        {
            _movimentacaoCaixaRepositorio = new MovimentacaoCaixaRepositorio();
        }
        private void InstanciarTipoPagamentoRepositorio()
        {
            _tipoPagamentoRepositorio = new TipoPagamentoRepositorio();
        }
        private bool ConcluirVendaComCreditar()
        {

            try
            {
                bool retorno = false;
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString())
                {
                    if (OpenMdiForm.OpenForWithShowDialog(new frmClienteCreditar(EnumTipoCreditar.Vender)) == DialogResult.Yes)
                    {
                        InstanciarFiadoRepositorio();
                        _fiadoRepositorio.Cadastrar(new Fiado() { IDCliente = Cliente.ClienteIDStatic, IDFuncionario = Usuarios.IDStatic, Valor = GetTotalDividoPelaParcela() });
                        PosSalvamentoPadrao();
                        MensagemDeAviso();                      
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;

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
                throw new Exception(erro.Message);
            }


        }

        /*private void DeletarItensDaComanda()
        {

            try
            {

                InstanciarVendaComComandaAtivaRepositorio();
                foreach (var comanda in _listaComanda)
                {
                    _vendaComComandaAtivaRepositorio.DeletaItensDaComandaPorCodigo(comanda.Codigo);
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

          
        }*/

        private void MensagemDeAviso()
        {
            DialogMessage.MessageFullComButtonOkIconeDeInformacao("Venda concluída com sucesso.", "Aviso");
        }

        private void InstanciarFiadoRepositorio()
        {
            _fiadoRepositorio = new FiadoRepositorio();
        }
        private void frmDividirComanda_Load(object sender, EventArgs e)
        {

            try
            {
                AtualizarCaixa();
                totalParaAutalizar = GetValorTotal();
                JogaValorTotalNaLabel();
                GetValorTotal();
                CarregarTxtParcelaComZero();
                InstanciarTipoPagamentoRepositorio();
                CarregarComboBoxTipoPagamento();
                EsconderBotao();
              
                DesabilitarComboBox();

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

        private void AtualizarCaixa()
        {

            try
            {

                InstanciaCaixaRepositorio();
                Caixa caixa = _caixaRepositorio.GetValor();
                if (caixa != null)
                {
                    lblValorCaixa.Text = "Valor no Caixa" + caixa.Valor.ToString("C2");
                }
                else
                {
                    _caixaRepositorio.Cadastrar(new Caixa() { IDUsuario = Usuarios.IDStatic, Valor = 0 });
                    lblValorCaixa.Text = "Valor no Caixa" + caixa.Valor.ToString("C2");
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

        private void DesabilitarComboBox()
        {
            cbbTipoDePagamento.Enabled = false;
        }

        private void JogaValorTotalNaLabel()
        {

            lblTotalDaComanda.Text = GetValorTotal().ToString("C2");
        }

        private void EsconderBotao()
        {
            btnConcluirVenda.Visible = false;
        }

        private void CarregarComboBoxTipoPagamento()
        {

            try
            {
                _tipoPagamentoRepositorio.Listar(cbbTipoDePagamento);
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

        private void CarregarTxtParcelaComZero()
        {
            txtNumeroDeParcelas.Text = _parcelas.ToString();
        }
        private void txtNumeroDeParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e);
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {

            try
            {
                decimal valorPorParcela = GetValorPorParcela();
                lblTotalPorParcela.Text = Math.Round(valorPorParcela, 2).ToString();
                DesabilitarGroupBox(new List<GroupBox>() { gpbGerarParcelas, gpbNumeroDeParcelas });
                LimparTxt(new List<TextBox>() { txtValorPago });
                HabilitarComboBox();
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

        private void HabilitarComboBox()
        {
            cbbTipoDePagamento.Enabled = true;
        }

        private void DesabilitarGroupBox(List<GroupBox> list)
        {
            foreach (var gpb in list)
            {
                gpb.Enabled = false;
            }
        }

        private decimal GetValorPorParcela()
        {


            try
            {
                return (GetValorTotal() / _parcelas);
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                AdicionarNoTxt();
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

        private void AdicionarNoTxt()
        {
            try
            {

                if (!GetValorDoTxtQuantidadeDeParcelas().Equals("8"))
                {
                    txtNumeroDeParcelas.Text = (_parcelas += 1).ToString();
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

        private void SubtrairNoTxt()
        {

            try
            {

                if (!GetValorDoTxtQuantidadeDeParcelas().Equals("2"))
                {
                    txtNumeroDeParcelas.Text = (_parcelas -= 1).ToString();
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

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            try
            {
                SubtrairNoTxt();

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
        private Venda PopularVendaComDinheiro(Venda venda)
        {
            try
            {

                InstanciaCaixaRepositorio();
                decimal valorTroco = Convert.ToDecimal(txtTroco.Text.Substring(2, txtTroco.Text.Length - 2));
                if (_caixaRepositorio.GetValor().Valor < valorTroco)
                {
                    MyErro.MyCustomException("Valor do troco acima do valor no caixa, é necessário abrir o caixa para a venda ocorrer corretamente.");
                }
                venda = new Venda();
                venda.Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                venda.LucroTotal = GetLucroDivididoPelaParcela();
                venda.IDTIPOPAGAMENTO = _tipoPagamentoRepositorio.GetIDPeloNome(cbbTipoDePagamento.Text);
                venda.VendaTotal = GetTotalDividoPelaParcela();
                venda.IdUsuario = Usuarios.IDStatic;
                return venda;
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
        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            if (DialogMessage.MessageFullQuestion("Deseja confirmar essa forma de pagamento " + cbbTipoDePagamento.Text.ToUpper(), "Aviso") == DialogResult.Yes)
            {
                try
                {


                    InstanciarVendaRepositorio();
                    InstanciaCaixaRepositorio();
                    InstanciarProdutoRepositorio();
                    InstanciarEstoqueRepositorio();

                    if (_vendaRepositorio.Cadastrar(PopularVenda()) == Sucesso)
                    {

                        InserirVendaNoCaixaConcluirVendaDinheiro();
                        CocluirVendaCreditar();
                        ConcluirVendaComCartao();
                       //DeletarItensDaComanda();
                        if (totalParaAutalizar <= 0.4M)
                        {
                            this.DialogResult = DialogResult.Yes;
                            DarBaixaNoEstoque();
                        }
                    }




                }
                catch (CustomException erro)
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                    FocarNotxt();
                }
                catch (Exception erro)
                {
                    DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
                }
            }
        }

        private void CocluirVendaCreditar()
        {

            try
            {


                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString())
                {
                    if (ConcluirVendaComCreditar() == false)
                    {

                        _vendaRepositorio.ExcluirUltimaVenda();
                        DialogMessage.MessageFullComButtonOkIconeDeInformacao("Para concluir a venda no modo CREDITAR é necessário selecionar o cliente.", "Aviso");
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
        private void ConcluirVendaComCartao()
        {

            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Cartão.ToString())
                {
                    PosSalvamentoPadrao();
                    MensagemDeAviso();
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
        private void InserirVendaNoCaixaConcluirVendaDinheiro()
        {

            try
            {
                InstanciarMovimentacaoCaixaRepositorio();
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Dinheiro.ToString())
                {
                    if (_caixaRepositorio.Cadastrar(caixa: new Caixa() { IDUsuario = Usuarios.IDStatic, Valor = GetTotalDividoPelaParcela() }) == 1)
                    {
                        _movimentacaoCaixaRepositorio.Salvar(new MovimentacaoCaixa() { Valor = GetTotalDividoPelaParcela(), Data = DateTime.Now.DataNoFormatoDate() });
                        PosSalvamentoPadrao();
                        MensagemDeAviso();

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

        private void PosSalvamentoPadrao()
        {

            try
            {

                txtValorPago.LimparTxt();
                txtTroco.LimparTxt();
                FocarNotxt();
                AtualizaValorNaLabel();
                MostrarGroupBox(new List<GroupBox>() { gpbGerarTroco, gpbValorPago });
                cbbTipoDePagamento.SelectedIndex = 0;

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

        private void FocarNotxt()
        {
            this.FocoNoTxt(txtValorPago);
        }
        private void AtualizaValorNaLabel()
        {


            totalParaAutalizar -= GetValorPorParcela();
            lblTotalDaComanda.Text = totalParaAutalizar.ToString("C2");

        }
        private void AtulizarPrecoRestante()
        {
            throw new NotImplementedException();
        }
        private void DarBaixaNoEstoque()
        {

            try
            {
                InstanciarProdutoRepositorio();
                InstanciarEstoqueRepositorio();
                foreach (var prod in _listaProdutos)
                {
                    Produto produto = _produtoRepositorio.GetProdutoPorCodigoUnidade(prod.Codigo);
                    if (produto != null)
                    {
                        Model.Entidades.Estoque estoque = new Model.Entidades.Estoque()
                        {
                            ProdutoCodigo = prod.Codigo
                            ,
                            Quantidade = prod.Quantidade
                        };
                        _estoqueRepositorio.DarBaixa(produto, estoque);

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
        private Venda PopularVenda()
        {

            try
            {
                Venda venda = null;
                switch (cbbTipoDePagamento.Text)
                {
                    case "Dinheiro":
                        venda = PopularVendaComDinheiro(venda);
                        break;
                    case "Cartão":
                        venda = PopularVendaSemDinheiro(venda);
                        break;
                    case "Creditar":
                        venda = PopularVendaSemDinheiro(venda);
                        break;

                }

                return venda;

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
        private Venda PopularVendaSemDinheiro(Venda venda)
        {

            try
            {


                venda = new Venda();
                venda.Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                venda.LucroTotal = GetLucroDivididoPelaParcela();
                venda.IDTIPOPAGAMENTO = _tipoPagamentoRepositorio.GetIDPeloNome(cbbTipoDePagamento.Text);
                venda.VendaTotal = GetTotalDividoPelaParcela();
                venda.IdUsuario = Usuarios.IDStatic;
                return venda;

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

        private decimal GetTotalDividoPelaParcela()
        {
            try
            {

                return GetValorTotal() / _parcelas;

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

        private decimal GetLucroDivididoPelaParcela()
        {


            try
            {

                return GetLucroTotal() / _parcelas;

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
        private void InstanciarEstoqueRepositorio()
        {
            _estoqueRepositorio = new EstoqueRepositorio();
        }

        private void InstanciarProdutoRepositorio()
        {
            _produtoRepositorio = new ProdutoRepositorio();
        }

        private void InstanciaCaixaRepositorio()
        {
            _caixaRepositorio = new CaixaRepositorio();
        }



        private void MostrarBotao()
        {
            if (gpbGerarParcelas.Enabled == false)
            {
                btnConcluirVenda.Visible = true;
            }

        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {

            try
            {

                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Dinheiro.ToString())
                {

                    if (gpbGerarParcelas.Enabled == false)
                    {

                        ValidarVenda();
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

        private void ValidarVenda()
        {

            try
            {

                decimal valorPago = ValorPago.ValorPagoPeloCliente(txtValorPago);
                if (valorPago >= GetValorPorParcela())
                {
                    txtTroco.Text = Troco.GerarTroco(valorPago, GetValorPorParcela());
                    MostrarBotao();
                }
                else
                {
                    LimparTxt(new List<TextBox>() { txtTroco });
                    EsconderBotao();
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

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.NoVirgula(e, sender);
            ValidatorField.Money(e);
        }

        public string GetValorDoTxtQuantidadeDeParcelas()
        {
            try
            {

                return txtNumeroDeParcelas.Text == "" ? "0" : txtNumeroDeParcelas.Text;

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


        public decimal GetValorTotal()
        {
            try
            {
                decimal valor = 0;
                foreach (var prod in _listaProdutos)
                {
                    valor += prod.ValorTotal;
                }

                return valor;
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

        public decimal GetLucroTotal()
        {
            try
            {
                decimal valor = 0;
                foreach (var prod in _listaProdutos)
                {
                    valor += prod.LucroTotal;
                }
                return valor;
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

        private void cbbTipoDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTipoDePagamento.Text)
            {
                case "Dinheiro":
                    MostrarGroupBox(new List<GroupBox>() { gpbGerarTroco, gpbValorPago });
                    ValidarVenda();
                    FocarNotxt();
                    break;
                case "Cartão":
                    EsconderGroupBox(new List<GroupBox>() { gpbGerarTroco, gpbValorPago });
                    LimparTxt(new List<TextBox>() { txtTroco, txtValorPago });
                    MostrarBotao();
                    FocoNoBotao();
                    break;
                case "Creditar":
                    EsconderGroupBox(new List<GroupBox>() { gpbGerarTroco, gpbValorPago });
                    LimparTxt(new List<TextBox>() { txtTroco, txtValorPago });
                    MostrarBotao();
                    FocoNoBotao();
                    break;

            }
        }

        private void FocoNoBotao()
        {
            this.FocoNoBotao(btnConcluirVenda);
        }

        private void MostrarGroupBox(List<GroupBox> list)
        {
            foreach (var gpb in list)
            {
                gpb.Visible = true;
            }
        }

        private void LimparTxt(List<TextBox> list)
        {
            foreach (var txt in list)
            {
                txt.Text = string.Empty;
            }
        }

        private void EsconderGroupBox(List<GroupBox> list)
        {
            foreach (var gpb in list)
            {
                gpb.Visible = false;
            }
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {

            try
            {
                if (OpenMdiForm.OpenForWithShowDialog(new frmAdicionarCaixa(EnumTipoOperacaoCaixa.Adicionar)) == DialogResult.Yes)
                {
                    LimparTxt(new List<TextBox>() { txtTroco, txtValorPago });
                    AtualizarCaixa();
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

        private void HabilitarGroupBox(List<GroupBox> gpb)
        {
            foreach (var item in gpb)
            {
                item.Enabled = true;
            }
        }



        private void btnMudarParcelas_Click(object sender, EventArgs e)
        {
            try
            {

                LimparTxt(new List<TextBox>() { txtTroco, txtValorPago });
                ZerarValorDaParcela();
                HabilitarGroupBox(gpb: new List<GroupBox>() { gpbGerarParcelas, gpbNumeroDeParcelas });
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

        private void ZerarValorDaParcela()
        {
            lblTotalPorParcela.Text = "00 R$";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            try
            {

                this.Close();

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
