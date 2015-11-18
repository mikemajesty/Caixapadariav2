using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewAnomalias;
using Controller.Repositorio;

namespace View.UI.ViewComanda
{
    public partial class frmGerenciarComanda : Form
    {
        private ComandaRepositorio _comandaRepositorio;
        private VendaComComandaAtivaRepositorio _vendaComComandaAtivaRepositorio;
        private const string vazio = "";
        private EnumComanda _enumComanda;

        public frmGerenciarComanda(EnumComanda enumComanda)
        {
            _enumComanda = enumComanda;
            InitializeComponent();
        }
        private void CarregarTextoDePermissao()
        {


            switch (Usuarios.PermissaoStatic)
            {
                case "Caixa":
                    btnDeletar.Visible = false;
                    break;
                case "Restrito":
                    btnDeletar.Visible = false;
                    btnNovo.Visible = false;
                    btnAlterar.Visible = false;
                    break;


            }
        }

        private void EsconderBotoes(Button[] buttonList)
        {
            for (int cont = 0; cont < buttonList.Length; cont++)
            {
                buttonList[cont].Visible = false;
            }

        }

        private void InstanciarVendaComComandaAtivaRepositorio()
        {
            _vendaComComandaAtivaRepositorio = new VendaComComandaAtivaRepositorio();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    break;
                    dgvComanda.MoveToUp();
                case Keys.Down:
                    dgvComanda.MoveToDown();
                    break;
                case Keys.Enter:
                    if (_enumComanda == EnumComanda.Comanda)
                    {
                        if (dgvComanda.Rows.Count > 0)
                        {
                            string codigo = dgvComanda.SelectedRows[0].Cells["Código"].Value.ToString();
                            if (!string.IsNullOrEmpty(codigo))
                            {
                                Comanda.CodigoComanda = codigo;
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {
                                MyErro.MyCustomException("Você deve escolher uma comanda.");
                            }
                        }
                       
                    }
                    break;                    
                case Keys.F1:
                    break;
                case Keys.F2:
                    break;
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmGerenciarComanda_Load(object sender, EventArgs e)
        {

            try
            {

                this.FocoNoTxt(txt: txtPesquisar);
                if (_enumComanda == EnumComanda.Seleção)
                {
                    InstanciarComandaRepositorio();
                    CarregaGridSelecao();
                    CarregarTextoDePermissao();
                    //MudartamanhoDoButton(btn: btnDeletar, size: new Size(67, 28));
                    //MudarLocationDoButton(btn: btnDeletar, location: new Point(227, 9));
                    //MudartamanhoDoGrid(btn: dgvComanda, size: new Size(423, 150));
                    //MudarLocationDoGrid(btn: dgvComanda, location: new Point(9, 62));
                }
                else if (_enumComanda == EnumComanda.Comanda)
                {
                    MudarTextoDoForm(txt: "Comandas em Uso");
                    MudarTextoDoGruopBox(gpb: gpbPesquisar, txt: "");
                    MudarTextoDoButton(btn: btnDeletar, txt: "Deletar itens da comanda.");
                    Button[] btn = { btnAlterar, btnNovo };
                    EsconderBotoes(buttonList: btn);
                    MudartamanhoDoButton(btn: btnDeletar, size: new Size(342, 28));
                    MudarLocationDoButton(btn: btnDeletar, location: new Point(20, 9));
                    MudartamanhoDoGrid(btn: dgvComanda, size: new Size(423, 189));
                    MudarLocationDoGrid(btn: dgvComanda, location: new Point(9, 19));
                    CarregarGridComanda();
                    EsconderTxt(txt: txtPesquisar);
                    if (dgvComanda.Rows.Count == 0)
                    {
                        FocarNoBtn(btnSair);
                    }
                    
                }
                dgvComanda.PadronizarGrid();
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

        private void CarregarGridComanda()
        {
            try
            {
                InstanciarVendaComComandaAtivaRepositorio();
                dgvComanda.DataSource = _vendaComComandaAtivaRepositorio.GetComandasEmUso();
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

        private void MudarTextoDoForm(string txt)
        {
            this.Text = txt;
        }

        private void MudarTextoDoButton(Button btn, string txt)
        {
            btn.Text = txt;
        }

        private void MudarTextoDoGruopBox(GroupBox gpb, string txt)
        {
            gpb.Text = txt;
        }

        private void MudarLocationDoGrid(DataGridView btn, Point location)
        {
            btn.Location = location;
        }

        private void MudartamanhoDoGrid(DataGridView btn, Size size)
        {
            btn.Size = size;
        }

        private void EsconderTxt(TextBox txt)
        {
            txt.Visible = false;
        }

        private void MudarLocationDoButton(Button btn, Point location)
        {
            btn.Location = location;
        }

        private void MudartamanhoDoButton(Button btn, Size size)
        {
            btn.Size = size;
        }

        private void InstanciarComandaRepositorio()
        {
            _comandaRepositorio = new ComandaRepositorio();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComanda(EnumTipoOperacao.Salvar, new Comanda())) == DialogResult.Yes)
            {
                CarregaGridSelecao();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {

                InstanciarComandaRepositorio();
                if (dgvComanda.Rows.Count > 0 && _comandaRepositorio.GetQuantidade() > 0)
                {

                    Comanda comanda = _comandaRepositorio.GetComandaPorID(PegaIDSelecionadaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComanda(EnumTipoOperacao.Alterar, comanda)) == DialogResult.Yes)
                    {
                        CarregaGridSelecao();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione uma comanda.");
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

        private int PegaIDSelecionadaDoGrid()
        {
            return Convert.ToInt32(dgvComanda.CurrentRow.Cells["ID"].Value);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                InstanciarComandaRepositorio();
                if (dgvComanda.Rows.Count > 0 && _comandaRepositorio.GetQuantidade() > 0)
                {
                    InstanciarComandaRepositorio();
                    if (_enumComanda == EnumComanda.Seleção)
                    {
                        Comanda comanda = _comandaRepositorio.GetComandaPorID(PegaIDSelecionadaDoGrid());
                        if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComanda(EnumTipoOperacao.Deletar, comanda)) == DialogResult.Yes)
                        {
                            CarregaGridSelecao();
                        }

                    }                  
                    else if (_enumComanda == EnumComanda.Comanda)
                    {
                        Comanda comanda = _comandaRepositorio.GetComandaPorID(PegaIDSelecionadaDoGrid());
                        if (OpenMdiForm.OpenForWithShowDialog(new frmCriarAnomalias(new Anomalias
                        {
                            IDComanda = comanda.ID,
                            IDUsuario = Usuarios.IDStatic,
                            Valor = GetvalorDaComanda(),

                        },EnumAnomalia.Criar)) == DialogResult.Yes)
                        {
                            InstanciarVendaComComandaAtivaRepositorio();
                            int resultado = _vendaComComandaAtivaRepositorio.DeletaItensDaComandaPorCodigo(dgvComanda.CurrentRow.Cells["Código"].Value.ToString());
                            if (resultado > 0)
                            {
                                DialogMessage.MessageFullComButtonOkIconeDeInformacao("Itens da Comanda deletado com Sucesso.", "Titulo");
                                CarregarGridComanda();
                                FocarNoBtn(btn: btnSair);
                            }
                        }
                    }                  
                }
                else
                {
                    MyErro.MyCustomException("Selecione uma comanda.");
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

        private void FocarNoBtn(Button btn)
        {
            this.ActiveControl = btn;
        }

        private decimal GetvalorDaComanda()
        {
            try
            {
                if (dgvComanda.Columns.Count > 0)
                {
                    return Convert.ToDecimal(dgvComanda.CurrentRow.Cells["Total"].Value);
                }
                return 0;
            }
            catch (CustomException error)
            {

                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
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

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InstanciarComandaRepositorio();
                if (_comandaRepositorio.GetQuantidade() > 0)
                {

                    int idSelecionado = Convert.ToInt32(txtPesquisar.Text == vazio ? 0 : Convert.ToInt32(txtPesquisar.Text));
                    _comandaRepositorio.PesquisarPorID(dgv: dgvComanda, ComandaID: idSelecionado);

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
        private void CarregaGridSelecao()
        {

            try
            {

                _comandaRepositorio.Listar(dgv: dgvComanda);
                AjustarTamanhoDoGrid(_enumComanda);
                
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

        private void AjustarTamanhoDoGrid(EnumComanda enumComanda)
        {

            try
            {
                switch (enumComanda)
                {
                    case EnumComanda.Seleção:
                        dgvComanda.AjustartamanhoDoDataGridView(new List<TamanhoGrid>() {
                    new TamanhoGrid(){ ColunaNome = "ID", Tamanho = 60},
                    new TamanhoGrid(){ ColunaNome="Codigo", Tamanho = 363} });
                        break;
                    case EnumComanda.Comanda:
                        dgvComanda.AjustartamanhoDoDataGridView(new List<TamanhoGrid>() {
                    new TamanhoGrid(){ ColunaNome = "ID", Tamanho = 50},
                    new TamanhoGrid(){ ColunaNome="Código", Tamanho = 250},
                    new TamanhoGrid() { ColunaNome="Total", Tamanho= 113} });
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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
        }



        private void PegarCodigoDaComanda()
        {
            if (dgvComanda.Rows.Count > 0)
            {
                string codigo = dgvComanda.CurrentRow.Cells["Código"].Value.ToString();
                if (!String.IsNullOrEmpty(codigo))
                {
                    Comanda.CodigoComanda = codigo;
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MyErro.MyCustomException("Você deve escolher uma comanda.");
                }
            }
         
        }

        private void dgvComanda_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((Keys)e.KeyChar == Keys.Enter)
            {
                try
                {
                    PegarCodigoDaComanda();
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

        }

        private void dgvComanda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (_enumComanda == EnumComanda.Comanda && e.RowIndex >= 0)
                {
                    PegarCodigoDaComanda();
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

        private void dgvComanda_KeyDown(object sender, KeyEventArgs e)
        {
            ValidatorField.DisableTabInGrid(sender, e);
        }
    }
}
