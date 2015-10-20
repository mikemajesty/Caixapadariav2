using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Linq;

namespace Model.BO
{
    public class ComandaBO
    {
        private readonly _DbContext _banco;
        private bool Existe = true, NaoExiste = false;
        public ComandaBO()
        {
            _banco = new _DbContext();
        }

        public bool VerificaSeExisteComanda(Comanda comanda)
        {
            try
            {
                return _banco.Comanda.FirstOrDefault(c => c.Codigo == comanda.Codigo) != null ? Existe.RetornaErro("Comanda já Existe.") : NaoExiste;
                
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
        public bool VerificarSeExisteComandaNaAlteracao(Comanda comanda)
        {
            try
            {

                bool existe = false;

                if (_banco.Comanda.Find(comanda.ID).Codigo != comanda.Codigo)
                {
                    if (_banco.Comanda.Any(c => c.Codigo == comanda.Codigo))
                    {
                        existe = true.RetornaErro("Comanda já existe.");
                    }

                }
                return existe;

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
