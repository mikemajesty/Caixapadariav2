using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;

namespace View.UI.ViewAnomalias
{
    public partial class frmCriarAnomalias : Form
    {
        private readonly Anomalias _anomalias;
        private EnumAnomalia _enumAnomalia;
        private AnomaliasRepositorio _anomaliasRepositorio;
        public frmCriarAnomalias(Anomalias anomalias, EnumAnomalia enumAnomalia)
        {
            _anomalias = anomalias;
            _enumAnomalia = enumAnomalia;
            InitializeComponent();
        }
        private void InstanciarAnomaliasRepositorio() => _anomaliasRepositorio = new AnomaliasRepositorio();
        
        private void frmCriarAnomalias_Load(object sender, EventArgs e)
        {
            switch (_enumAnomalia)
            {
                case EnumAnomalia.Criar:
                    FocarNotxt(txt: txtTexto);
                    break;
                case EnumAnomalia.Mostrar:
                    txtTexto.Text = _anomalias.Texto;
                    EsconderButton(btn: btnExcluir, mostrarOuNao: false);
                    MudarTamanhoDoButton(btn: btnSair, size: new Size(456, 54));//134; 54 tamanho padrão
                    MudarPosicaoDoButton(btn: btnSair, location: new Point(12,286));
                    DesabilitarTextBox(txt: txtTexto, disabilitadoOuNao: true);
                    FocarNoBtn(btn:btnSair);
                    break;
            }
            lblValor.Text = _anomalias.Valor.ToString("C2");           
           
        }

        private void MudarPosicaoDoButton(Button btn, Point location)
        {
            btn.Location = location;
        }

        private void FocarNoBtn(Button btn)
        {
            this.FocoNoBotao(btn);
        }

        private void DesabilitarTextBox(TextBox txt, bool disabilitadoOuNao)
        {
            txt.ReadOnly = disabilitadoOuNao;
        }

        private void EsconderButton(Button btn, bool mostrarOuNao)
        {
            btn.Visible = mostrarOuNao;
        }

        private void MudarTamanhoDoButton(Button btn, Size size)
        {
            btn.Size = size;
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
