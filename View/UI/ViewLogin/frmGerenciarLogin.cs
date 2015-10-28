using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Windows.Forms;
using View.Enum;

namespace View.UI.ViewLogin
{
    public partial class frmGerenciarLogin : Form
    {
        private UsuarioRepositorio _usuarioRepositorio;
        public frmGerenciarLogin()
        {
            InitializeComponent();
        }
        private void CarregarTextoDePermissao()
        {
            this.Text += Usuarios.PermissaoStatic;
            switch (Usuarios.PermissaoStatic)
            {
                case "Caixa":
                    btnDeletar.Visible = false;
                    break;
             


            }
        }
        private void frmGerenciarLogin_Load(object sender, EventArgs e)
        {

            try
            {
                
                this.FocoNoTxt(txt:txtPesquisar);
                InstanciaUsuarioRepositorio();
                _usuarioRepositorio.Listar(dgvUsuarios);
                CarregarTextoDePermissao();
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }



        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {


            try
            {

                CarregaGrid();

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }



        }

        private void CarregaGrid()
        {

            try
            {
                InstanciaUsuarioRepositorio();
                if (_usuarioRepositorio.GetQuantidadeUsuarios() > 0)
                {
                    
                    _usuarioRepositorio.PesquisarPorNome(dgvUsuarios, txtPesquisar.Text);

                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void InstanciaUsuarioRepositorio()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {


            try
            {

                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarLogin(new Usuarios(), EnumTipoOperacao.Salvar)) == DialogResult.Yes)
                {
                    CarregaGrid();
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {


            try
            {
                if (dgvUsuarios.Rows.Count > 0)
                {
                    InstanciaUsuarioRepositorio();
                    Usuarios usuario = _usuarioRepositorio.GetUsuarioPorLogin(PegaLinhaSelecionadaDOGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarLogin(usuario, EnumTipoOperacao.Alterar)) == DialogResult.Yes)
                    {
                        CarregaGrid();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione um Usuário");
                }
             

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }




        }

        private string PegaLinhaSelecionadaDOGrid()
        {

            try
            {
                var valor = dgvUsuarios.CurrentRow.Cells["Login"].Value.ToString();
                return valor != null ? valor : MyErro.MyTernaryExceptionString("Selecione um usuário");

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

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvUsuarios.Rows.Count > 0)
                {
                    InstanciaUsuarioRepositorio();
                    Usuarios usuario = _usuarioRepositorio.GetUsuarioPorLogin(PegaLinhaSelecionadaDOGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarLogin(usuario, EnumTipoOperacao.Deletar)) == DialogResult.Yes)
                    {
                        CarregaGrid();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione um Usuário");
                }
             
              
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            InstanciaUsuarioRepositorio();
            if (dgvUsuarios.Rows.Count > 0 && e.RowIndex >= 0 && _usuarioRepositorio.GetQuantidadeUsuarios() > 0)
            {
                try
                {
                   
                    Usuarios usuario = _usuarioRepositorio.GetUsuarioPorLogin(PegaLinhaSelecionadaDOGrid());
                    OpenMdiForm.OpenForWithShowDialog(new frmCadastrarLogin(usuario, EnumTipoOperacao.Detalhes));
                    LimparTxt();
                    FocarNoTxt();
                }
                catch (CustomException erro)
                {
                    DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                }
                catch (Exception erro)
                {
                    DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
                } 
            }

        }

        private void FocarNoTxt()
        {
            this.FocoNoTxt(txtPesquisar);
        }

        private void LimparTxt()
        {
            txtPesquisar.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void FecharForm()
        {
            this.Close();
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
        }
    }
}
