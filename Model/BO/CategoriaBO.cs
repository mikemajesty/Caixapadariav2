using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Linq;

namespace Model.BO
{
    public class CategoriaBO
    {
        private readonly _DbContext _banco;
        private const bool Existe = true, NaoExiste = false; 
        public CategoriaBO()
        {
            _banco = new _DbContext();
        }

        public bool VerificarSeJaExisteNoSalvamento(Categoria categoria)
        {
            try
            {
                return _banco.Categoria.FirstOrDefault(c => c.Nome == categoria.Nome) != null ? Existe.RetornaErro("Categoria já existe.") : NaoExiste;
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
        public bool VerificarSeJaExisteNaAlteracao(Categoria categoria)
        {
            try
            {
                bool retorno = NaoExiste;
                if (_banco.Categoria.Find(categoria.ID).Nome != categoria.Nome)
                {
                    if (_banco.Categoria.Any(c=>c.Nome == categoria.Nome))
                    {
                        retorno = Existe.RetornaErro("Categoria já existe.");
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
