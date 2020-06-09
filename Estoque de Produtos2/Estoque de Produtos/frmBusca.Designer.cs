namespace Estoque_de_Produtos
{
    partial class frmBusca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusca));
            this.txtMarcaBuscar = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtNomeBuscar = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtExibe = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNameProgram = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDBuscar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarcaBuscar
            // 
            this.txtMarcaBuscar.Location = new System.Drawing.Point(51, 172);
            this.txtMarcaBuscar.Name = "txtMarcaBuscar";
            this.txtMarcaBuscar.Size = new System.Drawing.Size(186, 20);
            this.txtMarcaBuscar.TabIndex = 20;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(8, 175);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(37, 13);
            this.lblBrand.TabIndex = 19;
            this.lblBrand.Text = "Marca";
            // 
            // txtNomeBuscar
            // 
            this.txtNomeBuscar.Location = new System.Drawing.Point(51, 146);
            this.txtNomeBuscar.Name = "txtNomeBuscar";
            this.txtNomeBuscar.Size = new System.Drawing.Size(186, 20);
            this.txtNomeBuscar.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Nome";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(13, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(224, 55);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Buscar Item";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.Location = new System.Drawing.Point(12, 259);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(225, 55);
            this.btnListar.TabIndex = 24;
            this.btnListar.Text = "Listar Itens";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtExibe);
            this.panel1.Location = new System.Drawing.Point(240, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 339);
            this.panel1.TabIndex = 26;
            // 
            // txtExibe
            // 
            this.txtExibe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExibe.Location = new System.Drawing.Point(3, 19);
            this.txtExibe.Multiline = true;
            this.txtExibe.Name = "txtExibe";
            this.txtExibe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExibe.Size = new System.Drawing.Size(542, 317);
            this.txtExibe.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblNameProgram);
            this.panel2.Location = new System.Drawing.Point(38, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 92);
            this.panel2.TabIndex = 27;
            // 
            // lblNameProgram
            // 
            this.lblNameProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameProgram.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProgram.Location = new System.Drawing.Point(11, 0);
            this.lblNameProgram.Name = "lblNameProgram";
            this.lblNameProgram.Size = new System.Drawing.Size(735, 92);
            this.lblNameProgram.TabIndex = 3;
            this.lblNameProgram.Text = "Sistema de Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // txtIDBuscar
            // 
            this.txtIDBuscar.Location = new System.Drawing.Point(51, 118);
            this.txtIDBuscar.Name = "txtIDBuscar";
            this.txtIDBuscar.Size = new System.Drawing.Size(186, 20);
            this.txtIDBuscar.TabIndex = 29;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(11, 320);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(111, 49);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(125, 320);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 49);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtIDBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMarcaBuscar);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtNomeBuscar);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarcaBuscar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtNomeBuscar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtExibe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNameProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}