using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewCetegoria;

namespace View.UI.ViewCetegoria
{
    public partial class frmGerenciarCategoria : Form
    {
        private CategoriaRepositorio _categoriaRepositorio;
        public frmGerenciarCategoria()
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
        private void frmCadastrarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                this.FocoNoTxt(txt: txtPesquisar);
                this.InstanciarCategoriaRepositorio();
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
                dgvCategoria.ClearSelection();
                this.InstanciarCategoriaRepositorio();
                _categoriaRepositorio.Listar(dgv: dgvCategoria);
                AjustarTamanhoDoGrid();
                dgvCategoria.PadronizarGrid();

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
        private void TirarFocoDoGrid()
                     => dgvCategoria.ClearSelection();
        private void AjustarTamanhoDoGrid()
        {
            dgvCategoria.AjustartamanhoDoDataGridView(
                new List<TamanhoGrid>(){
                new TamanhoGrid(){ Tamanho = 123, ColunaNome = "ID" },
                new TamanhoGrid(){ Tamanho = 300, ColunaNome = "Nome"}});
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCategoria(new Categoria(), EnumTipoOperacao.Salvar)) == DialogResult.Yes)
            {
                CarregarGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoria.Rows.Count > 0)
                {
                    Categoria categoria = _categoriaRepositorio.GetCategoriaPorID(PegaLinhaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCategoria(categoria, EnumTipoOperacao.Alterar)) == DialogResult.Yes)
                    {
                        CarregarGrid();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione uma categoria.");
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
                if (dgvCategoria.Rows.Count > 0)
                {
                    Categoria categoria = _categoriaRepositorio.GetCategoriaPorID(PegaLinhaDoGrid());
                    if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCategoria(categoria, EnumTipoOperacao.Deletar)) == DialogResult.Yes)
                    {
                        CarregarGrid();
                    }
                }
                else
                {
                    MyErro.MyCustomException("Selecione uma categoria.");
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
        public int PegaLinhaDoGrid()
                   => Convert.ToInt32(dgvCategoria.CurrentRow.Cells["ID"].Value);
        private void MostrarBotoes()
        {
            btnAlterar.Enabled = true;
            btnDeletar.Enabled = true;
        }

        private void EsconderBotoes()
        {
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
        }
        private void btnSair_Click(object sender, EventArgs e)
                     => FecharForm();
        private void FecharForm()
                     => this.Close();
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_categoriaRepositorio.GetQuantidade() > 0)
                {
                    _categoriaRepositorio.PesquisaCategoriaPeloNome(dgvCategoria, txtPesquisar.Text);
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
        private void InstanciarCategoriaRepositorio()
                     => _categoriaRepositorio = new CategoriaRepositorio();
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.IntegerAndLetter(e: e);
        }

        private void dgvCategoria_KeyDown(object sender, KeyEventArgs e)
                     => ValidatorField.DisableTabInGrid(sender, e);
    }
}
