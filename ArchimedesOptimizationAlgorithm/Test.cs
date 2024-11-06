namespace ArchimedesOptimizationAlgorithm
{
    class Test
    {
        static double RastriginFun(double[] x)
        {
            double y = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                y += x[i] * x[i] - 10 * Math.Cos(2 * Math.PI * x[i]);
            }
            y += 10 * x.Length;
            return y;
        }

        static void Main(string[] args)
        {
            Func<double[], double> testFun = RastriginFun;

            /* Parametry zewnętrzne:
             * N - wielkość populacji
             * I - ilość iteracji
             * Dim - wymiar dziedziny funkcji testowej
             * Fun - funkcja testowa
             * Lb - dolne ograniczenie dziedziny funkcji testowej
             * Ub - górne ograniczenie dziedziny funkcji testowej
             * 
             * Domyślne wartości parametrów wewnętrznych:
             * C1 = 2.0
             * C2 = 6.0
             * C3 = 2.0
             * C4 = 0.5
             */
            ArchimedesOptimization aoa = new ArchimedesOptimization(N: 40, I: 80, Dim: 2, Fun: testFun, Lb: -5.12, Ub: 5.12);
            double Fbest = aoa.Solve();
            double[] XBest = aoa.XBest;
            Console.WriteLine($"Result: f({string.Join(", ", XBest)}) = {Fbest}");
        }
    }
}
