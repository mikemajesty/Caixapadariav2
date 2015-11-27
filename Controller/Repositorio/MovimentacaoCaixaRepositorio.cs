using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class MovimentacaoCaixaRepositorio
    {
        private _DbContext _banco;
        private void InstanciarBanco()
                     => _banco = new _DbContext();
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
        public DateTime GetMinimunDate()
        {
            try
            {
                InstanciarBanco();
                var date = DateTime.Now;
                if (this.GetQuantidade() > 0)
                {
                    date = _banco.MovimentacaoCaixa.Min(c => c.Data);
                }
                return date;
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
        public DateTime GetMaximunDate()
        {
            try
            {
                InstanciarBanco();
                var date = DateTime.Now;
                if (this.GetQuantidade() > 0)
                {
                    date = _banco.MovimentacaoCaixa.Max(c => c.Data);
                }
                return date;
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

        public int RetirarValor(decimal valor, DateTime data)
        {

            try
            {
                InstanciarBanco();
                var movimentacaoCaixa = _banco.MovimentacaoCaixa.FirstOrDefault(c => c.Data == data.Date/*c=>c.Valor >= valor*/);
                int retorno = 0;
                if (movimentacaoCaixa != null)
                {
                    movimentacaoCaixa.Valor -= valor;
                    retorno = this.Alterar(movimentacaoCaixa) == true ? 1 : 0;
                }
                return retorno;
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
        private bool Alterar(MovimentacaoCaixa mov)
        {

            try
            {
                InstanciarBanco();
                _banco.Entry<MovimentacaoCaixa>(mov).State = EntityState.Modified;
                return _banco.SaveChanges() > 0;
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
