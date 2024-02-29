using Clientes;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            bool continua = true;
            List<Cliente> clientes = new List<Cliente>();
            while (continua)
            {
                Cliente cliente = new Cliente();
                Console.WriteLine("Informe os dados abaixo para cadastro de Cliente:");

                Console.Write("Nome: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("CPF: ");
                cliente.CPF = Console.ReadLine();

                Console.Write("Endereço: ");
                cliente.Endereco = Console.ReadLine();

                Console.Write("CEP: ");
                cliente.CEP = Console.ReadLine();

                Console.WriteLine("O cliente informado foi:");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.CPF}");
                Console.WriteLine($"Endereço: {cliente.Endereco}");
                Console.WriteLine($"CEP: {cliente.CEP}");

                Console.WriteLine("Deseja continuar cadastrando clientes?");
                Console.Write("Y /")
            }
            
        } 
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}