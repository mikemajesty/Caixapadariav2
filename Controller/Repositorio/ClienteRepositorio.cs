using Mike.Utilities.Desktop;
using Model.BO;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class ClienteRepositorio
    {
        private readonly _DbContext _banco;
        private const int Sucesso = 1, Insucesso = 0;
        private ClienteBO _clienteBO;
        private bool NaoExiste = false;
        private void InstanciarClienteBO()
        {
            _clienteBO = new ClienteBO();
        }
        public ClienteRepositorio()
        {
            _banco = new _DbContext();
        }

        public void ListarParaVender(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = (from cli in _banco.Cliente select new { ID = cli.ID, Nome = cli.Nome, CPF = cli.CPF, Celular = cli.Celular }).ToList();
                dgv.AjustartamanhoDoDataGridView(new List<TamanhoGrid>()
                {
                   
                     new TamanhoGrid(){ ColunaNome = "Nome", Tamanho = 228},
                     new TamanhoGrid(){ ColunaNome = "CPF", Tamanho = 150},
                     new TamanhoGrid(){ ColunaNome = "Celular", Tamanho = 150}
                });
                dgv.EsconderColuna("ID");
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



        public int Salvar(Cliente cliente)
        {

            try
            {
                InstanciarClienteBO();
                int retorno = Insucesso;
                if (_clienteBO.VerificarSeJaExisteNoSalvamento(cliente) == NaoExiste)
                {
                    _banco.Entry(cliente).State = EntityState.Added;
                    retorno = _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso.ErroCustomForTernary("Não foi possível salvar o cliente");
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

        public Cliente GetClientePorID(int ClienteID)
        {
            try
            {
                return _banco.Cliente.Find(ClienteID);

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

        public int Alterar(Cliente cliente)
        {
            try
            {
                InstanciarClienteBO();
                int retorno = Insucesso;
                if (_clienteBO.VerificarSeJaExisteNaAlteracao(cliente) == NaoExiste)
                {
                    _banco.Entry(cliente).State = EntityState.Modified;
                    retorno = _banco.SaveChanges() == Sucesso ? Sucesso : Sucesso;
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

        public int Deletar(Cliente cliente)
        {
            try
            {
                _banco.Entry(cliente).State = EntityState.Deleted;
                return _banco.SaveChanges() == Sucesso ? Sucesso : Sucesso;

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

        public void ListarClientePorNomeVender(DataGridView dgv, string nome)
        {
            try
            {
                dgv.DataSource =
                    (from cli in _banco.Cliente
                     select new
                     {
                         ID = cli.ID,
                         Nome = cli.Nome,
                         CPF = cli.CPF,
                         Celular = cli.Celular
                     }).Where(c => c.Nome.Contains(nome)).ToList();


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
                return _banco.Cliente.Count();
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

