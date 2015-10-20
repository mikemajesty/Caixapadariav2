using Mike.Utilities.Desktop;

namespace Model.Entidades
{
     public class Cliente
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set
            {
                if (int.MaxValue == value)
                {
                    MyErro.MyCustomException("Cliente Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                    _id = value;
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
                else if (value.Length > 50)
                {
                    MyErro.MyCustomException("Nome não pode conter mais de 50 letras.");
                }
                else
                {
                    _nome = value; 
                }
              
            }
        }
        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set 
            {
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("CPF não pode ser vazio.");
                }
                else if (value.Length > 50)
                {
                    MyErro.MyCustomException("CPF não pode conter mais de 11 numeros ou letras.");
                }
                else
                {
                    _cpf = value; 
                }
               
            }
        }
        private string _celular;

        public string Celular
        {
            get { return _celular; }
            set 
            {
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("Telefone não pode ser vazio.");
                }
                else if (value.Length > 50)
                {
                    MyErro.MyCustomException("Telefone não pode conter mais de 11 números.");
                }
                else
                {
                    _celular = value;
                }
              
            }
        }


        public static int ClienteIDStatic { get; set; }
      
    }
}
