using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View.UI.ViewLogin
{
    public partial class frmLogin : Form
    {
        private const bool Existe = true;
        private KeyGenRepositorio _keyGenRepositorio;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

            try
            {
                this.FocoNoTxt(txt: txtLogin);
                InstanciarKeyGenRepositorio();
                if (_keyGenRepositorio.GetDiasTrail() == 0)
                {
                    lblExpirar.Text = "Atenção sua licença expirou";
                }
                else
                {
                    lblExpirar.Text = "Atenção " + _keyGenRepositorio.GetDiasTrail().ToString("00") + " para expirar o Programa";
                   
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

        private void InstanciarKeyGenRepositorio()
        {
            _keyGenRepositorio = new KeyGenRepositorio();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Logar();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: erro.Message, title: "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(message: erro.Message, title: "Erro");
            }


        }

        private void Logar()
        {
            try
            { 


                UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio();
                if (_usuarioRepositorio.Logar(PreencherLogin()))
                {
                    new UsuarioRepositorio().AdicionarUltimoAcesso(PreencherLogin().Login);
                    OpenMdiForm.OpenForWithShow(formParaAbrir: new frmMenu(_usuarioRepositorio.GetUsuarioPorLogin(PreencherLogin().Login)),formParaFechar:this);
                }
                else if (_usuarioRepositorio.GetUsuarioPorLogin(PreencherLogin().Login) == null && _usuarioRepositorio.GetUsuarioPorSenha(PreencherLogin().Senha) != null)
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao("O Login: "+ PreencherLogin().Login+" não esta cadastrado.", "Aviso");
                    LimparTxt(new List<TextBox> {txtLogin});
                    this.FocoNoTxt(txt: txtLogin);
                }
                else if (_usuarioRepositorio.GetUsuarioPorSenha(PreencherLogin().Senha) == null && _usuarioRepositorio.GetUsuarioPorLogin(PreencherLogin().Login) != null)
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao("Senha incorreta.", "Aviso");
                    LimparTxt(new List<TextBox> { txtSenha });
                    this.FocoNoTxt(txt: txtSenha);
                }
                else
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao("Login e senha incorretos.", "Aviso");
                    LimparTxt(new List<TextBox> { txtLogin,txtSenha});
                    this.FocoNoTxt(txt: txtLogin);
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: erro.Message, title: "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(message: erro.Message, title: "Erro");
            }

        }

        private void LimparTxt(List<TextBox> list)
        {
            list.ForEach(c => c.Text = string.Empty);
        }

        private Usuarios PreencherLogin()
        {
            return new Usuarios() { Login = txtLogin.Text, Senha = txtSenha.Text };
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void FecharForm()
        {
            Application.Exit();
        }

      




    }
}
