
using Mike.Utilities.Desktop;
using System;
namespace Model.Entidades
{
    public class Venda
    {
        private Int64 _id;

        public Int64 ID
        {
            get { return _id; }
            set
            {
                if (int.MaxValue == value)
                {
                    MyErro.MyCustomException("Venda Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                    _id = value;
                }

            }

        }
        private decimal _vendaTotal;

        public decimal VendaTotal
        {
            get { return _vendaTotal; }
            set
            {
                if (value < 0)
                {
                    MyErro.MyCustomException("Venda não pode conter valores negativos.");
                }
                else if (value > Decimal.MaxValue)
                {
                    MyErro.MyCustomException("Venda De Venda não pode ser muito alto");
                }
                else
                {
                    _vendaTotal = value;
                }

            }

        }
        private decimal _lucroTotal;

        public decimal LucroTotal
        {
            get { return _lucroTotal; }
             set
            {
                if (value < 0)
                {
                    MyErro.MyCustomException("Venda não pode conter valores negativos.");
                }
                else if (value > Decimal.MaxValue)
                {
                    MyErro.MyCustomException("Venda De Venda não pode ser muito alto");
                }
                else
                {
                     _lucroTotal = value;
                }

            }
          
        }
        private DateTime _data;

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        private int _idUsuario;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        private int _idTipoPagamento;

        public int IDTIPOPAGAMENTO
        {
            get { return _idTipoPagamento; }
            set { _idTipoPagamento = value; }
        }

    }
}
