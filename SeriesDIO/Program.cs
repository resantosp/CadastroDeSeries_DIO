using System;

namespace SeriesDIO
{
    class program
    {
        static FilmeRepositorio repositorio = new FilmeRepositorio();
        static void Main(string[] args)
        {

        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("========== SCIFLIX MENU ==========\n");

            System.Console.WriteLine("1 - Listar Filmes");
            System.Console.WriteLine("2 - Inserir Novo Filme");
            System.Console.WriteLine("3 - Atualizar Filme");
            System.Console.WriteLine("4 - Excluir Filme");
            System.Console.WriteLine("5 - Visualizar Filme");
            System.Console.WriteLine("C - Limpar Tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            System.Console.WriteLine("Informe a opção desejada: ");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
    }
}