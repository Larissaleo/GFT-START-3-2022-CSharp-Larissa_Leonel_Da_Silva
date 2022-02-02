using System.Linq;
using static System.Console;

namespace FraseInvertida
{
    public class Program
    {
        static void Main(string[] args)
        {
            string frase;
            bool validacao;

            frase = Console.ReadLine();
            System.Console.WriteLine("Por favor insira o texto/frase a ser invertido");
            string Inverterfrase = new string(frase.Reverse().ToArray());

            if(frase == Inverterfrase)
            {
                validacao = true;
            }
            else{
                validacao = false;
            }

            System.Console.WriteLine($"Texto/Frase invertido(a): {Inverterfrase} --> {validacao}");
        }
            

            
    }
}

