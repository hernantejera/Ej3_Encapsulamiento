namespace Ej3_Encapsulamiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();

            circulo.EstablecerRadio(68);
           

            double radio = circulo.ObtenerRadio();


         Console.WriteLine($"El radio del circulo es {radio}");

        }
    }
}