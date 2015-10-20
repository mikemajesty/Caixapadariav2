using Mike.Utilities.Desktop;
using System;

namespace Model.Entidades
{
    public class MovimentacaoProduto
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set
            {
                if (int.MaxValue == value)
                {
                    MyErro.MyCustomException("Comanda Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                    _id = value;
                }

            }
        }
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set
            {
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("Código não pode ser vazio");
                }
                else if (value.Length > 20)
                {
                    MyErro.MyCustomException("Código não pode conter mais de 20 letras ou numeros");
                }
                else
                {
                    _codigo = value;
                }

            }
        }
        private DateTime _data;

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private Nullable<int> _quantidade;

        public Nullable<int> Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value < int.MinValue)
                {
                    MyErro.MyCustomException("Quantidade abaixo do limite.");
                }
                else if (value > int.MaxValue)
                {
                    MyErro.MyCustomException("Quantidade acima do limite.");
                }
                else
                {
                    _quantidade = value;
                }

            }
        }
        private decimal? _valor;
        public decimal? Valor
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
                    MyErro.MyCustomException("Valor não pode ser muito alto");
                }
                else
                {
                    _valor = value;
                }

            }
        }
    }
}
