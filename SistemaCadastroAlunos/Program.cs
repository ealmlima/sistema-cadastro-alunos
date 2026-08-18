using System.Text.RegularExpressions;

class Program
{
    static string[] nomeAluno = new string[10];
    static int[] idadeAluno = new int[10];
    static double[] nota1 = new double[10];
    static double[] nota2 = new double[10];
    static int contador = 0;

    static void Main()
    {
        CadastroInicial();

        int opcao;

        do
        {
            Console.WriteLine(" === Menu de opções ===");

            Console.WriteLine();
            Console.WriteLine("1 - Listar alunos");
            Console.WriteLine("2 - Buscar aluno");
            Console.WriteLine("3 - Exibir aprovados");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine();

            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Entrada inválida. Digite apenas números.");
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
                case 0:
                    Console.WriteLine("Programa Encerrado");
                    break;
                default:
                    Console.WriteLine("Você selecionou uma opção inválida");
                    break;
            }

        } while (opcao != 0);

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("=== Menu ===");
        Console.ResetColor();
    }

    static void CadastroInicial()
    {
        string cadastrarNovoAluno;

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("===Cadastro de alunos===");
        Console.WriteLine();
        Console.ResetColor();

        do
        {
            string _nomeAluno;

            Console.WriteLine("Aluno {0}", contador + 1);
            Console.WriteLine("--------------------");

            do
            {
                Console.Write("Nome: ");
                _nomeAluno = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(_nomeAluno) || !Regex.IsMatch(_nomeAluno, @"^[a-zA-Z\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome inválido! Por favor, utilize apenas letras e espaços.");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            } while (string.IsNullOrWhiteSpace(_nomeAluno) || !Regex.IsMatch(_nomeAluno, @"^[a-zA-Z\s]+$"));

            nomeAluno[contador] = _nomeAluno;

            int _idadeAluno;
            bool isValidIdade = false;

            do
            {
                Console.Write("Idade: ");
                isValidIdade = int.TryParse(Console.ReadLine(), out _idadeAluno);

                if (!isValidIdade || _idadeAluno <= 0 || _idadeAluno > 120)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Idade inválida! Por favor, digite um valor entre 1 e 120.");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            } while (!isValidIdade || _idadeAluno <= 0 || _idadeAluno > 120);

            idadeAluno[contador] = _idadeAluno;

            double _nota1;
            bool isValidNota1 = false;

            do
            {
                Console.Write("Nota 1: ");
                isValidNota1 = double.TryParse(Console.ReadLine(), out _nota1);

                if (!isValidNota1 || _nota1 < 0 || _nota1 > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nota inválida! Por favor, digite um valor entre 0 e 10.");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            } while (!isValidNota1 || _nota1 < 0 || _nota1 > 10);

            nota1[contador] = _nota1;

            double _nota2;
            bool isValidNota2 = false;

            do
            {
                Console.Write("Nota 2: ");
                isValidNota2 = double.TryParse(Console.ReadLine(), out _nota2);

                if (!isValidNota2 || _nota2 < 0 || _nota2 > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nota inválida! Por favor, digite um valor entre 0 e 10.");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            } while (!isValidNota2 || _nota2 < 0 || _nota2 > 10);

            nota2[contador] = _nota2;

            Console.WriteLine();
            contador++;

            if (contador < 10)
            {
                Console.WriteLine("Cadastro realizado com sucesso! Deseja cadastrar outro aluno? (s/n)");

                cadastrarNovoAluno = Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Limite de cadastro atingido! Não é possível cadastrar mais alunos.");
                Console.ResetColor();

                cadastrarNovoAluno = "n";
            }

        } while (cadastrarNovoAluno.ToLower() == "s" && contador < 10);
    }

    static void ListarAlunos()
    {
        for (int i = 0; i < contador; i++)
        {
            double mediaNotas = CalcularMedia(nota1[i], nota2[i]);

            Console.WriteLine($"Nome: {nomeAluno[i]}");
            Console.WriteLine($"Idade: {idadeAluno[i]}");
            Console.WriteLine($"Média: {mediaNotas:F1}");

            Console.WriteLine();
            Console.WriteLine("-------------------------");
        }
    }

    static void BuscarAluno()
    {
        Console.Write("Digite o nome do Aluno: ");

        string? nomeBusca = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nomeBusca))
        {
            Console.WriteLine("Nome inválido.");
            return;
        }

        bool encontrado = false;

        for (int i = 0; i < contador; i++)
        {
            if (nomeAluno[i].Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = true;

                double media = CalcularMedia(nota1[i], nota2[i]);

                Console.WriteLine();
                Console.WriteLine("Aluno encontrado!");
                Console.WriteLine($"Nome: {nomeAluno[i]}");
                Console.WriteLine($"Idade: {idadeAluno[i]}");
                Console.WriteLine($"Nota 1: {nota1[i]}");
                Console.WriteLine($"Nota 2: {nota2[i]}");
                Console.WriteLine($"Média: {media:F1}");

                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }

    static void ExibirAprovados()
    {
        int totalAprovados = 0;

        Console.WriteLine("=== Alunos aprovados ===");
        Console.WriteLine();

        for (int i = 0; i < contador; i++)
        {
            double media = CalcularMedia(nota1[i], nota2[i]);

            if (media >= 7)
            {
                Console.WriteLine($"{nomeAluno[i]} - Média: {media:F1}");
                totalAprovados++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Total: {totalAprovados} alunos");
    }

    static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }
}