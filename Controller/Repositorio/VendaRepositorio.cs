using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class VendaRepositorio
    {
        private _DbContext _banco;
        private TipoPagamentoRepositorio _tipoPagamentoRePositorio;
        private const int Sucesso = 1, Insucesso = 0;
        private void IntanciarVendaRepositorio()
        {
            _banco = new _DbContext();
        }
        private void InstanciarTipoDePagamentoRepositorio()
        {
            _tipoPagamentoRePositorio = new TipoPagamentoRepositorio();
        }
        public int Cadastrar(Venda venda)
        {
            try
            {
                IntanciarVendaRepositorio();
                _banco.Entry(venda).State = EntityState.Added;
                return _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
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
                IntanciarVendaRepositorio();

                dgv.DataSource = _banco.Venda.ToList();
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


        public void ListarMovimentacaoEntreDatas(DateTimePicker dtpInicial, DateTimePicker dtpFinal, DataGridView dgv, string tipoMovimentacao)
        {
            try
            {

                IntanciarVendaRepositorio();
                InstanciarTipoDePagamentoRepositorio();

                if (tipoMovimentacao != "Todos")
                {
                    int IDTipoDeMovimentacao = _tipoPagamentoRePositorio.GetIDPeloNome(tipoMovimentacao);

                    dgv.DataSource = (from venda in _banco.Venda
                                      join usu in _banco.Usuarios on venda.IdUsuario equals usu.ID
                                      join tipoPag in _banco.TipoPagamento on venda.IDTIPOPAGAMENTO equals tipoPag.ID
                                      where
                                         venda.Data >= dtpInicial.Value.Date
                                      && venda.Data <= dtpFinal.Value.Date
                                      && venda.IDTIPOPAGAMENTO == IDTipoDeMovimentacao
                                      select new
                                      {
                                          Valor_Vendido = venda.VendaTotal,
                                          Valor_Lucro = venda.LucroTotal,
                                          Data = venda.Data,
                                          Funcionario = usu.NomeCompleto,
                                          Tipo_Pagamento = tipoPag.Tipo
                                      }).ToList();
                }
                else
                {
                    dgv.DataSource = (from venda in _banco.Venda
                                      join usu in _banco.Usuarios on venda.IdUsuario equals usu.ID
                                      join tipoPag in _banco.TipoPagamento on venda.IDTIPOPAGAMENTO equals tipoPag.ID
                                      where
                                         venda.Data >= dtpInicial.Value.Date
                                      && venda.Data <= dtpFinal.Value.Date

                                      select new
                                      {
                                          Valor_Vendido = venda.VendaTotal,
                                          Valor_Lucro = venda.LucroTotal,
                                          Data = venda.Data,
                                          Funcionario = usu.NomeCompleto,
                                          Tipo_Pagamento = tipoPag.Tipo
                                      }).ToList();
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

        public void ListarTodos(DataGridView dgv)
        {
            try
            {

                IntanciarVendaRepositorio();
                dgv.DataSource = (from venda in _banco.Venda
                                  join usu in _banco.Usuarios on venda.IdUsuario equals usu.ID
                                  join tipoPag in _banco.TipoPagamento on venda.IDTIPOPAGAMENTO equals tipoPag.ID

                                  select new
                                  {
                                      Valor_Vendido = venda.VendaTotal,
                                      Valor_Lucro = venda.LucroTotal,
                                      Data = venda.Data,
                                      Funcionario = usu.NomeCompleto,
                                      Tipo_Pagamento = tipoPag.Tipo
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

        public int ExcluirUltimaVenda()
        {
            try
            {
                IntanciarVendaRepositorio();
                Venda venda = _banco.Venda.OrderByDescending(u => u.ID).FirstOrDefault();
                _banco.Entry(venda).State = EntityState.Deleted;
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


        public void ListarMovimentacaoPorData(DateTimePicker dtpPesquisarPorDia, DataGridView dgvMovimentacao, string tipoMovimentacao)
        {
            try
            {

                IntanciarVendaRepositorio();
                InstanciarTipoDePagamentoRepositorio();
                if (tipoMovimentacao != "Todos")
                {
                    int IDTipoDeMovimentacao = _tipoPagamentoRePositorio.GetIDPeloNome(tipoMovimentacao);
                    dgvMovimentacao.DataSource = (from venda in _banco.Venda
                                                  join usu in _banco.Usuarios on venda.IdUsuario equals usu.ID
                                                  join tipoPag in _banco.TipoPagamento on venda.IDTIPOPAGAMENTO equals tipoPag.ID
                                                  where
                                                     venda.Data == dtpPesquisarPorDia.Value.Date
                                                     && tipoPag.ID == IDTipoDeMovimentacao
                                                  select new
                                                  {
                                                      Valor_Vendido = venda.VendaTotal,
                                                      Valor_Lucro = venda.LucroTotal,
                                                      Data = venda.Data,
                                                      Funcionario = usu.NomeCompleto,
                                                      Tipo_Pagamento = tipoPag.Tipo
                                                  }).ToList();
                }
                else
                {

                    dgvMovimentacao.DataSource = (from venda in _banco.Venda
                                                  join usu in _banco.Usuarios on venda.IdUsuario equals usu.ID
                                                  join tipoPag in _banco.TipoPagamento on venda.IDTIPOPAGAMENTO equals tipoPag.ID
                                                  where
                                                     venda.Data == dtpPesquisarPorDia.Value.Date
                                                  select new
                                                  {
                                                      Valor_Vendido = venda.VendaTotal,
                                                      Valor_Lucro = venda.LucroTotal,
                                                      Data = venda.Data,
                                                      Funcionario = usu.NomeCompleto,
                                                      Tipo_Pagamento = tipoPag.Tipo
                                                  }).ToList();
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
