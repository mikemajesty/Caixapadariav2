
using Mike.Utilities.Desktop;

namespace Model.Entidades
{
    public class TipoCadastro
    {
        private int _tipoCadastroID;

        public int TipoCadastroID
        {
            get { return _tipoCadastroID; }
              set
            {
                if (int.MaxValue == value)
                {
                    MyErro.MyCustomException("Tipo de Cadastro Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                    _tipoCadastroID = value;
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
                    MyErro.MyCustomException("Tipo de Pagamento não pode ser vazio.");
                }
                else if (value.Length >= 10)
                {
                    MyErro.MyCustomException("Tipo de Pagamento não pode ter mais de 10 letras.");
                }
                else
                {
                    _nome = value; 
                }
               
            }
        }
        
    }
}
