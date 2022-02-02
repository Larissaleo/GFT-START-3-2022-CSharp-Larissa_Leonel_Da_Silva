using System;
using Salario.Models;

namespace Salario{

    public class program
    {
        static void Main(string[] args)
        {
            double salario;
            int idade;
            string nome;

            double  GerenteSalario = 2000;
            Gerente gerenteSalario = new Gerente (2000);
            gerenteSalario.Bonificacao(GerenteSalario);
             System.Console.WriteLine($"Salario Gerente {gerenteSalario.Bonificacao(GerenteSalario)}: ");
            

            double SupervisorSalario = 1500;
            Supervisor supervisorSalario = new Supervisor (1500);
            supervisorSalario.Bonificacao(SupervisorSalario);
            System.Console.WriteLine($"Salario Supervisor {supervisorSalario.Bonificacao(SupervisorSalario)}: ");


            double VendedorSalario = 1000;
            Vendedor vendedorSalario = new Vendedor(1000);
            vendedorSalario.Bonificacao(VendedorSalario);
            System.Console.WriteLine($"Salario Gerente {vendedorSalario.Bonificacao(VendedorSalario)}: ");



        }
    }
}


