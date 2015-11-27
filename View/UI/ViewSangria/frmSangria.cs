using Controller.Repositorio;
using Mike.Utilities.Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                _sangriaRepositorio.ListarFullPorData(dgvSangria,dtpPesquisar.Value);
                dgvSangria.PadronizarGrid();
                dgvSangria.EsconderColuna("ID");
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

        private void frmSangria_Load(object sender, EventArgs e)
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

        private void CarregarGridFull()
        {

            try
            {
                InstanciarSangriaRepositorio();
                _sangriaRepositorio.ListarFull(dgvSangria);
                dgvSangria.PadronizarGrid();
                dgvSangria.EsconderColuna("ID");
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
    }
}
