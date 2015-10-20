using Model.Entidades;
using System;
using System.Windows.Forms;

namespace Model.BO
{
    public static class GerenciarGerenciamentoDeEstoque
    {
        public static void FecharForm(Form formParaFechar)
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == formParaFechar.GetType())
                    {
                        form.Close();
                        break;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
           
        }
        public static void AbrirForm(Form formParaAbrir)
        {
            try
            {

                formParaAbrir.MdiParent = ContainerContext.Context;
                formParaAbrir.Show();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);

            }
        }
    }
}
