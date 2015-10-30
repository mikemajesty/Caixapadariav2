using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;

namespace View.UI.ViewComanda
{
    public partial class frmCadastrarComanda : Form
    {

        private Comanda _comanda;
        private EnumTipoOperacao _tipoOperacao;
        private ComandaRepositorio comandaRepositorio;
        private const int Sucesso = 1;
        public frmCadastrarComanda(EnumTipoOperacao tipoOperacao, Comanda comanda)
        {
            InitializeComponent();
            InicializaTipoDeOperacao(tipoOperacao, comanda);
        }

        private void InicializaTipoDeOperacao(EnumTipoOperacao tipoOperacao, Comanda comanda)
        {
            this._comanda = comanda;
            this._tipoOperacao = tipoOperacao;
        }
        private void frmCadastrarComanda_Load(object sender, EventArgs e)
        {
            MudarCorDoBotao();
            this.FocoNoTxt(txt:txtComanda);
            switch (this._tipoOperacao)
            {
                case EnumTipoOperacao.Alterar:
                    MudarTextoDoForm("Alterar Comanda");
                    MudarTextoDoBotao("Alterar");
                    PopularTxt();
                    break;
                case EnumTipoOperacao.Deletar:
                    MudarTextoDoForm("Deletar Comanda");
                    MudarTextoDoBotao("Deletar");
                    PopularTxt();
                    DesabilitarGruopBox();
                    break;

            }
        }

        private void DesabilitarGruopBox()
        {
            gpbCodigoDaComanda.Enabled = false;
        }

        private void PopularTxt()
        {
            txtComanda.Text = _comanda.Codigo;
        }

        private void MudarTextoDoBotao(string texto)
        {
            btnCadastrar.Text = texto;
        }

        private void MudarCorDoBotao()
        {
            switch (_tipoOperacao)
            {
               
                case EnumTipoOperacao.Alterar:
                    MudarCorDoBotao(Color.LightGreen);
                    break;
                case EnumTipoOperacao.Deletar:
                    MudarCorDoBotao(Color.LightCoral);
                    break;
               
            }

        }
        private void MudarCorDoBotao(Color color)
        {
            btnCadastrar.BackColor = color;
        }
        private void MudarTextoDoForm(string texto)
        {
            this.Text = texto;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {

                InstanciaComandaRepositorio();

                switch (this._tipoOperacao)
                {
                    case EnumTipoOperacao.Salvar:
                        if (SeTxtEstaVazio() == 0)
                        {
                            if (comandaRepositorio.Salvar(PopularComanda()) == Sucesso)
                            {
                                MenssagemDeInformacao(mensagem: "Comanda salva com sucesso.", title: "Aviso");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }
                       

                        break;
                    case EnumTipoOperacao.Alterar:
                        if (SeTxtEstaVazio() == 0)
                        {
                            if (comandaRepositorio.Alterar(PopularComanda()) == Sucesso)
                            {
                                MenssagemDeInformacao(mensagem: "Comanda alterada com sucesso.", title: "Aviso");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }
                     
                        break;
                    case EnumTipoOperacao.Deletar:
                        if (SeTxtEstaVazio() == 0)
                        {
                            if (comandaRepositorio.Deletar(PopularComanda()) == Sucesso)
                            {
                                MenssagemDeInformacao(mensagem: "Comanda deletada com sucesso.", title: "Aviso");
                                PosSalvamento();
                            }
                        }
                        else
                        {
                            MyErro.MyCustomException("Todos os campos em amarelo são obrigatórios.");
                        }
                      
                        break;
                  
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
                if (_tipoOperacao != EnumTipoOperacao.Deletar)
                {
                    LimparTxt();
                }
            
                FocarNoTxt();
            }
            catch (Exception erro)
            {
                SaveErroInTxt.RecordInTxt(erro, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }


        }

        private void FocarNoTxt()
        {
            this.FocoNoTxt(txtComanda);
        }

        private void LimparTxt()
        {
            txtComanda.Text = string.Empty;
        }
        private int SeTxtEstaVazio()
        {
            int retorno = 0;
            if (txtComanda.Text.Trim().Length == 0)
            {
                retorno = 1;
            }
            return retorno;
        }
        private void PosSalvamento()
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void MenssagemDeInformacao(string mensagem, string title)
        {
            DialogMessage.MessageFullComButtonOkIconeDeInformacao(mensagem, title);
        }

        private Comanda PopularComanda()
        {
            return new Comanda() { ID = _comanda.ID, Codigo = txtComanda.Text.Trim() };

        }

        private void InstanciaComandaRepositorio()
        {
            comandaRepositorio = new ComandaRepositorio();
        }

        private void txtComanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            ValidatorField.NoSpace(e);
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
