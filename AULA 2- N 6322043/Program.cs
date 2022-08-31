using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_2__N_6322043
{
    internal class Program
    {
        static void Main(string[] args)          
        {
            //Nome: Daniel dos Santos
            //Ra:6322043

            Filme fil = new Filme();
            Entrada entra = new Entrada();



            Console.WriteLine("Digite o Titulo do filme: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Digite a sinopse do Filme: ");
            string sinopse = Console.ReadLine();
            Console.WriteLine("Digite o Genero do Filme: ");
            string genero = Console.ReadLine();
            Console.WriteLine("Digite a classificação do Filme");
            string classificacao = Console.ReadLine();
            fil.Receber(titulo, sinopse, genero, classificacao);

            Console.WriteLine("Digite o Valor do Filme: ");
            entra.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a Poltrona do Cinema: ");
            entra.SetPoltrona(Console.ReadLine());
            Console.WriteLine("Digite a Data do Filme: ");
            entra.SetData(Console.ReadLine());
            Console.WriteLine("Digte a Hora do Filme: ");
            entra.SetHora(Console.ReadLine());

            Console.WriteLine(fil.Mostrar());
            Console.WriteLine("Valor: " + entra.GetValor().ToString("C") + "\nPoltrona: " + entra.GetPoltrona() +
                "\nData: " + entra.GetData()  + "\nHora: " + entra.GetHora());




            Console.ReadKey();







        }
    }
}
