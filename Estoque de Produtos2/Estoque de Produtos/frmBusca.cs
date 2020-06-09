
using System;
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
    public partial class frmBusca : Form
    {
        txtProduto prod = new txtProduto();
        public frmBusca()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtExibe.Text = prod.listarProdutos().ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtExibe.Clear();
            string pesquisa = prod.pesquisarProdutos(txtIDBuscar.Text, txtNomeBuscar.Text, txtMarcaBuscar.Text);

            if (pesquisa == "")
            {
                MessageBox.Show("Objeto não Encontrado !");
                return;
            }

            txtExibe.Text = pesquisa.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtIDBuscar.Text == "")
            {
                MessageBox.Show("Só é possivel excluir com um ID");
                return;
            }

            prod.Excluir(txtIDBuscar.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtIDBuscar.Text == "")
            {
                MessageBox.Show("Por favor, digite um ID primeiro!");
                return;
            }
            frmAlterar alterar = new frmAlterar(txtIDBuscar.Text);
            alterar.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            prod.Salvar();
        }
    }
}
