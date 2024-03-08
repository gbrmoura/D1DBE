namespace Domain.Models
{
    public class Cargo: BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int IdFuncionario { get; set; }

    }
}
