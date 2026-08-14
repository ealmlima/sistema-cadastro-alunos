class Program
{
    static void Main()
    {

        

    }

    static void ListarAlunos(string[] nomeAluno, int[] idadeAluno, double[] nota1, double[] nota2)
    {
        for (int i = 0; i < nomeAluno.Length; i++)
        {
            double mediaNotas = CalcularMedia(nota1[i], nota2[i]);

            Console.WriteLine($"Nome: {nomeAluno[i]}");
            Console.WriteLine($"Idade: {idadeAluno[i]}");
            Console.WriteLine($"Média: {mediaNotas:0.##}");
            Console.WriteLine("-------------------------");
        }

    }

    static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }
}
