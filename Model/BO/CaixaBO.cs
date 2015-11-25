using Mike.Utilities.Desktop;
using Model.Data;
using System;
using System.Linq;

namespace Model.BO
{
    public class CaixaBO
    {
        public static decimal VareficarValor()
        {

            try
            {
                var banco = new _DbContext().Caixa.FirstOrDefault();
                return banco.Valor;
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
    }
}
