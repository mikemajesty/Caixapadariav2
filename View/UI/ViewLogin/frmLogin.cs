
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
                FocarNotxt(txt:txtLogin);
               
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
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void FocarNotxt(TextBox txt)
        {
            this.FocoNoTxt(txt: txt);
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
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
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
                    FocarNotxt(txt:txtLogin);
                }
                else if (_usuarioRepositorio.GetUsuarioPorSenha(PreencherLogin().Senha) == null && _usuarioRepositorio.GetUsuarioPorLogin(PreencherLogin().Login) != null)
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao("Senha incorreta.", "Aviso");
                    LimparTxt(new List<TextBox> { txtSenha });
                    FocarNotxt(txt: txtSenha);
                }
                else
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao("Login e senha incorretos.", "Aviso");
                    LimparTxt(new List<TextBox> { txtLogin,txtSenha});
                    FocarNotxt(txt: txtLogin);
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: erro.Message, title: "Aviso");
                
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(message: erro.Message, title: "Erro");
            }

        }

        private void LimparTxt(List<TextBox> list)
        {
            list.ForEach(c => c.Text = string.Empty);
        }

        private Usuarios PreencherLogin()
        {
            return new Usuarios() { Login = txtLogin.Text.Trim(), Senha = txtSenha.Text.Trim() };
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void FecharForm()
        {
            Application.Exit();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                FocarNotxt(txt:txtSenha);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                FocarNoBtn(btn: btnEntrar);
            }
        }

        private void FocarNoBtn(Button btn)
        {
            this.FocoNoBotao(btn);
        }
    }
}
