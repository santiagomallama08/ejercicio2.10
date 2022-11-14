namespace ejer4
{
    public class program
    {
        public static void Main()
        {
            double pulg = 0;
            double mt= 0.0254;
            double cpulg= 0;
            double mdados= 0;
            Console.WriteLine("digite la cantidad de metros necesitados");
            mdados = double.Parse(Console.ReadLine());
                cpulg = mdados / mt;
            Console.WriteLine($"la cantidad de metros que debe pedir es de {cpulg}")
        }
    }
}
