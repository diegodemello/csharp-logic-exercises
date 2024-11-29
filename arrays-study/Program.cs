namespace arrays_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    mz[i, j] = int.Parse(vet[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    soma = soma + mz[i, j];
                }
            }
            Console.WriteLine(soma);
        }
    }
}
