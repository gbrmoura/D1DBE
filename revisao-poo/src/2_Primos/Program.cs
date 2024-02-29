using Primos;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Informe os dados abaixo para validação de numeros primos:");

            Console.Write("Primeiro Parametro: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo Parametro: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Utils utils = new Utils();
            int count = utils.ContaPrimos(x, y);
            Console.WriteLine($"A quantidade de numero primos encontrados foi: {count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}