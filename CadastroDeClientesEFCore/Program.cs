using CadastroDeClientesEFCore.Menus;
using CadastroDeClientesEFCore.Modelos;
using CadastroDeClientesEFCore.Banco;

class Program
{
    static void Main()
    {
        var context = new CadastroContext();
        var clienteDAL = new DAL<Cliente>(context);

        Dictionary<int, Menu> opcoes = new()
        {
            { 1, new MenuRegistrarCliente() },
            { 2, new MenuMostrarClientes() }
        };

        ExibirOpcoesDoMenu(opcoes, clienteDAL);
    }

    static void ExibirLogo()
    {
        Console.WriteLine("Boas vindas ao Sistema de Cadastro de Clientes!");
    }

    static void ExibirOpcoesDoMenu(Dictionary<int, Menu> opcoes, DAL<Cliente> clienteDAL)
    {
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar um cliente");
        Console.WriteLine("Digite 2 para mostrar todos os clientes");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);

        if (opcoes.ContainsKey(opcaoEscolhida))
        {
            opcoes[opcaoEscolhida].Executar(clienteDAL);
            Console.Clear();
            ExibirOpcoesDoMenu(opcoes, clienteDAL);
        }
        else
        {
            if (opcaoEscolhida == -1)
            {
                Console.WriteLine("Saindo so sistema....");
                return;
            }
            Console.WriteLine("Opção inválida");
            ExibirOpcoesDoMenu(opcoes, clienteDAL);
        }
    }
}
