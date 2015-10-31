using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Repositorio
{
    public class AnomaliasRepositorio : IDisposable
    {
        public _DbContext _Banco {get; } = new _DbContext();


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
       
        public void Dispose(bool dispose)
        {
            if (dispose)
            {
                _Banco.Dispose();
            }
        }

        public void Dispose()
        {
            if (_Banco != null)
            {
                _Banco.Dispose();
            }
          
        }
    }
}
