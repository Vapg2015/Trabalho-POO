namespace Estoque_de_Produtos
{
    partial class frmAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeAltera = new System.Windows.Forms.TextBox();
            this.txtMarcaAltera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantAltera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntradaAltera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValidadeAltera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALTERAR ITEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtNomeAltera
            // 
            this.txtNomeAltera.Location = new System.Drawing.Point(87, 53);
            this.txtNomeAltera.Name = "txtNomeAltera";
            this.txtNomeAltera.Size = new System.Drawing.Size(120, 20);
            this.txtNomeAltera.TabIndex = 2;
            // 
            // txtMarcaAltera
            // 
            this.txtMarcaAltera.Location = new System.Drawing.Point(87, 79);
            this.txtMarcaAltera.Name = "txtMarcaAltera";
            this.txtMarcaAltera.Size = new System.Drawing.Size(120, 20);
            this.txtMarcaAltera.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // txtQuantAltera
            // 
            this.txtQuantAltera.Location = new System.Drawing.Point(87, 105);
            this.txtQuantAltera.Name = "txtQuantAltera";
            this.txtQuantAltera.Size = new System.Drawing.Size(120, 20);
            this.txtQuantAltera.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade";
            // 
            // txtEntradaAltera
            // 
            this.txtEntradaAltera.Location = new System.Drawing.Point(87, 131);
            this.txtEntradaAltera.Name = "txtEntradaAltera";
            this.txtEntradaAltera.Size = new System.Drawing.Size(120, 20);
            this.txtEntradaAltera.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Entrada";
            // 
            // txtValidadeAltera
            // 
            this.txtValidadeAltera.Location = new System.Drawing.Point(87, 157);
            this.txtValidadeAltera.Name = "txtValidadeAltera";
            this.txtValidadeAltera.Size = new System.Drawing.Size(120, 20);
            this.txtValidadeAltera.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Validade";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(22, 183);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(185, 50);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 237);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtValidadeAltera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEntradaAltera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantAltera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarcaAltera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeAltera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "frmAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTERAR ITEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeAltera;
        private System.Windows.Forms.TextBox txtMarcaAltera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantAltera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntradaAltera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValidadeAltera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterar;
    }
}