using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class TipoCadastroRepositorio
    {
        private  _DbContext _banco;
        
        private void InstanciarBanco()
        {
            _banco = new _DbContext();
        }
        public void Listar(ComboBox cbb)
        {
            try
            {
                InstanciarBanco();
                cbb.DisplayMember = "Nome";
                cbb.DataSource = _banco.TipoCadastro.ToList();
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

        public int GetIDPeloNome(string nome)
        {
            try
            {
                InstanciarBanco();
                return _banco.TipoCadastro.FirstOrDefault(c=>c.Nome == nome).TipoCadastroID;
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
        public string GetNomePeloID(int TipoCadastroID)
        {
            try
            {
                InstanciarBanco();
                return _banco.TipoCadastro.Find(TipoCadastroID).Nome;
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

        public int Cadastrar()
        {
            try
            {
                int contador = 0;
                InstanciarBanco();
                if (GetQuantidade() != 2)
                {
                    foreach (TipoCadastro tipo in TipoDeCadastroList())
                    {
                        _banco.Entry(tipo).State = System.Data.Entity.EntityState.Added;
                        contador += _banco.SaveChanges();
                    }
                }
               
                return contador;

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
                return _banco.TipoCadastro.Count();
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

        private List<TipoCadastro> TipoDeCadastroList()
        {

            try
            {
                return new System.Collections.Generic.List<TipoCadastro>()
                {
                     new TipoCadastro(){ Nome="Unidade"},
                     new TipoCadastro(){ Nome="Peso"} 
                };

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
