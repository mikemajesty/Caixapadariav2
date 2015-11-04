using Controller.Enum;
using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewComanda;
using View.UI.ViewEstoque;
using View.UI.ViewProduto;

namespace View.UI.ViewCaixa
{
    public partial class frmCaixa : Form
    {
        private frmMensagemDeEspera mensagem = null;
        private List<Comanda> comandList = new List<Comanda>();
        private TipoPagamentoRepositorio _tipoPagamentoRepositorio;
        private VendaComComandaAtivaRepositorio _vendaComComandaAtivaRepositorio;
        private ProdutoRepositorio _produtoRepositorio;
        private VendaRepositorio _vendaRepositorio;
        private UsuarioRepositorio _usuarioRepositorio;
        private CaixaRepositorio _caixaRepositorio;
        private EstoqueRepositorio _estoqueRepositorio;
        private List<Model.Entidades.Estoque> estoqueList = new List<Model.Entidades.Estoque>();
        private ComandaRepositorio _comandaRepositorio;
        private FiadoRepositorio _fiadoRepositorio;
        private ClienteRepositorio _clienteRepositorio;
        private List<Comanda> comandaLista;
        private MovimentacaoCaixaRepositorio _movimentacaoCaixaRepositorio;
        private MovimentacaoProdutoRepositorio _movimentacaoProdutoRepositorio;
        private frmGerenciarComanda formComanda;
        private TipoCadastroRepositorio _tipoCadastroRepositorio;
        private const bool Esconder = false, Mostrar = true, NaoExiste = false;
        private decimal VendaTotal;
        private const int Sucesso = 1, Insucesso = 0;

        public frmCaixa()
        {
            InitializeComponent();
        }
        private void InstanciarTipoCadastroRepositorio()
        {
            _tipoCadastroRepositorio = new TipoCadastroRepositorio();
        }
        private void InstanciarMovimentacaoProdutoRepositorio()
        {
            _movimentacaoProdutoRepositorio = new MovimentacaoProdutoRepositorio();
        }
        private void InstanciarMovimentacaoCaixa()
        {
            _movimentacaoCaixaRepositorio = new MovimentacaoCaixaRepositorio();
        }
        private void InstanciarClienteRepositorio()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }
        private void InstanciarFiadoRepositorio()
        {
            _fiadoRepositorio = new FiadoRepositorio();
        }
        private void InstanciarEstoqueRepositorio()
        {

            _estoqueRepositorio = new EstoqueRepositorio();
        }
        private void InstanciaCaixaRepositorio()
        {
            _caixaRepositorio = new CaixaRepositorio();
        }
        private void InstanciarComandaRepositorio()
        {
            _comandaRepositorio = new ComandaRepositorio();
        }
        private void InstanciaUsuarioRepositorio()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }
        private void InstanciarVendaRepositorio()
        {
            _vendaRepositorio = new VendaRepositorio();
        }
        private void frmCaixa_Load(object sender, EventArgs e)
        {


            try
            {

                if (Properties.Settings.Default.CaixaAberto == true)
                {
                    Properties.Settings.Default.CaixaAberto = false;
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao("O Caixa esta aberto, verifique o valor correto para evitar futuros problemas.", "Aviso");
                    Form frmAdd = new frmAdicionarCaixa(EnumTipoOperacaoCaixa.Fechar);
                    if (frmAdd.ShowDialog() == DialogResult.Yes)
                    {
                        CarregarValorDoCaixaAtualiza();
                        frmAdd.Close();
                    }
                    else
                    {

                        while (frmAdd.ShowDialog() != DialogResult.Yes)
                        {
                            if (frmAdd.ShowDialog() == DialogResult.Yes)
                            {
                                break;
                            }
                        }
                    }
                }

                InstanciaCaixaRepositorio();
                if (_caixaRepositorio.GetValor() == null)
                {
                    _caixaRepositorio.Cadastrar(new Caixa() { IDUsuario = Usuarios.IDStatic, Valor = 0 });
                }
                comandaLista = new List<Comanda>();
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                CarregarValorDoCaixaAtualiza();
                EsconderGpb();
                CarregarTxtQuantidadeComUm();
                EsconderOuMostrarButtonVenda(Esconder);
                InstanciaTipoPagamentoRepositorio();
                _tipoPagamentoRepositorio.Listar(cbb: cbbTipoDePagamento);
                FocarNoTxt(txtCodigoDaComanda);

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }



        private void CarregarValorDoCaixaAtualiza()
        {

            try
            {

                InstanciaCaixaRepositorio();
                if (_caixaRepositorio.GetValor() != null)
                {
                    lblTotalNoCaixa.Text = _caixaRepositorio.GetValor().Valor.ToString("C2");
                }
                else
                {
                    lblTotalNoCaixa.Text = (00.0).ToString("C2");
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void CarregarTxtQuantidadeComUm()
        {
            txtQuantidade.Text = "1";
        }


        private void EsconderOuMostrarButtonVenda(bool esconder)
        {
            if (esconder == Esconder)
            {
                btnConcluirVenda.Visible = false;
            }
            else
            {
                btnConcluirVenda.Visible = true;
            }
        }

        private void FocarNoTxt(TextBox txt)
        {

            try
            {
                this.FocoNoTxt(txt: txt);
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }
        private void InstanciaTipoPagamentoRepositorio()
        {
            _tipoPagamentoRepositorio = new TipoPagamentoRepositorio();
        }
        public void run()
        {
            mensagem = new frmMensagemDeEspera();
            mensagem.ShowDialog();
        }
        private void txtCodigoDaComanda_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                ValidatorField.IntegerAndLetter(e: e);
                ValidatorField.NoSpace(e);

                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    if (txtCodigoDaComanda.Text.Trim().Length > 0)
                    {
                        Espere espere = new Espere();
                        CarregarComandaAtiva(task: espere, metodo: run);
                        MostrarBotaoVendaSeExisteItensNaComanda();
                        LimparTxt(new List<TextBox>() { txtCodigoDaComanda });
                        FocarNoTxt(txtQuantidade);
                        espere.CancelarTask();
                        if (espere.Cancel.IsCancellationRequested)
                        {
                            if (mensagem != null)
                            {
                                mensagem.Close();
                            }

                        }
                    }
                    else
                    {
                        CarregarComandaEmUso();

                    }

                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void CarregarComandaEmUso()
        {
            try
            {
                formComanda = new frmGerenciarComanda(EnumComanda.Comanda);
                if (formComanda.ShowDialog() == DialogResult.Yes)
                {
                    txtCodigoDaComanda.Text = Comanda.CodigoComanda.ToString();
                    SendKeys.SendWait("{ENTER}");
                }
            }
            catch (CustomException erro2)
            {
                throw new CustomException(erro2.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }

        private void MostrarBotaoVendaSeExisteItensNaComanda()
        {


            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Cartão.ToString() ||
                cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString())
                {
                    if (VerificarSeExisteItensNoListView() > 0)
                    {
                        EsconderOuMostrarButtonVenda(Mostrar);
                    }
                    else
                    {
                        FocarNoTxt(txt:txtCodigoDoProduto);
                    }
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }


        private void CarregarComandaAtiva(Espere task, Action metodo)
        {

            try
            {
                InstanciarVendaComComandaAtivaRepositorio();
                InstanciarComandaRepositorio();
                Comanda comanda = _comandaRepositorio.GetComandaPorCodigo(txtCodigoDaComanda.Text);
                if (comanda != null)
                {
                    if (_comandaRepositorio.Inserir(comandaLista, comanda))
                    {
                        task.Start(metodo);
                        comandaLista.Add(comanda);
                        _vendaComComandaAtivaRepositorio.GetItensnaComandaPorCodigo(comanda.Codigo, ltvProdutos);
                        GetValorNaComanda();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Comanda não esta cadastrada.");
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }


        private int VerificarSeExisteItensNoListView()
        {

            try
            {
                return ltvProdutos.Items.Count;
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

        private decimal GetValorNaComanda()
        {

            try
            {
                decimal sum = 0;

                foreach (ListViewItem lstItem in ltvProdutos.Items)
                {
                    sum += decimal.Parse(lstItem.SubItems[3].Text);
                }
                lblTotalVenda.Text = sum.ToString("C2");
                VendaTotal = sum;
                return sum;
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
        private decimal GetValorLucroTotal()
        {

            try
            {
                decimal lucro = 0;
                foreach (ListViewItem lstItem in ltvProdutos.Items)
                {
                    lucro += decimal.Parse(lstItem.SubItems[4].Text);
                }
                return lucro;
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
        private void InstanciarVendaComComandaAtivaRepositorio()
        {
            _vendaComComandaAtivaRepositorio = new VendaComComandaAtivaRepositorio();
        }



        private void cbbTipoDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                LimparTxt(new List<TextBox>() { txtValorPago, txtTroco });
                switch (cbbTipoDePagamento.Text)
                {
                    case "Dinheiro":
                        MostrarGpb();
                        if (VerificarSeExisteItensNoListView() > 0)
                        {
                            FocarNoTxt(txtValorPago);
                            decimal valorPago = ValorPago.ValorPagoPeloCliente(txtValorPago);
                            decimal valorDaComanda = GetValorNaComanda();
                            if (valorPago >= valorDaComanda)
                            {
                                EsconderOuMostrarButtonVenda(Mostrar);
                                this.FocoNoBotao(btnConcluirVenda);
                            }
                            else
                            {
                                EsconderOuMostrarButtonVenda(Esconder);
                            }

                        }
                        else
                        {
                            FocarNoTxt(txt:txtCodigoDoProduto);
                        }
                        break;
                    case "Cartão":
                        EsconderGpb();
                        HabilitarBotaoVenda();
                        MostrarBotaoVendaSeExisteItensNaComanda();
                        break;
                    case "Creditar":
                        MostrarBotaoVendaSeExisteItensNaComanda();
                        HabilitarBotaoVenda();
                        EsconderGpb();
                        break;

                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void HabilitarBotaoVenda()
        {
            if (VerificarSeExisteItensNoListView() > 0)
            {
                EsconderOuMostrarButtonVenda(Mostrar);
            }
        }
        private void MostrarGpb()
        {
            EsconderGroupBoxOuMostrar(listGpb: new List<GroupBox>() { gpbGerarTroco, gpbValorPago }, esconder: Mostrar);
        }
        private void EsconderGpb()
        {
            EsconderGroupBoxOuMostrar(listGpb: new List<GroupBox>() { gpbGerarTroco, gpbValorPago }, esconder: Esconder);
        }

        private void EsconderGroupBoxOuMostrar(List<GroupBox> listGpb, bool esconder)
        {

            try
            {
                listGpb.ForEach(c => c.Visible = (c is GroupBox) && esconder == Esconder ? Esconder : Mostrar);
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
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
                        InstanciarMovimentacaoProdutoRepositorio();
                        ConcluirVendaComDinheiro();
                        ConcluirVendaComCreditar();
                        ConcluirVendaComCartao();
                    }
                }
                catch (CustomException erro)
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                }
                catch (Exception erro)
                {
                    SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                    DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
                }
                finally
                {
                    AtualizarQuandroDeAvisos();
                }
            }
        }

        private static void AtualizarQuandroDeAvisos()
        {


            try
            {
                frmAlertaEstoque form = (frmAlertaEstoque)Application.OpenForms[name: nameof(frmAlertaEstoque)];
                if (form != null)
                {
                    form.CarregarDgv();
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, "frmCaixa");
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void ConcluirVendaComCreditar()
        {

            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString())
                {
                    if (VendaComCreditar() == false)
                    {
                        _vendaRepositorio.ExcluirUltimaVenda();
                        DialogMessage.MessageFullComButtonOkIconeDeInformacao("Para concluir a venda no modo CREDITAR é necessário selecionar o cliente.", "Aviso");
                    }
                    else
                    {
                        PosSalvamentoPadrao();
                        DarBaixaNoEstoque();
                        FocarNoTxt(txt:txtCodigoDoProduto);
                    }
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void ConcluirVendaComCartao()
        {

            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Cartão.ToString())
                {
                    DarBaixaNoEstoque();
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
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void JogarNovoValorParaCaixa()
        {

            try
            {
                CarregarValorDoCaixaAtualiza();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private bool VendaComCreditar()
        {

            try
            {
                bool retorno = false;
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString())
                {
                    if (OpenMdiForm.OpenForWithShowDialog(new frmClienteCreditar(EnumTipoCreditar.Vender)) == DialogResult.Yes)
                    {
                        InstanciarFiadoRepositorio();
                        _fiadoRepositorio.Cadastrar(new Fiado() { IDCliente = Cliente.ClienteIDStatic, IDFuncionario = Usuarios.IDStatic, Valor = VendaTotal });                        
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

        private void ConcluirVendaComDinheiro()
        {

            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Dinheiro.ToString())
                {

                    if (_caixaRepositorio.Cadastrar(caixa: new Caixa() { IDUsuario = Usuarios.IDStatic, Valor = VendaTotal }) == 1)
                    {
                        InstanciarMovimentacaoCaixa();
                        int resultado = _movimentacaoCaixaRepositorio.Salvar(new MovimentacaoCaixa() { Valor = VendaTotal, Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) });
                        if (resultado > 0)
                        {                            
                            DarBaixaNoEstoque();
                            JogarNovoValorParaCaixa();
                            PosSalvamentoPadrao();
                            MensagemDeAviso();
                        }


                    }
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void MensagemDeAviso()
        {
            timer.Start();
            DialogMessage.MessageFullComButtonOkIconeDeInformacao("Venda concluída com sucesso.", "Aviso");

        }

        private void DarBaixaNoEstoque()
        {

            try
            {

                foreach (ListViewItem lstItem in ltvProdutos.Items)
                {
                    Produto produto = _produtoRepositorio.GetProdutoPorCodigoUnidade(lstItem.SubItems[1].Text);
                    if (produto != null)
                    {
                        Model.Entidades.Estoque estoque = new Model.Entidades.Estoque() { ProdutoCodigo = lstItem.SubItems[1].Text, Quantidade = Convert.ToInt32(lstItem.SubItems[2].Text) };
                        _estoqueRepositorio.DarBaixa(produto, estoque);
                    }
                    _movimentacaoProdutoRepositorio.Cadastrar(new MovimentacaoProduto()
                    {
                        Codigo = lstItem.SubItems[1].Text,
                        Data = DateTime.Now.DataNoFormatoDate(),
                        Quantidade = lstItem.SubItems[2].Text == "Peso" ? 0 : Convert.ToInt32(lstItem.SubItems[2].Text),
                        Valor = Convert.ToDecimal(lstItem.SubItems[3].Text)
                    });



                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void PosSalvamentoPadrao()
        {

            try
            {
                ExcluirComandaAtiva();
                LimparTxt(new List<TextBox>() { txtCodigoDaComanda, txtCodigoDoProduto, txtTroco, txtValorPago });
                CarregarTxtQuantidadeComUm();
                ZerarTotalVenda();
                ZerarListView();
                EsconderOuMostrarButtonVenda(Esconder);
                ZerarLabelTotalVenda();
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                DesmarcarCheckBox();
                FocarNoTxt(txtCodigoDaComanda);
                cbbTipoDePagamento.SelectedIndex = 0;

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void ExcluirComandaAtiva()
        {

            try
            {

                if (comandaLista.Count > 0)
                {
                    InstanciarVendaComComandaAtivaRepositorio();
                    int contador = 0;
                    comandaLista.ForEach(c => contador = _vendaComComandaAtivaRepositorio.DeletaItensDaComandaPorCodigo(c.Codigo));
                    if (contador > 0)
                    {
                        comandaLista.Clear();
                    }
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void ZerarLabelTotalVenda()
        {
            lblTotalVenda.Text = "0,00 R$";
        }

        private void ZerarListView()
        {
            ltvProdutos.Items.Clear();
        }

        private void ZerarTotalVenda()
        {
            VendaTotal = 0;
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
                venda.LucroTotal = GetValorLucroTotal();
                venda.IDTIPOPAGAMENTO = _tipoPagamentoRepositorio.GetIDPeloNome(cbbTipoDePagamento.Text);
                venda.VendaTotal = GetValorNaComanda();
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

        private Venda PopularVendaComDinheiro(Venda venda)
        {
            try
            {
                InstanciaCaixaRepositorio();
                decimal valorTroco = GetValorTroco();
                if (_caixaRepositorio.GetValor().Valor < valorTroco)
                {
                    MyErro.MyCustomException($"Você não possui {GetValorTroco()} no caixa. Atualize o valor ou adicione valor ao mesmo.");
                }
                venda = new Venda();
                venda.Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                venda.LucroTotal = GetValorLucroTotal();
                venda.IDTIPOPAGAMENTO = _tipoPagamentoRepositorio.GetIDPeloNome(cbbTipoDePagamento.Text);
                venda.VendaTotal = VendaTotal;
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

        private decimal GetValorTroco()
        {
            try
            {
                return Convert.ToDecimal(txtTroco.Text.Substring(2, txtTroco.Text.Length - 2));
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

        private void txtCodigoDoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ValidatorField.IntegerAndLetter(e);
                ValidatorField.NoSpace(e);
                string codigo = txtCodigoDoProduto.Text;
                if ((Keys)e.KeyChar == Keys.Enter && codigo.Length > 0)
                {
                    if (ckbPorPeso.Checked)
                    {

                        InstanciarProdutoRepositorio();
                        InstanciarTipoCadastroRepositorio();
                        Produto prod = _produtoRepositorio.GetProdutoPorCodigo(codigo);
                        if (prod.TipoCadastro == _tipoCadastroRepositorio.GetIDPeloNome(EnumTipoCadastro.Unidade.ToString()))
                        {
                            ChecarChebox(ckb: ckbPorPeso, checado: false);
                            LimparTxt(new List<TextBox> { txtPesoDoProduto });
                            VenderPorUnidade(codigo);
                        }
                        else
                        {
                            VenderPorPeso(codigo);
                        }

                    }
                    else
                    {
                        VenderPorUnidade(codigo);
                    }


                }
                else if ((Keys)e.KeyChar == Keys.Enter && txtCodigoDoProduto.Text.Length == 0)
                {

                    txtCodigoDoProduto_DoubleClick(txtCodigoDoProduto, e);
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                LimparTxt(new List<TextBox>() { txtCodigoDoProduto });
                FocarNoTxt(txtCodigoDoProduto);
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void VenderPorPeso(string codigo)
        {
            try
            {
                decimal peso = 0;
                if (txtPesoDoProduto.Text.Contains("0,"))
                {
                    string temp = txtPesoDoProduto.Text.Substring(2, txtPesoDoProduto.Text.Length - 2);
                    peso = txtPesoDoProduto.Text == "" ? 0 : Convert.ToDecimal(temp);
                }
                else
                {
                    peso = txtPesoDoProduto.Text == "" ? 0 : Convert.ToDecimal(txtPesoDoProduto.Text.Replace(",", ""));
                }

                if (peso > 0)
                {

                    _produtoRepositorio.AdicionarProdutoParaVendaPorPeso(ltvProdutos, codigo, peso);
                    GetValorNaComanda();
                    LimparTxt(new List<TextBox>() { txtCodigoDoProduto });
                    MostrarBotaoVendaSeExisteItensNaComanda();
                    EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                    DesmarcarCheckBox();
                    LimparTxt(new List<TextBox>() { txtValorPago });
                    CarregarTxtQuantidadeComUm();
                }
                else
                {
                    MyErro.MyCustomException("Digite o peso do item vendido.");
                    FocarNoTxt(txtPesoDoProduto);
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                LimparTxt(new List<TextBox>() { txtCodigoDoProduto });
                FocarNoTxt(txtCodigoDoProduto);
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void VenderPorUnidade(string codigo)
        {
            try
            {
                DialogResult dialogResult = DialogResult.OK;
                if (Convert.ToInt32(txtQuantidade.Text) > 20)
                {
                    dialogResult = DialogMessage.MessageFullQuestion("Deseja vender " + txtQuantidade.Text + " produtos?", "Aviso");
                }
                if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
                {
                    if (txtQuantidade.Text == "0" || txtQuantidade.Text == "00" || txtQuantidade.Text == "000")
                    {
                        LimparTxt(new List<TextBox>() { txtQuantidade });
                        FocarNoTxt(txtQuantidade);
                        DialogMessage.MessageFullComButtonOkIconeDeInformacao("Não é possível vende um produto com o campo Quantidade com 0", "Aviso");
                    }
                    else if (txtQuantidade.Text.Length == 0)
                    {
                        FocarNoTxt(txtQuantidade);
                        DialogMessage.MessageFullComButtonOkIconeDeInformacao("Não é possível vende um produto com o campo Quantidade vazio.", "Aviso");
                    }
                    else
                    {
                        InstanciarProdutoRepositorio();
                        _produtoRepositorio.AdicionarProdutoParaVenda(ltvProdutos, codigo, Convert.ToInt32(txtQuantidade.Text));
                        GetValorNaComanda();
                        LimparTxt(new List<TextBox>() { txtCodigoDoProduto });
                        MostrarBotaoVendaSeExisteItensNaComanda();
                        EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                        DesmarcarCheckBox();
                        LimparTxt(new List<TextBox>() { txtValorPago });
                        CarregarTxtQuantidadeComUm();
                    }
                }
                else
                {
                    FocarNoTxt(txt: txtQuantidade);
                    LimparTxt(new List<TextBox> { txtQuantidade });
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                LimparTxt(new List<TextBox>() { txtCodigoDoProduto });
                FocarNoTxt(txtCodigoDoProduto);
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void ChecarChebox(CheckBox ckb, bool checado)
        {
            ckb.Checked = checado;
        }

        private void DesmarcarCheckBox()
        {
            ckbPorPeso.Checked = false;
        }

        private void InstanciarProdutoRepositorio()
        {
            _produtoRepositorio = new ProdutoRepositorio();
        }
        private void LimparTxt(List<TextBox> txtList)
        {
            txtList.ForEach(c => c.Text = string.Empty);
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbTipoDePagamento.Text == EnumTipoPagamento.Dinheiro.ToString())
                {
                    decimal valorPago = ValorPago.ValorPagoPeloCliente(txtValorPago);
                    decimal valorDaComanda = GetValorNaComanda();
                    if (ltvProdutos.Items.Count > 0 && valorPago >= valorDaComanda)
                    {
                        txtTroco.Text = Troco.GerarTroco(valorPago, valorDaComanda);
                        EsconderOuMostrarButtonVenda(Mostrar);
                    }
                    else
                    {
                        LimparTxt(new List<TextBox>() { txtTroco });
                        EsconderOuMostrarButtonVenda(Esconder);
                    }


                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }


        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidatorField.Integer(e);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                FocarNoTxt(txtCodigoDoProduto);
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidatorField.NoVirgula(e: e, sender: sender);
            ValidatorField.Money(e: e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtTroco.Text.Length > 0)
                {
                    FocarNoBtn(btn: btnConcluirVenda);
                }
            }

        }

        private void FocarNoBtn(Button btn)
        {
            this.ActiveControl = btn;
        }

        private void txtValorDoProdutoPorpeso_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                FocarNoTxt(txtCodigoDoProduto);
            }
            else
            {
                ValidatorField.Peso(e: e, sender: sender);
            }

        }

        private void ckbPorPeso_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbPorPeso.Checked)
            {
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Esconder);
                LimparTxt(new List<TextBox>() { txtPesoDoProduto });
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbQuantidadeDoProduto }, Mostrar);
                FocarNoTxt(txtQuantidade);
            }
            else
            {
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbValorPorPeso }, Mostrar);
                EsconderGroupBoxOuMostrar(new List<GroupBox>() { gpbQuantidadeDoProduto }, Esconder);
                FocarNoTxt(txtPesoDoProduto);
            }
        }




        private void ltvProdutos_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                InstanciarProdutoRepositorio();
                Produto produto = _produtoRepositorio.GetProdutoPorCodigo(MyListView.RetornarValorPeloIndexDaColuna(ltvProdutos, 1));
                if (produto != null)
                {
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(produto, EnumTipoOperacao.ListView)) == DialogResult.Yes)
                    {
                        if (MyListView.RemoverItem(ltvProdutos))
                        {
                            GetValorNaComanda();
                            LimparTxt(new List<TextBox>() { txtValorPago });
                            FocarNoTxt(txt: txtValorPago);
                        }
                    }
                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }



        }



        private void ltvProdutos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {

            try
            {

                MyListView.ColumnWidthChanging(e, ltvProdutos);
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }



        }



        private void btnReceberCredito_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.OpenForWithShowDialog(new frmClienteCreditar(EnumTipoCreditar.Pagar));
                CarregarValorDoCaixaAtualiza();


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {

            try
            {
                Calculadora.ChamarCalculadora();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void btnDividirComanda_Click(object sender, EventArgs e)
        {

            try
            {
                if (MyListView.VerificarSeExisteItensNoListView(ltvProdutos) > 0)
                {
                    InstanciarMovimentacaoProdutoRepositorio();
                    List<BaixarEstoque> lista = new List<BaixarEstoque>();
                    foreach (var item in MyListView.RetornarValoresParaDarBaixaNoEstoque(ltvProdutos))
                    {
                        lista.Add(item);
                        _movimentacaoProdutoRepositorio.Cadastrar(PopulaMovimentacaoProduto(item));
                    }

                    if (OpenMdiForm.OpenForWithShowDialog(new frmDividirComanda(lista)) == DialogResult.Yes)
                    {
                        CarregarValorDoCaixaAtualiza();
                        PosSalvamentoPadrao();
                        ExcluirComandaAtiva();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Não é possível parcelar uma venda inexistente.");
                }



            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private static MovimentacaoProduto PopulaMovimentacaoProduto(BaixarEstoque item)
        {
            MovimentacaoProduto produto = new MovimentacaoProduto();

            produto.Codigo = item.Codigo;
            produto.Data = DateTime.Now.DataNoFormatoDate();
            produto.Valor = item.ValorTotal;
            produto.Quantidade = item.Quantidade;
            return produto;

        }

        private void txtCodigoDoProduto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (OpenMdiForm.OpenForWithShowDialog(new frmPesquisarProduto(EnumMovimentacao.Pesquisa))
                    == DialogResult.Yes)
                {
                    (sender as TextBox).Text = Produto.CodigoDoProduto;
                    SendKeys.SendWait("{ENTER}");
                    CarregarTxtQuantidadeComUm();

                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void ltvProdutos_Click(object sender, EventArgs e)
        {

            try
            {
                ltvProdutos_DoubleClick(sender, e);
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void txtCodigoDaComanda_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CarregarComandaEmUso();

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {

            try
            {

                if (OpenMdiForm.OpenForWithShowDialog(new frmAdicionarCaixa(EnumTipoOperacaoCaixa.Adicionar)) == DialogResult.Yes)
                {
                    CarregarValorDoCaixaAtualiza();
                    FocarNoTxt(txtCodigoDaComanda);
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            try
            {

                if (OpenMdiForm.OpenForWithShowDialog(new frmAdicionarCaixa(EnumTipoOperacaoCaixa.Fechar)) == DialogResult.Yes)
                {

                    CarregarValorDoCaixaAtualiza();
                    FocarNoTxt(txtCodigoDaComanda);
                    LimparTxt(new List<TextBox>() { txtValorPago, txtTroco, txtPesoDoProduto });
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void cbbTipoDePagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (btnConcluirVenda.Visible == true)
                {
                    FocarNoBtn(btnConcluirVenda);
                }
                else if (cbbTipoDePagamento.Text == EnumTipoPagamento.Cartão.ToString()
                    && ltvProdutos.Items.Count == 0)
                {
                    FocarNoTxt(txtCodigoDoProduto);
                }
                else if(cbbTipoDePagamento.Text == EnumTipoPagamento.Creditar.ToString()
                    && ltvProdutos.Items.Count == 0)
                {
                    FocarNoTxt(txtCodigoDoProduto);
                }
                else
                {
                    FocarNoCbb(cbbTipoDePagamento);
                }
            }
           
        }

        private void btnSairDoMenu_Click(object sender, EventArgs e)
        {
            btnOperacoes.HideDropDown();
            FocarNoTxt(txtCodigoDoProduto);
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            try
            {
                SendKeys.Send("{ENTER}");
                timer.Stop();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.F1:
                    FocarNoTxt(txtCodigoDaComanda);
                    break;
                case Keys.F2:
                    if (ckbPorPeso.Checked == false)
                    {
                        ChecarChebox(ckbPorPeso, true);
                    }
                    else
                    {
                        ChecarChebox(ckbPorPeso, false);
                    }
                    break;
                case Keys.F3:
                    if (txtQuantidade.Visible == true)
                    {
                        FocarNoTxt(txtQuantidade);
                    }
                    else
                    {
                        ChecarChebox(ckbPorPeso, false);
                    }
                    break;
                case Keys.F4:
                    FocarNoTxt(txtCodigoDoProduto);
                    break;
                case Keys.F5:
                    FocarNoCbb(cbb:cbbTipoDePagamento);
                    cbbTipoDePagamento.DroppedDown = true;
                    break;
                case Keys.F6:
                    if (cbbTipoDePagamento.Text == EnumTipoPagamento.Dinheiro.ToString())
                    {
                        FocarNoTxt(txtValorPago);
                    }
                    break;
                case Keys.F7:
                    btnCalculadora.PerformClick();
                    break;
                case Keys.F8:
                    btnOperacoes.ShowDropDown();
                    btnReceberCredito.Select();
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    if (btnConcluirVenda.Visible == true)
                    {
                        btnConcluirVenda.PerformClick();
                    }                   
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

     

        private void FocarNoCbb(ComboBox cbb)
        {
            this.ActiveControl = cbb;
        }
    }
}
