using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;

namespace View.UI.ViewCetegoria
{
    public partial class frmCadastrarCategoria : Form
    {
        private Categoria _categoria;
        private EnumTipoOperacao _tipoOperacao;
        private CategoriaRepositorio _categoriaRepositorio;
        private const int Sucesso = 1, Vazio = 0;

        public frmCadastrarCategoria(Categoria categoria, EnumTipoOperacao tipoOperacao)
        {
            CarregaComponentes(categoria, tipoOperacao);
            InitializeComponent();
        }

        private void CarregaComponentes(Categoria categoria, EnumTipoOperacao tipoOperacao)
        {
            _categoria = categoria;
            _tipoOperacao = tipoOperacao;
        }

        private void frmCadastrarCategoria_Load(object sender, EventArgs e)
        {

            try
            {

               
                switch (_tipoOperacao)
                {

                    case EnumTipoOperacao.Alterar:
                        MudarTextoDoForm("Alterar Categoria");
                        MudarTextoDoBotao(texto: "Alterar");
                        MudarCorDoBotao(color: Color.LightGreen);
                        PupularTxt();
                        FocarNotxt();
                        break;
                    case EnumTipoOperacao.Deletar:
                        MudarTextoDoForm("Deletar Categoria");
                        MudarTextoDoBotao(texto: "Deletar");
                        MudarCorDoBotao(color: Color.LightCoral);
                        PupularTxt();
                        FocarNoBtn();
                        DesabilitarDruopBox();
                        break;

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

        private void DesabilitarDruopBox()
        {
            gpbCategoria.Enabled = false;
        }

        private void PupularTxt()
        {
            txtCategoria.Text = _categoria.Nome;
        }

        private void MudarCorDoBotao(Color color)
        {
            btnCadastrar.BackColor = color;
        }

        private void MudarTextoDoBotao(string texto)
        {
            btnCadastrar.Text = texto;
        }

        private void MudarTextoDoForm(string texto)
        {
            this.Text = texto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!VerificarSeTxtEstaVazio())
                {


                    switch (_tipoOperacao)
                    {
                        case EnumTipoOperacao.Salvar:
                            InstanciarCategoriaRepositorio();
                            if (_categoriaRepositorio.Cadastrar(PupularCategoria()) == Sucesso)
                            {
                                MensagemDeAviso(mensagem: "Categoria cadastrada com sucesso.");
                                PosSalvamento();
                            }
                            break;
                        case EnumTipoOperacao.Alterar:
                            InstanciarCategoriaRepositorio();
                            if (_categoriaRepositorio.Alterar(PupularCategoria()) == Sucesso)
                            {
                                MensagemDeAviso(mensagem: "Categoria alterado com sucesso.");
                                PosSalvamento();
                            }
                            break;
                        case EnumTipoOperacao.Deletar:
                            InstanciarCategoriaRepositorio();
                            if (_categoriaRepositorio.Deletar(PupularCategoria()) == Sucesso)
                            {
                                MensagemDeAviso(mensagem: "Categoria deletada com sucesso.");
                                PosSalvamento();
                            }
                            break;

                    }
                }
                else
                {
                    MyErro.MyCustomException("O campo em amarelo é obrigatório.");
                }
            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                if (_tipoOperacao != EnumTipoOperacao.Deletar)
                {
                    LimparTxt(txtCategoria);
                }              
                FocarNotxt();
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }
        private bool VerificarSeTxtEstaVazio()
        {
            bool retorno = false;
            if (txtCategoria.Text.Trim().Length == Vazio)
            {
                retorno = true;
            }
            return retorno;
        }
        private void FocarNotxt()
        {
            this.FocoNoTxt(txtCategoria);
        }

        private void LimparTxt(TextBox txt)
        {
            txt.Text = string.Empty;
        }

        private void PosSalvamento()
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void MensagemDeAviso(string mensagem)
        {
            DialogMessage.MessageFullComButtonOkIconeDeInformacao(mensagem, "Aviso");
        }

        private Categoria PupularCategoria()
        {
            return new Categoria() { ID = _categoria.ID, Nome = txtCategoria.Text.Trim().UpperCaseOnlyFirst() };
        }

        private void InstanciarCategoriaRepositorio()
        {
            _categoriaRepositorio = new CategoriaRepositorio();
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            ValidatorField.AllowOneSpaceTogether(e, sender);
            if (e.KeyChar == (char)Keys.Enter)
            {
                FocarNoBtn();               
            }
        }

        private void FocarNoBtn()
        {
            this.ActiveControl = btnCadastrar;
        }
    }
}
