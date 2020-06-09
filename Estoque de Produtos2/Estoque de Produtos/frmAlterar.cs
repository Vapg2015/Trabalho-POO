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
    public partial class frmAlterar : Form
    {
        txtProduto prod = new txtProduto();

        string identificador;
        public frmAlterar(string id)
        {
            InitializeComponent();
            identificador = id;
        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            prod.Alterar(identificador, txtNomeAltera.Text, txtQuantAltera.Text, txtMarcaAltera.Text, txtEntradaAltera.Text, txtValidadeAltera.Text);

            MessageBox.Show("Produto Alterado!\nPor favor clique em Listar para ver alteaçções.");

            this.Close();
        }
    }
}
