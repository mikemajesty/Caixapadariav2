using Controller.Repositorio;
using Mike.Utilities.Desktop;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View.UI.ViewCaixa
{
    public partial class frmMovimentacaoVenda : Form
    {
        private VendaRepositorio _vendaRepositorio;
        private TipoPagamentoRepositorio _tipoPagamentoRepositorio;
        public frmMovimentacaoVenda()
        {
            InitializeComponent();
        }
        private void InstanciarTipoPagamentoRepositorio()
        {
            _tipoPagamentoRepositorio = new TipoPagamentoRepositorio();
        }
        private void frmMovimentacaoCaixa_Load(object sender, EventArgs e)
        {

            try
            {
                FocoNoBotao();
                CarregarGrid();
                CarregarTipoMovimentacao();
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

        private void FocoNoBotao()
        {
            this.FocoNoBotao(btnPesquisarEntreDatas);
        }

        private void CarregarTipoMovimentacao()
        {
            try
            {
                InstanciarTipoPagamentoRepositorio();
                _tipoPagamentoRepositorio.ListarComUmaLinhaEmBranco(cbb: cbbTipoDeMovimentacao);
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

        private void CarregarGrid()
        {

            try
            {

                InstanciarVendaRepositorio();
                _vendaRepositorio.ListarTodos(dgvMovimentacao);
                dgvMovimentacao.AjustartamanhoDoDataGridView(new List<TamanhoGrid>() 
                {
                    new TamanhoGrid(){ ColunaNome = "Valor_Vendido", Tamanho = 140},
                         new TamanhoGrid(){ ColunaNome = "Valor_Lucro", Tamanho = 120},
                              new TamanhoGrid(){ ColunaNome = "Data", Tamanho = 110},
                              new TamanhoGrid(){ ColunaNome = "Funcionario", Tamanho = 260},
                                   new TamanhoGrid(){ ColunaNome = "Tipo_Pagamento", Tamanho = 170}
                });
                ExibirLucroTotalVendido();
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

        private void InstanciarVendaRepositorio()
        {
            _vendaRepositorio = new VendaRepositorio();
        }

        private void dtpValorFinal_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                CarregarPesquisaEntreDatas();

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

        private void CarregarPesquisaEntreDatas()
        {

            try
            {


                InstanciarVendaRepositorio();
                _vendaRepositorio.ListarMovimentacaoEntreDatas(dtpValorInicial, dtpValorFinal, dgvMovimentacao, cbbTipoDeMovimentacao.Text);
                ExibirLucroTotalVendido();
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
        private void CarregarPesquisaPorDatas()
        {

            try
            {

                InstanciarVendaRepositorio();
                _vendaRepositorio.ListarMovimentacaoPorData(dtpPesquisarPorDia, dgvMovimentacao, cbbTipoDeMovimentacao.Text);
                ExibirLucroTotalVendido();
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
        private void dtpValorInicial_ValueChanged(object sender, EventArgs e)
        {


            CarregarPesquisaEntreDatas();
        }

        private void ExibirLucroTotalVendido()
        {

            try
            {
                LimparTxt();
                if (dgvMovimentacao.Rows.Count > 0)
                {
                    decimal lucro = 0, vendido = 0;
                    for (int contador = 0; contador < dgvMovimentacao.Rows.Count; ++contador)
                    {
                        lucro += Convert.ToDecimal(dgvMovimentacao.Rows[contador].Cells[1].Value);
                        vendido += Convert.ToDecimal(dgvMovimentacao.Rows[contador].Cells[0].Value);
                    }
                    txtTotalLucro.Text = lucro.ToString("C2");
                    txtTotalVendido.Text = vendido.ToString("C2");

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

        private void LimparTxt()
        {
            txtTotalVendido.Text = string.Empty;
            txtTotalLucro.Text = string.Empty;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {

            try
            {
                ExibirLucroTotalVendido();
                CarregarGrid();

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

       

        private void btnPesquisarEntreDatas_Click(object sender, EventArgs e)
        {

            try
            {
                CarregarPesquisaEntreDatas();
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

        private void btnPesquisarDia_Click(object sender, EventArgs e)
        {

            try
            {

                CarregarPesquisaPorDatas();

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

      

    }
}
