using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mike.Utilities.Desktop;
using Controller.Repositorio;
namespace UnitTestProject
{
    [TestClass]
    public class RelatorioComprasRepositorioTest
    {
        [TestMethod]
        public void GetQuantidadeRegistros_Correto_2()
        {
            try
            {
                var repositorio = new RelatorioCompraRepositorio().GerarRelatorioDeVendas();
              
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
