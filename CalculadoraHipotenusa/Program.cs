
namespace Hipotenusa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Hipotenusa");
            Console.WriteLine("Informe a medida do do cateto A: ");
            if (double.TryParse(Console.ReadLine(), out double catetoA))
            {
                Console.WriteLine("Informe a medida do cateto B: ");
                if (double.TryParse(Console.ReadLine(), out double catetoB))
                    {
                    double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
                    Console.WriteLine($"Hipotenusa: aproximadamente {hipotenusa:F2}");
                }
                else
                {
                    Console.WriteLine("Entrada Inválida.");
                }
            }
            else
            {
                Console.WriteLine("Entrada Inválida.");
            }
            Console.ReadKey();
        }
    }
}
