using Domain.Models;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Domain.DAL
{
    public class FuncionarioDAL
    {
        private ApplicationContext _context;

        public FuncionarioDAL(ApplicationContext context ) 
        {
            _context = context;
        }

        public void Insert(Funcionario value) 
        {
            string query = "INSERT INTO Funcionario";
            query += "(Matricula, Salario, DataAdmissao, Nome, CPF, Sexo, CEP, Endereco, Telefone, DataNascimento, IsDeleted)";
            query += "VALUES";
            query += "(@Matricula, @Salario, @DataAdmissao, @Nome, @CPF, @Sexo, @CEP, @Endereco, @Telefone, @DataNascimento, @IsDeleted)";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();

                cmd.Parameters.AddWithValue("@Matricula", value.Matricula);
                cmd.Parameters.AddWithValue("@Salario", value.Salario);
                cmd.Parameters.AddWithValue("@DataAdmissao", value.DataAdmissao);
                cmd.Parameters.AddWithValue("@Nome", value.Nome);
                cmd.Parameters.AddWithValue("@CPF", value.CPF);
                cmd.Parameters.AddWithValue("@Sexo", value.Sexo);
                cmd.Parameters.AddWithValue("@CEP", value.CEP);
                cmd.Parameters.AddWithValue("@Endereco", value.Endereco);
                cmd.Parameters.AddWithValue("@Telefone", value.Telefone);
                cmd.Parameters.AddWithValue("@DataNascimento", value.DataNascimento);
                cmd.Parameters.AddWithValue("@IsDeleted", false);

                cmd.ExecuteNonQuery();

                _context.CloseConnection();
            }
        }

        public Funcionario Select(int id) 
        {
            Funcionario? funcionario = null;
            string query = $"SELECT * FROM Funcionario WHERE id=@Id";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();


                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                funcionario = new Funcionario
                {
                    Id = reader.GetInt32(0),
                    Matricula = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    Salario = reader.IsDBNull(2) ? 0 : reader.GetFloat(2),
                    DataAdmissao = reader.IsDBNull(3) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(3),
                    Nome = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    CPF = reader.IsDBNull(5) ? "" : reader.GetString(5),
                    Sexo = reader.IsDBNull(6) ? "" : reader.GetString(6),
                    CEP = reader.IsDBNull(7) ? "" : reader.GetString(7),
                    Endereco = reader.IsDBNull(8) ? "" : reader.GetString(8),
                    Telefone = reader.IsDBNull(9) ? "" : reader.GetString(9),
                    DataNascimento = reader.IsDBNull(10) ? DateTime.Parse("01/01/0001") :  reader.GetDateTime(10),
                    IsDeleted = reader.GetBoolean(11),
                };

                _context.CloseConnection();
            }

            return funcionario;
        }

        public List<Funcionario> Select()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            string query = $"SELECT * FROM Funcionario WHERE IsDeleted=FALSE LIMIT 50";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();
                cmd.ExecuteNonQuery();


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    funcionarios.Add(new Funcionario
                    {
                        Id = reader.GetInt32(0),
                        Matricula = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        Salario = reader.IsDBNull(2) ? 0 : reader.GetFloat(2),
                        DataAdmissao = reader.IsDBNull(3) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(3),
                        Nome = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        CPF = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        Sexo = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        CEP = reader.IsDBNull(7) ? "" : reader.GetString(7),
                        Endereco = reader.IsDBNull(8) ? "" : reader.GetString(8),
                        Telefone = reader.IsDBNull(9) ? "" : reader.GetString(9),
                        DataNascimento = reader.IsDBNull(10) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(10),
                        IsDeleted = reader.GetBoolean(11),
                    });
                }

                _context.CloseConnection();
            }

            return funcionarios;
        }

        public void Update(int id, Funcionario value) 
        {
            string query = "UPDATE Funcionario SET";
            query += $"Matricula=@Matricula, Salario=@Salario, DataAdmissao=@DataAdmissao, ";
            query += $"Nome=@Nome, CPF=@CPF, Sexo=@Sexo, CEP=@CEP, Endereco=@Endereco, ";
            query += $"Telefone=@Telefone, DataNascimento=@DataNascimento";
            query += $"WHERE id=@Id";
            
            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Matricula", value.Matricula);
                cmd.Parameters.AddWithValue("@Salario", value.Salario);
                cmd.Parameters.AddWithValue("@DataAdmissao", value.DataAdmissao);
                cmd.Parameters.AddWithValue("@Nome", value.Nome);
                cmd.Parameters.AddWithValue("@CPF", value.CPF);
                cmd.Parameters.AddWithValue("@Sexo", value.Sexo);
                cmd.Parameters.AddWithValue("@CEP", value.CEP);
                cmd.Parameters.AddWithValue("@Endereco", value.Endereco);
                cmd.Parameters.AddWithValue("@Telefone", value.Telefone);
                cmd.Parameters.AddWithValue("@DataNascimento", value.DataNascimento);

                cmd.ExecuteNonQuery();
                _context.CloseConnection();
            }
        }
        public void Delete(int id)
        {
            string query = $"UPDATE Funcionario SET IsDeleted=@IsDeleted WHERE id=@Id";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@IsDeleted", true);

                cmd.ExecuteNonQuery();

                _context.CloseConnection();
            }
        }
    }
}
