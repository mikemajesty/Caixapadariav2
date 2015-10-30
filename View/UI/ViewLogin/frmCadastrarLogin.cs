using System;
using System.Drawing;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Controller.Repositorio;
using Model.Entidades;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using View.Enum;
using Model.BO;
using System.Linq;
using View.UI.ViewCaixa;

namespace View.UI.ViewLogin
{
    public partial class frmCadastrarLogin : Form
    {
        private const int Sucesso = 1;
        private Usuarios _usuarios;
        private EnumTipoOperacao _tipoOperacao;
        private UsuarioRepositorio _usuarioRepositorio;
        public frmCadastrarLogin(Usuarios usuarios, EnumTipoOperacao tipoOperacao)
        {
            InicializaTipoDeOperacao(usuarios, tipoOperacao);
            InitializeComponent();
        }

        private void InicializaTipoDeOperacao(Usuarios usuarios, EnumTipoOperacao tipoOperacao)
        {
            _usuarios = usuarios == null ? new Usuarios() : usuarios;
            _tipoOperacao = tipoOperacao;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            try
            {


                CarregarPermissao();
                switch (_tipoOperacao)
                {
                    case EnumTipoOperacao.Salvar:
                        MudarTextosDoForm(textoForm: "Salvar Usuário");
                        MudarCorDoBotao(_tipoOperacao);
                        EsconderUltimoAcesso();
                        VerificarSeExistemAlgumUsuarioCadastrado();
                        FocarNoTxt(txtNome);
                        break;
                    case EnumTipoOperacao.Alterar:
                        PopularTxt(_usuarios);
                        MudarTextosDoForm(textoForm: "Alterar Usuário", textoButton: "Alterar");
                        MudarCorDoBotao(_tipoOperacao);
                        EsconderUltimoAcesso();
                        FocarNoTxt(txtNome);
                        break;
                    case EnumTipoOperacao.Deletar:
                        PopularTxt(_usuarios);
                        DesabilitarCampos();
                        EsconderConfirmarSenha();
                        RedimencionarGroupBoxDadosDoLogin();
                        MudarLocalizacaoDoGroupBoxPermissao();
                        MudarLocalizacaoDoBotaoParaCima();
                        MudarTamanhoDoFormParaMenos();
                        MudarTextosDoForm(textoForm: "Deletar Usuário", textoButton: "Deletar");
                        MudarCorDoBotao(_tipoOperacao);
                        EsconderUltimoAcesso();
                        FocarNoBtn(btnCadastrar);
                        break;
                    case EnumTipoOperacao.Detalhes:
                        PopularTxt(_usuarios);
                        DesabilitarCampos();
                        EsconderConfirmarSenha();
                        RedimencionarGroupBoxDadosDoLogin();
                        MudarLocalizacaoDoGroupBoxPermissao();
                        MudarLocalizacaoDoGroupBoxUlmimoAcesso();
                        MudarLocalizacaoDoBotaoParaBaixo();
                        MudarTamanhoDoFormParaMais();
                        MudarTextosDoForm(textoForm: "Detalhes do Usuário", textoButton: "Sair");
                        MudarCorDoBotao(_tipoOperacao);
                        FocarNoBtn(btnCadastrar);
                        break;
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void VerificarSeExistemAlgumUsuarioCadastrado()
        {

            try
            {
                InstanciarUsuarioRepositorio();

                if (_usuarioRepositorio.GetQuantidadeUsuarios() == 0)
                {
                    DesabilitarComboBox(cbbPermissao);
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void DesabilitarComboBox(ComboBox cbb) => cbb.Enabled = false;

        private void MudarLocalizacaoDoBotaoParaBaixo() => btnCadastrar.Location = new Point(12, 350);

        private void MudarTamanhoDoFormParaMais() => this.Size = new Size(359, 550);

        private void MudarLocalizacaoDoGroupBoxUlmimoAcesso() => gpbUltimoAcesso.Location = new Point(12, 278);

        private void EsconderUltimoAcesso() => gpbUltimoAcesso.Visible = false;

        private void MudarCorDoBotao(EnumTipoOperacao _tipoOperacao)
        {
            switch (_tipoOperacao)
            {
                case EnumTipoOperacao.Salvar:
                    MudarCorDoBotao(Color.White);
                    break;
                case EnumTipoOperacao.Alterar:
                    MudarCorDoBotao(Color.LightGreen);
                    break;
                case EnumTipoOperacao.Deletar:
                    MudarCorDoBotao(Color.LightCoral);
                    break;
                case EnumTipoOperacao.Detalhes:
                    MudarCorDoBotao(Color.Silver);
                    break;

            }
        }

        private void MudarCorDoBotao(Color cor) => btnCadastrar.BackColor = cor;

        private void MudarTamanhoDoFormParaMenos() => this.Size = new Size(359, 475);

        private void MudarLocalizacaoDoBotaoParaCima() => btnCadastrar.Location = new Point(12, 277);

        private void MudarLocalizacaoDoGroupBoxPermissao() => gpbPermicao.Location = new Point(12, 203);

        private void RedimencionarGroupBoxDadosDoLogin() => gpbDadosDoUsuario.Height = 109;

        private void EsconderConfirmarSenha()
        {
            lblConfirmarSenha.Visible = false;
            txtConfirmarSenha.Visible = false;
        }

        private void DesabilitarCampos()
        {
            foreach (Control gpb in this.Controls)
            {
                if (gpb is GroupBox)
                {
                    gpb.BackColor = Color.Transparent;
                    gpb.Enabled = false;
                }
            }
        }

        private void MudarTextosDoForm(string textoForm, string textoButton = "Salvar")
        {
            this.Text = textoForm;
            this.btnCadastrar.Text = textoButton;
        }

        private void PopularTxt(Usuarios usuarios)
        {
            try
            {


                txtNome.Text = usuarios.NomeCompleto;
                txtLogin.Text = usuarios.Login;
                txtSenha.Text = usuarios.Senha;
                txtConfirmarSenha.Text = usuarios.Senha;
                if (Usuarios.PermissaoStatic == "Administrador")
                {
                    txtSenha.PasswordChar = '\0';
                    txtConfirmarSenha.PasswordChar = '\0';
                }
                cbbPermissao.Text = usuarios.Permicao;
                txtUltimoAcesso.Text = usuarios.UltimoAcesso != null
                && _tipoOperacao == EnumTipoOperacao.Detalhes
                ? usuarios.UltimoAcesso : "Nenhum acesso";

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }
        private void FocarNoTxt(TextBox txt) => this.FocoNoTxt(txt);

        private void CarregarPermissao()
        {
            new PermissaoRepositorio().ListarPermissao(cbbPermissao);
            cbbPermissao.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void MensagemDeSucesso(string mensagem) => DialogMessage.MessageFullComButtonOkIconeDeInformacao(mensagem, "Aviso");

        private void InstanciarUsuarioRepositorio() => _usuarioRepositorio = new UsuarioRepositorio();


        private void PosSalvamento()
        {
            if (Application.OpenForms.Count > 1)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                OpenMdiForm.OpenForWithShow(new frmLogin(), this);
            }
        }
        private Usuarios PreencherUsuario() =>
        new Usuarios()
        {
            ID = _usuarios.ID,
            Login = txtLogin.Text.Trim(),
            Senha = txtSenha.Text.Trim(),
            Confirmar = txtConfirmarSenha.Text.Trim(),
            Permicao = cbbPermissao.Text.Trim(),
            NomeCompleto = txtNome.Text.Trim().UpperCaseOnlyFirst()
        };

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                InstanciarUsuarioRepositorio();
                int numeroDeTxtVazio = SeTxtEstaVazio();
                switch (_tipoOperacao)
                {
                  
                    case EnumTipoOperacao.Salvar:

                        if (numeroDeTxtVazio == 0)
                        {
                            if (_usuarioRepositorio.Salvar(PreencherUsuario()) == Sucesso)
                            {
                                MensagemDeSucesso("Usuário cadastrado com sucesso");
                                PosSalvamento();
                            }
                        }
                        else                         
                        {
                            FocarNoTxt(GetTxtRequired().ValidarCampos());
                        }
                        break;
                    case EnumTipoOperacao.Alterar:
                        if (numeroDeTxtVazio == 0)
                        {
                            if (_usuarioRepositorio.Alterar(PreencherUsuario()) == Sucesso)
                            {
                                var nomeCompleto = PreencherUsuario().NomeCompleto;
                                if (Usuarios.NomeCompletoStatic != nomeCompleto)
                                {
                                    frmMenu form = (frmMenu)Application.OpenForms[name: nameof(frmMenu)];
                                    if (form != null)
                                    {
                                        form.LblUsuarioTexto = nomeCompleto;
                                    }

                                }
                                MensagemDeSucesso("Usuário alterado com sucesso");
                                this.DialogResult = DialogResult.Yes;
                            }
                        }
                        else if (numeroDeTxtVazio > 0)
                        {
                            FocarNoTxt(GetTxtRequired().ValidarCampos());
                        }

                        break;
                    case EnumTipoOperacao.Deletar:

                        if (_usuarios.ID == Usuarios.IDStatic)
                        {
                            DialogMessage.MessageFullComButtonOkIconeDeInformacao("Não é possível excluir o seu próprio usuário enquanto estiver logado no sistema.", "Aviso");

                        }
                        else if (new UsuariosBO().VerificarSeExisteAdministrador(usuario: PreencherUsuario()))
                        {
                            DialogMessage.MessageFullComButtonOkIconeDeInformacao("Você não pode excluir o unico administrador do sistema.", "Aviso");
                        }
                        else if (_usuarios.ID > 0)
                        {
                            if (_usuarioRepositorio.Deletar(PreencherUsuario()) == Sucesso)
                            {
                                MensagemDeSucesso("Usuário deletado com sucesso");
                                this.DialogResult = DialogResult.Yes;
                            }
                        }                        
                        break;
                    case EnumTipoOperacao.Detalhes:
                        FecharForm();
                        break;
                }
            }

            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");                
            }
            catch (DbUpdateException erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }

        private void LimparTxt(List<TextBox> listTxt) => listTxt.ForEach(c => c.Text = string.Empty);

        public int SeTxtEstaVazio()
        {
            try
            {
                TextBox[] txtList = GetTxtRequired();
                int retorno = 0;
                txtList.ToList().ForEach(c => retorno += c.Text.Trim() == "" ? 1 : 0);             
                return retorno;
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

        private TextBox[] GetTxtRequired() => 
            new TextBox[] { txtNome, txtLogin, txtSenha, txtConfirmarSenha };
       
        private void FecharForm() => this.Close();

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Letter(e: e);
            ValidatorField.AllowOneSpaceTogether(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                FocarNoTxt(txt: txtLogin);
            }
        }

        private void cbbPermissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbDadosDoAcesso.Items.Clear();
            switch (cbbPermissao.Text)
            {
                case "Administrador":
                    ltbDadosDoAcesso.Items.Add("Acesso total ao sistema.");
                    break;
                case "Caixa":
                    ltbDadosDoAcesso.Items.Add("Pesquisa, alteração, criação, caixa,");
                    ltbDadosDoAcesso.Items.Add("relatórios, adicionar no estoque.");
                    break;
                case "Restrito":
                    ltbDadosDoAcesso.Items.Add("Pesquisa, caixa, relatórios");
                    break;
                default:
                    break;
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                FocarNoTxt(txt: txtSenha);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                FocarNoTxt(txt: txtConfirmarSenha);
            }
        }

        private void txtConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbbPermissao.Enabled == true)
                {
                    this.ActiveControl = cbbPermissao;
                    MostrarItensDoCbb(cbb:cbbPermissao);
                }
                else
                {
                    FocarNoBtn(btn: btnCadastrar);
                }

            }
        }

        private void MostrarItensDoCbb(ComboBox cbb)
        {
            cbb.DroppedDown = true;
        }

        private void FocarNoBtn(Button btn)
        {
            this.FocoNoBotao(btn);
        }

        private void cbbPermissao_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                FocarNoBtn(btn: btnCadastrar);
            }
        }
    }
}
