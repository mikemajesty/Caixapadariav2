namespace View
{
    partial class frmMensagemDeEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensagemDeEspera));
            this.ptbImgLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbImgLoad
            // 
            this.ptbImgLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbImgLoad.Image = ((System.Drawing.Image)(resources.GetObject("ptbImgLoad.Image")));
            this.ptbImgLoad.Location = new System.Drawing.Point(0, 0);
            this.ptbImgLoad.Name = "ptbImgLoad";
            this.ptbImgLoad.Size = new System.Drawing.Size(230, 70);
            this.ptbImgLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImgLoad.TabIndex = 0;
            this.ptbImgLoad.TabStop = false;
            // frmMensagemEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 70);
            this.Controls.Add(this.ptbImgLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMensagemEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImgLoad;

    }
}