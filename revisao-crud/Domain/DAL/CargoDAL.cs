using Domain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL
{
    public class CargoDAL : BaseDAL<Cargo>
    {
        private ApplicationContext _context;

        public CargoDAL(ApplicationContext context)
        {
            _context = context;
        }

        public override void Insert(Cargo value)
        {
            string query = "INSERT INTO Cargo";
            query += "(Nome, Descricao, DataInicio, DataFim, IdFuncionario, IsDeleted)";
            query += "VALUES";
            query += "(@Nome, @Descricao, @DataInicio, @DataFim, @IdFuncionario, @IsDeleted)";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();

                cmd.Parameters.AddWithValue("@Nome", value.Nome);
                cmd.Parameters.AddWithValue("@Descricao", value.Descricao);
                cmd.Parameters.AddWithValue("@DataInicio", value.DataInicio);
                cmd.Parameters.AddWithValue("@DataFim", value.DataFim);
                cmd.Parameters.AddWithValue("@IdFuncionario", value.IdFuncionario);
                cmd.Parameters.AddWithValue("@IsDeleted", false);

                cmd.ExecuteNonQuery();

                _context.CloseConnection();
            }
        }

        public override Cargo Select(int id)
        {
            Cargo? cargo = null;
            string query = $"SELECT * FROM Cargo WHERE id=@Id";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    _context.CloseConnection();
                    return null;
                }

                cargo = new Cargo
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    Descricao = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    DataInicio = reader.IsDBNull(3) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(3),
                    DataFim = reader.IsDBNull(4) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(4),
                    IsDeleted = reader.GetBoolean(5),
                    IdFuncionario = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                };

                _context.CloseConnection();
            }

            return cargo;
        }

        public override List<Cargo> Select()
        {
            List<Cargo> cargos = new List<Cargo>();
            string query = $"SELECT * FROM Cargo WHERE IsDeleted=FALSE LIMIT 50";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();
                cmd.ExecuteNonQuery();


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cargos.Add(new Cargo {
                        Id = reader.GetInt32(0),
                        Nome = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        Descricao = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        DataInicio = reader.IsDBNull(3) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(3),
                        DataFim = reader.IsDBNull(4) ? DateTime.Parse("01/01/0001") : reader.GetDateTime(4),
                        IsDeleted = reader.GetBoolean(5),
                        IdFuncionario = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                    });
                }

                _context.CloseConnection();
            }

            return cargos;
        }

        public override void Update(int id, Cargo value)
        {
            string query = "UPDATE Cargo SET ";
            query += $"Nome=@Nome, Descricao=@Descricao, DataInicio=@DataInicio, DataFim=@DataFiim, ";
            query += $"IdFuncionario=@IdFuncionario ";
            query += $"WHERE id=@Id";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();

                cmd.Parameters.AddWithValue("@Nome", value.Nome);
                cmd.Parameters.AddWithValue("@Descricao", value.Descricao);
                cmd.Parameters.AddWithValue("@DataInicio", value.DataInicio);
                cmd.Parameters.AddWithValue("@DataFim", value.DataFim);
                cmd.Parameters.AddWithValue("@IdFuncionario", value.IdFuncionario);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
                _context.CloseConnection();
            }
        }
        public override void Delete(int id)
        {
            string query = $"UPDATE Cargo SET IsDeleted=@IsDeleted WHERE id=@Id";

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
