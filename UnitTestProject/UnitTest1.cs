using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Entidades;
using Mike.Utilities.Desktop;
using Controller.Repositorio;
using Model.BO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteLog()
        {
            try
            {
               
                UsuarioRepositorio banco = new UsuarioRepositorio();
                UsuariosBO usuarioBo = new UsuariosBO();
                Usuarios usuarios = new Usuarios() { Login = "mike", Senha = "mike"};
                Assert.AreEqual(true, banco.Logar(usuario: usuarios));


            }
            catch (CustomException erro)
            {
                global::System.Windows.Forms.MessageBox.Show(erro.Message);
                Assert.Fail();
            }
            catch (Exception erro)
            {
                global::System.Windows.Forms.MessageBox.Show(erro.Message);
                Assert.Fail();
            }



        }
    }
}
