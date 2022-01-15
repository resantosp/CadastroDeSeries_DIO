using System;

namespace SeriesDIO
{
    class program
    {
        static FilmeRepositorio repositorio = new FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarFilmes();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                    case "3":
                        AtualizarFilme();
                        break;
                    case "4":
                        ExcluirFilme();
                        break;
                    case "5":
                        VisualizarFilme();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

            System.Console.WriteLine("Obrigado por utilizar nossos serviços.");
            System.Console.WriteLine();

        }

        private static void ListarFilmes()
        {
            System.Console.WriteLine("========== Lista de Filmes ==========");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                System.Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach (var filme in lista)
            {
                var excluido = filme.retornaEcluido();
                System.Console.WriteLine();
                if (excluido == false)
                {
                    System.Console.WriteLine("#ID:  {0}  \t-\tTÍTULO: {1}", filme.retornaId(), filme.retornaTitulo());
                }
                else
                {
                    System.Console.WriteLine("#ID:  {0}  \t-\tTÍTULO: {1}\t*EXCLUÍDO*", filme.retornaId(), filme.retornaTitulo());
                }
            }
        }

        private static void InserirFilme()
		{
			Console.WriteLine("========== Inserir novo filme ==========");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				System.Console.WriteLine();
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

            System.Console.WriteLine();
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Lançamento do Filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Sinopse do Filme: ");
			string entradaDescricao = Console.ReadLine();

			Filme novoFilme = new Filme(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novoFilme);
        }

        private static void AtualizarFilme()
        {
            System.Console.WriteLine("Digite o ID do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				System.Console.WriteLine();
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

            System.Console.WriteLine();
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Lançamento do Filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Sinopse do Filme: ");
			string entradaDescricao = Console.ReadLine();

			Filme atualizaFilme = new Filme(id: indiceFilme,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceFilme, atualizaFilme);
            
        }

        private static void ExcluirFilme()
        {
            System.Console.WriteLine("========== Excluir Filme ==========");

            System.Console.WriteLine();
            System.Console.Write("Digite o ID do Filme: ");
            int idFilme = int.Parse(Console.ReadLine());

            repositorio.Exclui(idFilme);
        }

        private static void VisualizarFilme()
        {
            System.Console.WriteLine("========== Visualizar Filme ==========");
            System.Console.WriteLine();

            System.Console.Write("Digite o ID do Filme: ");
            int idFilme = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            var filme = repositorio.RetornaPorId(idFilme);

            System.Console.WriteLine(filme);
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

    internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
}