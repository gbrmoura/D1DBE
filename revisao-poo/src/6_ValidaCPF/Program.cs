
using _6_ValidaCPF;

internal class Program
{
    private static void Main(string[] args)
    {
        Util util = new Util();

        string firstCpf = "461.735.577-46";
        string firstCpfResult = util.IsValidCPF(firstCpf) ? "Valido" : "Invalido";
        Console.WriteLine($"O CPF: {firstCpf} ele é {firstCpfResult}");

        string secondCpf = "421.732.537-26";
        string secondCpfResult = util.IsValidCPF(secondCpf) ? "Valido" : "Invalido";
        Console.WriteLine($"O CPF: {secondCpf} ele é {secondCpfResult}");

        string thirdCpf = "23303708142";
        string thirdCpfResult = util.IsValidCPF(thirdCpf) ? "Valido" : "Invalido";
        Console.WriteLine($"O CPF: {thirdCpf} ele é {thirdCpfResult}");
    }
}