using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewComanda;

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

        private void frmGerenciarComanda_Load(object sender, EventArgs e)
        {

            try
            {

                this.FocoNoTxt(txt: txtPesquisar);
                if (_enumComanda == EnumComanda.Seleção)
                {
                    InstanciarComandaRepositorio();
                    CarregaGrid();
                    CarregarTextoDePermissao();
                    //MudartamanhoDoButton(btn: btnDeletar, size: new Size(67, 28));
                    //MudarLocationDoButton(btn: btnDeletar, location: new Point(227, 9));
                    //MudartamanhoDoGrid(btn: dgvComanda, size: new Size(423, 150));
                    //MudarLocationDoGrid(btn: dgvComanda, location: new Point(9, 62));
                }
                else if (_enumComanda == EnumComanda.Comanda)
                {
                    MudarTextoDoGruopBox(gpb: gpbPesquisar, txt: "");
                    MudarTextoDoButton(btn: btnDeletar, txt: "Deletar itens da comanda.");
                    Button[] btn = { btnAlterar, btnNovo };
                    EsconderBotoes(buttonList: btn);
                    MudartamanhoDoButton(btn: btnDeletar, size: new Size(342, 28));
                    MudarLocationDoButton(btn: btnDeletar, location: new Point(20, 9));
                    MudartamanhoDoGrid(btn: dgvComanda, size: new Size(423, 189));
                    MudarLocationDoGrid(btn: dgvComanda, location: new Point(9, 19));
                    InstanciarVendaComComandaAtivaRepositorio();
                    dgvComanda.DataSource = _vendaComComandaAtivaRepositorio.GetComandasEmUso();
                    EsconderTxt(txt: txtPesquisar);
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
                CarregaGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {

                InstanciarComandaRepositorio();
                if (dgvComanda.Rows.Count > 0 && _comandaRepositorio.GetQuantidade() > 0)
                {

                    Comanda comanda = _comandaRepositorio.GetComandaPorID(PegaLinhaSelecionadaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComanda(EnumTipoOperacao.Alterar, comanda)) == DialogResult.Yes)
                    {
                        CarregaGrid();
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
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private int PegaLinhaSelecionadaDoGrid()
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
                        Comanda comanda = _comandaRepositorio.GetComandaPorID(PegaLinhaSelecionadaDoGrid());
                        if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComanda(EnumTipoOperacao.Deletar, comanda)) == DialogResult.Yes)
                        {
                            CarregaGrid();
                        }
                    }
                    else if (_enumComanda == EnumComanda.Comanda)
                    {
                        if (DialogMessage.MessageFullQuestion("Deseja Realmente excluir os itens dessa camanda?", "Aviso") == DialogResult.Yes)
                        {
                            InstanciarVendaComComandaAtivaRepositorio();
                            _vendaComComandaAtivaRepositorio.DeletaItensDaComandaPorCodigo(dgvComanda.CurrentRow.Cells["Código"].Value.ToString());
                        }
                        else
                        {
                            LimparTxt();
                            this.FocoNoTxt(txt: txtPesquisar);
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
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
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
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }
        }
        private void CarregaGrid()
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
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
        }

        private void dgvComanda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (_enumComanda == EnumComanda.Comanda && e.RowIndex >= 0)
                {
                    int codigo = Convert.ToInt32(dgvComanda.CurrentRow.Cells["Código"].Value);
                    if (codigo > 0)
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
}
