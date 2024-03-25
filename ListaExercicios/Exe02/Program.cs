namespace Exe02;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[100];
        Random random = new Random();
        //Preenchendo o vetor com valores aleatórios
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(10000);
        }
        //Imprimindo o vetor desordenado
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine("\n");

        //Ordenar o vetor
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            if (vetor[i] > vetor[i + 1])
            {
                int aux = vetor[i];
                vetor[i] = vetor[i + 1];
                vetor[i + 1] = aux;
            }
        }


        //Imprimindo o vetor ordenado
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}
