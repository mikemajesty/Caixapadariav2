using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewProduto;

namespace View.UI.ViewProduto
{
    public partial class frmPesquisarProduto : Form
    {
        private ProdutoRepositorio _produtoRepositorio;
        private EnumMovimentacao _enumMovimentacao;
        private BindingSource _source = new BindingSource();
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
                ColocarSelecaoNaPrimeiraLinha();
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

        private void ColocarSelecaoNaPrimeiraLinha()
        {
            if (dgvProdutos.Rows.Count > 0)
            {
                dgvProdutos.Rows[0].Selected = true;
            }            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Left:
                    break;
                case Keys.Up:
                    dgvProdutos.MoveToUp();                  
                    break;
                case Keys.Right:
                    break;
                case Keys.Down:
                    dgvProdutos.MoveToDown();                 
                    break;
                case Keys.Select:
                    break;
                case Keys.F1:
                    ChecarRdb(rdb: rdbNome);
                    break;
                case Keys.F2:
                    ChecarRdb(rdb: rdbCodigo);
                    break;
                case Keys.F3:
                    ChecarRdb(rdb: rdbCategoria);
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;
                case Keys.Enter:
                    if (_enumMovimentacao == EnumMovimentacao.Pesquisa)
                    {
                        if (dgvProdutos.Rows.Count > 0)
                        {
                            int idProduto = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["ID"].Value);
                            InstanciarProdutoRepositorio();
                            Produto prod =  _produtoRepositorio.GetProdutoPorID(idProduto);
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

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ChecarRdb(RadioButton rdb)
        {
            rdb.Checked = true;
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
                dgvProdutos.PadronizarGrid();

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
                ColocarSelecaoNaPrimeiraLinha();
                //TirarFocoDoGrid();
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
                //TirarFocoDoGrid();
                ColocarSelecaoNaPrimeiraLinha();
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
                //TirarFocoDoGrid();
                ColocarSelecaoNaPrimeiraLinha();
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

        private void MudarTextoDoGroupBox(string texto)
        {
            gpbPesquisar.Text = texto;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                PesquisarNoBanco();
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

        private void PesquisarNoBanco()
        {

            try
            {
                InstanciarProdutoRepositorio();
                if (_produtoRepositorio.GetQuantidade() > 0)
                {
                    int tamanho = txtPesquisar.Text.Length;
                    switch (SelecionarTextoDoRadioButtonSelecionado())
                    {
                        case "Nome":
                            _produtoRepositorio.SelectProdutoPeloNome(dgv: dgvProdutos, nome: txtPesquisar.Text.Trim());
                            break;
                        case "Código":
                            if (tamanho == 0)
                            {
                                _produtoRepositorio.SelectProdutoPeloCodigo(dgv: dgvProdutos, codigo: txtPesquisar.Text.Trim());
                            }
                            break;
                        case "Categoria":
                            _produtoRepositorio.SelectProdutoPeloCategoria(dgv: dgvProdutos, categoria: txtPesquisar.Text.Trim());
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
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
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
                        rdbSelecionado = rdb.Text.Contains("Nome") ? "Nome" : rdb.Text.Contains("Categoria") ? "Categoria" : rdb.Text.Contains("Código") ? "Código" : "Nome";
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
                ValidatorField.AllowOneSpaceTogether(e, sender);

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
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
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
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dgvProdutos.Rows.Count > 0)
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
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
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
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
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

        private void dgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            ValidatorField.DisableTabInGrid(sender, e);
        }

    }
}


