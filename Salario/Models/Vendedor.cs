namespace Salario.Models
{
    public class Vendedor : Funcionario
    {
        public double salario{get; set;}

        public Vendedor(double salario)
        {
            this.salario = salario;
        }

        public double Bonificacao(double salario)
        {
            salario = salario + 3000.00;

            return salario;
        }
    }
}