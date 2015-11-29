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
        private int _GetQuantidade()
        {

            try
            {
                return Banco.Sangria.Count();
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
            Banco.Usuarios on san.UsuarioID equals usu.ID
                                      where san.Data == data.Date
                                      select new SangriaViewModel
                                      {
                                          ID = san.ID,
                                          Data = san.Data,
                                          Usuário = usu.NomeCompleto,
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
                                          Usuário = usu.NomeCompleto,
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
        public DateTime GetMinDate()
        {

            try
            {
                using (Banco = new _DbContext())
                {
                    return this._GetQuantidade() > 0 ? Banco.Sangria.Min(c => c.Data) : DateTime.MinValue;
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
        public DateTime GetMaxDate()
        {

            try
            {
                using (Banco = new _DbContext())
                {
                    return this._GetQuantidade() > 0 ? Banco.Sangria.Max(c => c.Data) : DateTime.MaxValue;
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

        public SangriaViewModel GetViewModelPorID(int id)
        {

            try
            {
                using (Banco = new _DbContext())
                {
                    return (from san in Banco.Sangria
                            join usu in
  Banco.Usuarios on san.UsuarioID equals usu.ID
                            select new SangriaViewModel
                            {
                                ID = san.ID,
                                Data = san.Data,
                                Descricao = san.Descricao,
                                Usuário = usu.NomeCompleto,
                                Valor = san.valor
                            }).Where(c => c.ID == id).FirstOrDefault();
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
