using Mike.Utilities.Desktop;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entidades
{
    public class Produto : Estoque
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set
            {

                if (value.Length == 0)
                {
                      MyErro.MyCustomException("Códido não pode ser vazio.");
                }
                else if (value.Length > 20)
                {
                    MyErro.MyCustomException("Códido não pode conter mais de 20 letras ou numeros.");
                }                
                else
                {
                    _codigo = value;
                }
               
            }
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set 
            {
               
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("Nome não pode ser vazio.");
                }
                else if (value.Length > 30)
                {
                    MyErro.MyCustomException("Nome não pode conter mais de 30 letras ou numeros.");
                }
                else
                {
                    _nome = value; 
                }
               
            }
        }
        private int _categoria;

        public int Categoria
        {
            get { return _categoria; }
            set 
            {
                if (value <= 0)
                {
                    MyErro.MyCustomException("Categoria é obrigatório.");
                }
                else
                {
                    _categoria = value;
                }
                
            }
        }
        private decimal _precoCompra;

        public decimal PrecoCompra
        {
            get { return _precoCompra; }
            set 
            {
                if (value < 0)
                {
                    MyErro.MyCustomException("Preço De Compra não pode ser menor a zero.");
                }
                else if (value > Decimal.MaxValue)
                {
                    MyErro.MyCustomException("Preço De Compra não pode ser muito alto");
                }
                else
                {
                    _precoCompra = value;
                }
              
            }
        }
        private decimal _precoVenda;

        public decimal PrecoVenda
        {
            get { return _precoVenda; }
            set 
            {
                if (value < _precoCompra)
                {
                    MyErro.MyCustomException("Preço De Venda não pode ser menor a Preço De Compra.");
                }
                else if (value > Decimal.MaxValue)
                {
                    MyErro.MyCustomException("Preço De Venda não pode ser muito alto");
                }
                else
                {
                    _precoVenda = value;
                }
               
            }
        }
        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set 
            {
                if (value.Length > 70)
                {
                    MyErro.MyCustomException("Descrição não pode conter mais de 70 letras ou números.");
                }
                else
                {
                    _descricao = value; 
                }
                
            }
        }
        private Nullable<int> _porcentagem;

        public Nullable<int> Porcentagem
        {
            get { return _porcentagem; }
            set 
            {
              
                 if (value > int.MaxValue)
                {
                    MyErro.MyCustomException("Porcentagem não pode ser muito alta.");
                }
                 else if (value < 0)
                 {
                     MyErro.MyCustomException("Porcentagem não pode ser menor que zero.");
                 }
                else
                {
                    _porcentagem = value; 
                }
               
            }
        }
        private int _tipoCadastro;

        public int TipoCadastro
        {
            get { return _tipoCadastro; }
            set { _tipoCadastro = value; }
        }

        private bool  _gerenciarEstoque;

        public bool GerenciarEstoque
        {
            get { return _gerenciarEstoque; }
            set { _gerenciarEstoque = value; }
        }

        private decimal _precoVendaPeso;
        [NotMapped]
        public decimal PrecoVendaPeso
        {
            get { return _precoVendaPeso; }
            set
            {
                if (value < _precoVendaPeso)
                {
                    MyErro.MyCustomException("Preço De Venda não pode ser menor a Preço De Compra.");
                }
                else if (value > Decimal.MaxValue)
                {
                    MyErro.MyCustomException("Preço De Venda não pode ser muito alto");
                }
                else
                {
                    _precoVendaPeso = value;
                }

            }
        }
        public static string CodigoDoProduto { get; set; }
    }
}
