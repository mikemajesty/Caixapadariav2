using System;
using System.Windows.Forms;
using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using View.UI.ViewKeyGen;
using Model.Data;
using View.UI.ViewLogin;

namespace View.Enum
{
    static class Program
    {


        private static frmMensagemDeEspera mensagem;
        private static Espere espere = new Espere();
        [STAThread]
        static void Main()
        {
            
            espere.Start(ExibirMensagem);
            KeyGenRepositorio _keyGenRepositorio;
            UsuarioRepositorio _usuariosRepositorio;
            CaixaRepositorio _caixaRepositorio;
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                _keyGenRepositorio = new KeyGenRepositorio();            
                if (InserirDatas(_keyGenRepositorio) > 0)
                {
                    _caixaRepositorio = new CaixaRepositorio();
                    if (_caixaRepositorio.GetValor().Valor > 0)
                    {
                        Properties.Settings.Default.CaixaAberto = true;
                    }
                }
                else
                {
                    Properties.Settings.Default.CaixaAberto = false;
                }
                _usuariosRepositorio = new UsuarioRepositorio();
                _usuariosRepositorio.InserirLoginAdmin(new Usuarios() { Login = "mikeadmin", Senha = "mikeadmin", NomeCompleto = "Mike rodrigues de Lima", Permicao = "Administrador" });

                if (new UsuarioRepositorio().GetQuantidadeUsuarios() > 0)
                {
                    if (_keyGenRepositorio.GetQuantidade() >= 30)
                    {
                        Backup.GerarBeckup(new _DbContext());
                        CancelarMensagem();
                        Application.Run(new frmKeyGen());
                    }
                    else
                    {
                        CancelarMensagem();
                        Application.Run(new frmLogin());
                    }
                }
                else
                {
                    if (_keyGenRepositorio.GetQuantidade() >= 30)
                    {
                        CancelarMensagem();
                        Application.Run(new frmKeyGen());
                    }
                    else
                    {
                        CancelarMensagem();
                        Application.Run(new frmCadastrarLogin(null, EnumTipoOperacao.Salvar));
                    }
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, "Inicialização");
                DialogMessage.MessageComButtonOkIconeErro("Problema ao estabelecer conexão com o banco de dados, reinice o computador, se o erro persistir contate o Administrador: " + erro.Message, "Erro");
            }
            finally { CancelarMensagem(); }
        }
        private static void CancelarMensagem()
        {
            espere.CancelarTask();
            if (espere.Cancel.IsCancellationRequested)
            {
                if (mensagem != null)
                {
                    mensagem.Close();
                }

            }
        }
        private static void ExibirMensagem()
        {
            mensagem = new frmMensagemDeEspera();
            mensagem.ShowDialog();
        }

        private static int InserirDatas(KeyGenRepositorio _keyGenRepositorio)
        {

            try
            {
                return _keyGenRepositorio.InsertDatas(new Datas()
                  {
                      Data = DateTime.Now.ToDataCertaSemHora()
                  });

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, "Inicialização");
                throw new Exception(erro.Message);
            }


        }
    }
}
