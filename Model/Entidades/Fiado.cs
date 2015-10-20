
using Mike.Utilities.Desktop;
using System;
namespace Model.Entidades
{
    public class Fiado
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set
            {
                if (int.MaxValue == value)
                {
                    MyErro.MyCustomException("Fiado Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                    _id = value;
                }

            }
        }
        private int _idCliente;

        public int IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        private decimal _valor;

        public decimal Valor
        {
            get { return _valor; }
            set 
            {
                if (value < 0)
                {
                     MyErro.MyCustomException("Valor não pode conter valores negativos.");
                }
                else if (value > Decimal.MaxValue)
                {
                    MyErro.MyCustomException("Valor da Venda não pode ser muito alto");
                }
                else
                {
                    _valor = value; 
                }
              
            }
           
        }
        private int _idFuncionario;

        public int IDFuncionario
        {
            get { return _idFuncionario; }
            set { _idFuncionario = value; }
        }
        
    }
}
