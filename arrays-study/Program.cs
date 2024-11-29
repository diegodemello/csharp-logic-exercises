namespace arrays_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mz;
            mz = new int[n, n];


            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    mz[i, j] = int.Parse(s[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int cont = 0;
                for (int j = 0; j < n; j++)
                {
                    cont = cont + mz[i, j];
                }
                Console.WriteLine(cont);
            }
        }
    }
}
