using _4_Operacoes;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine($"O calculo da soma de X: 4 e Y: 5 é: {calc.Soma(4, 5)}");
        Console.WriteLine($"O calculo da subtração de X: 10 e Y: 3 é: {calc.Subtracao(10, 3)}");
        Console.WriteLine($"O calculo da multiplicação de X: 10 e Y: 10 é: {calc.Multiplicacao(10, 10)}");
        Console.WriteLine($"O calculo da divisão de X: 50 e Y: 3 é: {calc.Divide(50, 3)}");
        Console.WriteLine($"O calculo da raiz de X: 64 é: {calc.RaizQuadrada(64)}");
        Console.WriteLine($"O calculo da fatorial de X: 5 é: {calc.Fatorial(5)}");
    }
}