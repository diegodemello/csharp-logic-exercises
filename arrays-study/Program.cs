namespace arrays_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            string[] s = Console.ReadLine().Split(" ");
            m = int.Parse(s[0]);
            n = int.Parse(s[1]);
            int[,] mz;
            mz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] ar = Console.ReadLine().Split(" ");
                for(int j = 0; j < n; j++)
                {
                    mz[i,j] = int.Parse(ar[j]);
                }
            }

            Console.WriteLine("Números negativos: ");
            for (int i = 0; i < m; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    if (mz[i,j] < 0)
                    {
                        Console.WriteLine(mz[i,j]);
                    }
                }
            }
        }
    }
}
