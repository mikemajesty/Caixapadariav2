﻿using Controller.Repositorio;
using Mike.Utilities.Desktop;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using View.Enum;
using View.UI.ViewCaixa;
using View.UI.ViewComanda;

namespace View.UI.ViewComanda
{
    public partial class frmClienteCreditar : Form
    {
        private ClienteRepositorio _clienteRepositorio;
        private FiadoRepositorio _fiadoRepositorio;
        private EnumTipoCreditar _enumCreditar;
        public frmClienteCreditar(EnumTipoCreditar enumCreditar)
        {
            _enumCreditar = enumCreditar;
            InitializeComponent();
        }
        private void InstanciarFiadoRepositorio()
                     => _fiadoRepositorio = new FiadoRepositorio();
        private void InstanciarlienteRepositorio()
                     => _clienteRepositorio = new ClienteRepositorio();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    FecharForm();
                    break;
                case Keys.Up:
                    dgvCliente.MoveToUp();
                    break;
                case Keys.Down:
                    dgvCliente.MoveToDown();
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
                case Keys.Enter:
                    if (_enumCreditar == EnumTipoCreditar.Vender)
                    {
                        Cliente.ClienteIDStatic = Convert.ToInt32(dgvCliente.GetSelectRow(0, "ID"));
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    else
                    {

                        Fiado fiado = _fiadoRepositorio.PesquisarFiadoPeloID(Convert.ToInt32(dgvCliente.GetSelectRow(0, "ID")));
                        if (OpenMdiForm.OpenForWithShowDialog(new frmReceberFiado(fiado)) == DialogResult.Yes)
                            _fiadoRepositorio.ListarCreditos(dgv: dgvCliente);
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FecharForm()
                     => this.Close();
        private void ClienteCreditar_Load(object sender, EventArgs e)
        {
            try
            {
                if (_enumCreditar == EnumTipoCreditar.Vender)
                    CarregarGridParaVender();
                else
                {
                    EsconderBtnAdicionar();
                    InstanciarFiadoRepositorio();
                    _fiadoRepositorio.ListarCreditos(dgv: dgvCliente);
                    AumentarTamanhoDoForm();
                    AumentarTamanhoDoGroupBox();
                    AumentarTamanhoDoTxt();
                    AjustarTamanhoDoDataGridView();
                }
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
        private void AumentarTamanhoDoGroupBox()
                     => gpbPesquisar.Size = new Size(576, 218);
        private void AjustarTamanhoDoDataGridView()
        {
            try
            {
                dgvCliente.Size = new Size(565, 150);
                dgvCliente.AjustartamanhoDoDataGridView(new List<TamanhoGrid>()
                {
                    new TamanhoGrid(){ ColunaNome = "ID", Tamanho= -1},
                    new TamanhoGrid(){ ColunaNome = "Nome", Tamanho= 225},
                    new TamanhoGrid(){ ColunaNome = "Celular", Tamanho= 120},
                     new TamanhoGrid(){ ColunaNome = "CPF", Tamanho= 120},
                      new TamanhoGrid(){ ColunaNome = "Total", Tamanho= 100},
                });
                dgvCliente.EsconderColuna("ID");
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
        private void AumentarTamanhoDoTxt()
                     => txtPesquisar.Size = new Size(565, 29);
        private void AumentarTamanhoDoForm()
                     => this.Size = new Size(620, 283);
        private void EsconderBtnAdicionar()
                     => btnAdicionar.Visible = false;
        private void CarregarGridParaVender()
        {
            try
            {
                InstanciarlienteRepositorio();
                _clienteRepositorio.ListarParaVender(dgv: dgvCliente);
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
                InstanciarlienteRepositorio();
                if (_clienteRepositorio.GetQuantidade() > 0 && dgvCliente.Rows.Count > 0 && e.RowIndex >= 0)
                {
                    if (GetIDDoGrid() > 0)
                    {
                        if (_enumCreditar == EnumTipoCreditar.Vender)
                        {
                            Cliente.ClienteIDStatic = GetIDDoGrid();
                            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        }
                        else
                        {
                            InstanciarFiadoRepositorio();
                            Fiado fiado = _fiadoRepositorio.PesquisarFiadoPeloID(GetIDDoGrid());
                            if (OpenMdiForm.OpenForWithShowDialog(new frmReceberFiado(fiado)) == DialogResult.Yes)
                                _fiadoRepositorio.ListarCreditos(dgv: dgvCliente);
                        }
                    }
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
        public int GetIDDoGrid()
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
        public decimal GetTotalDoGrid()
        {
            try
            {
                return Convert.ToDecimal(dgvCliente.CurrentRow.Cells["Total"].Value);
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
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCliente(new Cliente(), EnumTipoOperacao.Salvar)) == DialogResult.Yes)
                    CarregarGridParaVender();
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
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InstanciarlienteRepositorio();
                InstanciarFiadoRepositorio();
                if (_clienteRepositorio.GetQuantidade() > 0)
                {
                    if (_enumCreditar == EnumTipoCreditar.Vender)
                        _clienteRepositorio.ListarClientePorNomeVender(dgvCliente, txtPesquisar.Text);
                    else
                        _fiadoRepositorio.ListarClientePorNomePagar(dgvCliente, txtPesquisar.Text);
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
        private void frmClienteCreditar_FormClosing(object sender, FormClosingEventArgs e)
                     => this.DialogResult = DialogResult.Yes;
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Letter(e);
            ValidatorField.AllowOneSpaceTogether(e, sender);
        }

        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
                     => (sender as DataGridView).DefaultCellStyle.Format = "C2";
        private void dgvCliente_KeyDown(object sender, KeyEventArgs e)
                     => ValidatorField.DisableTabInGrid(sender, e);
    }
}
