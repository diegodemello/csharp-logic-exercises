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
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    mz[i,j] = int.Parse(s[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mz[i, j] > 0)
                    {
                        soma = soma + mz[i, j];
                    }
                }
            }
            Console.WriteLine("Soma dos números positivos: " + soma);

            int indiceLinha = int.Parse(Console.ReadLine());
            Console.Write("Linha Escolhida: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mz[indiceLinha, i] + " ");
            }
            Console.WriteLine();

            int indiceColuna = int.Parse(Console.ReadLine());
            Console.Write("Coluna Escolhida: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(mz[j, indiceColuna] + " ");
            }
            Console.WriteLine();

            Console.Write("Diagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j)
                    {
                        Console.Write(mz[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mz[i,j] < 0)
                    {
                        mz[i,j] = mz[i,j]*mz[i,j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    Console.Write(mz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
