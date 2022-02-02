namespace Salario.Models
{
    public class Gerente
    {
        public double salario{get;set;}
       

        public Gerente(double salario)
        {
            this.salario = salario;
          
            
        }

        

        public double Bonificacao(double salario){
            salario = salario + 10000.00;

            return salario;

            
        }

        
    }
}