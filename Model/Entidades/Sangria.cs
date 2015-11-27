
using Mike.Utilities.Desktop;
using Model.BO;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entidades
{
    [Table(nameof(Sangria))]
    public class Sangria
    {
        public int ID { get; set; }

        private decimal _valor;

        public decimal valor
        {
            get { return _valor; }
            set
            {
                if (value <= 0)
                {
                    MyErro.MyCustomException("Valor da Sangria deve ser maios que 0.");
                }
                else if (CaixaBO.VareficarValor() < value)
                {
                    MyErro.MyCustomException("Você não pode retirar um valor maior que o valor no caixa.");
                }
                else if (CaixaBO.VareficarValor() >= value)
                {
                    _valor = value;
                }
               
            }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("Descrição não pode ser vazio.");
                }
                if (value.Length < 10)
                {
                    MyErro.MyCustomException("Descrição deve conter mais palavras.");
                }
                if (value.Length > 100)
                {
                    MyErro.MyCustomException("Descrição deve conter menos palavras.");
                }
                else
                {
                    _descricao = value;
                }
               
            }
        }

        public int UsuarioID { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
    }
}
