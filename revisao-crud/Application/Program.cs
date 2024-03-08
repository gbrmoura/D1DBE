using Application;
using Domain;
using Domain.DAL;
using Domain.Models;
using System;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var context = new ApplicationContext();
            var exit = 1;

            if (context.OpenConnection())
            {
                Console.WriteLine("the connectio is right");
                context.CloseConnection();
            }

            Console.Clear();
            Console.WriteLine("Bem vindo ao sistema de cadastro de Funcionario");

            while (exit != 0)
            {
                Console.WriteLine("Esolha as opções abaixo:");
                Console.WriteLine(" 1 - Gerenciar Funcionario \n 2 - Gerenciar Dependentes \n 3 - Gerenciar Cargos \n 0 - Sair");
                Console.Write("Opção: ");

                var read = Console.ReadLine();
                var option = Convert.ToInt32(read == "" ? 0 : read);

                switch (option)
                {
                    case 0:
                        exit = 0;
                        break;
                    case 1:
                        GerenciarFuncionario(context);
                        break;
                    case 2:
                        GerenciarDependente(context);
                        break;
                    case 3:
                        GerenciarCargo(context);
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção escolhida foi valida");
                        Console.WriteLine("Aperte enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

            Console.WriteLine("Obrigado por ter cadastrado funcionarios, volte sempre!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não foi possivel iniciar o sistema");
        }
    }

    private static void GerenciarFuncionario(ApplicationContext context)
    {
        var dal = new FuncionarioDAL(context);
        var gui = new UserInterfaceManager<Funcionario>(dal);
        var back = 1; 

        while (back != 0)
        {
            Console.Clear();
            Console.WriteLine("Esolha as opções abaixo relacionados ao gerenciamento de Funcionarios:");
            Console.WriteLine(" 1 - Inserir  \n 2 - Alterar \n 3 - Visualizar \n 4 - Visualizar Todos \n 5 - Remover \n 0 - Voltar");
            Console.Write("Opção: ");

            var read = Console.ReadLine();
            var option = Convert.ToInt32(read == "" ? 0 : read);

            switch (option)
            {
                case 0:
                    back = 0;
                    break;
                case 1:
                    gui.Insert();
                    break;
                case 2:
                    gui.Update();
                    break;
                case 3:
                    gui.Select();
                    break;
                case 4:
                    gui.SelectAll();
                    break;
                case 5:
                    gui.Delete();
                    break;
                default:
                    Console.WriteLine("Nenhuma opção escolhida foi valida");
                    Console.WriteLine("Aperte enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }

        Console.Clear();
    }

    private static void GerenciarDependente(ApplicationContext context)
    {
        var dal = new DependenteDAL(context);
        var gui = new UserInterfaceManager<Dependente>(dal);
        var back = 1;

        while (back != 0)
        {
            Console.Clear();
            Console.WriteLine("Esolha as opções abaixo relacionados ao gerenciamento de Dependentes:");
            Console.WriteLine(" 1 - Inserir  \n 2 - Alterar \n 3 - Visualizar \n 4 - Visualizar Todos \n 5 - Remover \n 0 - Voltar");
            Console.Write("Opção: ");

            var read = Console.ReadLine();
            var option = Convert.ToInt32(read == "" ? 0 : read);

            switch (option)
            {
                case 0:
                    back = 0;
                    break;
                case 1:
                    gui.Insert();
                    break;
                case 2:
                    gui.Update();
                    break;
                case 3:
                    gui.Select();
                    break;
                case 4:
                    gui.SelectAll();
                    break;
                case 5:
                    gui.Delete();
                    break;
                default:
                    Console.WriteLine("Nenhuma opção escolhida foi valida");
                    Console.WriteLine("Aperte enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }

        Console.Clear();
    }

    private static void GerenciarCargo(ApplicationContext context)
    {
        var dal = new CargoDAL(context);
        var gui = new UserInterfaceManager<Cargo>(dal);
        var back = 1;

        while (back != 0)
        {
            Console.Clear();
            Console.WriteLine("Esolha as opções abaixo relacionados ao gerenciamento de Cargos:");
            Console.WriteLine(" 1 - Inserir  \n 2 - Alterar \n 3 - Visualizar \n 4 - Visualizar Todos \n 5 - Remover \n 0 - Voltar");
            Console.Write("Opção: ");

            var read = Console.ReadLine();
            var option = Convert.ToInt32(read == "" ? 0 : read);

            switch (option)
            {
                case 0:
                    back = 0;
                    break;
                case 1:
                    gui.Insert();
                    break;
                case 2:
                    gui.Update();
                    break;
                case 3:
                    gui.Select();
                    break;
                case 4:
                    gui.SelectAll();
                    break;
                case 5:
                    gui.Delete();
                    break;
                default:
                    Console.WriteLine("Nenhuma opção escolhida foi valida");
                    Console.WriteLine("Aperte enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }

        Console.Clear();
    }
}