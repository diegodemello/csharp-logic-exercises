namespace arrays_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] op = Console.ReadLine().Split(" ");
            int m = int.Parse(op[0]);
            int n = int.Parse(op[1]);

            int[,] pmMz = new int[m, n];
            int[,] scMz = new int[m, n];
            int[,] fnMz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    pmMz[i,j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    scMz[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    fnMz[i, j] = pmMz[i, j] + scMz[i, j];
                    Console.Write(fnMz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
