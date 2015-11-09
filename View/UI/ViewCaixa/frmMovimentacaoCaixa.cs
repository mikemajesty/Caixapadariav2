using Controller.Repositorio;
using Mike.Utilities.Desktop;
using System;
using System.Windows.Forms;

namespace View.UI.ViewCaixa
{
    public partial class frmMovimentacaoCaixa : Form
    {
        private MovimentacaoCaixaRepositorio _movimentacaoCaixaRepositorio;

        public frmMovimentacaoCaixa()
        {
            InitializeComponent();
        }
     
        private void InstanciarCaixaRepositorio()
        {
            _movimentacaoCaixaRepositorio = new MovimentacaoCaixaRepositorio();
        }
        private void frmMovimentacaoCaixa_Load(object sender, EventArgs e)
        {

            try
            {
                InstanciarCaixaRepositorio();
                DefinirValoresNoDateTimePicker();
                this.FocoNoBotao(btnTodos);                
                _movimentacaoCaixaRepositorio.Listar(dgvMovimentacao);
                dgvMovimentacao.PadronizarGrid();
                ExibirLucroTotalVendido();
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
        private void DefinirValoresNoDateTimePicker()
        {
            try
            {
                DateTime minDate = _movimentacaoCaixaRepositorio.GetMinimunDate();
                DateTime maxDate = _movimentacaoCaixaRepositorio.GetMaximunDate();
                dtpValorInicial.MinDate = minDate;
                dtpValorInicial.MaxDate = maxDate;
                dtpValorFinal.MaxDate = maxDate;
                dtpValorFinal.MinDate = minDate;
                dtpPesquisarPorDia.MinDate = minDate;
                dtpPesquisarPorDia.MaxDate = maxDate;
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
        private void btnPesquisarEntreDatas_Click(object sender, EventArgs e)
        {

            try
            {

                InstanciarCaixaRepositorio();
                _movimentacaoCaixaRepositorio.ListarEntreDatas(dgvMovimentacao, dtpValorInicial,dtpValorFinal);
                ExibirLucroTotalVendido();
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

        private void btnPesquisarDia_Click(object sender, EventArgs e)
        {

            try
            {


                InstanciarCaixaRepositorio();
                _movimentacaoCaixaRepositorio.ListarPorDia(dgvMovimentacao,dtpPesquisarPorDia);
                ExibirLucroTotalVendido();
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

        private void btnTodos_Click(object sender, EventArgs e)
        {
                
            try
            {

                InstanciarCaixaRepositorio();
                _movimentacaoCaixaRepositorio.Listar(dgvMovimentacao);
                ExibirLucroTotalVendido();
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
        private void ExibirLucroTotalVendido()
        {

            try
            {
                LimparTxt();
                if (dgvMovimentacao.Rows.Count > 0)
                {
                    decimal lucro = 0;
                    for (int contador = 0; contador < dgvMovimentacao.Rows.Count; ++contador)
                    {
                        lucro += Convert.ToDecimal(dgvMovimentacao.Rows[contador].Cells[0].Value);                        
                    }
                    txtTotalLucro.Text = lucro.ToString("C2");
                    

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

        private void LimparTxt()
        {
            txtTotalLucro.Text = string.Empty;
        }

        private void dgvMovimentacao_KeyDown(object sender, KeyEventArgs e)
        {
            ValidatorField.DisableTabInGrid(sender, e);
        }
    }
}
