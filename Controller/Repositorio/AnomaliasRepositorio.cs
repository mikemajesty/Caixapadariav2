using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Controller.Repositorio
{
    public class AnomaliasRepositorio : IDisposable
    {
        private _DbContext _Banco { get; } = new _DbContext();
        public int GetQuantidade()
        {

            try
            {
                return _Banco.Anomalias.Count();
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
        public List<AnomaliasViewModel> ListarFull(int idAnomalia = 0, DateTime? data = null)
        {

            try
            {
                //idAnomalia = 1;
                //return (from ano in _Banco.Anomalias
                //        join usu in _Banco.Usuarios
                //        on ano.IDUsuario equals usu.ID
                //        join com in _Banco.Comanda
                //        on ano.IDComanda equals com.ID
                //        where ano.Data == data
                //        select new AnomaliasViewModel
                //        {
                //            ID = ano.ID,
                //            Data = ano.Data,
                //            Código = ano.IDComanda,
                //            Usuário = usu.NomeCompleto,
                //            Texto = ano.Texto,
                //            Valor = ano.Valor
                //        }).ToList();
                return (from ano in _Banco.Anomalias
                        join usu in _Banco.Usuarios
                        on ano.IDUsuario equals usu.ID
                        join com in _Banco.Comanda
                        on ano.IDComanda equals com.ID
                        where idAnomalia == 0 ? ano.ID > 0 : ano.ID == idAnomalia
                        select new AnomaliasViewModel
                        {
                            ID = ano.ID,
                            Data = ano.Data,
                            Código = ano.IDComanda,
                            Usuário = usu.NomeCompleto,
                            Texto = ano.Texto,
                            Valor = ano.Valor
                        }).Where(c=> data == null ? c.Data > DateTime.MinValue : c.Data == data ).ToList();

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
       
        public int Salvar(Anomalias anomalias)
        {
            try
            {
                _Banco.Entry<Anomalias>(anomalias).State = EntityState.Added;
                return SalvarMudancas();
            }
            catch (CustomException erro) { throw new CustomException(erro.Message); }
            catch (Exception erro) { throw new Exception(erro.Message); }
        }
        private int SalvarMudancas() => _Banco.SaveChanges();      

        public DateTime GetMaximunDate()
        {

            try
            {
               return _Banco.Anomalias.Max(c=>c.Data);
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

        public DateTime GetMinimunDate()
        {

            try
            {
              return  _Banco.Anomalias.Min(c => c.Data);
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

        public void Dispose()
        {
            _Banco.Dispose();
        }
    }
}
