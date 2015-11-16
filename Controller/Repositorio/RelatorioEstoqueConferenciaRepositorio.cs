using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller.Repositorio
{
    public class RelatorioEstoqueConferenciaRepositorio
    {
        private _DbContext banco { get; set; }
        public List<RelatorioEstoqueConferenciaViewModel> GetRelatorioConferencia()
        {

            try
            {
                using (banco = new _DbContext())
                {
                    return (from prod in banco.Produto.Where(c=>c.GerenciarEstoque == true)
                           select new RelatorioEstoqueConferenciaViewModel
                           {
                               Código = prod.Codigo,
                               Descrição = prod.Descricao,
                               Nome = prod.Nome,
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
