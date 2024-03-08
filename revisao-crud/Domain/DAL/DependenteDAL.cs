using Domain.Models;
using MySql.Data.MySqlClient;

namespace Domain.DAL
{
    public class DependenteDAL
    {
        private ApplicationContext _context;

        public DependenteDAL(ApplicationContext context)
        {
            _context = context;
        }

        public void Insert(Dependente value)
        {   
            string query = "INSERT INTO Dependente";
            query += "(Nome, CPF, Sexo, CEP, Endereco, Telefone, DataNascimento, IdFuncionario, IsDeleted)";
            query += "VALUES";
            query += "(@Nome, @CPF, @Sexo, @CEP, @Endereco, @Telefone, @DataNascimento, IdFuncionario, @IsDeleted)";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();

                cmd.Parameters.AddWithValue("@Nome", value.Nome);
                cmd.Parameters.AddWithValue("@CPF", value.CPF);
                cmd.Parameters.AddWithValue("@Sexo", value.Sexo);
                cmd.Parameters.AddWithValue("@CEP", value.CEP);
                cmd.Parameters.AddWithValue("@Endereco", value.Endereco);
                cmd.Parameters.AddWithValue("@Telefone", value.Telefone);
                cmd.Parameters.AddWithValue("@DataNascimento", value.DataNascimento);
                cmd.Parameters.AddWithValue("@IdFuncionario", value.IdFuncionario);
                cmd.Parameters.AddWithValue("@IsDeleted", false);

                cmd.ExecuteNonQuery();

                _context.CloseConnection();
            }
        }

        public Dependente Select(int id)
        {
            Dependente? dependente = null;
            string query = $"SELECT * FROM Dependente WHERE id=@Id";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();


                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                dependente = new Dependente
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    CPF = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Sexo = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    CEP = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    Endereco = reader.IsDBNull(5) ? "" : reader.GetString(5),
                    Telefone = reader.IsDBNull(6) ? "" : reader.GetString(6),
                    DataNascimento = reader.IsDBNull(7) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(7),
                    IsDeleted = reader.GetBoolean(8),
                    IdFuncionario = reader.IsDBNull(9) ? 0 : reader.GetInt32(9),
                };

                _context.CloseConnection();
            }

            return dependente;
        }

        public List<Dependente> Select()
        {
            List<Dependente> dependentes = new List<Dependente>();
            string query = $"SELECT * FROM Dependente WHERE IsDeleted=FALSE LIMIT 50";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();
                cmd.ExecuteNonQuery();


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dependentes.Add(new Dependente
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        CPF = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Sexo = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        CEP = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        Endereco = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        Telefone = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        DataNascimento = reader.IsDBNull(7) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(7),
                        IsDeleted = reader.GetBoolean(8),
                        IdFuncionario = reader.IsDBNull(9) ? 0 : reader.GetInt32(9),
                    });
                }

                _context.CloseConnection();
            }

            return dependentes;
        }

        public void Update(int id, Dependente value)
        {
            string query = "UPDATE Dependente SET";
            query += $"Nome=@Nome, CPF=@CPF, Sexo=@Sexo, CEP=@CEP, Endereco=@Endereco, ";
            query += $"Telefone=@Telefone, DataNascimento=@DataNascimento, IdFuncionario=@IdFuncionario";
            query += $"WHERE id=@Id";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nome", value.Nome);
                cmd.Parameters.AddWithValue("@CPF", value.CPF);
                cmd.Parameters.AddWithValue("@Sexo", value.Sexo);
                cmd.Parameters.AddWithValue("@CEP", value.CEP);
                cmd.Parameters.AddWithValue("@Endereco", value.Endereco);
                cmd.Parameters.AddWithValue("@Telefone", value.Telefone);
                cmd.Parameters.AddWithValue("@DataNascimento", value.DataNascimento);
                cmd.Parameters.AddWithValue("@IdFuncionario", value.IdFuncionario);

                cmd.ExecuteNonQuery();
                _context.CloseConnection();
            }
        }
        public void Delete(int id)
        {
            string query = $"UPDATE Dependente SET IsDeleted=@IsDeleted WHERE id=@Id";

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
