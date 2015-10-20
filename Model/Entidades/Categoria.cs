using Mike.Utilities.Desktop;

namespace Model.Entidades
{
    public class Categoria
    {
        private int _id;

        public int ID
        {
            get { return _id; }
             set 
            {
                if (int.MaxValue == value)
                {
                     MyErro.MyCustomException("Categoria Excedeu o número máximo de cadastro, contate o Administrador");
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
                    MyErro.MyCustomException("Categoria não pode ser vazio.");
                }
                else if (value.Length > 20)
                {
                    MyErro.MyCustomException("Categoria não pode cpnter mais de 20 letras ou numeros.");
                }
                else
                {
                    _nome = value;
                }
               
            }
        }
        
    }
}
