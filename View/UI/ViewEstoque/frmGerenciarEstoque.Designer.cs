namespace View.UI.ViewEstoque
{
    partial class frmGerenciarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbEstoque = new System.Windows.Forms.GroupBox();
            this.ckbPorCodigo = new System.Windows.Forms.RadioButton();
            this.ckbPorNome = new System.Windows.Forms.RadioButton();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gpbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEstoque
            // 
            this.gpbEstoque.Controls.Add(this.ckbPorCodigo);
            this.gpbEstoque.Controls.Add(this.ckbPorNome);
            this.gpbEstoque.Controls.Add(this.txtEstoque);
            this.gpbEstoque.Controls.Add(this.dgvEstoque);
            this.gpbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEstoque.Location = new System.Drawing.Point(12, 12);
            this.gpbEstoque.Name = "gpbEstoque";
            this.gpbEstoque.Size = new System.Drawing.Size(590, 328);
            this.gpbEstoque.TabIndex = 7;
            this.gpbEstoque.TabStop = false;
            this.gpbEstoque.Text = "Pesquisar produto para alterar o estoque";
            // 
            // ckbPorCodigo
            // 
            this.ckbPorCodigo.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbPorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPorCodigo.Image = ((System.Drawing.Image)(resources.GetObject("ckbPorCodigo.Image")));
            this.ckbPorCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbPorCodigo.Location = new System.Drawing.Point(298, 21);
            this.ckbPorCodigo.Name = "ckbPorCodigo";
            this.ckbPorCodigo.Size = new System.Drawing.Size(279, 63);
            this.ckbPorCodigo.TabIndex = 9;
            this.ckbPorCodigo.TabStop = true;
            this.ckbPorCodigo.Text = "Código";
            this.ckbPorCodigo.UseVisualStyleBackColor = true;
            this.ckbPorCodigo.CheckedChanged += new System.EventHandler(this.ckbPorCodigo_CheckedChanged);
            // 
            // ckbPorNome
            // 
            this.ckbPorNome.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbPorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPorNome.Image = ((System.Drawing.Image)(resources.GetObject("ckbPorNome.Image")));
            this.ckbPorNome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbPorNome.Location = new System.Drawing.Point(8, 21);
            this.ckbPorNome.Name = "ckbPorNome";
            this.ckbPorNome.Size = new System.Drawing.Size(279, 63);
            this.ckbPorNome.TabIndex = 9;
            this.ckbPorNome.TabStop = true;
            this.ckbPorNome.Text = "Nome";
            this.ckbPorNome.UseVisualStyleBackColor = true;
            this.ckbPorNome.CheckedChanged += new System.EventHandler(this.ckbPorNome_CheckedChanged);
            // 
            // txtEstoque
            // 
            this.txtEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(6, 90);
            this.txtEstoque.MaxLength = 30;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(575, 31);
            this.txtEstoque.TabIndex = 8;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEstoque.TextChanged += new System.EventHandler(this.txtEstoque_TextChanged);
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowDrop = true;
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AllowUserToResizeColumns = false;
            this.dgvEstoque.AllowUserToResizeRows = false;
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstoque.ColumnHeadersHeight = 40;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstoque.Location = new System.Drawing.Point(6, 127);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.RowHeadersWidth = 40;
            this.dgvEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(575, 183);
            this.dgvEstoque.TabIndex = 7;
            this.dgvEstoque.TabStop = false;
            this.dgvEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellDoubleClick);
            this.dgvEstoque.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEstoque_CellFormatting);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(623, 142);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 75);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Estoque esta normal";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(623, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 75);
            this.textBox2.TabIndex = 8;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Estoque esta acima da média";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Red;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(623, 265);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 75);
            this.textBox3.TabIndex = 8;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Estoque esta abaixo da média";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGerenciarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 352);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gpbEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Estoque";
            this.Load += new System.EventHandler(this.frmGerenciarEstoque_Load);
            this.gpbEstoque.ResumeLayout(false);
            this.gpbEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.RadioButton ckbPorCodigo;
        private System.Windows.Forms.RadioButton ckbPorNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}