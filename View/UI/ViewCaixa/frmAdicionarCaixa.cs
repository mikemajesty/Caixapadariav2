using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Windows.Forms;
using View.Enum;

namespace View.UI.ViewCaixa
{
    public partial class frmAdicionarCaixa : Form
    {
        private CaixaRepositorio _caixaRepositorio;
        private MovimentacaoCaixaRepositorio _movimentacaoCaixaRepositorio;
        private EnumTipoOperacaoCaixa _enumTipoOperacaoCaixa;
        private const bool visible = true, invisible = false;
        private const int Sucesso = 1;
        public frmAdicionarCaixa(EnumTipoOperacaoCaixa enumTipoOperacaoCaixa)
        {
            _enumTipoOperacaoCaixa = enumTipoOperacaoCaixa;
            InitializeComponent();
        }

        private void InstanciarCaixaRepositorio()
                     => _caixaRepositorio = new CaixaRepositorio();
        private void frmAdicionarCaixa_Load(object sender, EventArgs e)
        {

            try
            {
                CarregarCaracteristicasDoForm();
                AtualizarCaixa();

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

        private void CarregarCaracteristicasDoForm()
        {
            switch (_enumTipoOperacaoCaixa)
            {
                case EnumTipoOperacaoCaixa.Adicionar:
                    MudaroTextoDoForm("Abrir caixa");
                    MudarVisaoDoBotao(btn: btnFechar, visao: invisible);
                    MudarVisaoDoBotao(btn: btnAdicionarNoCaixa, visao: visible);
                    break;
                case EnumTipoOperacaoCaixa.Fechar:
                    MudaroTextoDoForm("Fechar caixa");
                    MudarTextoDoGruopBox(gpb: gpbAdicionarNoCaixa, texto: "Remover do Caixa");
                    MudarVisaoDoBotao(btn: btnFechar, visao: visible);
                    MudarVisaoDoBotao(btn: btnAdicionarNoCaixa, visao: invisible);
                    break;

            }
        }

        private void MudarVisaoDoBotao(Button btn, bool visao)
                     => btn.Visible = visao;
        private void MudarTextoDoGruopBox(GroupBox gpb, string texto)
                     => gpb.Text = texto;
        private void MudaroTextoDoForm(string text)
                     => this.Text = text;
        private void AtualizarCaixa()
        {
            try
            {
                InstanciarCaixaRepositorio();
                lblTotalNoCaixa.Text = _caixaRepositorio.GetValor().Valor.ToString("C2");

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

        private void btnFechar_Click(object sender, EventArgs e)
        {

            try
            {
                InstanciarCaixaRepositorio();
                if (DialogMessage.MessageFullQuestion("Deseja fechar o caixa?", "Aviso") == DialogResult.Yes)
                {
                    if (_caixaRepositorio.Alterar(_caixaRepositorio.GetValor()) == Sucesso)
                    {
                        PosSalvamentoPadrao(texto: "Caixa fechado com sucesso.");
                      
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

        private void PosSalvamentoPadrao(string texto)
        {
            DialogMessage.MessageFullComButtonOkIconeDeInformacao(texto, "Aviso");
            this.DialogResult = DialogResult.Yes;
        }

        private void btnAdicionarNoCaixa_Click(object sender, EventArgs e)
        {

            try
            {

                InstanciarCaixaRepositorio();
                InstanciarMovimentacaoCaixaRepositorio();
                if (txtAdicionarNoCaixa.Text.Length > 0)
                {
                    decimal valor = Convert.ToDecimal(txtAdicionarNoCaixa.Text);
                    if (_caixaRepositorio.Cadastrar(new Caixa() { ID = _caixaRepositorio.GetValor().ID, IDUsuario = Usuarios.IDStatic, Valor = valor }) == Sucesso)
                    {
                        _movimentacaoCaixaRepositorio.Salvar(new MovimentacaoCaixa() { Valor = valor , Data = DateTime.Now.DataNoFormatoDate()});
                        PosSalvamentoPadrao(texto: "Caixa aberto com sucesso.");
                    }
                }
                else
                {
                    FocarNoTxt(txtAdicionarNoCaixa);
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
        private void InstanciarMovimentacaoCaixaRepositorio()
                     => _movimentacaoCaixaRepositorio = new MovimentacaoCaixaRepositorio();
        private void FocarNoTxt(TextBox txt)
                     => this.FocoNoTxt(txt);
        private void txtAdicionarNoCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.NoVirgula(e, sender);
            ValidatorField.Money(e);
        }
    }
}
