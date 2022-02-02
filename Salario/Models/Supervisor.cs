namespace Salario.Models
{
    public class Supervisor
    {
        public double salario{get;set;}

        public Supervisor(double salario){
            this.salario = salario;
        }

        public double Bonificacao(double salario){
            salario = salario + 5000.00;

            return salario;
        }
    }
}