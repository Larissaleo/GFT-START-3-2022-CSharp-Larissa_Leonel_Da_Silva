namespace calculoArea.Models
{
    public class Retangulo : AreaCalculavel

    {

        public double largura{get; set;}
        public double altura{get; set;}

        public void definirMedidasRetangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
            
        
        
        public double calcularArea(double area)
        {
            area = largura*altura;

            return area;
        }


    }
}