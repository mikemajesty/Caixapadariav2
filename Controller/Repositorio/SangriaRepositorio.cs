using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;
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
                    return SaveChanges() > 0;
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
        public void ListarFullPorData(DataGridView dgv, DateTime data)
        {
            try
            {
                using (Banco = new _DbContext())
                {
                    dgv.DataSource = (from san in Banco.Sangria
                                      join usu in
            Banco.Usuarios on san.UsuarioID equals usu.ID where san.Data == data.Date 
                                      select new SangriaViewModel
                                      {
                                          ID = san.ID,
                                          Data = san.Data
                                          Usuario = usu.NomeCompleto,
                                          Valor = san.valor
                                      }).ToList();
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
        public void ListarFull(DataGridView dgv)
        {

            try
            {
                using (Banco = new _DbContext())
                {
                    //Usando o distinct
                    //        dgv.DataSource = (from san in Banco.Sangria
                    //                          join usu in
                    //Banco.Usuarios on san.UsuarioID equals usu.ID
                    //                          group san by new { san.ID, san.Data, san.Descricao, usu.NomeCompleto } into g
                    //                          select new SangriaViewModel
                    //                          {
                    //                              ID = g.Key.ID,
                    //                              Data = g.Key.Data,
                    //                              Descricao = g.Key.Descricao,
                    //                              Usuario = g.Key.NomeCompleto,
                    //                              Valor = g.Sum(c => c.valor)
                    //                          }).ToList();


                    dgv.DataSource = (from san in Banco.Sangria
                                      join usu in
            Banco.Usuarios on san.UsuarioID equals usu.ID
                                      select new SangriaViewModel
                                      {
                                          ID = san.ID,
                                          Data = san.Data,
                                          Usuario = usu.NomeCompleto,
                                          Valor = san.valor
                                      }).ToList();
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
