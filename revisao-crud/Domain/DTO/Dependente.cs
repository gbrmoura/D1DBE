namespace Domain.Models
{
    public class Dependente : BaseModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdFuncionario { get; set; }
    }
}
