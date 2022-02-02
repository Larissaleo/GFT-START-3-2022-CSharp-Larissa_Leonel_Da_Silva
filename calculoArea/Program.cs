using System;
using calculoArea.Models;

namespace calculoArea
{
    public class Program 
    {
         static void Main(string[] args)
    {
        double raio, lado, altura, largura, area;

       System.Console.WriteLine("Insira o valor do lado do quadrado");
       lado = double.Parse(Console.ReadLine());
       Quadrado q = new Quadrado(lado);
        q.calcularAreaQuadrado(lado);

        System.Console.WriteLine("Insira o valor do raio do circulo: ");
        raio = double.Parse(Console.ReadLine());
        Circulo c = new Circulo();
        c.definirRaio(raio);


        System.Console.WriteLine("Insira o valor da largura do retangulo: ");
        largura = double.Parse(Console.ReadLine());
         System.Console.WriteLine("Insira o valor da Altura do retangulo: ");
        altura = double.Parse(Console.ReadLine());
        Retangulo r = new Retangulo();
        r.definirMedidasRetangulo(altura, largura);


        

        

       
        

        System.Console.WriteLine($"Area do circulo: {c.calcularArea(raio)}");
        System.Console.WriteLine($"Area quadrado: {q.calcularArea(lado)}");
        System.Console.WriteLine($"Area Retangulo: {r.calcularArea(largura)}");

    }
    }

   
}
