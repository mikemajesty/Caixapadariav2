using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Controller.Repositorio;
using Model.Entidades;
namespace View.Enum.UI.ViewComanda
{

    public partial class frmGerenciarComanda : Form
    {
        private ComandaRepositorio _comandaRepositorio;
        private const  string vazio = "";
        public frmGerenciarComanda()
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
        private void frmGerenciarComanda_Load(object sender, EventArgs e)
        {

            try
            {
                this.FocoNoTxt(txt:txtPesquisar);
                InstanciarComandaRepositorio();
                CarregaGrid();
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

        private void CarregaGrid()
        {
            _comandaRepositorio.Listar(dgv: dgvComanda);
            AjustarTamanhoDoGrid();
        }

        private void AjustarTamanhoDoGrid()
        {
            dgvComanda.AjustartamanhoDoDataGridView(new List<TamanhoGrid>() {
                    new TamanhoGrid(){ ColunaNome = "ID", Tamanho = 60},
                    new TamanhoGrid(){ ColunaNome="Codigo", Tamanho = 363} });
        }

        private void InstanciarComandaRepositorio()
        {

            try
            {
                _comandaRepositorio = new ComandaRepositorio();
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
                    Comanda comanda = _comandaRepositorio.GetComandaPorID(PegaLinhaSelecionadaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComanda(EnumTipoOperacao.Deletar, comanda)) == DialogResult.Yes)
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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
        }

        

    }
  
}
