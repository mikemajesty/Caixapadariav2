using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Enum;

namespace View.UI.ViewSangria
{
    public partial class frmCriarSangria : Form
    {
        private CaixaRepositorio _caixaRepositorio;
        private EnumSangria _enumSangria;
        private SangriaViewModel _sangria;
        public frmCriarSangria(EnumSangria enumSangria, SangriaViewModel sangria)
        {
            _enumSangria = enumSangria;
            _sangria = sangria;
            InitializeComponent();
        }
        public void InstanciaCaixaRepositorio()
                    => _caixaRepositorio = new CaixaRepositorio();
        private void frmSangria_Load(object sender, EventArgs e)
        {

            try
            {
                switch (_enumSangria)
                {
                    case EnumSangria.Exibir:
                        PreencherCampos();
                        MudarTextoDoButton();
                        MudarCorDoButton();
                        //------size------
                        //168; 100 gpb
                        //137; 35 txt
                        //415; 382 frm
                        //-----location-----
                        //14; 286 btn
                        MudarTamanhoDoGroupBox(gpb: gpbValores, size: new Size(367, 100));
                        MudarTamanhoDoTextBox(txt: txtValorSangria, size: new Size(334, 35));
                        EsconderOuMostrarGroupBox(gpb: gpbCaixa);
                        MudarPosicaoDoButton(btn: btnRetirar, location: new Point(16, 356));
                        EsconderOuMostrarGroupBox(gpb: gpbUsuario, mostrarOuEsconder: true);
                        DesabilitarTextBox(txtDescricao);
                        DesabilitarTextBox(txtValorSangria);
                        MudarTamanhoDoForm(new Size(415, 452));
                        break;
                    case EnumSangria.Criar:
                        CarregarCaixa();
                        FocarNoTxt(txt: txtValorSangria);
                        MudarTamanhoDoGroupBox(gpbValores, new Size(168, 100));
                        MudarTamanhoDoTextBox(txtValorSangria, new Size(137, 35));
                        EsconderOuMostrarGroupBox(gpbUsuario);
                        MudarPosicaoDoButton(btnRetirar, new Point(14, 286));
                        MudarTamanhoDoForm(new Size(415, 382));
                        break;
                }

            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

        }

        private void MudarPosicaoDoButton(Button btn, Point location)
                     => GerenciarButton.MudarPosicao(btn, location);

        private void EsconderOuMostrarGroupBox(GroupBox gpb, bool mostrarOuEsconder = false)
                     => GerenciarGroupBox.EsconderOuMostrar(gpb, mostrarOuEsconder);

        private void MudarTamanhoDoTextBox(TextBox txt, Size size)
                     => GerenciarTextBox.MudarTamanho(txt, size);
        private void MudarTamanhoDoGroupBox(GroupBox gpb, Size size)
                     => GerenciarGroupBox.MudarTamanho(gpb, size);
        private void DesabilitarTextBox(TextBox txt, bool desativarOuHabilitar = false)
                     => GerenciarTextBox.DesabilitarOuHabilitar(txt, desativarOuHabilitar);
        private void MudarTamanhoDoForm(Size size)
                     => GerenciarForm.MudarTamanho(this, size);
        private void MudarCorDoButton()
                     => btnRetirar.BackColor = Color.Silver;
        private void MudarTextoDoButton()
                     => btnRetirar.Text = "Sair";
        private void PreencherCampos()
        {
            if (_sangria != null)
            {
                txtDescricao.Text = _sangria.Descricao;
                txtValorSangria.Text = _sangria.Valor.ToString("C2");
                lblNomeUsuario.Text = _sangria.Usuário;
            }
        }

        private void FocarNoTxt(TextBox txt)
                     => this.FocoNoTxt(txt);
        private void CarregarCaixa()
        {
            InstanciaCaixaRepositorio();
            Caixa caixa = _caixaRepositorio.GetValor();
            if (caixa != null)
            {
                lblValorCaixa.Text = caixa.Valor.ToString("C2");
            }
            else
            {
                _caixaRepositorio.Cadastrar(new Caixa() { IDUsuario = Usuarios.IDStatic, Valor = 0 });
                lblValorCaixa.Text = caixa.Valor.ToString("C2");
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                FocarNoBtn(btn: btnRetirar);
            }
        }
        private void FocarNoBtn(Button btn)
                     => this.FocoNoBotao(btn);
        private void txtValorSangria_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Money(e);
            ValidatorField.NoVirgula(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if ((sender as TextBox).Text.Length == 0)
                {
                    FocarNoTxt(txt: txtDescricao);
                }

            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {

            try
            {
                switch (_enumSangria)
                {
                    case EnumSangria.Exibir:
                        FecharForm();
                        break;
                    case EnumSangria.Criar:
                        var resultSangriaSalvar = new SangriaRepositorio().Salvar(PreencherSangria());
                        if (resultSangriaSalvar == true)
                        {
                            InstanciaCaixaRepositorio();
                            var caixa = _caixaRepositorio.GetValor();
                            var sangria = Convert.ToDecimal(txtValorSangria.Text);
                            var resultCaixaRetirar = _caixaRepositorio.Retirar(
                                new Caixa
                                {
                                    ID = caixa.ID,
                                    IDUsuario = caixa.IDUsuario,
                                    Valor = (caixa.Valor - sangria)
                                });
                            new MovimentacaoCaixaRepositorio().RetirarValor(valor: sangria, data: DateTime.Now);
                            if (resultCaixaRetirar > 0)
                            {
                                this.DialogResult = DialogResult.Yes;
                            }
                        }
                        break;

                }


            }
            catch (CustomException error)
            {
                FocarNoTxt(txtValorSangria);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

        }

        private void FecharForm()
                     => this.Close();
        private Sangria PreencherSangria()
        {
            decimal valor = txtValorSangria.Text.Length == 0 ?
                0 : Convert.ToDecimal(txtValorSangria.Text);
            return new Sangria
            {
                valor = valor,
                Descricao = txtDescricao.Text,
                UsuarioID = Usuarios.IDStatic
            };
        }

    }
}
