using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class SangriaRepositorio
    {
        public _DbContext Banco { get; private set; }

        public bool Salvar(Sangria sangria)
        {

            try
            {
                using (Banco = new _DbContext())
                {
                    Banco.Entry<Sangria>(sangria).State = EntityState.Added;
                    return SaveChanges() > 0 ? true : false;
                }
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }
        public void Listar(DataGridView dgv)
        {

            try
            {
                using (Banco = new _DbContext())
                {
                    dgv.DataSource = Banco.Sangria;
                }
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }
        private int SaveChanges()
                    => Banco.SaveChanges();
    }
}
