namespace View.UI.ViewSangria
{
    partial class frmSangria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSangria));
            this.gpbSangria = new System.Windows.Forms.GroupBox();
            this.dgvSangria = new System.Windows.Forms.DataGridView();
            this.gpbValor = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpPesquisar = new System.Windows.Forms.DateTimePicker();
            this.btnTodos = new System.Windows.Forms.Button();
            this.gpbSangria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSangria)).BeginInit();
            this.gpbValor.SuspendLayout();
            this.gpbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSangria
            // 
            this.gpbSangria.Controls.Add(this.dgvSangria);
            this.gpbSangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSangria.Location = new System.Drawing.Point(12, 78);
            this.gpbSangria.Name = "gpbSangria";
            this.gpbSangria.Size = new System.Drawing.Size(583, 201);
            this.gpbSangria.TabIndex = 0;
            this.gpbSangria.TabStop = false;
            this.gpbSangria.Text = "Sangria";
            // 
            // dgvSangria
            // 
            this.dgvSangria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSangria.Location = new System.Drawing.Point(7, 22);
            this.dgvSangria.Name = "dgvSangria";
            this.dgvSangria.Size = new System.Drawing.Size(565, 171);
            this.dgvSangria.TabIndex = 0;
            this.dgvSangria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSangria_CellDoubleClick);
            // 
            // gpbValor
            // 
            this.gpbValor.Controls.Add(this.lblValor);
            this.gpbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValor.Location = new System.Drawing.Point(12, 282);
            this.gpbValor.Name = "gpbValor";
            this.gpbValor.Size = new System.Drawing.Size(583, 70);
            this.gpbValor.TabIndex = 1;
            this.gpbValor.TabStop = false;
            this.gpbValor.Text = "Valor";
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(7, 19);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(565, 45);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.btnPesquisar);
            this.gpbPesquisar.Controls.Add(this.dtpPesquisar);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(431, 60);
            this.gpbPesquisar.TabIndex = 3;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(287, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(135, 38);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpPesquisar
            // 
            this.dtpPesquisar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesquisar.Location = new System.Drawing.Point(7, 22);
            this.dtpPesquisar.Name = "dtpPesquisar";
            this.dtpPesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpPesquisar.Size = new System.Drawing.Size(274, 26);
            this.dtpPesquisar.TabIndex = 3;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.Yellow;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTodos.Location = new System.Drawing.Point(449, 28);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(135, 38);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // frmSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 367);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.gpbPesquisar);
            this.Controls.Add(this.gpbValor);
            this.Controls.Add(this.gpbSangria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSangria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangria";
            this.Load += new System.EventHandler(this.frmSangria_Load);
            this.gpbSangria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSangria)).EndInit();
            this.gpbValor.ResumeLayout(false);
            this.gpbPesquisar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSangria;
        private System.Windows.Forms.DataGridView dgvSangria;
        private System.Windows.Forms.GroupBox gpbValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gpbPesquisar;
        private System.Windows.Forms.DateTimePicker dtpPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnTodos;
    }
}