using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewComanda;

namespace View.UI.ViewComanda
{
    public partial class frmGerenciarCliente : Form
    {

        private ClienteRepositorio _clienteRepositorio;
        public frmGerenciarCliente()
        {
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
        private void frmGerenciarCliente_Load(object sender, EventArgs e)
        {

            try
            {
                this.FocoNoTxt(txt:txtPesquisar);
                CarregarGrid();
                CarregarTextoDePermissao();
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

        private void CarregarGrid()
        {

            try
            {

                InstanciarClienteRepositorio();
                _clienteRepositorio.ListarParaVender(dgv: dgvCliente);
                AjustarTamanhoDoGrid();
                dgvCliente.PadronizarGrid();
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

        private void AjustarTamanhoDoGrid()
        {
            dgvCliente.AjustartamanhoDoDataGridView(new List<TamanhoGrid>()
                {
                      new TamanhoGrid() { Tamanho=78, ColunaNome="ID"},
                      new TamanhoGrid() { Tamanho =200 , ColunaNome="Nome"},
                      new TamanhoGrid() { Tamanho =125, ColunaNome="CPF" },
                      new TamanhoGrid() { Tamanho=125, ColunaNome="Celular"}
                });
        }

        private void InstanciarClienteRepositorio()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            try
            {

                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCliente(new Model.Entidades.Cliente(), EnumTipoOperacao.Salvar)) == DialogResult.Yes)
                {
                    CarregarGrid();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvCliente.Rows.Count > 0)
                {
                    InstanciarClienteRepositorio();
                    Model.Entidades.Cliente cliente = _clienteRepositorio.GetClientePorID(GetLinhaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCliente(cliente, EnumTipoOperacao.Alterar)) == DialogResult.Yes)
                    {
                        CarregarGrid();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione um Cliente.");
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvCliente.Rows.Count > 0)
                {
                    InstanciarClienteRepositorio();
                    Model.Entidades.Cliente cliente = _clienteRepositorio.GetClientePorID(GetLinhaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCliente(cliente, EnumTipoOperacao.Deletar)) == DialogResult.Yes)
                    {
                        CarregarGrid();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione um Cliente.");
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                InstanciarClienteRepositorio();
                if (_clienteRepositorio.GetQuantidade() > 0)
                {
                    
                    _clienteRepositorio.ListarClientePorNomeVender(dgv: dgvCliente, nome: txtPesquisar.Text);
                    AjustarTamanhoDoGrid();
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

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                InstanciarClienteRepositorio();
                if (dgvCliente.Rows.Count > 0 && e.RowIndex >= 0 && _clienteRepositorio.GetQuantidade() > 0)
                {
                    InstanciarClienteRepositorio();
                    Model.Entidades.Cliente cliente = _clienteRepositorio.GetClientePorID(GetLinhaDoGrid());
                    OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCliente(cliente, EnumTipoOperacao.Detalhes));
                    LimparTxt();
                    FocarNoTxt();
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

        private void FocarNoTxt()
        {
            this.FocoNoTxt(txtPesquisar);
        }

        private void LimparTxt()
        {
            txtPesquisar.Text = string.Empty;
        }
        private void FecharForm()
        {
            this.Close();
        }
        private int GetLinhaDoGrid()
        {

            try
            {

                return Convert.ToInt32(dgvCliente.CurrentRow.Cells["ID"].Value);

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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Letter(e);
            ValidatorField.AllowOneSpaceTogether(e, sender);
        }

        private void dgvCliente_KeyDown(object sender, KeyEventArgs e)
        {
            ValidatorField.DisableTabInGrid(sender, e);
        }
    }
}
