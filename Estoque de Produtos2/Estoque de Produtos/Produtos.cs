using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque_de_Produtos;

namespace Estoque_de_Produtos
{
    public class Produtos
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string quantidade { get; set; }
        public string marca { get; set; }
        public string dataEntrada { get; set; }
        public string validade { get; set; }

        public Produtos()
        {
            id = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();
            nome = "";
            quantidade = "";
            marca = "";
            dataEntrada = "";
            validade = "";
        }
        public Produtos(string pNome, string quant, string pMarca, string entrada, string pValidade)
        {
            id = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();
            nome = pNome;
            quantidade = quant;
            marca = pMarca;
            dataEntrada = entrada;
            validade = pValidade;
        }

    }
}
