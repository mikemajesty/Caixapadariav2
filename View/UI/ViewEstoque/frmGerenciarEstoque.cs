using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewProduto;

namespace View.UI.ViewEstoque
{
    public partial class frmGerenciarEstoque : Form
    {
        private EstoqueRepositorio _estoqueRepositorio;
        public frmGerenciarEstoque()
        {
            InitializeComponent();
        }

        private void frmGerenciarEstoque_Load(object sender, EventArgs e)
        {

            try
            {
                          
                CarregaGrid();               
                ChecarRadioButtonNome();
                FocoNoTxt();
                string codigo = null;
                if ((codigo = Estoque.CodigoEstoque) != null)
                {
                    ChecarRadioButtonCodigo();
                    txtEstoque.Text = codigo;
                    SendKeys.SendWait("{ENTER}");
                    Estoque.CodigoEstoque = null;
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

        private void ChecarRadioButtonCodigo()
        {
            ckbPorCodigo.Checked = true;
        }

        private void ChecarRadioButtonNome()
        {
            
            ckbPorNome.Checked = true;
            
        }

        private void CarregaGrid()
        {

            try
            {

                InstanciarEstoqueRepositorio();
               
                _estoqueRepositorio.ListarPorNome(dgv: dgvEstoque,nome: "");
                DefinirTamanhoDoGrid();

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

        private void DefinirTamanhoDoGrid()
        {
            dgvEstoque.AjustartamanhoDoDataGridView(new List<TamanhoGrid> {
                new TamanhoGrid() { Tamanho = -1, ColunaNome="ID"} ,
                new TamanhoGrid() { Tamanho = 192, ColunaNome = "Código" },
                 new TamanhoGrid() { Tamanho = -1, ColunaNome = "Min" },
                   new TamanhoGrid() { Tamanho = -1, ColunaNome = "Max" },
                     new TamanhoGrid() { Tamanho = -1, ColunaNome = "Quantidade" },
                new TamanhoGrid() { Tamanho = 300, ColunaNome = "Nome" },
                new TamanhoGrid() { Tamanho = 177, ColunaNome="Categoria" }});
            dgvEstoque.EsconderColuna("ID");
            dgvEstoque.EsconderColuna("Min");
            dgvEstoque.EsconderColuna("Max");
            dgvEstoque.EsconderColuna("Quantidade");
          
        }

        private void InstanciarEstoqueRepositorio()
        {
            _estoqueRepositorio = new EstoqueRepositorio();
        }

        private void dgvEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                InstanciarEstoqueRepositorio();
                if (dgvEstoque.Rows.Count > 0 && _estoqueRepositorio.GetQuantidade() > 0 && e.RowIndex >= 0)
                {
                    int linha = PegarLinhaDoGrid();
                    Produto produto = _estoqueRepositorio.GetLinhaPeloID(linha);
                    LimparTxt();
                    FocarNoTxt();
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(produto, EnumTipoOperacao.Estoque)) == DialogResult.Yes)
                    {
                        CarregaGrid();
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

        private void FocarNoTxt()
        {
            this.FocoNoTxt(txtEstoque);
        }


        private int PegarLinhaDoGrid()
        {

            try
            {

                return Convert.ToInt32(dgvEstoque.CurrentRow.Cells["ID"].Value);

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

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (ckbPorNome.Checked)
                {

                    MudarOMaximoDeCaracteresDigitadosNoTxt(caracter: 30);
                    InstanciarEstoqueRepositorio();
                    if (_estoqueRepositorio.GetQuantidade() > 0)
                    {
                        
                        if (ckbPorNome.Checked)
                        {
                            _estoqueRepositorio.ListarPorNome(dgv: dgvEstoque, nome: txtEstoque.Text);                          
                        }

                    }

                }
                else if (ckbPorCodigo.Checked)
                {
                    MudarOMaximoDeCaracteresDigitadosNoTxt(caracter: 20);

                    if (txtEstoque.Text.Length == 0)
                    {
                        _estoqueRepositorio.ListarPorNome(dgv: dgvEstoque, nome: txtEstoque.Text);                       
                    }
                }
                else
                {
                    MudarOMaximoDeCaracteresDigitadosNoTxt(caracter: 1);

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
            finally {TirarFocoDoDgv(); }
        }

        private void MudarOMaximoDeCaracteresDigitadosNoTxt(int caracter)
        {
            txtEstoque.MaxLength = caracter;
        }

        private void TirarFocoDoDgv()
        {
            dgvEstoque.ClearSelection();
        }

        private void LimparTxt()
        {
            txtEstoque.Text = string.Empty;
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                ValidatorField.IntegerAndLetter(e: e);
                LimparFocoDoDataGridView();
                if (ckbPorCodigo.Checked)
                {
                    ValidatorField.NoSpace(e);
                }
                else
                {
                    ValidatorField.AllowOneSpaceTogether(e, sender);
                } 
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    if (_estoqueRepositorio.GetQuantidade() > 0)
                    {
                        if (ckbPorCodigo.Checked)
                        {
                            _estoqueRepositorio.ListarPorCodigo(dgv: dgvEstoque, codigo: txtEstoque.Text);
                            
                        }
                    }
                }


            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                LimparTxt();
                FocoNoTxt();
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void FocoNoTxt()
        {
            this.FocoNoTxt(txtEstoque);
        }

        private void ckbPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            FocoNoTxt();
            LimparTxt();
            LimparFocoDoDataGridView();
        }

        private void ckbPorNome_CheckedChanged(object sender, EventArgs e)
        {
            FocoNoTxt();
            LimparTxt();
            LimparFocoDoDataGridView();
        }

        private void LimparFocoDoDataGridView()
        {
            dgvEstoque.ClearSelection();
        }

        private void dgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dgvEstoque.Rows)
                {
                    

                    if (Convert.ToInt32(row.Cells["Quantidade"].Value) <= Convert.ToInt32(row.Cells["MIN"].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(row.Cells["Quantidade"].Value) > Convert.ToInt32(row.Cells["MIN"].Value) && Convert.ToInt32(row.Cells["Quantidade"].Value) < Convert.ToInt32(row.Cells["MAX"].Value))//
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (Convert.ToInt32(row.Cells["Quantidade"].Value) >= Convert.ToInt32(row.Cells["MAX"].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Lime;
                    }
                }
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }

        private void dgvEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            ValidatorField.DisableTabInGrid(sender, e);
        }

        private void dgvEstoque_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            (sender as DataGridView).ClearSelection();
        }
    }
}
