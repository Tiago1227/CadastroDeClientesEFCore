using CadastroDeClientesEFCore.Modelos;
using CadastroDeClientesEFCore.Banco;

namespace CadastroDeClientesEFCore.Menus
{
    internal class MenuMostrarClientes : Menu
    {
        public override void Executar(DAL<Cliente> clienteDal)
        {
            base.Executar(clienteDal);
            ExibirTituloDaOpcao("Exibir Todos os Clientes");

            var clientes = clienteDal.Listar();
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}
