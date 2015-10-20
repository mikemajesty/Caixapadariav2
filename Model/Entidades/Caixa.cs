

using Mike.Utilities.Desktop;
using System;
namespace Model.Entidades
{
    public class Caixa
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set
            {
                if (int.MaxValue == value)
                {
                    MyErro.MyCustomException("Caixa Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                    _id = value;
                }

            }
        }

        private int _idUsuario;

        public int IDUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }

        }
        private decimal _valor;

        public decimal Valor
        {
            get { return _valor; }
            set 
            {
                if (value < 0)
                {
                     MyErro.MyCustomException("Caixa não pode conter valores negativos.");
                }
                else if (value > Decimal.MaxValue)
                {
                    MyErro.MyCustomException("Caixa não pode ser muito alto");
                }
                else
                {
                    _valor = value; 
                }
              
            }
        }
      
    }
}
