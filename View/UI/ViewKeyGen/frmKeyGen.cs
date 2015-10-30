using Controller.Repositorio;
using Mike.Utilities.Desktop;
using System;
using System.Windows.Forms;
using View.UI.ViewLogin;

namespace View.UI.ViewKeyGen
{
    public partial class frmKeyGen : Form
    {
        private KeyGenRepositorio _keyGRepositorio;
    
        public frmKeyGen()
        {
            InitializeComponent();
        }

        private void btn_Ativar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Validacao.Text == KeyGen.Validador(lbl: lbl_Numero).ToString())
                {
                    IntanciarKeyGenRepositorio();
                    if (_keyGRepositorio.DeletarDatas() > 0)
                    {
                        DialogMessage.MessageFullComButtonOkIconeDeInformacao("Serial correto, você tem mais 30 dias de uso.", "Aviso");                               
                        new frmLogin().Show();
                        this.Hide();                  
                    }
                    else
                    {
                        DialogMessage.MessageFullComButtonOkIconeDeInformacao("Serial correto, mas ocorreu um problema de validação, contate o Administrador", "Aviso");
                    }
                }
                else
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao("Serial incorreto, tente novamente","Aviso");
                    FocarNoTxt();
                  
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

        private void IntanciarKeyGenRepositorio()
        {
            _keyGRepositorio = new KeyGenRepositorio();
        }

        private void LimparTxt()
        {
            txt_Validacao.LimparTxt();
        }

        private void FocarNoTxt()
        {
            this.FocoNoTxt(txt_Validacao);
        }

        private void frmKeyGen_Load(object sender, EventArgs e)
        {

            try
            {

                KeyGen.GerarValor(lbl: lbl_Numero);
                FocarNoTxt();
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
    }
}
