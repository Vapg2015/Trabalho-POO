
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Estoque_de_Produtos
{
    public partial class frmAdd : Form
    {

        public frmAdd()
        {
            InitializeComponent();
        }

        txtProduto prod = new txtProduto();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Produtos meusProdutos = new Produtos(txtNome.Text, txtQuant.Text, txtMarca.Text, txtEntrada.Text, txtValidade.Text);

            txtNome.Clear();
            txtEntrada.Clear();
            txtQuant.Clear();
            txtMarca.Clear();
            txtEntrada.Clear();
            txtValidade.Clear();

            prod.inserir(meusProdutos);

        }
    }
}
