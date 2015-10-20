using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class MovimentacaoProdutoRepositorio
    {
        private _DbContext _banco;
        private void InstanciarBanco()
        {
            _banco = new _DbContext();
        }

        public int Cadastrar(MovimentacaoProduto movimentacaProduto)
        {
            try
            {
                InstanciarBanco();
                _banco.Entry(movimentacaProduto).State = EntityState.Added;
                return _banco.SaveChanges();

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



        public void ListarTodos(DataGridView dgv,string codigo)
        {

            try
            {
                InstanciarBanco();
                dgv.DataSource = ((from mov in _banco.MovimentacaoProduto
                                   join prod in _banco.Produto on new { Codigo = mov.Codigo } equals new { Codigo = prod.Codigo }
                                   where prod.Codigo == codigo
                                   group new { mov, prod } by new
                                   {
                                       mov.Codigo,
                                       prod.Nome
                                   } into g
                                   select new
                                   {
                                       Código = g.Key.Codigo,
                                       Nome = g.Key.Nome,
                                       Quantidade = (g.Sum(p => p.mov.Quantidade)),
                                       Total = g.Sum(p => p.mov.Valor)
                                   }).Distinct()).ToList();

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

        public void ListarPordata(DataGridView dgv, string codigo, DateTimePicker dtp)
        {
            try
            {
                InstanciarBanco();
                dgv.DataSource = ((from mov in _banco.MovimentacaoProduto
                                   join prod in _banco.Produto on new { Codigo = mov.Codigo } equals new { Codigo = prod.Codigo }
                                   where prod.Codigo == codigo && mov.Data == dtp.Value.Date
                                   group new { mov, prod } by new
                                   {
                                       mov.Codigo,
                                       prod.Nome
                                   } into g
                                   select new
                                   {
                                       Código = g.Key.Codigo,
                                       Nome = g.Key.Nome,
                                       Quantidade = g.Sum(p => p.mov.Quantidade),
                                       Total = g.Sum(p => p.mov.Valor)
                                   }).Distinct()).ToList();

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

        public void ListarEntredatas(DataGridView dgv, string codigo, DateTimePicker dtpInicial, DateTimePicker dtpFinal)
        {
            try
            {
                InstanciarBanco();
                dgv.DataSource = ((from mov in _banco.MovimentacaoProduto
                                   join prod in _banco.Produto on new { Codigo = mov.Codigo } equals new { Codigo = prod.Codigo }
                                   where prod.Codigo == codigo && mov.Data >= dtpInicial.Value.Date && mov.Data <= dtpFinal.Value.Date
                                   group new { mov, prod } by new
                                   {
                                       mov.Codigo,
                                       prod.Nome
                                   } into g
                                   select new
                                   {
                                       Código = g.Key.Codigo,
                                       Nome = g.Key.Nome,
                                       Quantidade = g.Sum(p => p.mov.Quantidade),
                                       Total = g.Sum(p => p.mov.Valor)
                                   }).Distinct()).ToList();

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
