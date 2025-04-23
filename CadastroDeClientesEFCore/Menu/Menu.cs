using CadastroDeClientesEFCore.Modelos;
using CadastroDeClientesEFCore.Banco;

namespace CadastroDeClientesEFCore.Menus
{
    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            string asteriscos = new string('*', titulo.Length);
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        public virtual void Executar(DAL<Cliente> clienteDal)
        {
        }
    }
}
