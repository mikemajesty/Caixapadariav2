using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Model.BO;
namespace Controller.Repositorio
{
    public class CategoriaRepositorio
    {
        private readonly _DbContext _banco;
        private const int Sucesso = 1, Insucesso = 0;
        private const bool NaoExiste = false;
        public CategoriaRepositorio()
        {
            _banco = new _DbContext();
        }

        public void Listar(DataGridView dgv)
        {
            try
            {

                dgv.DataSource = (from a in _banco.Categoria select new { ID = a.ID, Nome = a.Nome }).ToList();

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

        public int Cadastrar(Categoria categoria)
        {
            try
            {
                int retorno = Insucesso;
                if (new CategoriaBO().VerificarSeJaExisteNoSalvamento(categoria: categoria) == NaoExiste)
                {
                    _banco.Entry(categoria).State = EntityState.Added;
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

        public int Alterar(Categoria categoria)
        {
            try
            {
                int retorno = Insucesso;
                if (new CategoriaBO().VerificarSeJaExisteNaAlteracao(categoria) == NaoExiste)
                {
                    _banco.Entry(categoria).State = EntityState.Modified;
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
        public Categoria GetCategoriaPorID(int CategoriaID)
        {

            try
            {
                return _banco.Categoria.Find(CategoriaID);
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
        public int Deletar(Categoria categoria)
        {

            try
            {
                if (_banco.Produto.FirstOrDefault(c=>c.Categoria == categoria.ID) == null)
                {
                    _banco.Entry(categoria).State = EntityState.Deleted;
                    return _banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
                }
                else
                {
                    throw new CustomException("Não é possível deletar uma Categoria associada a um produto.");
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

        public void PesquisaCategoriaPeloNome(DataGridView dgv, string nome)
        {
            try
            {

                dgv.DataSource = (from a in _banco.Categoria select new { ID = a.ID, Nome = a.Nome }).Where(c => c.Nome.Contains(nome)).ToList();

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

        public int GetIdDaCategoriaPeloNome(string nome)
        {
            try
            {
                Categoria categoria = _banco.Categoria.FirstOrDefault(c => c.Nome == nome);
                if (categoria != null)
                {
                    return categoria.ID;
                }
                else
                {
                    return 0;
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




        public void CarregaCategoria(ComboBox cbb)
        {
            try
            {
                cbb.DisplayMember = "Nome";
                cbb.DataSource = _banco.Categoria.ToList();

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

        public string GetCategoriaNomePeloID(int CategoriID)
        {
            try
            {
                return _banco.Categoria.Find(CategoriID).Nome;
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
                return _banco.Categoria.Count();
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

        public void CarregaCategoriaSelecionada(ComboBox cbb)
        {
            try
            {
                cbb.DisplayMember = "Nome";
                cbb.DataSource = _banco.Categoria.ToList();
                cbb.Text = GetUltimoRegistroDoBanco();
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

        private string GetUltimoRegistroDoBanco()
        {
            try
            {
               Categoria categoria =  _banco.Categoria.OrderByDescending(c => c.ID).FirstOrDefault();
               return categoria.Nome;
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
