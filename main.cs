using System;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Projeto_marlon
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Ola Lucca. Seja Bem vindo de volta.");
            Console.WriteLine("Selecione os itens e quantidades a serem comprados hoje");
            Console.WriteLine("1 - Mascara Masculina por apenas 5.99 a unidade");
            Console.WriteLine("2 - Mascara Feminina por apenas 5.99 a unidade");
            Console.WriteLine("3 - Face shield promoçao 8.99 a unidade");
            Console.WriteLine("4 - Alcool em gel 500ml 4.99");
            Console.WriteLine("5 - Deseja verificar O seu cadastro?");
            Console.WriteLine("6 - Consultar cadastro de produtos");
            
            double total = 0.0;
            string[] item = Console.ReadLine().Split(' ');
            double codigo = double.Parse(item[0]);
            double quantidade = double.Parse(item[1]);


            Cliente Lucca = new Cliente();
            Lucca.Nome = "Lucca Ferrari";
            Lucca.Endereço = "Rua guaracy, 363";


            Produto Mascara_Masculina = new Produto();
            Mascara_Masculina.SetNome("Mascara Masculina");
            Mascara_Masculina.SetPreço(5.99);


            Produto Mascara_Feminina = new Produto();
            Mascara_Feminina.SetNome("Mascara Feminina");
            Mascara_Feminina.SetPreço(5.99);

            Produto Face_shield = new Produto();
            Face_shield.SetNome("Face shield");
            Face_shield.SetPreço(8.99);

            Produto Alcool_gel = new Produto();
            Alcool_gel.SetNome("Alcool em gel 500ml");
            Alcool_gel.SetPreço(4.99);

            if (codigo == 1)
            {
                total = quantidade * 5.99;
            }


            else if (codigo == 2)
            {
                total = quantidade * 5.99;
            }


            else if (codigo == 3)
            {
                total = quantidade * 8.99;
            }


            else if (codigo == 4)
            {
                total = quantidade * 4.99;
            }

            else if (codigo == 5)
            {
                Console.WriteLine(Lucca.Nome);
                Console.WriteLine(Lucca.Endereço);
                
            }

            else if (codigo == 6)
            {
                Console.WriteLine(Mascara_Feminina);
                Console.WriteLine(Mascara_Masculina);
                Console.WriteLine(Face_shield);
                Console.WriteLine("Produto {0}",Alcool_gel);

            }
            else
            {
                Console.WriteLine("codigo nao cadastrado");
            }



            Console.WriteLine("Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}