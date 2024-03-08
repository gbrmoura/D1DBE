namespace Domain.Models
{
    public class Funcionario : BaseModel
    {
        public int Matricula { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Sexo { get; set; }
        public string? CEP { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
