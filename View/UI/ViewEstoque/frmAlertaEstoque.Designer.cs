namespace View.UI.ViewEstoque
{
    partial class frmAlertaEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlertaEstoque));
            this.tabAvisos = new System.Windows.Forms.TabControl();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.lblSemRecado = new System.Windows.Forms.Label();
            this.dgvAvisosEstoque = new System.Windows.Forms.DataGridView();
            this.tab = new System.Windows.Forms.TabPage();
            this.lblExpirar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAvisos.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisosEstoque)).BeginInit();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAvisos
            // 
            this.tabAvisos.Controls.Add(this.tabEstoque);
            this.tabAvisos.Controls.Add(this.tab);
            this.tabAvisos.Font = new System.Drawing.Font("Ravie", 12F);
            this.tabAvisos.Location = new System.Drawing.Point(12, 34);
            this.tabAvisos.Name = "tabAvisos";
            this.tabAvisos.SelectedIndex = 0;
            this.tabAvisos.Size = new System.Drawing.Size(343, 196);
            this.tabAvisos.TabIndex = 20;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.lblSemRecado);
            this.tabEstoque.Controls.Add(this.dgvAvisosEstoque);
            this.tabEstoque.Font = new System.Drawing.Font("Ravie", 12F);
            this.tabEstoque.Location = new System.Drawing.Point(4, 31);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(335, 161);
            this.tabEstoque.TabIndex = 0;
            this.tabEstoque.Text = "Estoque";
            this.tabEstoque.UseVisualStyleBackColor = true;
            // 
            // lblSemRecado
            // 
            this.lblSemRecado.AutoSize = true;
            this.lblSemRecado.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemRecado.Location = new System.Drawing.Point(77, 53);
            this.lblSemRecado.Name = "lblSemRecado";
            this.lblSemRecado.Size = new System.Drawing.Size(182, 44);
            this.lblSemRecado.TabIndex = 22;
            this.lblSemRecado.Text = "Você não possui \r\n      Recados";
            // 
            // dgvAvisosEstoque
            // 
            this.dgvAvisosEstoque.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.dgvAvisosEstoque.AllowDrop = true;
            this.dgvAvisosEstoque.AllowUserToAddRows = false;
            this.dgvAvisosEstoque.AllowUserToDeleteRows = false;
            this.dgvAvisosEstoque.AllowUserToResizeColumns = false;
            this.dgvAvisosEstoque.AllowUserToResizeRows = false;
            this.dgvAvisosEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvisosEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAvisosEstoque.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ravie", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvisosEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvisosEstoque.ColumnHeadersHeight = 40;
            this.dgvAvisosEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ravie", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvisosEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvisosEstoque.Location = new System.Drawing.Point(6, 6);
            this.dgvAvisosEstoque.MultiSelect = false;
            this.dgvAvisosEstoque.Name = "dgvAvisosEstoque";
            this.dgvAvisosEstoque.ReadOnly = true;
            this.dgvAvisosEstoque.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvisosEstoque.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAvisosEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvisosEstoque.Size = new System.Drawing.Size(323, 149);
            this.dgvAvisosEstoque.TabIndex = 21;
            this.dgvAvisosEstoque.TabStop = false;
            this.dgvAvisosEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvisosEstoque_CellDoubleClick);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.lblExpirar);
            this.tab.Location = new System.Drawing.Point(4, 31);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(335, 161);
            this.tab.TabIndex = 1;
            this.tab.Text = "Sistema";
            this.tab.UseVisualStyleBackColor = true;
            // 
            // lblExpirar
            // 
            this.lblExpirar.AutoSize = true;
            this.lblExpirar.ForeColor = System.Drawing.Color.Red;
            this.lblExpirar.Location = new System.Drawing.Point(94, 19);
            this.lblExpirar.Name = "lblExpirar";
            this.lblExpirar.Size = new System.Drawing.Size(173, 88);
            this.lblExpirar.TabIndex = 0;
            this.lblExpirar.Text = "Faltam tantos \r\n     dias \r\npara expirar \r\no programa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Avisos  e Recados\r\n";
            // 
            // frmAlertaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabAvisos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlertaEstoque";
            this.Text = "Alerta de Estoque";
            this.Load += new System.EventHandler(this.frmAlertaEstoque_Load);
            this.tabAvisos.ResumeLayout(false);
            this.tabEstoque.ResumeLayout(false);
            this.tabEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisosEstoque)).EndInit();
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabAvisos;
        private System.Windows.Forms.TabPage tabEstoque;
        private System.Windows.Forms.DataGridView dgvAvisosEstoque;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.Label lblSemRecado;
        private System.Windows.Forms.Label lblExpirar;
        private System.Windows.Forms.Label label1;
    }
}