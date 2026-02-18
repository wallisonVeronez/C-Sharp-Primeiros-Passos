namespace JurosSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora de Juros Simples");

            decimal capital = ParseDecimal("Informe o valor do Capital investido: ");
            decimal taxa = ParseDecimal("Informe a taxa anual de juros: (ex: 0,12 para 12%)");
            decimal tempo = ParseDecimal("Informe o período em anos: ");

            decimal juros = capital * taxa * tempo;
            decimal montante = capital + juros;

            Console.WriteLine($"\nRendimentos:{juros:C} \nMontante final: {montante:C} ");
            Console.ReadKey();
            
        }
        static decimal ParseDecimal(string mensagem)
        {
            decimal saida;
            Console.WriteLine(mensagem);
            while(!decimal.TryParse(Console.ReadLine(), out saida))
            {
                Console.WriteLine("Entrada inválida");
                Console.WriteLine(mensagem);
            }
            return saida;
        }

    }
}
