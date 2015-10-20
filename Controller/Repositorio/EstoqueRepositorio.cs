using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{

    public class EstoqueRepositorio
    {
        private _DbContext _banco;
        private TipoCadastroRepositorio _tipoCadastroRepositorio;
        private MovimentacaoProdutoRepositorio _movimentacaoProdutoRepositorio;
        private const int Unidade = 3;
        private const bool NaoGerenciarEstoque = false, GerenciarEstoque = true;
        private void InstanciarTipoCadastroRepositorio()
        {
            _tipoCadastroRepositorio = new TipoCadastroRepositorio();
        }
        private void InstanciarMovimentacaoProdutoRepositorio()
        {
            _movimentacaoProdutoRepositorio = new MovimentacaoProdutoRepositorio();
        }

        public int GetIDTipoCategoria(string nome)
        {
            try
            {

                InstanciarTipoCadastroRepositorio();
                return _tipoCadastroRepositorio.GetIDPeloNome(nome);

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
        public List<int> VerificarSeEstaAbaixoDoEstoque()
        {
            try
            {

                List<int> listProdID = new List<int>();
                foreach (var item in SelectNoEstoqueAbaixoDoAceitavel())
                {
                    listProdID.Add(item.ID);
                   
                }
                return listProdID;
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
            InstanciarDbContext();

            try
            {

                dgv.DataSource = SelectNoEstoque();
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
        public IEnumerable SelectNoEstoque()
        {



            try
            {

                int TipoCadastro = GetIDTipoCategoria("Unidade");
                InstanciarDbContext();
                return (from prod in _banco.Produto
                     join cat in _banco.Categoria on prod.Categoria equals cat.ID
                     where prod.TipoCadastro == TipoCadastro
                     select new 
                     {
                         ID = prod.ID,
                         Código = prod.Codigo,
                         Min = prod.QuantidadeMinima,
                         Max = prod.QuantidadeMaxima,
                         Quantidade = prod.Quantidade,
                         Nome = prod.Nome,
                         Categoria = cat.Nome
                     }).OrderBy(c => c.Nome).ToList();
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
        public dynamic SelectNoEstoqueAbaixoDoAceitavel()
        {



            try
            {

                int TipoCadastro = GetIDTipoCategoria("Unidade");
                InstanciarDbContext();
                return (from prod in _banco.Produto
                        join cat in _banco.Categoria on prod.Categoria equals cat.ID
                        where prod.TipoCadastro == TipoCadastro && prod.Quantidade < prod.QuantidadeMinima
                        select new
                        {
                            ID = prod.ID,
                            Código = prod.Codigo,
                            Min = prod.QuantidadeMinima,
                            Max = prod.QuantidadeMaxima,
                            Quantidade = prod.Quantidade,
                            Nome = prod.Nome,
                            Categoria = cat.Nome
                        }).OrderBy(c => c.Nome).ToList();
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
        private void InstanciarDbContext()
        {
            _banco = new _DbContext();
        }



        public Produto GetLinhaPeloID(int ProdutoID)
        {



            try
            {

                InstanciarDbContext();
                return _banco.Produto.Find(ProdutoID);
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

        public void ListarPorNome(DataGridView dgv, string nome)
        {
            InstanciarDbContext();

            try
            {

                int TipoCadastro = GetIDTipoCategoria("Unidade");
                dgv.DataSource = (from prod in _banco.Produto
                                  join cat in _banco.Categoria on prod.Categoria equals cat.ID
                                  where prod.TipoCadastro == TipoCadastro && prod.GerenciarEstoque == GerenciarEstoque
                                  select new
                                  {
                                      ID = prod.ID,
                                      Código = prod.Codigo,
                                      Min = prod.QuantidadeMinima,
                                      Max = prod.QuantidadeMaxima,
                                      Quantidade = prod.Quantidade,
                                      Nome = prod.Nome,
                                      Categoria = cat.Nome
                                  }).OrderBy(c => c.Nome).Where(c => c.Nome.Contains(nome)).ToList();
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
                int TipoCadastro = GetIDTipoCategoria("Unidade");
                return _banco.Produto.Count(c => c.TipoCadastro == TipoCadastro);
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

        public void DarBaixa(Produto produto, Estoque estoque)
        {
            try
            {


                if (produto.GerenciarEstoque == GerenciarEstoque)
                {
                    InstanciarDbContext();
                    produto.Quantidade -= estoque.Quantidade;
                    _banco.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                    _banco.SaveChanges();
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

        public void ListarPorCodigo(DataGridView dgv, string codigo)
        {
            InstanciarDbContext();

            try
            {
                int TipoCadastro = GetIDTipoCategoria("Unidade");

                var lista = (from prod in _banco.Produto
                             join cat in _banco.Categoria on prod.Categoria equals cat.ID
                             where prod.TipoCadastro == TipoCadastro && prod.GerenciarEstoque == GerenciarEstoque
                             select new
                             {
                                 ID = prod.ID,
                                 Código = prod.Codigo,
                                 Min = prod.QuantidadeMinima,
                                 Max = prod.QuantidadeMaxima,
                                 Quantidade = prod.Quantidade,
                                 Nome = prod.Nome,
                                 Categoria = cat.Nome
                             }).OrderBy(c => c.Nome).Where(c => c.Código == codigo).ToList();
                if (lista.Count > 0)
                {
                    dgv.DataSource = lista;
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
    }
}
