using Mike.Utilities.Desktop;
using Model.BO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entidades
{
    public class Usuarios
    {
        private UsuariosBO _usuarioBo;
      
        
        public Usuarios()
        {
            _usuarioBo = new UsuariosBO();      
    
        }
        private int _id;

        public int ID
        {
            get { return _id; }
             set 
            {
                if (int.MaxValue == value)
                {
                     MyErro.MyCustomException("Usuário Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                    _id = value; 
                }
               
            }
          
        }
        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("Usuário nao pode ser vazio");
                }
                else if (value.Length > 20)
                {
                    MyErro.MyCustomException("Usuário nao pode conter mais de 20 letrar");
                }             
                else
                {
                    _login = value;
                }

            }
        }
        private string _confirmar;
        [NotMapped]
        public string Confirmar
        {
            get { return _confirmar; }
            set
            {
                if (value != _senha)
                {                  
                    MyErro.MyCustomException("As senhas não são iguais");
                }
                else
                {
                    _confirmar = value;
                }

            }
        }

        private string _senha;


        public string Senha
        {
            get { return _senha; }
            set
            {
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("Senha nao pode ser vazio");
                }
                else if (value.Length > 20)
                {
                    MyErro.MyCustomException("Senha nao pode conter mais de 20 letrar");
                }
                else
                {
                    _senha = value;
                }
            }
        }
        private string _permicao;

        public string Permicao
        {
            get { return _permicao; }
            set { _permicao = value; }
        }
        private string _nomeCompleto;

        public string NomeCompleto
        {
            get { return _nomeCompleto; }
            set
            {
                if (value.Length == 0)
                {
                    MyErro.MyCustomException("Nome nao pode estar em branco");
                }
                else if (value.Length >= 50)
                {
                     MyErro.MyCustomException("Nome nao ter mais de 50 letrar");
                }
                else
                {
                    _nomeCompleto = value; 
                }
                
            }
        }
        
        private string _ultimoAcesso;

        public string UltimoAcesso
        {
            get { return _ultimoAcesso; }
            set { _ultimoAcesso = value; }
        }
        public static string NomeCompletoStatic { get; set; }
        public static string NomeStatic { get; set; }
        public static int IDStatic { get; set; }
        public static string PermissaoStatic { get; set; }
    }
}
