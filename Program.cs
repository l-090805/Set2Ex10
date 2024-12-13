namespace Set2Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nr de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Elemente vector: ");
            for(int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            int lungimeCurenta = 1;
            int lungimeMaxima = 1;

            for(int i = 1; i< v.Length; i++)
            {
                if (v[i] == v[i - 1])
                {
                    lungimeCurenta++;
                }
                else
                {
                    if(lungimeCurenta > lungimeMaxima)
                    {
                        lungimeMaxima = lungimeCurenta;
                    }
                    lungimeCurenta = 1;
                }
            }

            if (lungimeCurenta > lungimeMaxima)
            {
                lungimeMaxima = lungimeCurenta;
            }

            Console.WriteLine($"Nr max elem repetitive: {lungimeMaxima}");

        }
    }
}
