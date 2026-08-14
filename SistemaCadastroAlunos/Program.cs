class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine(" === Menu de opções ===");
            Console.WriteLine();
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar alunos");
            Console.WriteLine("2 - Buscar aluno");
            Console.WriteLine("3 - Exibir aprovados");
            Console.WriteLine("4 - Exibir média");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
                opcao = -1;
                continue;
            }

            switch (opcao)
            {
                case 1:
                    ListarAlunos();
                    break;

                case 2:
                    BuscarAluno();
                    break;

                case 3:
                    ExibirAprovados();
                    break;

                case 4:
                    ExibirMedia();
                    break;

                case 0:
                    Console.WriteLine("Programa Encerrado");
                    break;

                default:
                    Console.WriteLine("Você selecionou uma opção inválida");
                    break;
            }

        } while (opcao != 0);
    }

    // Funções

    static void ListarAlunos()
    {
        Console.WriteLine("Listando alunos...");
    }

    static void BuscarAluno()
    {
        Console.WriteLine("Buscando aluno...");
    }

    static void ExibirAprovados()
    {
        Console.WriteLine("Exibindo alunos aprovados...");
    }

    static void ExibirMedia()
    {
        Console.WriteLine("Exibindo média...");
    }
}