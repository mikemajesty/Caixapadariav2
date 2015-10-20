using Model.Entidades;
using Mike.Utilities.Desktop;
using System;
using System.Linq;
using Model.Data;

namespace Model.BO
{
    public class UsuariosBO
    {
        private readonly _DbContext banco;
        public UsuariosBO()
        {
            banco = new _DbContext();
        }
        public bool VerificarSeJaExisteSalvar(Usuarios nomeUsuarios)
        {
            try
            {
                 
                Usuarios usuario = banco.Usuarios.FirstOrDefault(c => c.Login == nomeUsuarios.Login && c.Senha == nomeUsuarios.Senha);
                return usuario == null ? false : true;

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
        public bool VerificarSeJaExisteAlteracao(Usuarios usuario)
        {
            try
            {
               
                bool existe = false;

                if (banco.Usuarios.Find(usuario.ID).Login.ToLower() != usuario.Login.ToLower())
                {
                    if (banco.Usuarios.Any(c => c.Login == usuario.Login))
                    {
                        existe = true;
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
