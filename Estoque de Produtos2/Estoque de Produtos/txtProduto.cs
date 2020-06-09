using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.IO.IsolatedStorage;

namespace Estoque_de_Produtos
{
    public class txtProduto
    {
        public txtProduto()
        {
            prodlist = new ArrayList();

            prodlist = lerProdutos();
        }
        public ArrayList prodlist;

        public string Nome { get; set; }
        public int quantidade { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataValidade { get; set; }


        public void inserir(Produtos produtos)
        {
            prodlist.Add(produtos);
            string arquivo = @"C:\\Users\\vgalv\\source\\repos\\Estoque de Produtos2\\Estoque de Produtos\\produtos.txt";

            using (StreamWriter gravaProdutos = File.AppendText(arquivo))
            {
                gravaProdutos.WriteLine($"ID:{produtos.id.Trim()}");
                gravaProdutos.WriteLine($"Nome:{produtos.nome.Trim()}");
                gravaProdutos.WriteLine($"Quantidade:{produtos.quantidade.ToString().Trim()}");
                gravaProdutos.WriteLine($"Marca:{produtos.marca.ToString().Trim()}");
                gravaProdutos.WriteLine($"Data de Entrada:{produtos.dataEntrada.ToString().Trim()}");
                gravaProdutos.WriteLine($"Data de Validade:{produtos.validade.ToString().Trim()}");
            }
        }


        public ArrayList lerProdutos()
        {
            try
            {
                string linha;

                prodlist.Clear();

                StreamReader lerProdutos = new StreamReader("C:\\Users\\vgalv\\source\\repos\\Estoque de Produtos2\\Estoque de Produtos\\produtos.txt");

                Produtos x = new Produtos();

                while ((linha = lerProdutos.ReadLine()) != null)
                {


                    string[] split1 = linha.Split(':');

                    if (split1[0] == "ID")
                    {
                        x.id = split1[1];
                    }

                    if (split1[0] == "Nome")
                    {
                        x.nome = split1[1];
                    }

                    if (split1[0] == "Quantidade")
                    {
                        x.quantidade = split1[1];
                    }

                    if (split1[0] == "Marca")
                    {
                        x.marca = split1[1];
                    }

                    if (split1[0] == "Data de Entrada")
                    {
                        x.dataEntrada = split1[1];
                    }

                    if (split1[0] == "Data de Validade")
                    {
                        x.validade = split1[1];
                        prodlist.Add(x);
                        x = new Produtos();
                    }
                }

                lerProdutos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o produto. Descrição: {0}", ex.Message.ToString());
            }
            return prodlist;
        }



        public string listarProdutos()
        {
            string linha = "";

            prodlist = lerProdutos();

            foreach (Produtos x in prodlist)
            {
                linha += $"\r\nID: {x.id}\r\n";
                linha += $"Nome: {x.nome}\r\n";
                linha += $"Quantidade: {x.quantidade}\r\n";
                linha += $"Marca: {x.marca}\r\n";
                linha += $"Data de Entrada: {x.dataEntrada}\r\n";
                linha += $"Data de Validade: {x.validade}\r\n";
                linha += "=========================================";
            }
            return linha;
        }

        public string pesquisarProdutos(string id, string nome, string marca)
        {
            string linha = "";
            foreach (Produtos x in prodlist)
            {
                if (x.nome.ToString().ToLower() == nome.ToLower() || x.id.ToString().ToLower() == id.ToLower() || x.marca.ToString().ToLower() == marca.ToString().ToLower())
                {
                    linha += $"\r\nID: {x.id}\r\n";
                    linha += $"Nome: {x.nome}\r\n";
                    linha += $"Quantidade: {x.quantidade}\r\n";
                    linha += $"Marca: {x.marca}\r\n";
                    linha += $"Data de Entrada: {x.dataEntrada}\r\n";
                    linha += $"Data de Validade: {x.validade}\r\n";
                    linha += "=========================================";
                }
            }
            return linha;
        }

        public void Excluir(string id)
        {
            foreach (Produtos x in prodlist)
            {
                if (x.id.ToLower() == id.ToLower())
                {
                    prodlist.Remove(x);
                    MessageBox.Show("Produto Excluido!\nPor favor clique em Listar para ver alteaçções.");
                    Salvar();
                    return;
                }
            }
            MessageBox.Show("Produto não encontrado!");

            
        }

        public void Alterar(string id, string nome, string quant, string marca, string entrada, string validade)
        {
            int i = 0;
            foreach (Produtos x in prodlist)
            {
                if (x.id.ToLower() == id.ToLower())
                {
                    prodlist.Remove(x);
                    x.nome = nome;
                    x.quantidade = quant;
                    x.marca = marca;
                    x.dataEntrada = entrada;
                    x.validade = validade;
                    prodlist.Add(x);

                    Salvar();
                    return;
                }
                i++;
            }
        }

        public void Salvar()
        {
            string arquivo = @"C:\\Users\\vgalv\\source\\repos\\Estoque de Produtos2\\Estoque de Produtos\\produtos.txt";

            //FileStream file = File.WriteAllText(arquivo, "");

            File.WriteAllText(arquivo, "");

            using (StreamWriter gravaProdutos = File.AppendText(arquivo))
            {
                foreach (Produtos x in prodlist)
                {
                    gravaProdutos.WriteLine($"ID:{x.id.Trim()}");
                    gravaProdutos.WriteLine($"Nome:{x.nome.Trim()}");
                    gravaProdutos.WriteLine($"Quantidade:{x.quantidade.ToString().Trim()}");
                    gravaProdutos.WriteLine($"Marca:{x.marca.ToString().Trim()}");
                    gravaProdutos.WriteLine($"Data de Entrada:{x.dataEntrada.ToString().Trim()}");
                    gravaProdutos.WriteLine($"Data de Validade:{x.validade.ToString().Trim()}");
                }
                gravaProdutos.Close();
            }
            return;
        }
    }
}