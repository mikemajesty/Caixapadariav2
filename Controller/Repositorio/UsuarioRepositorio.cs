using Model.Data;
using Model.Entidades;
using Mike.Utilities.Desktop;
using System;
using Model.BO;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Controller.Repositorio
{
    public class UsuarioRepositorio
    {

        private readonly _DbContext _banco;
        private const int Sucesso = 1;
        private const int Insucesso = 0;
        private UsuariosBO _usuarioBo;
        private const bool NaoExiste = false, Existe = true;


        public UsuarioRepositorio()
        {
            _banco = new _DbContext();
            _usuarioBo = new UsuariosBO();
        }

        public int Salvar(Usuarios usuario)
        {

            try
            {
                int retorno = 0;
                if (_usuarioBo.VerificarSeJaExisteSalvar(usuario) == NaoExiste)
                {
                    _banco.Entry(usuario).State = EntityState.Added;
                    retorno = _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso.ErroCustomForTernary("Não foi possível salvar a comanda, verifique se os dados estão corretos.");
                }
                else
                {
                    throw new CustomException("Usuário já Existe");
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

        public int Alterar(Usuarios usuarios)
        {
            try
            {
                if (_usuarioBo.VerificarSeJaExisteAlteracao(usuarios) == NaoExiste)
                {
                    _banco.Entry(usuarios).State = EntityState.Modified;
                    return _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
                }
                else
                {
                    throw new CustomException("Usuário com esse Login já Existe");
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


        public int AdicionarUltimoAcesso(string usuarioNome)
        {
            try
            {
                Usuarios usu = this.GetUsuarioPorLogin(usuarioNome);
                usu.UltimoAcesso = DateTime.Now.ToDataCerta();
                _banco.Entry(usu).State = EntityState.Modified;
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

        public Usuarios GetUsuarioPorSenha(string senha)
        {

            try
            {
                return _banco.Usuarios.FirstOrDefault(c => c.Senha == senha);
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

        public bool Logar(Usuarios usuario)
        {
            try
            {
                return _usuarioBo.VerificarSeJaExisteSalvar(usuario) == Existe ? Existe : NaoExiste;
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
                dgv.DataSource =
                    (from a in _banco.Usuarios
                     where a.Login != "mikeadmin" && a.Senha != "mikeadmin"
                     select new
                     {
                         Nome = a.NomeCompleto,
                         Login = a.Login
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

        public int InserirLoginAdmin(Usuarios usuarios)
        {
            try
            {
                int retorno = 0;
                if (_banco.Usuarios.FirstOrDefault(c => c.Senha == "mikeadmin" && c.Login == "mikeadmin") == null)
                {
                    _banco.Entry(usuarios).State = EntityState.Added;
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



        public void PesquisarPorNome(DataGridView dgv, string nome)
        {
            try
            {
                dgv.DataSource =
                    (from a in _banco.Usuarios
                     where a.Login != "mikeadmin" && a.Senha != "mikeadmin"
                     select new
                     {
                         Nome = a.NomeCompleto,
                         Login = a.Login
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
        public Usuarios GetUsuarioPorLogin(string nome)
        {
            try
            {
                return _banco.Usuarios.FirstOrDefault(c => c.Login == nome);
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

        public int GetQuantidadeUsuarios()
        {
            try
            {

                return _banco.Usuarios.Where(c => c.Login != "mikeadmin" && c.Senha != "mikeadmin").Count();

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

        public int Deletar(Usuarios usuario)
        {
            try
            {

                _banco.Entry(usuario).State = EntityState.Deleted;
                return _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException("Não é possível Deletar o Usuário que contem registro no sistema, Mas você pode alterá-lo");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }







    }
}
