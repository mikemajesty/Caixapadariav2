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

namespace View.UI.ViewProduto
{
    public partial class frmMovimentacaoProdutos : Form
    {
        private Produto _produto;
        private MovimentacaoProdutoRepositorio _movimentacaoProdutoRepositorio;
        private TipoCadastroRepositorio _tipoCadastroRepositorio;
        public frmMovimentacaoProdutos(Produto produto)
        {
            _produto = produto;
            InitializeComponent();
        }
       

        private void InstanciarTipoCadastroRepositorio()
        {
            _tipoCadastroRepositorio = new TipoCadastroRepositorio();
        }
        private void InstanciarMovimentacaoProdutoRepositorio()
        {
            _movimentacaoProdutoRepositorio = new MovimentacaoProdutoRepositorio();
        }

        private void frmMovimentacaoProdutos_Load(object sender, EventArgs e)
        {

            try
            {
              
                InstanciarMovimentacaoProdutoRepositorio();
                DefinirValoresNoDateTimePicker();
                _movimentacaoProdutoRepositorio.ListarTodos(dgv: dgvProdutos, codigo: _produto.Codigo);
                dgvProdutos.AjustartamanhoDoDataGridView(new List<TamanhoGrid>()
                    {
                        new TamanhoGrid(){ ColunaNome="Código", Tamanho = 131},
                        new TamanhoGrid(){ ColunaNome="Nome", Tamanho = 200},
                        new TamanhoGrid(){ ColunaNome="Quantidade", Tamanho = 100},
                        new TamanhoGrid(){ ColunaNome="Total", Tamanho = 100},
                    });
                FocarNoBotao(btn: btnTodos);
                ExibirQuantidadeTotalVendido();
                InstanciarTipoCadastroRepositorio();
                CarregarPesoVendido(_produto.TipoCadastro);

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
                DateTime minDate = _movimentacaoProdutoRepositorio.GetMinimunDate();
                DateTime maxDate = _movimentacaoProdutoRepositorio.GetMaximunDate();
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
      
        private void CarregarPesoVendido(int tipoCadastro)
        {

            try
            {

                if (_tipoCadastroRepositorio.GetNomePeloID(tipoCadastro) == "Peso")
                {
                    if (dgvProdutos.Rows.Count > 0)
                    {
                        MudarTextoDaLabel(lbl: lblQuantidade, texto: "KG");
                        dgvProdutos.EsconderColuna("Quantidade");
                        decimal pesoKilo = _produto.PrecoVenda;
                        decimal valorVendido = Convert.ToDecimal(dgvProdutos.Rows[0].Cells[3].Value);
                        if (valorVendido >= pesoKilo)
                        {
                            txtQuantidade.Text = (valorVendido / pesoKilo).ToString("C2") + " Kg";
                        }
                        else
                        {
                            txtQuantidade.Text = "0 Kg";
                        }
                    }
                    else
                    {
                        txtQuantidade.Text = "Nenhuma venda";
                    }

                    /*Caso o cliente não precise de kilos vendidos
                     * EsconderTxt(txt:txtQuantidade);
                    EsconderLabel(lbl:lblQuantidade);
                    MudarPosicaoDoTextBox(txt:txtTotalLucro,posicao: new Point(206,215));
                    MudarPosicaoDaLabel(lbl: lblTotalLucro, posicao: new Point(7, 218));
                    MudaTamanhoDoForm(new Size(564,500));
                    MudarPosicaoDoTextBox(txtTotalLucro, new Point(206, 164));
                    MudarPosicaoDaLabel(lblTotalLucro,new Point(7,167));
                    MudarPosicaoDoGrid(new Point(7,225));*/
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



        private void MudarTextoDaLabel(Label lbl, string texto)
        {
            lbl.Text = texto;
        }

        private void MudarPosicaoDoGrid(Point point)
        {
            dgvProdutos.Location = point;
        }

        private void MudaTamanhoDoForm(System.Drawing.Size size)
        {
            this.Size = size;
        }

        private void MudarPosicaoDaLabel(Label lbl, Point posicao)
        {
            lbl.Location = posicao;
        }

        private void MudarPosicaoDoTextBox(TextBox txt, Point posicao)
        {
            txt.Location = posicao;
        }

        private void EsconderLabel(Label lbl)
        {
            lbl.Visible = false;
        }

        private void EsconderTxt(TextBox txt)
        {
            txt.Visible = false;
        }
        private void ExibirQuantidadeTotalVendido()
        {

            try
            {
                LimparTxt();
                if (dgvProdutos.Rows.Count > 0)
                {
                    decimal vendido = 0;
                    int quantidade = 0;
                    for (int contador = 0; contador < dgvProdutos.Rows.Count; ++contador)
                    {
                        quantidade += Convert.ToInt32(dgvProdutos.Rows[contador].Cells[2].Value);
                        vendido += Convert.ToDecimal(dgvProdutos.Rows[contador].Cells[3].Value);
                    }
                    txtTotalLucro.Text = vendido.ToString("C2");
                    txtQuantidade.Text = quantidade.ToString();

                }
                else
                {
                    txtQuantidade.Text = "Nenhuma venda";
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
            txtQuantidade.LimparTxt();
            txtTotalLucro.LimparTxt();
        }
        private void FocarNoBotao(Button btn)
        {
            this.FocoNoBotao(btn);
        }

        private void btnPesquisarDia_Click(object sender, EventArgs e)
        {

            try
            {

                InstanciarMovimentacaoProdutoRepositorio();
                _movimentacaoProdutoRepositorio.ListarPordata(dgv: dgvProdutos, codigo: _produto.Codigo, dtp: dtpPesquisarPorDia);
                ExibirQuantidadeTotalVendido();
                CarregarPesoVendido(_produto.TipoCadastro);
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
                InstanciarMovimentacaoProdutoRepositorio();
                _movimentacaoProdutoRepositorio.ListarEntredatas(dgv: dgvProdutos, codigo: _produto.Codigo, dtpInicial: dtpValorInicial, dtpFinal: dtpValorFinal);
                ExibirQuantidadeTotalVendido();
                CarregarPesoVendido(_produto.TipoCadastro);
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

     
        private void dgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            ValidatorField.DisableTabInGrid(sender, e);
        }
    }
}
