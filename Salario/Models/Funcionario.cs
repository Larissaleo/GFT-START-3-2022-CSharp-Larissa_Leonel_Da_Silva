namespace Salario.Models
{
    public class Funcionario
    {
        public string nome;

        public int idade;

        public double salario;

        public double Bonificacao(double salario)
        {
            return salario;
        }
        
    }
}