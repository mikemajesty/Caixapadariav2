using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Controller.Repositorio
{
    public class PermissaoRepositorio
    {
        public ComboBox ListarPermissao(ComboBox comboBox)
        {
            try
            {
                comboBox.DisplayMember = "Nome";
                comboBox.DataSource = new List<Permissao>(){
                                              new Permissao(){ PermissaoID = 1, Nome = "Caixa"},
                                              new Permissao(){ PermissaoID = 2, Nome = "Administrador"},
                                              new Permissao(){ PermissaoID = 3, Nome = "Restrito"}}.OrderBy(c => c.Nome).ToList();
                return comboBox;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
    }
}
