using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewProduto;

namespace View.UI.ViewProduto
{
    public partial class frmPesquisarProduto : Form
    {
        private ProdutoRepositorio _produtoRepositorio;
        private EnumMovimentacao _enumMovimentacao;

        public frmPesquisarProduto(EnumMovimentacao enumMovimentacao)
        {
            _enumMovimentacao = enumMovimentacao;
            InitializeComponent();
        }

        private void frmPesquisarProduto_Load(object sender, EventArgs e)
        {

            try
            {
                CarregarGrid();
                ChecarRadioButtonNome();
                FocarNoTxt();
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

        private void ChecarRadioButtonNome()
        {
            rdbNome.Checked = true;
        }

        private void CarregarGrid()
        {

            try
            {

                InstanciarProdutoRepositorio();
                _produtoRepositorio.Listar(dgv: dgvProdutos);
                dgvProdutos.AjustartamanhoDoDataGridView(new List<TamanhoGrid> {
                new TamanhoGrid() { Tamanho = -1, ColunaNome="ID"} ,
                new TamanhoGrid() { Tamanho = 145, ColunaNome = "Código" },
                new TamanhoGrid() { Tamanho = 220, ColunaNome = "Nome" },
                new TamanhoGrid() { Tamanho = 120, ColunaNome="Categoria" },
                new TamanhoGrid() { Tamanho = 100, ColunaNome="Preço" }  ,
                new TamanhoGrid() { Tamanho = 90, ColunaNome="Estoque" }});

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

        private void InstanciarProdutoRepositorio()
        {
            _produtoRepositorio = new ProdutoRepositorio();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                MudarTextoDoGroupBox(texto: "Pesquisar pelo Nome do produto");
                this.FocoNoTxt(txt: txtPesquisar);
                LimparTxt(txt: txtPesquisar);
                TirarFocoDoGrid();
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

        private void TirarFocoDoGrid()
        {
            dgvProdutos.ClearSelection();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                MudarTextoDoGroupBox(texto: "Pesquisar pelo Código do produto");
                this.FocoNoTxt(txt: txtPesquisar);
                LimparTxt(txt: txtPesquisar);
                TirarFocoDoGrid();
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

        private void LimparTxt(TextBox txt)
        {
            txt.Text = string.Empty;
        }


        private void rdbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                MudarTextoDoGroupBox(texto: "Pesquisar pela Categoria do produto");
                this.FocoNoTxt(txt: txtPesquisar);
                LimparTxt(txt: txtPesquisar);
                TirarFocoDoGrid();
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

        private void MudarTextoDoGroupBox(string texto)
        {
            gpbPesquisar.Text = texto;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                PesquisarNoBancoPorNome();

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

        private void PesquisarNoBancoPorNome()
        {

            try
            {
                InstanciarProdutoRepositorio();
                if (_produtoRepositorio.GetQuantidade() > 0)
                {
                    int tamanho = txtPesquisar.Text.Length;
                    InstanciarProdutoRepositorio();
                    switch (SelecionarTextoDoRadioButtonSelecionado())
                    {
                        case "Nome":
                            _produtoRepositorio.SelectProdutoPeloNome(dgv: dgvProdutos, nome: txtPesquisar.Text);
                            break;
                        case "Código":
                            if (tamanho == 0)
                            {
                                _produtoRepositorio.SelectProdutoPeloCodigo(dgv: dgvProdutos, codigo: txtPesquisar.Text);
                            }
                            break;
                        case "Categoria":
                            _produtoRepositorio.SelectProdutoPeloCategoria(dgv: dgvProdutos, categoria: txtPesquisar.Text);
                            break;
                    }
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

        private string SelecionarTextoDoRadioButtonSelecionado()
        {

            try
            {

                RadioButton[] rdbList = { rdbCategoria, rdbCodigo, rdbNome };
                string rdbSelecionado = string.Empty;
                foreach (var rdb in rdbList)
                {
                    if (rdb.Checked)
                    {
                        rdbSelecionado = rdb.Text;
                    }
                }
                return rdbSelecionado;

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if ((Keys)e.KeyChar == Keys.Enter)
                {

                    switch (SelecionarTextoDoRadioButtonSelecionado())
                    {

                        case "Código":
                            _produtoRepositorio.SelectProdutoPeloCodigo(dgv: dgvProdutos, codigo: txtPesquisar.Text);
                            break;
                    }

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

        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            try
            {

                (sender as DataGridView).DefaultCellStyle.Format = "C2";


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

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dgvProdutos.Rows.Count >0)
                {
                    CarregarInformacaoComTeclaEnter();
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

        private void CarregarInformacaoComTeclaEnter()
        {
            try
            {
                InstanciarProdutoRepositorio();
                if (_enumMovimentacao == EnumMovimentacao.Movimentacao)
                {
                    Produto prod = GetProdutoPorID();
                    OpenMdiForm.OpenForWithShowDialog(new frmMovimentacaoProdutos(prod));
                    LimparTxt(txtPesquisar);
                    FocarNoTxt();
                }
                else if (_enumMovimentacao == EnumMovimentacao.Pesquisa)
                {
                    Produto prod = GetProdutoPorID();
                    if (prod != null)
                    {
                        Produto.CodigoDoProduto = prod.Codigo;
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        DialogMessage.MessageFullComButtonOkIconeDeInformacao("Selecione um Produto", "Aviso");
                    }
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

        private Produto GetProdutoPorID()
        {
            try
            {

                return _produtoRepositorio.GetProdutoPorID(GetIdNoGrid());

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        private void FocarNoTxt()
        {
            this.FocoNoTxt(txtPesquisar);
        }

        private int GetIdNoGrid()
        {

            try
            {

                return Convert.ToInt32(dgvProdutos.CurrentRow.Cells["ID"].Value);

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        private void dgvProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                try
                {
                    CarregarInformacaoComTeclaEnter();

                }
                catch (CustomException erro)
                {
                    throw new CustomException(erro.Message);
                }
                catch (Exception erro)
                {
                    throw new Exception(erro.Message);
                }
            }
        }


    }
}


