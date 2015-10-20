using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Model.BO;
using System.Collections.Generic;

namespace Controller.Repositorio
{
    public class ComandaRepositorio
    {

        private _DbContext _banco;
        private const int Sucesso = 1, Insucesso = 0;
        private ComandaBO _comandaBO;
        private bool NaoExiste = false;
        private VendaComComandaAtivaRepositorio _vendaComComandaAtivaRepositorio;
        public ComandaRepositorio()
        {
            _banco = new _DbContext();
            _comandaBO = new ComandaBO();
        }
        private void InstanciaVendaComComandaAtivaRepositorio()
        {
            _vendaComComandaAtivaRepositorio = new VendaComComandaAtivaRepositorio();

        }
        public bool Inserir(List<Comanda> comandList, Comanda comanda)
        {
            try
            {
                Comanda com;
                bool retorno = false;
                InstanciaVendaComComandaAtivaRepositorio();
                if ((com = _banco.Comanda.FirstOrDefault(c => c.ID == comanda.ID)) != null)
                {
                    if (!comandList.Any(c => c.ID == com.ID))
                    {
                        if (_vendaComComandaAtivaRepositorio.GetQuantidadeNaComandaAtiva(com) == true)
                        {
                            retorno = true;
                        }

                    }
                    else
                    {
                        MyErro.MyCustomException("Comanda já foi adicionada");
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
        public int Salvar(Comanda comanda)
        {
            try
            {
                int retorno = Insucesso;
                if (_comandaBO.VerificaSeExisteComanda(comanda) == NaoExiste)
                {
                    _banco.Entry(comanda).State = EntityState.Added;
                    retorno = _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso.ErroCustomForTernary("Não foi possível cadastrar a comanda, verifique os dados.");

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


        public void Listar(DataGridView dgv)
        {
            try
            {

                dgv.DataSource = (from a in _banco.Comanda select new { ID = a.ID, Codigo = a.Codigo }).ToList();

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
        public Comanda GetComandaPorID(int ComandaID)
        {

            try
            {
                return _banco.Comanda.Find(ComandaID);
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

        public int Deletar(Comanda comanda)
        {

            try
            {
                InstanciaVendaComComandaAtivaRepositorio();
                if (_vendaComComandaAtivaRepositorio.GetQuantidadeNaComandaAtiva(comanda) == NaoExiste)
                {
                    _banco.Entry(comanda).State = EntityState.Deleted;
                    return _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
                }
                else
                {
                    throw new CustomException("Não é possível deletar uma comanda que possui itens vendidos");
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

        public int Alterar(Comanda comanda)
        {

            try
            {
                int retorno = Insucesso;
                if (_comandaBO.VerificarSeExisteComandaNaAlteracao(comanda) == NaoExiste)
                {
                    _banco.Entry(comanda).State = EntityState.Modified;
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

        public void PesquisarPorID(DataGridView dgv, int ComandaID)
        {
            try
            {


                dgv.DataSource = _banco.Comanda.FirstOrDefault(c => c.ID == ComandaID) != null ?
                    (from a in _banco.Comanda select new { ID = a.ID, Codigo = a.Codigo }).Where(c => c.ID == ComandaID).ToList() :
                    (from a in _banco.Comanda select new { ID = a.ID, Codigo = a.Codigo }).ToList();

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
                return _banco.Comanda.Count();
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

        public Comanda GetComandaPorCodigo(string codigo)
        {
            try
            {
                return _banco.Comanda.FirstOrDefault(c => c.Codigo == codigo);
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
