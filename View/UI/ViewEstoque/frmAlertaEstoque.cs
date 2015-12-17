using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Model.BO;
using Controller.Repositorio;

namespace View.UI.ViewEstoque
{
    public partial class frmAlertaEstoque : Form
    {
        private EstoqueRepositorio _estoqueRepositorio;
        private List<int> listaDeProdutosAbaixoNoEstoque = new List<int>();
        private ProdutoRepositorio _produtoRepositorio;
        private List<Produto> listProd = new List<Produto>();
        public frmAlertaEstoque()
        {
            InitializeComponent();
        }

        private void frmAlertaEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                PlaceLowerRight();
                CarregarDgv();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CarregarDgv()
        {
            try
            {
                lblExpirar.Text = "Faltam \n" + new KeyGenRepositorio().GetDiasTrail() + "\ndias\n" +
                  "para expirar\no programa";
                AtualizarGrid();               
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                throw;
            }
           
        }     
        private void AtualizarGrid()
        {
            try
            {
                _estoqueRepositorio = new EstoqueRepositorio();
                listaDeProdutosAbaixoNoEstoque.Clear();
                _estoqueRepositorio.VerificarSeEstaAbaixoDoEstoque().ForEach(c => listaDeProdutosAbaixoNoEstoque.Add(c));
                _produtoRepositorio = new ProdutoRepositorio();

                if (listaDeProdutosAbaixoNoEstoque.Count > 0)
                {
                    dgvAvisosEstoque.Visible = true;
                    tabAvisos.Visible = true;
                    lblSemRecado.Visible = false;
                    listProd.Clear();
                    listaDeProdutosAbaixoNoEstoque.ForEach(c=> listProd.Add(_produtoRepositorio.GetProdutoPorID(c)));                  
                    lblSemRecado.Visible = false;
                    dgvAvisosEstoque.Columns.Clear();
                    dgvAvisosEstoque.DataSource = listProd.Select(item => new { Nome = item.Nome, Código = item.Codigo, Qtd = item.Quantidade }).ToList();
                    dgvAvisosEstoque.EsconderColuna("Código");
                    dgvAvisosEstoque.AjustartamanhoDoDataGridView(new List<TamanhoGrid>() { new TamanhoGrid { ColunaNome = "Nome", Tamanho = 250 }, new TamanhoGrid { ColunaNome = "Qtd", Tamanho = 80 } });
                }
                else
                {
                    dgvAvisosEstoque.Visible = false;
                    lblSemRecado.Visible = true;
                }
                
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                throw;
            }
        }

        private void PlaceLowerRight()
        {
            this.Left = ContainerContext.Context.Right - this.Width - 16;
            this.Top = ContainerContext.Context.Bottom - this.Height - 118;
        }

        private void dgvAvisosEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var codigo = dgvAvisosEstoque.CurrentRow.Cells["Código"].Value.ToString();
                    if (codigo != null)
                    {
                        var formAlertEstoque = new frmGerenciarEstoque();
                        GerenciarGerenciamentoDeEstoque.FecharForm(formAlertEstoque);
                        Estoque.CodigoEstoque = codigo;
                        OpenMdiForm.LoadNewKeepAnother(ContainerContext.Context, formAlertEstoque);
                    }
                }
               
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                throw;
            }
        }

       
    }
}
