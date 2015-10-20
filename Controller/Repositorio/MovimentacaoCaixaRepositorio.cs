using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class MovimentacaoCaixaRepositorio
    {
        private _DbContext _banco;
        private void InstanciarBanco()
        {
            _banco = new _DbContext();
        }

        public int Salvar(MovimentacaoCaixa movimentacaoCaixa)
        {
            try
            {
                InstanciarBanco();
                _banco.Entry(movimentacaoCaixa).State = EntityState.Added;
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

        public void ListarPorDia(DataGridView dgv, DateTimePicker dtp)
        {
            try
            {
                InstanciarBanco();
                dgv.DataSource = (from movimentacaoCaixa in
                                      (from mcaixa in _banco.MovimentacaoCaixa
                                       where mcaixa.Data == dtp.Value.Date
                                       select new
                                       {
                                           mcaixa.Valor,
                                           mcaixa.Data
                                       })
                                  group movimentacaoCaixa by new { movimentacaoCaixa.Data } into g
                                  select new
                                  {
                                      Valor = g.Sum(p => p.Valor),
                                      Data = g.Key.Data
                                  }).ToList();

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
                InstanciarBanco();
                dgv.DataSource = ((from movimentacaoCaixa in _banco.MovimentacaoCaixa
                                   group movimentacaoCaixa by new
                                   {
                                       movimentacaoCaixa.Data
                                   } into g
                                   select new
                                   {
                                       Valor = g.Sum(p => p.Valor),
                                       Data = g.Key.Data
                                   }).Distinct()).ToList();

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
        public void ListarEntreDatas(DataGridView dgv, DateTimePicker dtpInicial, DateTimePicker dtpFinal)
        {
            try
            {
                InstanciarBanco();
                dgv.DataSource = ((from movimentacaoCaixa in _banco.MovimentacaoCaixa
                                   where movimentacaoCaixa.Data >= dtpInicial.Value.Date
                                       && movimentacaoCaixa.Data <= dtpFinal.Value.Date
                                   group movimentacaoCaixa by new
                                   {
                                       movimentacaoCaixa.Data
                                   } into g
                                   select new
                                   {
                                       Valor = g.Sum(p => p.Valor),
                                       Data = g.Key.Data
                                   }).Distinct()).ToList();

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
                InstanciarBanco();
                return _banco.MovimentacaoCaixa.Count();

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
