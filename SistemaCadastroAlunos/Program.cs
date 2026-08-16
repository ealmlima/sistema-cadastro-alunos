class Program
{
    static void Main()
    {
        static void ExibirAprovados(string[] nomeAluno, double[] nota1, double[] nota2)
        {
            int totalAprovados = 0;

            Console.WriteLine("=== Alunos aprovados ===");
            Console.WriteLine();

            for (int i = 0; i < nomeAluno.Length; i++)
            {
                double media = CalcularMedia(nota1[i], nota2[i]);

                if (media >= 7)
                {
                    Console.WriteLine($"{nomeAluno[i]} - Média: {media:F1}");
                    totalAprovados++;
                }

                //não lê a idade do aluno porque não é exibido no resultado final
            }

            Console.WriteLine();
            Console.WriteLine($"Total: {totalAprovados} alunos");
        }
        ExibirAprovados(nomeAluno, nota1, nota2);
    }
}
