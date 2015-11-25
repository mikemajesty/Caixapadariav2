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

namespace View.UI.ViewSangria
{
    public partial class frmCriarSangria : Form
    {
        private CaixaRepositorio _caixaRepositorio;
        public frmCriarSangria()
        {
            InitializeComponent();
        }
        public void InstanciaCaixaRepositorio()
                    => _caixaRepositorio = new CaixaRepositorio();
        private void frmSangria_Load(object sender, EventArgs e)
        {

            try
            {
                CarregarCaixa();
                FocarNoTxt(txt: txtValorSangria);
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
                var resultSangriaSalvar = new SangriaRepositorio().Salvar(PreencherSangria());
                if (resultSangriaSalvar == true)
                {
                    InstanciaCaixaRepositorio();
                    var caixa = _caixaRepositorio.GetValor();
                    var sangria = Convert.ToDecimal(txtValorSangria.Text);
                    var resultCaixaRetirar = _caixaRepositorio.Retirar(new Caixa { ID = caixa.ID, IDUsuario = caixa.IDUsuario, Valor = (caixa.Valor - sangria) });
                    if (resultCaixaRetirar > 0)
                    {
                        this.DialogResult = DialogResult.Yes;                      
                    }
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

        private Sangria PreencherSangria()
                        => new Sangria
                        {
                            valor = Convert.ToDecimal(txtValorSangria.Text),
                            Descricao = txtDescricao.Text,
                            UsuarioID = Usuarios.IDStatic
                        };
    }
}
