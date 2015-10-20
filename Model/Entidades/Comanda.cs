using Mike.Utilities.Desktop;

namespace Model.Entidades
{
    public class Comanda
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set 
            {
                if (int.MaxValue == value)
                {
                     MyErro.MyCustomException("Comanda Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                    _id = value; 
                }
               
            }
        }
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
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
                    _codigo = value; 
                }              

            }
        }
        
    }
}
