

using Mike.Utilities.Desktop;
using System;
namespace Model.Entidades
{
    public class VendaComComandaAtiva
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
        private int _idProduto;

        public int IDProduto
        {
            get { return _idProduto; }
            set { _idProduto = value; }
        }
        private int _idComanda;

        public int IDComanda
        {
            get { return _idComanda; }
            set { _idComanda = value; }
        }
        private int _quantidade;

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        private decimal _precoTotal;

        public decimal PrecoTotal
        {
            get { return _precoTotal; }
            set 
            {
                if (value < 0)
                {
                     MyErro.MyCustomException("Venda não pode conter valores negativos.");
                }
                else if (value > Decimal.MaxValue)
                {
                    MyErro.MyCustomException("Preço De Venda não pode ser muito alto");
                }
                else
                {
                    _precoTotal = value;
                }
              
            }
           
        }
        
    }
}
