using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mike.Utilities.Desktop;
namespace Model.Entidades
{
    public class Permissao
    {
        private int _permissaoID;

        public int PermissaoID
        {
            get { return _permissaoID; }
             set 
            {
                if (int.MaxValue == value)
                {
                     MyErro.MyCustomException("Permissão Excedeu o número máximo de cadastro, contate o Administrador");
                }
                else
                {
                   _permissaoID = value;
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
                    MyErro.MyCustomException("Permissão é obrigatório");
                }
                else if (value.Length > 15)
                {
                     MyErro.MyCustomException("Permissão não pode conter mais de 15 caracteres");
                }
                else
                {
                    _nome = value; 
                }
              
            }
        }
        

    }
}
