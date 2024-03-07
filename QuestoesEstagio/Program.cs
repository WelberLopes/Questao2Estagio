using System;
using System.Globalization;


namespace Questoes {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número para verificação: ");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;
            int n1 = 0;
            int n2 = 1;



            for (int i = 1; i <= numero && soma < numero; i++) {
                soma = n1 + n2;
                n2 = n1;
                n1 = soma;

                Console.WriteLine(soma);
            }
            if (soma == numero) {
                Console.WriteLine($"Sim, o número {numero} faz parte! E o proximo será: "+ (numero + n2));
            } else {
                Console.WriteLine($"Não, o número {numero} não faz parte");
            }
           
        }
    }
}