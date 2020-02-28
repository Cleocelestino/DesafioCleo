using System;

namespace DesafioCleo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Contrato de Adesão\n" +
                "Obrigado Sr(a) " + nome + " por contratar o nosso serviço.\n" +
                "Assine abaixo\n\n\n" + nome.ToUpper());


        }
    }
}
