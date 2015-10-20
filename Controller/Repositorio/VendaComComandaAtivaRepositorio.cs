using Mike.Utilities.Desktop;
using Model.Data;
using System;
using System.Linq;
using Model.Entidades;
using System.Windows.Forms;
using System.Data.Entity;
namespace Controller.Repositorio
{
    public class VendaComComandaAtivaRepositorio
    {
        private _DbContext _banco;
        private ComandaRepositorio _comandaRepositorio;
        private VendaComComandaAtiva _vendaComComandaAtiva;
        private const bool Existe = true, NaoExiste = false;
        private void InstanciaBanco()
        {
            _banco = new _DbContext();
        }
        private void InstanciarComandaRepositorio()
        {
            _comandaRepositorio = new ComandaRepositorio();
        }
        private void InstanciarVendaComComandaAtiva()
        {
            _vendaComComandaAtiva = new VendaComComandaAtiva();
        }
        public void GetItensnaComandaPorCodigo(string codigo, ListView ltv)
        {
            try
            {

                InstanciaBanco();
                IQueryable<dynamic> _venda = (from venda in _banco.VendaComComandaAtiva
                                              join comanda in _banco.Comanda on venda.IDComanda equals
                                                  comanda.ID
                                              join prod in _banco.Produto on venda.IDProduto equals prod.ID
                                              where comanda.Codigo == codigo
                                              select new
                                              {
                                                  Nome = prod.Nome,
                                                  Codigo = prod.Codigo,
                                                  Quantidade = venda.Quantidade,
                                                  Total = venda.PrecoTotal,
                                                  LucroTotal =
                                                  venda.Quantidade == 0 ?
                                                  ((venda.PrecoTotal * 100) / prod.Porcentagem) :
                                                  ((prod.PrecoVenda - prod.PrecoCompra) * venda.Quantidade)
                                              });

                AdicionarItensNoListView(ltv, _venda);


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
        public void GetItensnaComandaPorID(int ID, ListView ltv)
        {
            try
            {

                InstanciaBanco();
                IQueryable<dynamic> _venda = (from venda in _banco.VendaComComandaAtiva
                                              join comanda in _banco.Comanda on venda.IDComanda equals
                                                  comanda.ID
                                              join prod in _banco.Produto on venda.IDProduto equals prod.ID
                                              where comanda.ID == ID
                                              select new
                                              {
                                                  Nome = prod.Nome,
                                                  Codigo = prod.Codigo,
                                                  Quantidade = venda.Quantidade,
                                                  Total = venda.PrecoTotal,
                                                  LucroTotal =
                                                  venda.Quantidade == 0 ?
                                                  ((prod.Porcentagem * venda.PrecoTotal) / 100) :
                                                  ((prod.PrecoVenda - prod.PrecoCompra) * venda.Quantidade)
                                              });

                AdicionarItensNoListView(ltv, _venda);


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
                    if (item.Quantidade == 0)
                    {
                        listView.SubItems.Add("Peso");
                    }
                    else
                    {
                        listView.SubItems.Add("" + item.Quantidade);
                    }
                    listView.SubItems.Add("" + item.Total);
                    listView.SubItems.Add("" + item.LucroTotal);
                    ltv.Items.Add(listView);
                }


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


        public int DeletaItensDaComandaPorCodigo(string codigo)
        {
            try
            {
                InstanciaBanco();
                int retorno = 0;
                Comanda comanda = _banco.Comanda.FirstOrDefault(c=>c.Codigo == codigo);
                var listaVenda = _banco.VendaComComandaAtiva.Where(c => c.IDComanda == comanda.ID);
                foreach (var venda in listaVenda)
	            {
		           _banco.Entry(venda).State = EntityState.Deleted;
                    retorno = _banco.SaveChanges();
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







        public bool GetQuantidadeNaComandaAtiva(Comanda comanda)
        {

            try
            {

                InstanciaBanco(); 
                bool retorno = _banco.VendaComComandaAtiva.Where(c=>c.IDComanda == comanda.ID).Count() >  0 ? Existe : NaoExiste;
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
    }
}
