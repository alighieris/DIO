using System;

namespace Series
{
    class Program
    {
		static SerieRepositorio repositorio = new SerieRepositorio();
      
		static void Main(string[] args)
        {	
			Console.Clear();
			string opcaoUsuario = ObterOpcaoUsuario(); 
			while (opcaoUsuario.ToUpper() !="X")
			{
				switch(opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
				opcaoUsuario = ObterOpcaoUsuario();
			}
			Console.WriteLine(Environment.NewLine + "Obrigado por usar o DIO Séries!");
        }

		// Métodos do Menu

		private static void ListarSeries()
		{
			Console.Clear();
			Console.WriteLine("Listar séries" + Environment.NewLine);

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				PressAndClear();
				return;
			}

			foreach (var serie in lista)
			{
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), serie.retornaExcluido() ? "- *Excluido*" : "");
			}
			PressAndClear();
		}

		private static void InserirSerie()
		{
			Console.Clear();
			Console.WriteLine("Adcionar nova série" + Environment.NewLine);
			
			repositorio.Insere(InputSerie(repositorio.ProximoId()));
			Console.WriteLine("Série adcionada!");
			PressAndClear();
		}

		private static void AtualizarSerie()
		{
			Console.Clear();
			Console.WriteLine("Atualizar série" + Environment.NewLine);
			Console.WriteLine("Digite o ID da série que deseja atualizar");
			int indiceSerie = int.Parse(Console.ReadLine());
			repositorio.Atualiza(indiceSerie, InputSerie(indiceSerie));
			PressAndClear();
		}
		
		private static void ExcluirSerie()
		{
			Console.Clear();
			Console.WriteLine("Excluir série" + Environment.NewLine);
			Console.WriteLine("Digite o ID da série que deseja excluir");
			int indiceSerie = int.Parse(Console.ReadLine());
			Console.WriteLine("Tem certeza que deseja excluir a série:");
			Console.WriteLine(repositorio.RetornaPorId(indiceSerie));
			Console.WriteLine("S para confirmar, qualquer outra tecla para cancelar...");
			string confirmacao = Console.ReadLine().ToUpper();
			if (confirmacao == "S")
			{
				repositorio.Exclui(indiceSerie);
				Console.Write("Série excluída!");
			}
			else
			{
				Console.Write("Cancelado!");
			}
			
			PressAndClear();
		}

		private static void VisualizarSerie()
		{
			Console.Clear();
			Console.WriteLine("Vizualizar série");
			while (true)
			{
				Console.WriteLine(Environment.NewLine + "Digite o ID da série que deseja vizualizar");
				int indiceSerie = int.Parse(Console.ReadLine());
				Console.WriteLine(repositorio.RetornaPorId(indiceSerie));
				Console.WriteLine("\nPressione X para voltar ao menu, qualquer outra tecla para visualizar outra série...");
				if (Console.ReadLine().ToUpper()=="X")
				{
					Console.Clear();
					break;
				}

			}

		}

		// Métodos de utilidade

		private static Serie InputSerie(int id)
		{
			Console.WriteLine("Digite o Título da série:");
			string entradaTitulo = Console.ReadLine();
			Console.WriteLine("\nEscolha o Gênero da série:");
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
			}
			int entradaGenero = int.Parse(Console.ReadLine());
			

			Console.WriteLine("\nDigite o Ano de Início da série:");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.WriteLine("\nDigite a Descrição da série:");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: id,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);
			return novaSerie;
		}

		private static void PressAndClear()
		{
			Console.WriteLine(Environment.NewLine + "Pressione qualquer tecla para continuar...");
			Console.ReadKey();
			Console.Clear();
		}

		private static string ObterOpcaoUsuario()
		{	
			Console.WriteLine("********************************");
			Console.WriteLine("           DIO Séries           ");
			Console.WriteLine("********************************");
			Console.WriteLine("Informe a opção desejada:");
			Console.WriteLine("1 - Listar séries");
			Console.WriteLine("2 - Adcionar nova série");
			Console.WriteLine("3 - Atualizar série");
			Console.WriteLine("4 - Excluir série");
			Console.WriteLine("5 - Visualizar série");
			Console.WriteLine("X - Sair");
			Console.Write(Environment.NewLine + "-> ");

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

    }
}
