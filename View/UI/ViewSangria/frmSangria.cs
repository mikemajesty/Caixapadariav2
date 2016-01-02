using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Enum;

namespace View.UI.ViewSangria
{
    public partial class frmSangria : Form
    {
        private SangriaRepositorio _sangriaRepositorio;
        public frmSangria()
        {
            InitializeComponent();
        }
        public void InstanciarSangriaRepositorio()
                    => _sangriaRepositorio = new SangriaRepositorio();
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                InstanciarSangriaRepositorio();
                _sangriaRepositorio.ListarFullPorData(dgvSangria, dtpPesquisar.Value);
                PersonalizarGrid();
                EsconderColunas();
                AtribuirTotalNaLabel();
                DifinirTamanhoDoGrid();
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

        private void PersonalizarGrid()
                     => dgvSangria.PadronizarGrid();
        private void EsconderColunas()
        {
            dgvSangria.EsconderColuna("ID");
            dgvSangria.EsconderColuna("Descricao");
        }

        private void frmSangria_Load(object sender, EventArgs e)
        {

            try
            {
                CarregarGridFull();
                DefinirValoresNoDateTimePicker();
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

        private void DefinirValoresNoDateTimePicker()
        {

            try
            {
                InstanciarSangriaRepositorio();
                dtpPesquisar.MinDate = _sangriaRepositorio.GetMinDate();
                dtpPesquisar.MaxDate = _sangriaRepositorio.GetMaxDate();
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

        private void CarregarGridFull()
        {

            try
            {
                InstanciarSangriaRepositorio();
                _sangriaRepositorio.ListarFull(dgvSangria);
                PersonalizarGrid();
                EsconderColunas();
                AtribuirTotalNaLabel();
                DifinirTamanhoDoGrid();
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

        private void DifinirTamanhoDoGrid()
        {
            dgvSangria.AjustartamanhoDoDataGridView(new List<TamanhoGrid>
            {
                new TamanhoGrid() { ColunaNome = "Data",  Tamanho=160 },
                 new TamanhoGrid() { ColunaNome = "Usuário",  Tamanho=300 },
                  new TamanhoGrid() { ColunaNome = "Valor",  Tamanho=100 }
            });
        }

        private void AtribuirTotalNaLabel()
                     => lblValor.Text = dgvSangria.SomarColunaDoGrid("Valor").ToString("C2");
        private void btnTodos_Click(object sender, EventArgs e)
        {

            try
            {
                CarregarGridFull();
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

        private void dgvSangria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int idSangria = Convert.ToInt32(dgvSangria.CurrentRow.Cells[0].Value);
                InstanciarSangriaRepositorio();
                SangriaViewModel sangriaViewModel = _sangriaRepositorio.GetViewModelPorID(id: idSangria);
                if (OpenMdiForm.OpenForWithShowDialog(new frmCriarSangria(EnumSangria.Exibir, sangriaViewModel)) == DialogResult.Yes) ;
               
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
    }
}
