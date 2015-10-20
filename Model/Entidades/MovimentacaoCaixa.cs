using Mike.Utilities.Desktop;
using System;

namespace Model.Entidades
{
    public class MovimentacaoCaixa
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set
            {
                if (value >= Int16.MaxValue)
                {
                    MyErro.MyCustomException("Movimentação do caixa Excedeu o limite de cadastros.");
                }
                else
                {
                    _id = value;
                }

            }
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
                    MyErro.MyCustomException("Preço De Venda não pode ser muito alto");
                }
                else
                {
                    _valor = value;
                }
            }
        }
        private DateTime _data;

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        

    }
}
