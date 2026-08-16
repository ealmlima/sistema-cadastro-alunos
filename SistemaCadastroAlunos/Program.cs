using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] nomeAluno = new string[10];
        int[] idadeAluno = new int[10];
        double[] nota1 = new double[10];
        double[] nota2 = new double[10];

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("===Cadastro de alunos===");
        Console.WriteLine();
        Console.ResetColor();

        for (int i = 0; i < 10; i++)
        {
            string _nomeAluno;
            Console.WriteLine("Aluno {0}", i + 1);
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
            nomeAluno[i] = _nomeAluno;

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
            idadeAluno[i] = _idadeAluno;

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
            nota1[i] = _nota1;

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
            nota2[i] = _nota2;

            Console.WriteLine();
        }

        Console.WriteLine("Cadastro realizado com sucesso!");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("=== Menu ===");
        Console.ResetColor();
    }
}
