using ConsoleTables;
using Domain.DAL;
using Domain.Models;
using System.Reflection;

namespace Application
{
    public class UserInterfaceManager<T> where T : BaseModel, new()
    {
        private BaseDAL<T> _dal;
        private PropertyInfo[] _properties;
        private Type _type;

        public UserInterfaceManager(BaseDAL<T> dal)
        {
            _dal = dal;
            _type = typeof(T);
            _properties = _type.GetProperties();
        }

        public void Insert()
        {
            var payload = new T();

            Console.Clear();
            Console.WriteLine($"Insira os valores abaixo para cadastrar um {_type.Name}");

            foreach (var property in _properties)
            {
                var exit = 1;
                while (exit != 0)
                {
                    try
                    {
                        if (property.Name != "Id" && property.Name != "IsDeleted")
                        {
                            Console.Write($"{property.Name}: ");
                            var value = Console.ReadLine();
                            payload.SetPropertyValue(payload, property.Name, value);
                        }

                        exit = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.InnerException.Message}");
                        Console.WriteLine("Tente novamente");
                    }
                }
            }

            _dal.Insert(payload);

            Console.WriteLine($"O {_type.Name} foi incluido com sucesso");
            Console.WriteLine("\nAperte enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        public void Update()
        {
            Console.Clear();
            Console.Write($"Insira o identificador do {_type.Name} para alterar: ");

            var id = Convert.ToInt32(Console.ReadLine());
            var selectValue = _dal.Select(id);

            if (selectValue == null)
            {
                Console.WriteLine($"{_type.Name} com identificador {id} não foi encontrado");
                Console.WriteLine("\nAperte enter para continuar");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            Console.WriteLine($"Insira os valores abaixo para cadastrar um {_type.Name}");
            Console.WriteLine("Para manter os valores antigos, nao insira dados");

            foreach (var property in _properties)
            {
                var exit = 1;
                while (exit != 0)
                {
                    try
                    {
                        if (property.Name != "Id" && property.Name != "IsDeleted")
                        {
                            Console.Write($"{property.Name} (Antigo Valor: {property.GetValue(selectValue)}) : ");
                            var value = Console.ReadLine();

                            if (value != "")
                            {
                                selectValue.SetPropertyValue(selectValue, property.Name, value);
                            }
                        }

                        exit = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.InnerException.Message}");
                        Console.WriteLine("Tente novamente");
                    }
                }
            }

            _dal.Update(id, selectValue);

            Console.WriteLine($"{_type.Name} alterado com sucesso!");
            Console.WriteLine("\nAperte enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        public void Delete()
        {
            Console.Clear();
            Console.Write($"Insira o identificador do {_type.Name} para removelo: ");

            var id = Convert.ToInt32(Console.ReadLine());
            var value = _dal.Select(id);

            if (value == null)
            {
                Console.WriteLine($"{_type.Name} com identificador {id} não foi encontrado");
                Console.WriteLine("\nAperte enter para continuar");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            Console.Write($"Deseja realmente remover o {_type.Name} (Y/N): ");
            var option = Console.ReadLine();

            if (option == "Y")
            {
                _dal.Delete(id);
                Console.WriteLine($"{_type.Name} removido com sucesso!");
            }

            Console.WriteLine("\nAperte enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        public void Select()
        {
            Console.Clear();
            Console.Write("Insira o indentificador do funcionario (ID):");
            var id = Convert.ToInt32(Console.ReadLine());
            var value = _dal.Select(id);
            
            if (value == null)
            {
                Console.WriteLine($"{_type.Name} com identificador {id} não foi encontrado");
                Console.WriteLine("\nAperte enter para continuar");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            var columns = _properties.Select(p => p.Name).ToArray();
            var table = new ConsoleTable(columns);

            var row = new List<object>();
            foreach (var property in _properties)
            {
                row.Add(property.GetValue(value));
            }

            table.AddRow(row.ToArray());

            Console.WriteLine("");
            table.Write();

            Console.WriteLine("\nAperte enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        public void SelectAll()
        {
            Console.Clear();

            var values = _dal.Select();
            var columns = _properties.Select(p => p.Name).ToArray();
            var table = new ConsoleTable(columns);

            foreach (var value in values)
            {
                var row = new List<object>();
                foreach (var property in _properties)
                {
                    row.Add(property.GetValue(value));
                }

                table.AddRow(row.ToArray());
            }

            table.Write();

            Console.WriteLine("\nAperte enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
