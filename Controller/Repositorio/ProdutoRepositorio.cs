using Mike.Utilities.Desktop;
using Model.BO;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class ProdutoRepositorio
    {
        private _DbContext _banco;
        private TipoCadastroRepositorio _tipoCadastroRepositorio;
        private ProdutoBO _produtoBO;
        private const int Sucesso = 1, Insucesso = 0;
        private const bool NaoExiste = false;
        private void InstanciarDbContext()
        {
            _banco = new _DbContext();
        }
        private void InstanciarProdutoBO()
        {
            _produtoBO = new ProdutoBO();
        }
        private void InstanciarTipoCadastroRepositorio()
        {
            _tipoCadastroRepositorio = new TipoCadastroRepositorio();
        }
        public int Salvar(Produto produto)
        {
            try
            {
                InstanciarDbContext();
                InstanciarProdutoBO();
                int retorno = 0;
                if (_produtoBO.VerificaSeExisteProduto(produto) == NaoExiste)
                {
                    _banco.Entry(produto).State = EntityState.Added;
                    retorno = _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso.ErroCustomForTernary("Não foi possível salvar, verifiques os dados");

                }
                return retorno;
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

        public int? GetQuantidadeNoEstoque(Produto produto)
        {
            try
            {
                InstanciarDbContext();
                Produto prod = _banco.Produto.FirstOrDefault(c => c.Codigo == produto.Codigo);
                return prod.Quantidade;


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


        public void Listar(DataGridView dgv)
        {
            try
            {
                InstanciarDbContext();
                dgv.DataSource = (from prod in _banco.Produto
                                  join cat in _banco.Categoria on prod.Categoria equals cat.ID
                                  select new
                                      {
                                          ID = prod.ID,
                                          Código = prod.Codigo,
                                          Nome = prod.Nome,
                                          Categoria = cat.Nome,
                                          Preço = prod.PrecoVenda,
                                          Estoque = prod.GerenciarEstoque
                                      }).OrderBy(c => c.Nome).ToList();
                dgv.EsconderColuna("ID");

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

        public Produto GetProdutoPorID(int ID)
        {
            try
            {
                InstanciarDbContext();
                return _banco.Produto.Find(ID);

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
        public int Alterar(Produto produto)
        {
            try
            {
                InstanciarDbContext();
                InstanciarProdutoBO();
                int retorno = 0;
                if (_produtoBO.VerificarSeExisteProdutoNaAlteracao(produto) == NaoExiste)
                {
                    _banco.Entry(produto).State = EntityState.Modified;
                    retorno = _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
                }
                return retorno;

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

        public int Deletar(Produto produto)
        {
            try
            {
                InstanciarDbContext();
                InstanciarProdutoBO();
                int retorno = 0;
                if (_produtoBO.VerificarSeEstaNaComanda(produto) == NaoExiste)
                {
                    if (_produtoBO.VerificarSeEstaNaMovimentacao(produto) == NaoExiste)
                    {
                        _banco.Entry(produto).State = EntityState.Deleted;
                        retorno = _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
                    }
                  
                }
                return retorno;

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
        public void SelectProdutoPeloNome(DataGridView dgv, string nome)
        {
            try
            {
                InstanciarDbContext();
                dgv.DataSource = (from prod in _banco.Produto
                                  join cat in _banco.Categoria on prod.Categoria equals cat.ID
                                  select new
                                  {
                                      ID = prod.ID,
                                      Código = prod.Codigo,
                                      Nome = prod.Nome,
                                      Categoria = cat.Nome,
                                      Preço = prod.PrecoVenda,
                                      Estoque = prod.GerenciarEstoque
                                  }).Where(c => c.Nome.Contains(nome)).ToList();
                dgv.EsconderColuna("ID");

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

        public void SelectProdutoPeloCodigo(DataGridView dgv, string codigo)
        {

            try
            {
                InstanciarDbContext();
                dgv.DataSource = ((from prod in _banco.Produto
                                   join cat in _banco.Categoria on prod.Categoria equals cat.ID
                                   select new
                                   {
                                       ID = prod.ID,
                                       Codigo = prod.Codigo,
                                       Nome = prod.Nome,
                                       Categoria = cat.Nome,
                                       Preço = prod.PrecoVenda,
                                       Estoque = prod.GerenciarEstoque
                                   }).Where(c => c.Codigo == codigo).OrderBy(c => c.Nome).ToList());

                if (dgv.Rows.Count == 0)
                {
                    dgv.DataSource = ((from prod in _banco.Produto
                                       join cat in _banco.Categoria on prod.Categoria equals cat.ID
                                       select new
                                       {
                                           ID = prod.ID,
                                           Código = prod.Codigo,
                                           Nome = prod.Nome,
                                           Categoria = cat.Nome,
                                           Preço = prod.PrecoVenda,
                                           Estoque = prod.GerenciarEstoque
                                       }).OrderBy(c => c.Nome).ToList());
                }
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

        public void SelectProdutoPeloCategoria(DataGridView dgv, string categoria)
        {
            try
            {
                InstanciarDbContext();
                dgv.DataSource = (from prod in _banco.Produto
                                  join cat in _banco.Categoria on prod.Categoria equals cat.ID
                                  select new
                                  {
                                      ID = prod.ID,
                                      Código = prod.Codigo,
                                      Nome = prod.Nome,
                                      Categoria = cat.Nome,
                                      Preço = prod.PrecoVenda,
                                      Estoque = prod.GerenciarEstoque
                                  }).Where(c => c.Categoria.Contains(categoria)).ToList();

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

        public int GetQuantidade()
        {


            try
            {
                InstanciarDbContext();
                return _banco.Produto.Count();

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

        public decimal AdicionarProdutoParaVenda(ListView ltv, string codigo, int quantidade)
        {
            try
            {
                InstanciarDbContext();
                return AdicionarProdutoNoListViewSemComanda(ltv, codigo, quantidade);
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

        private decimal AdicionarProdutoNoListViewSemComanda(ListView ltv, string codigo, int quantidade)
        {

            try
            {
                InstanciarTipoCadastroRepositorio();
                int IDTipoUnidade = _tipoCadastroRepositorio.GetIDPeloNome("Unidade");

                Produto produto = this.GetProdutoPorCodigoUnidade(codigo);

                IQueryable<dynamic> _venda = null;
                decimal lucroTotal = 0;
                if (produto != null)
                {
                    if (produto.TipoCadastro == IDTipoUnidade)
                    {
                        _venda = (from prod in _banco.Produto
                                  select new
                                  {
                                      Nome = prod.Nome
                                      ,
                                      Codigo = prod.Codigo
                                      ,
                                      Quantidade = quantidade
                                      ,
                                      Total = prod.PrecoVenda * quantidade
                                      ,
                                      LucroTotal = ((prod.PrecoVenda - prod.PrecoCompra) * quantidade)
                                  }).Where(c => c.Codigo == codigo);

                        AdicionarItensNoListView(ltv, _venda);
                        foreach (var lucro in _venda)
                        {
                            lucroTotal += lucro.LucroTotal;
                        }
                    }
                }
                else
                {
                    MyErro.MyCustomException("Esse Produto é vendido por peso.");
                }

                return lucroTotal;
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
        private static void AdicionarItensNoListView(ListView ltv, IQueryable<dynamic> _venda)
        {

            try
            {

                ListViewItem listView;


                if (ltv.Columns.Count == 0)
                {
                    ltv.Columns.Add("Nome").Width = 160;
                    ltv.Columns.Add("Codigo").Width = 106;
                    ltv.Columns.Add("Quantidade").Width = 76;
                    ltv.Columns.Add("Total").Width = 70;
                    ltv.Columns.Add("LucroTotal").Width = 0;

                }

                foreach (var item in _venda)
                {
                    listView = new ListViewItem(item.Nome);
                    listView.SubItems.Add(item.Codigo);
                    object itemQtd = item.Quantidade;
                    if (itemQtd.ToString().Contains("Peso"))
                    {
                        listView.SubItems.Add("Peso");
                    }
                    else
                    {
                        listView.SubItems.Add("" + item.Quantidade);
                    }
                    listView.SubItems.Add(item.Total.ToString("N2"));
                    listView.SubItems.Add(item.LucroTotal.ToString("N2"));
                    ltv.Items.Add(listView);
                }


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

        public Produto GetProdutoPorCodigoUnidade(string codigo)
        {
            try
            {
                InstanciarDbContext();
                InstanciarTipoCadastroRepositorio();
                if (_banco.Produto.FirstOrDefault(c => c.Codigo == codigo) != null)
                {
                    int ID = _tipoCadastroRepositorio.GetIDPeloNome("Unidade");
                    Produto prod = _banco.Produto.FirstOrDefault(c => c.Codigo == codigo && c.TipoCadastro == ID);
                    return prod;

                }
                else
                {
                    throw new CustomException("Produto com esse código não esta cadastrado.");
                }


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
        public Produto GetProdutoPorCodigoPorPeso(string codigo)
        {
            try
            {
                InstanciarDbContext();
                InstanciarTipoCadastroRepositorio();

                if (_banco.Produto.FirstOrDefault(c => c.Codigo == codigo) != null)
                {
                    int ID = _tipoCadastroRepositorio.GetIDPeloNome("Peso");
                    Produto prod = _banco.Produto.FirstOrDefault(c => c.Codigo == codigo && c.TipoCadastro == ID);
                    if (prod != null)
                    {
                        return prod;
                    }
                    else
                    {
                        throw new CustomException("Esse Produto é vendido por unidade.");
                    }
                }
                else
                {
                    throw new CustomException("Produto com esse código não esta cadastrado.");
                }


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
        public void AdicionarProdutoParaVendaPorPeso(ListView ltvProdutos, string codigo, decimal peso)
        {
            try
            {
                InstanciarTipoCadastroRepositorio();
                int IDTipoPeso = _tipoCadastroRepositorio.GetIDPeloNome("Peso");
                Produto produto = this.GetProdutoPorCodigoPorPeso(codigo);

                if (produto != null)
                {
                    IQueryable<dynamic> _venda = null;

                    if (produto.TipoCadastro == IDTipoPeso)
                    {
                        _venda = (from prod in _banco.Produto
                                  select new
                                  {
                                      Nome = prod.Nome
                                      ,
                                      Codigo = prod.Codigo
                                      ,
                                      Quantidade = "Peso"
                                      ,
                                      Total = (prod.PrecoVenda / 1000) * peso
                                      ,
                                      LucroTotal = ((((prod.PrecoVenda / 1000) * peso) * 100) / prod.Porcentagem)
                                  }).Where(c => c.Codigo == codigo);

                        AdicionarItensNoListView(ltvProdutos, _venda);

                    }
                }
                else
                {
                    MyErro.MyCustomException("Produto com esse código não esta cadastrado.");
                }


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
        public Produto GetProdutoPorCodigo(string codigo)
        {
            try
            {
                InstanciarDbContext();
                return _banco.Produto.FirstOrDefault(c => c.Codigo == codigo);


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
