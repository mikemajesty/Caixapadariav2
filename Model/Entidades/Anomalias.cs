using Mike.Utilities.Desktop;
using System;

namespace Model.Entidades
{
    public class Anomalias
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _idComanda;

        public int IDComanda
        {
            get { return _idComanda; }
            set
            {
                if (value <= 0)
                {
                    MyErro.MyCustomException("A comanda deve ser valída");
                }
                else
                {
                    _idComanda = value;
                }
                
            }
        }
        private int _idUsuario;

        public int IDUsuario
        {
            get { return _idUsuario; }
            set
            {
                if (value <= 0)
                {
                    MyErro.MyCustomException("O Usuário deve ser valída");
                }
                else
                {
                    _idUsuario = value;
                }

            }
        }
        private decimal _valor;

        public decimal Valor
        {
            get { return _valor; }
            set
            {
                if (value <= 0)
                {
                    MyErro.MyCustomException("O Valor da comanda deve ser acima de 0.00 R$");
                }
                else
                {
                    _valor = value;
                }

            }
        }
        public DateTime Date { get; set; } = DateTime.Now;


    }
}
