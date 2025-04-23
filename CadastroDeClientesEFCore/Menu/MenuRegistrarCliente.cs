using CadastroDeClientesEFCore.Modelos;
using CadastroDeClientesEFCore.Banco;

namespace CadastroDeClientesEFCore.Menus
{
    internal class MenuRegistrarCliente : Menu
    {
        public override void Executar(DAL<Cliente> clienteDal)
        {
            base.Executar(clienteDal);
            ExibirTituloDaOpcao("Registrar Cliente");

            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine()!;
            Console.Write("Digite o email do cliente: ");
            string email = Console.ReadLine()!;
            Console.Write("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine()!;

            Cliente cliente = new Cliente(nome, email, telefone);
            clienteDal.Adicionar(cliente);

            Console.WriteLine("\nCliente registrado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}
