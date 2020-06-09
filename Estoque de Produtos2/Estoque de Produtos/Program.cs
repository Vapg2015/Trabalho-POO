using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque_de_Produtos
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            txtProduto prod = new txtProduto();
            frmLogin login = new frmLogin();
            frmAdd add = new frmAdd();
            frmMain main = new frmMain();


            if (login.ShowDialog() == DialogResult.OK)
            {
                main.ShowDialog();
            }

            //if (main.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new frmAdd());
            //}
            //else
            //{
            //    Application.Exit();
            //}

            //if (main.ShowDialog() == DialogResult.Yes)
            //{
            //    Application.Run(new frmBusca());
            //}

            //if (add.ShowDialog() == DialogResult.Retry)
            //{
            //    Application.Run(new frmMain());
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}
