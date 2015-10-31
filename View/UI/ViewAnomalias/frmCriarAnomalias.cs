using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Windows.Forms;

namespace View.UI.ViewAnomalias
{
    public partial class frmCriarAnomalias : Form
    {
        private readonly Anomalias _anomalias;
        private AnomaliasRepositorio _anomaliasRepositorio;
        public frmCriarAnomalias(Anomalias anomalias)
        {
            _anomalias = anomalias;
            InitializeComponent();
        }
        private void InstanciarAnomaliasRepositorio() => _anomaliasRepositorio = new AnomaliasRepositorio();
        
        private void frmCriarAnomalias_Load(object sender, EventArgs e)
        {
            lblValor.Text = _anomalias.Valor.ToString("C2");
            FocarNotxt(txt:txtTexto);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                InstanciarAnomaliasRepositorio();
                _anomalias.Texto = txtTexto.Text;
                if (_anomaliasRepositorio.Salvar(_anomalias) > 0)
                {
                    this.DialogResult = DialogResult.Yes;
                }

            }
            catch (CustomException erro)
            {
                FocarNotxt(txt:txtTexto);
                LimparTxt(txt:txtTexto);
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
            this.ActiveControl = txt;
        }

        private void LimparTxt(TextBox txt)
        {
            txt.Text = string.Empty;
        }
    }
}
