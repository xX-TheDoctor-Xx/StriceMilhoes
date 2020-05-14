using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriceMilhoes
{
    class Program
    {
        static int numero1 = 0;
        static int numero2 = 0;
        static int numero3 = 0;
        static int numero4 = 0;
        static int numero5 = 0;

        static int estrela1 = 0;
        static int estrela2 = 0;

        static void getNumeros()
        {
            Console.Clear();
            Console.WriteLine("Digite numeros entre 1 e 50");
            Console.Write("Primeiro numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Terceiro numero: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quarto numero: ");
            numero4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quinto numero: ");
            numero5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite numeros entre 1 e 12");

            Console.Write("Primeira estrela: ");
            estrela1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segunda estrela: ");
            estrela2 = Convert.ToInt32(Console.ReadLine());
        }

        static void jogar()
        {
            Console.Clear();
            getNumeros();

            while (numero1 == numero2 || numero1 == numero2 || numero1 == numero3 || numero1 == numero4 || numero1 == numero5 ||
                numero2 == numero3 || numero2 == numero4 || numero2 == numero5 ||
                numero3 == numero4 || numero3 == numero5 ||
                numero4 == numero5 ||
                estrela1 == estrela2 ||
                numero1 > 50 || numero2 > 50 || numero3 > 50 || numero4 > 50 || numero5 > 50 ||
                estrela1 > 12 || estrela2 > 12 ||
                numero1 == 0 || numero2 == 0 || numero3 == 0 || numero4 == 0 || numero5 == 0 || estrela1 == 0 || estrela2 == 0)
            {
                getNumeros();
                Console.WriteLine("Voce digitou numeros invalidos. Por favor digite outros numeros");
                Console.ReadKey();
            }

            Random rand = new Random();

            int quantidade_de_numeros_acertados = 0;
            int quantidade_de_estrelas_acertadas = 0;

            if (numero1 == rand.Next(1, 50))
                quantidade_de_numeros_acertados++;
            if (numero2 == rand.Next(1, 50))
                quantidade_de_numeros_acertados++;
            if (numero3 == rand.Next(1, 50))
                quantidade_de_numeros_acertados++;
            if (numero4 == rand.Next(1, 50))
                quantidade_de_numeros_acertados++;
            if (numero5 == rand.Next(1, 50))
                quantidade_de_numeros_acertados++;
            if (estrela1 == rand.Next(1, 12))
                quantidade_de_estrelas_acertadas++;
            if (estrela2 == rand.Next(1, 12))
                quantidade_de_estrelas_acertadas++;

            Console.WriteLine("Voce acertou: " + Convert.ToString(quantidade_de_numeros_acertados) + " numeros e " + Convert.ToString(quantidade_de_estrelas_acertadas) + " estrelas");
            Console.ReadKey();
        }

        //estrelas 12
        static void Main(string[] args)
        {
            while (true)
                jogar();
        }
    }
}
