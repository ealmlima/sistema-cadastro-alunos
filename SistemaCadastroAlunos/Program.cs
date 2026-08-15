class Program
{
    static void Main()
    {
        string[] nomeAluno =
        {
            "João",
            "Maria",
            "Pedro",
            "Ana",
            "Carlos",
            "Juliana",
            "Lucas",
            "Beatriz",
            "Rafael",
            "Camila"
        };

        int[] idadeAluno =
        {
            18,
            19,
            20,
            18,
            21,
            19,
            22,
            20,
            18,
            21
        };

        double[] nota1 =
        {
            8.5,
            7.0,
            9.5,
            6.0,
            8.0,
            7.5,
            9.0,
            6.5,
            5.5,
            10.0
        };

        double[] nota2 =
        {
            7.5,
            8.0,
            9.0,
            7.5,
            8.5,
            9.0,
            8.0,
            7.5,
            6.5,
            9.5
        };

        ListarAlunos(nomeAluno, idadeAluno, nota1, nota2);


    }

    static void ListarAlunos(string[] nomeAluno, int[] idadeAluno, double[] nota1, double[] nota2)
    {
        for (int i = 0; i < nomeAluno.Length; i++)
        {
            double mediaNotas = CalcularMedia(nota1[i], nota2[i]);

            Console.WriteLine($"Nome: {nomeAluno[i]}");
            Console.WriteLine($"Idade: {idadeAluno[i]}");
            Console.WriteLine($"Média: {mediaNotas:F1}");

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

    }

    static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }
}
