using Domain.Utils;
using System.Text.RegularExpressions;

namespace Domain.Models
{
    public class Funcionario : BaseModel
    {
        private string cep = "";
        private string cpf = "";
        private string sexo = "";

        public string CPF
        {
            get { return cpf; }
            set
            {
                string pattern = @"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new FormatException("CPF não segue o padrão esperado");
                }

                if (!DocumentUtils.IsCPFValid(value))
                {
                    throw new FormatException("CPF não é valido");
                }

                cpf = value;
            }
        }

        public string CEP
        {
            get { return cep; }
            set
            {
                string pattern = @"\d{5}-\d{3}";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new FormatException("CEP não segue o padrão esperado");
                }

                cep = value;
            }
        }

        public string? Sexo
        {
            get { return sexo; }
            set
            {
                if (value != "M" && value != "F" && value != "O")
                {
                    throw new FormatException("Sexo não segue o padrão esperado, deve conter apenas (M, F, O)");
                }

                sexo = value;
            }
        }

        public int Matricula { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
