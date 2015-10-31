using Mike.Utilities.Desktop;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entidades
{
    [Table(nameof(Anomalias))]
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
        public DateTime Data { get; set; } = DateTime.Now;
        private string _texto;

        public string Texto
        {
            get { return _texto; }
            set
            {
                if (value.Length <= 0)
                {
                    MyErro.MyCustomException("Texto dever ser preenchido.");
                }
                else if (value.Length <= 15)
                {
                    MyErro.MyCustomException("Texto deve explicar o ocorrido, para que não gere problemas ao operador.");
                }
                else if (value.Length > 150)
                {
                    MyErro.MyCustomException("Tente explicar o ocorrido em um texto mais curto.");
                }
                else
                {
                    _texto = value;
                }

            }
        }


    }
}
