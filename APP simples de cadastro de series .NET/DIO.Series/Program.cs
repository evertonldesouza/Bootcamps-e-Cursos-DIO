using DIO.Series.Model;
using DIO.Series.Model.Enum;
using DIO.Series.Model.Repositorio;
using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
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
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar os nossos serviços");
            Console.ReadLine();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("--- Listar séries ---");

            var lista = repositorio.Listar();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série foi cadrastada.");
                return; //para sair sem retornar nada
            }

            foreach (var serie in lista)
            {
                var excluido = serie.GetExcluido();
                string mensagem = (excluido ? "*Excluido*" : "");
                Console.WriteLine($"#ID {serie.GetId()} - {serie.GetTitulo()} {mensagem}");
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("--- Inserir nova série ---");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }

            Console.Write("Digite o Genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do Inicio da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            //cria um novo objeto da classe serie
            Serie novaSerie = new Serie(Id: repositorio.ProximoId(),
                                        Genero: (Genero)entradaGenero,
                                        Titulo: entradaTitulo,
                                        Descricao: entradaDescricao,
                                        Ano: entradaAno);

            //adiciona a lista de serie
            repositorio.inserir(novaSerie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("--- Atualizar séries ---");

            Console.Write("Digite o Id da Série: ");
            int entradaId = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }

            Console.Write("Digite o Genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do Inicio da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            //cria um novo objeto da classe serie
            Serie novaSerie = new Serie(Id: entradaId,
                                        Genero: (Genero)entradaGenero,
                                        Titulo: entradaTitulo,
                                        Descricao: entradaDescricao,
                                        Ano: entradaAno);

            //atualiza os antigos para o novo inserido
            repositorio.Atualizar(entradaId, novaSerie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("--- Excluir série ---");

            Console.Write("Digite o Id da Série: ");
            int entradaId = int.Parse(Console.ReadLine());

            //elimina da lista
            repositorio.Excluir(entradaId);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("--- Visualizar série ---");

            Console.Write("Digite o Id da Série: ");
            int entradaId = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(entradaId);
            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
