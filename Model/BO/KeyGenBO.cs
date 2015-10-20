using Mike.Utilities.Desktop;
using Model.Data;
using Model.Entidades;
using System;
using System.Linq;

namespace Model.BO
{
    public class KeyGenBO
    {
        
        private readonly _DbContext _banco;
     
        public KeyGenBO()
        {
            _banco = new _DbContext();
        }
        public Datas VerificaSeExisteDatas(Datas data)
        {
            try
            {
                return _banco.Datas.FirstOrDefault(c => c.Data == data.Data);

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
