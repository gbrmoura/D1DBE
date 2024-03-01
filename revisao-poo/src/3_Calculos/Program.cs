using Calculos;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine("A area do circulo utilizando o(s) valore(s) 1.5 é:");
        Console.WriteLine($"Area do circulo: {calc.Calcular(1.5)}");

        Console.WriteLine("A area do quadrado utilizando o(s) valore(s) 2 e 2 é:");
        Console.WriteLine($"Area do circulo: {calc.Calcular(2, 2)}");

        Console.WriteLine("O perímetro de um triangulo utilizando o(s) valore(s) 6, 5, 7 é:");
        Console.WriteLine($"Area do circulo: {calc.Calcular(6, 5, 7)}");
    
        Console.WriteLine("A area do triangulo utilizando o(s) valore(s) 4 e 2.5 é:");
        Console.WriteLine($"Area do circulo: {calc.Calcular(4, 2.5)}");

        Console.WriteLine("A area do triangulo utilizando o(s) valore(s) (-4, 2), (2, 3), (-2, -2) é:");
        Console.WriteLine($"Area do circulo: {calc.Calcular((-4, 2), (2, 3), (-2, -2))}");

        Console.WriteLine("O Calculo utilizando o(s) valore(s) '5':");
        Console.WriteLine($"Area do circulo: {calc.Calcular("5")}");
    }
}