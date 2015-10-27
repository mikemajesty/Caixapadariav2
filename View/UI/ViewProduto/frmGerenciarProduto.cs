using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewProduto;

namespace View.UI.ViewProduto
{
    public partial class frmGerenciarProduto : Form
    {
        private ProdutoRepositorio _produtoRepositorio;
        private TipoCadastroRepositorio _tipoCadastroRepositorio;
        public frmGerenciarProduto()
        {
            InitializeComponent();
        }
        private void InstanciarTipoCadastroRepositorio()
        {
            _tipoCadastroRepositorio = new TipoCadastroRepositorio();
        }
        private void CarregarTextoDePermissao()
        {
            switch (Usuarios.PermissaoStatic)
            {
                case "Caixa":
                    btnDeletar.Visible = false;
                    break;




            }
        }
        private void frmGerenciarProduto_Load(object sender, EventArgs e)
        {

            try
            {

                InstanciarProdutoRepositorio();
                CarregaGrid();
                CarregarTextoDePermissao();
                FocarNoTxt(txtPesquisar);
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

        private void CarregaGrid()
        {

            try
            {

                _produtoRepositorio.Listar(dgv: dgvProdutos);
                dgvProdutos.AjustartamanhoDoDataGridView(new List<TamanhoGrid> {
                new TamanhoGrid() { Tamanho = -1, ColunaNome="ID"} ,
                new TamanhoGrid() { Tamanho = 135, ColunaNome = "Código" },
                new TamanhoGrid() { Tamanho = 220, ColunaNome = "Nome" },
                new TamanhoGrid() { Tamanho = 120, ColunaNome="Categoria" },
                 new TamanhoGrid() { Tamanho = 110, ColunaNome="Estoque" },
                new TamanhoGrid() { Tamanho =  90, ColunaNome="Preço" }});


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

        private void btnNovo_Click(object sender, EventArgs e)
        {

            try
            {
                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(new Produto(), EnumTipoOperacao.Salvar)) == DialogResult.Yes)
                {
                    CarregaGrid();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                InstanciarProdutoRepositorio();
                if (dgvProdutos.Rows.Count > 0 && _produtoRepositorio.GetQuantidade() > 0)
                {
                    Produto produto = _produtoRepositorio.GetProdutoPorID(PegaLinhaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(produto, EnumTipoOperacao.Alterar)) == DialogResult.Yes)
                    {
                        CarregaGrid();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione um produto");
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            try
            {

                InstanciarProdutoRepositorio();
                if (dgvProdutos.Rows.Count > 0 && _produtoRepositorio.GetQuantidade() > 0)
                {
                    Produto produto = _produtoRepositorio.GetProdutoPorID(PegaLinhaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(produto, EnumTipoOperacao.Deletar)) == DialogResult.Yes)
                    {
                        CarregaGrid();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione um produto");
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void FecharForm()
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (_produtoRepositorio.GetQuantidade() > 0)
                {
                    _produtoRepositorio.SelectProdutoPeloNome(dgvProdutos, txtPesquisar.Text);
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

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                InstanciarProdutoRepositorio();
                if (e.RowIndex >= 0)
                {
                    CarregarGridPelaLinha();
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

        private void CarregarGridPelaLinha()
        {
            try
            {
                if (dgvProdutos.Rows.Count > 0 && _produtoRepositorio.GetQuantidade() > 0)
                {
                    int linha = PegaLinhaDoGrid();
                    Produto produto = _produtoRepositorio.GetProdutoPorID(linha);
                    OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(produto, EnumTipoOperacao.Detalhes));
                    LimparTxt();
                    FocarNoTxt(txtPesquisar);
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

        private void FocarNoTxt(TextBox txtPesquisar)
        {
            this.FocoNoTxt(txtPesquisar);
        }

        private void LimparTxt()
        {
            txtPesquisar.Text = string.Empty;
        }
        private int PegaLinhaDoGrid()
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

        private void dgvProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    CarregarGridPelaLinha();
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
    }
}
