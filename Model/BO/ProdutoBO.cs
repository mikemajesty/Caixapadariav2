using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Linq;

namespace Model.BO
{
    public class ProdutoBO
    {
        private readonly _DbContext _banco;
        private bool Existe = true, NaoExiste = false;
        public ProdutoBO()
        {
            _banco = new _DbContext();
        }

        public bool VerificaSeExisteProduto(Produto produto)
        {
            try
            {
                return _banco.Produto.FirstOrDefault(c => c.Codigo == produto.Codigo) != null ? Existe.RetornaErro("Produto com esse código já esta cadastrado.") : NaoExiste;

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
        public bool VerificarSeExisteProdutoNaAlteracao(Produto produto)
        {
            try
            {

                bool existe = false;

                if (_banco.Produto.Find(produto.ID).Codigo != produto.Codigo)
                {
                    if (_banco.Produto.Any(c => c.Codigo == produto.Codigo))
                    {
                        existe = true.RetornaErro("Produto com esse código já esta cadastrado.");
                    }

                }
                return existe;

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
        public bool VerificarSeEstaNaComanda(Produto produto)
        {
            try
            {

                bool existe = false;

                if (_banco.VendaComComandaAtiva.FirstOrDefault(c => c.IDProduto == produto.ID) != null)
                {
                    existe = true.RetornaErro("Não é possível deletar um produto que esta na Comanda");
                }
                return existe;

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
        public bool VerificarSeEstaNaMovimentacao(Produto produto)
        {
            try
            {

                bool existe = false;

                if (_banco.MovimentacaoProduto.FirstOrDefault(c => c.Codigo == produto.Codigo && c.Valor > 0) != null)
                {
                    existe = true.RetornaErro("Não é possível deletar um produto que esta na Movimentação de Produto");
                }
                return existe;

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
