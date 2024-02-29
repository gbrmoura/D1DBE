using System.Text.RegularExpressions;

namespace Clientes
{
    public class Cliente
    {
        private string nome = "";
        private string endereco = "";
        private string cep = "";
        private string cpf = "";
        
        public string CPF
        {
            get { return cpf; }
            set 
            {
                string pattern = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$";
                if (!Regex.IsMatch(value, pattern)) 
                {
                    throw new Exception("CPF não segue o padrão esperado");
                }

                if (!Utils.IsCPFValid(value))
                {
                    throw new Exception("CPF não é valido");
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
                    throw new Exception("CEP não segue o padrão esperado");
                }

                cep = value; 
            }
        }
        
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}

