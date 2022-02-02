namespace calculoArea.Models
{
    public class Circulo : AreaCalculavel
    {
        
        public double raio {get;set;}

        public void definirRaio(double raio)
        {
            this.raio = raio;
        }
       

        public double calcularArea(double area)
        {
            // throw new area= ();

            area = 3.14*raio*raio;

            return area;
        }
    }
}