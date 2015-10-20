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
                if (usuario == null)
                {
                    return false;
                }
                else
                {
                    Usuarios.IDStatic = usuario.ID;
                    return true;
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
        public bool VerificarSeExisteAdministrador(Usuarios usuario)
        {
            try
            {
                bool retorno = false;
                if (banco.Usuarios.Where(c=>c.Permicao == "Administrador").Count() == 2)
                {
                    retorno = true;
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
