using Domain;
using System;

public class Program
{
    private static void Main(string[] args)
    {
        var context = new ApplicationContext();
        var exit = 1;

        if (context.OpenConnection())
        {
            Console.WriteLine("certo");
            context.CloseConnection();
        }

        Console.WriteLine("Bem vindo ao sistema de cadastro de Funcionario");

        while (exit != 0)
        {
            Console.WriteLine("Esolha as opções abaixo:");
            Console.WriteLine(" 1 - Gerenciar Funcionario \n 2 - Gerenciar Dependentes \n 3 - Gerenciar \n 0 - Sair");
            Console.Write("Opção: ");

            var read = Console.ReadLine();
            var option = Convert.ToInt32(read);

            if (option == 1)
            {
                GerenciarFuncionario(context);
            }
            else if (option == 2)
            {
                GerenciarDependente(context);
            }
            else if (option == 3)
            {
                GerenciarCargo(context);
            }
            else if (option == 0)
            {
                exit = 0;
            }
            else
            {
                Console.WriteLine("Nenhuma opção escolhida foi valida");
                Console.WriteLine("Aperte enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }

        Console.WriteLine("Obrigado por ter cadastrado funcionarios, volte sempre!");
    }

    private static void GerenciarFuncionario(ApplicationContext context)
    {

    }

    private static void GerenciarDependente(ApplicationContext context)
    {

    }

    private static void GerenciarCargo(ApplicationContext context)
    {

    }
}