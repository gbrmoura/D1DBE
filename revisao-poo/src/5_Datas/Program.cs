using _5_Datas;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Informe os dados abaixo para validação de datas:");

            Console.Write("Primeira Data: ");
            string beginDate = Console.ReadLine();

            Console.Write("Segunda Data: ");
            string endDate = Console.ReadLine();

            DateUtils dateUtils = new DateUtils();
            Console.WriteLine($"A diferença de dias entre {beginDate} e {endDate} é de {dateUtils.DiasDiferenca(beginDate, endDate)} dias");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

    }
}