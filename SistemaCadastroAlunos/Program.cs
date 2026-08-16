class Program
{
    static void Main()
    {

       static void  BuscarAluno(string[] nomes, int[] idades, double[] notas1 , double[] notas2)
        {
        Console.Write("Digite o nome do Aluno: ");
        string nomeBusca = Console.ReadLine();
        }
        bool encontrado = false;

        for(int i = 0; i<nomes.Length;i++)
        {
            if(nomes[i] == nomeBusca)
            {
                encontrado = true;

                 double media = calcularmedia(notas1[i],notas2[i]);

            Console.WriteLine("Aluno encontrado!");
            Console.WriteLine($"Nome: {nomes[i]}");
            Console.WriteLine($"Idade: {idades[i]}");
            Console.WriteLine($"Nota 1: {notas1[i]}");
            Console.WriteLine($"Nota 2: {notas2[i]}");
            Console.WriteLine($"Média: {media}");

            break;
            }
            if(!encontrado)
            {
                Console.WriteLine("Aluno não encontrado");
            }
        }
    }
}
