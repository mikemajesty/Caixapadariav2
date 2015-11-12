using Mike.Utilities.Desktop;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entidades
{
    public class Estoque
    {
        private string _produtoCodigo;
        [NotMapped]
        public string ProdutoCodigo
        {
            get { return _produtoCodigo; }

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
                    _produtoCodigo = value;
                }

            }
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
        private Nullable<int> _quantidadeMinima;

        public Nullable<int> QuantidadeMinima
        {
            get { return _quantidadeMinima; }
            set
            {
                if (value <= 0)
                {
                    MyErro.MyCustomException("Quantidade Mínima não pode ser menor que zero.");
                }
                else if (value > int.MaxValue)
                {
                    MyErro.MyCustomException("Quantidade Mínima acima do limite.");
                }
                else if (value > _quantidadeMaxima)
                {
                    MyErro.MyCustomException("Quantidade Mínima não pode ser maior que Quantidade Aceitável.");
                }
                else
                {
                    _quantidadeMinima = value;
                }

            }
        }
        private Nullable<int> _quantidadeMaxima;

        public Nullable<int> QuantidadeMaxima
        {
            get { return _quantidadeMaxima; }
            set
            {
                if (value <= 1)
                {
                    MyErro.MyCustomException("Quantidade Mánima não pode ser menor ou igual a zero.");
                }
                else if (value > int.MaxValue)
                {
                    MyErro.MyCustomException("Quantidade Mánima acima do limite.");
                }
                else if (value < _quantidadeMinima)
                {
                    MyErro.MyCustomException("Quantidade Aceitável não pode ser maior que Quantidade Míxima.");
                }
                else
                {
                    _quantidadeMaxima = value;
                }

            }
        }
        public static string CodigoEstoque { get; set; }

    }
}
