using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            double total_disp = 0;
            do
            {
                Console.WriteLine("Descrição da despesa:");
                string despesa = Console.ReadLine();
                Console.WriteLine("Valor da despesa:");
                double valor = double.Parse(Console.ReadLine());


                Console.WriteLine("Deseja adicionar outra despesa ?");
                resp = Console.ReadLine().ToUpper();

                total_disp += valor;
            }

            while (resp == "SIM");

            Console.WriteLine("Valor total de despesas: " + total_disp);







            Console.ReadKey();
        }
    }
}
