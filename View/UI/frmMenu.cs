using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Model.Entidades;
using View.UI.ViewKeyGen;
using View.UI.ViewCaixa;
using View.UI.ViewCetegoria;
using View.UI.ViewComanda;
using View.UI.ViewEstoque;
using View.UI.ViewLogin;
using View.UI.ViewProduto;
using View.Enum;
using View.UI;
using View.UI.ViewAnomalias;
using Model.Data;
using Microsoft.Reporting.WebForms;
using System.Text;
using Mike.Utilities.Desktop;
using Model.BO;
using System.Linq;
using System.Drawing;
using Controller.Repositorio;

namespace View
{
    public partial class frmMenu : Form
    {
        private TipoCadastroRepositorio _tipoCadastroRepositorio;
        private TipoPagamentoRepositorio _tipoPagamentoRepositorio;
        private Usuarios _usuario;
        private KeyGenRepositorio _keyGenRepositorio;
        private CaixaRepositorio _caixaRepositorio;
        private Espere espere;
        private frmMensagemDeEspera frmEspera;
        public frmMenu()
        {

        }
        public frmMenu(Usuarios usuario)
        {
            _usuario = usuario;
            InitializeComponent();

        }

        private void InstanciaCaixaRepositorio() => _caixaRepositorio = new CaixaRepositorio();
        
        private void frmMenu_Load(object sender, EventArgs e)
        {

            try
            {
                this.KeyPreview = true;
                ContainerContext.Context = this;
                OpenMdiForm.LoadNewKeepAnother(this, new frmAlertaEstoque());
                VerificaQuantidadesDeDatas();
                AtribuirItensNoRodape(_usuario);
                lblUsuarioLogado.Text = _usuario.NomeCompleto;
                InstanciarTipoCadastroRepositorio();
                InstanciarTipoPagamentoRepositorio();
                _tipoCadastroRepositorio.Cadastrar();
                _tipoPagamentoRepositorio.Cadastrar();
                CarregarTextoDePermissao();
                if (InserirDatasUnicas() > 0)
                {
                    _caixaRepositorio = new CaixaRepositorio();
                    if (_caixaRepositorio.GetValor().Valor > 0)
                    {
                        Properties.Settings.Default.CaixaAberto = true;
                    }
                    else
                    {
                        Properties.Settings.Default.CaixaAberto = false;
                    }

                }

                if (_keyGenRepositorio.GetDiasTrail() == 0)
                {
                    new frmKeyGen().Show();
                    this.Hide();
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

        public string LblUsuarioTexto
        {

            get { return this.lblUsuarioLogado.Text; }

            set { this.lblUsuarioLogado.Text = value; }
        }


        private void VerificaQuantidadesDeDatas()
        {

            try
            {
                InstanciarKeyGenRepositorio();
                if (_keyGenRepositorio.GetQuantidade() >= 30)
                {
                    new frmKeyGen().Show();
                    this.Hide();
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

        private int InserirDatasUnicas()
        {
            try
            {

                InstanciarKeyGenRepositorio();
                return _keyGenRepositorio.InsertDatas(new Datas()
                {
                    Data = DateTime.Now.ToDataCertaSemHora()
                });

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
        private void InstanciarKeyGenRepositorio() => _keyGenRepositorio = new KeyGenRepositorio();
        
        private void CarregarTextoDePermissao()
        {
            this.Text += ": " + Usuarios.PermissaoStatic + " | Data: " + DateTime.Now;
            switch (Usuarios.PermissaoStatic)
            {
                case "Caixa":
                    menuMovimentacao.Visible = false;
                    btnGerenciarProduto.Visible = false;
                    menuUsuario.Visible = false;
                    break;
                case "Restrito":
                    menuMovimentacao.Visible = false;
                    btnGerenciarProduto.Visible = false;
                    menuUsuario.Visible = false;
                    menuEstoque.Visible = false;
                    break;
            }
        }
        private void AtribuirItensNoRodape(Usuarios _usuario)
        {
            try
            {
                Usuarios.LoginStatic = _usuario.Login;
                Usuarios.NomeCompletoStatic = _usuario.NomeCompleto;
                Usuarios.IDStatic = _usuario.ID;
                Usuarios.PermissaoStatic = _usuario.Permicao;
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
        private void InstanciarTipoPagamentoRepositorio() => _tipoPagamentoRepositorio = new TipoPagamentoRepositorio();
       
        private void InstanciarTipoCadastroRepositorio() { _tipoCadastroRepositorio = new TipoCadastroRepositorio();
            }
        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            

            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarLogin());
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(error.Message, "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(error.Message, "Erro");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                OpenMdiForm.OpenAndCloseNoMdi(new frmLogin(), this);
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(error.Message, "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(error.Message, "Erro");
            }
        }
        private void btnSair_Click(object sender, EventArgs e) => Sair();


        private static void Sair()
        {
            if (DialogMessage.MessageFullQuestion("Deseja realmente sair?", "Aviso") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGerenciarComanda_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarComanda(EnumComanda.Seleção));
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(error.Message, "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(error.Message, "Erro");
            }
           
        }
        private void btnGerenciarCategoria_Click(object sender, EventArgs e)
        {          
            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarCategoria());
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(error.Message, "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(error.Message, "Erro");
            }
        }
        private void btnGerenciarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarProduto());
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(error.Message, "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(error.Message, "Erro");
            }
           
        }
        private void btnPesuisarProduto_Click(object sender, EventArgs e)
        {

            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmPesquisarProduto(EnumMovimentacao.Neutro));
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(error.Message, "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageComButtonOkIconeErro(error.Message, "Erro");
            }

        }

        private void btnGerenciarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarCliente());
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
           
        }
        private void btnGerenciarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarEstoque());
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

            
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmCaixa());
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
           
        }
        private void btnMovimentacaoCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmMovimentacaoVenda());
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            
        }
        private void btnMovimentacaoCaixa_Click_1(object sender, EventArgs e)
        {

            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmMovimentacaoCaixa());
            }
              catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

           
        }
        private void btnMovimentacaoProduto_Click(object sender, EventArgs e)
        {

            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmPesquisarProduto(EnumMovimentacao.Movimentacao));
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }


         
        }
        private void btnRelatorioCompra_Click(object sender, EventArgs e)
        {
            try
            {
                espere = new Espere();
                espere.Start(MostrarMensagemEspera);
                _DbContext banco = new _DbContext();
                string fileName = "rpvCompras.rdlc";
                RelatorioCompraRepositorio relatorio = new RelatorioCompraRepositorio();
                var table = relatorio.GerarRelatorioDeVendas();
                MyReport report = new MyReport(table, fileName.GetFullPath(), "Compras", ProcessingMode.Local);
                report.GerarRelatoriosComParametrosDefinidosNaQueryPDF();
                espere.CancelarTask();
                if (espere.Cancel.IsCancellationRequested)
                {
                    if (frmEspera != null)
                    {
                        frmEspera.Close();
                    }
                   
                }
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            finally
            {
                espere.CancelarTask();
                if (espere.Cancel.IsCancellationRequested)
                {
                    if (frmEspera != null)
                    {
                        frmEspera.Close();
                    }

                }
            }
        }

        private void MostrarMensagemEspera()
        {
            frmEspera = new frmMensagemDeEspera();
            frmEspera.ShowDialog();
           
        }

        private void btnAnomalias_Click(object sender, EventArgs e)
        {
            try
            {
                OpenMdiForm.LoadNewKeepAnother(this, new frmAnomalias());
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
           
        }

        private void btnConferenciaEstoque_Click(object sender, EventArgs e)
        {

            try
            {
                espere = new Espere();
                espere.Start(MostrarMensagemEspera);
                string fileName = "estoqueConferencia.rdlc";
                RelatorioEstoqueConferenciaRepositorio estoqueConferenciaRepositorio = new RelatorioEstoqueConferenciaRepositorio();
                var table = estoqueConferenciaRepositorio.GetRelatorioConferencia();
                MyReport report = new MyReport(table, fileName.GetFullPath(), "EstoqueConferencia", ProcessingMode.Local);
                report.GerarRelatoriosComParametrosEQueryDefinidosNaQueryPDF(new System.Collections.Generic.List<ReportParameter>
                {
                    new ReportParameter("NomeConf",Usuarios.NomeCompletoStatic)

                });
                espere.CancelarTask();
                if (espere.Cancel.IsCancellationRequested)
                {
                    if (frmEspera != null)
                    {
                        frmEspera.Close();
                    }

                }
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            finally
            {
                espere.CancelarTask();
                if (espere.Cancel.IsCancellationRequested)
                {
                    if (frmEspera != null)
                    {
                        frmEspera.Close();
                    }

                }
            }
        }
    }
}
