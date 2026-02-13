namespace Quadratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            Console.WriteLine("Informe o valor de A: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Entrada Inválida.");
                return;
            }
            Console.WriteLine("Informe o valor de B: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Entrada Inválida.");
                return;
            }
            Console.WriteLine("Informe o valor de C: ");
            if(!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Entrada Inválida. Por favor Insira um Nu");
                return;
            }

            // delta  = (b*b) - 4ac
            double delta = Math.Pow(b, 2) - (4 * a * c);
            
            if (delta < 0)
            {
                Console.WriteLine("A equação não possui raízes reais.");
            }
            else
            {
                // b + ou - Sqrt Δ / (2a)
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                // com concatencao Console.WriteLine("S = {" + x1 + " ," + x2 + "}.");
                Console.WriteLine($"S = {{{x1:F2}, {x2:F2}}}");



            }
        }   
    }
}
