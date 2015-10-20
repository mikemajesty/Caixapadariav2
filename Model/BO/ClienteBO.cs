using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Linq;

namespace Model.BO
{
    public class ClienteBO
    {
        private _DbContext _banco;
        private const bool Existe = true, NaoExiste = false;
        public void InstanciarBanco()
        {
            _banco = new _DbContext();
        }
        public bool VerificarSeJaExisteNoSalvamento(Cliente cliente)
        {
            try
            {
                InstanciarBanco();
                return _banco.Cliente.FirstOrDefault(c => c.CPF == cliente.CPF) != null ? Existe.RetornaErro("CPF já existe.") : NaoExiste;
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
        public bool VerificarSeJaExisteNaAlteracao(Cliente cliente)
        {
            try
            {
                bool retorno = NaoExiste;
                InstanciarBanco();
                if (_banco.Cliente.Find(cliente.ID).CPF !=  cliente.CPF)
                {
                    if (_banco.Cliente.Any(c => c.CPF == cliente.CPF))
                    {
                        retorno = Existe.RetornaErro("CPF já existe.");
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
    }
}
