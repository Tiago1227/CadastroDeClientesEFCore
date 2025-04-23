namespace CadastroDeClientesEFCore.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        public Cliente() { }

        public Cliente(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Nome: {Nome} - Email: {Email} - Telefone: {Telefone}";
        }
    }
}
