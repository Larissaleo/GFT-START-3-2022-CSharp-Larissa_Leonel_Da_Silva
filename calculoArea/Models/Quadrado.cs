namespace calculoArea.Models
{
    public class Quadrado : AreaCalculavel
    {
        public double lado {get;set;}

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        
        public void calcularAreaQuadrado(double lado)
        {
            this.lado = lado;
        }

        public double calcularArea(double area)
        {
            area = lado*lado;
            return area;
        }
    }

}