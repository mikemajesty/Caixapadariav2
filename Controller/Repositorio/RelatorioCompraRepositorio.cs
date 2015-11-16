using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller.Repositorio
{
    public class RelatorioCompraRepositorio
    {
        public _DbContext Banco { get; private set; }

        public List<RelatorioComprasViewModel> GerarRelatorioDeVendas()
        {

            try
            {
                using (Banco = new _DbContext())
                {
                    return (from prod in Banco.Produto
                            join cat in Banco.Categoria on prod.Categoria equals cat.ID
                            where (prod.Quantidade < ((prod.QuantidadeMaxima + prod.QuantidadeMinima) / 2))
                            select new RelatorioComprasViewModel
                            {
                                Código = prod.Codigo,
                                Nome = prod.Nome,
                                Descrição = prod.Nome,
                                Comprar = prod.QuantidadeMaxima - prod.Quantidade,
                                Quantidade = prod.Quantidade
                            }).ToList();
                }

            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

    }
}
