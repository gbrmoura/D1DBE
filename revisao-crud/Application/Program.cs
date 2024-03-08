using Domain;

var context = new ApplicationContext();

if (context.OpenConnection())
{
    Console.WriteLine("certo");
    context.CloseConnection();
}
