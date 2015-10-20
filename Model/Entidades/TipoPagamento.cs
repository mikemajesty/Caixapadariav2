using Mike.Utilities.Desktop;

namespace Model.Entidades
{
    public class TipoPagamento
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
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("Tipo de pagamento não pode ser vazio.");
                }
                else if (value.Length >= 20)
                {
                    MyErro.MyCustomException("Tipo de pagamento não pode conter mais de 15 letras.");
                }
                else
                {
                    _tipo = value;
                }

            }
        }

    }
}
