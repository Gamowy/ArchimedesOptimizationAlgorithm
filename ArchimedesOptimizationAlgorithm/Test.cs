namespace ArchimedesOptimizationAlgorithm
{
    class Test
    {
        static void Main(string[] args)
        {
            /* Parametry zewnętrzne:
             *     N - wielkość populacji
             *     I - ilość iteracji
             *     Dim - wymiar dziedziny funkcji testowej
             *     Fun - funkcja testowa
             *     Lb - tablica dolnych ograniczeń dziedziny funkcji testowej (jeżeli ograniczenie jest takie same dla każdej zmiennej to wystarczy podać jedno)
             *     Ub - tablica górnych ograniczeń dziedziny funkcji testowej (jeżeli ograniczenie jest takie same dla każdej zmiennej to wystarczy podać jedno)
             * 
             * Domyślne wartości parametrów wewnętrznych:
             *     C1 = 2.0
             *     C2 = 6.0
             *     C3 = 2.0
             *     C4 = 0.5
             * 
             * Dostępne funkcje:
             *     TestFunctions.Rastragin:     -5.12 <= x_n <= 5.12,          Dim = 2,5,10,30
             *     TestFunctions.Rosenbrock:    -inf <= x_n <= inf,            Dim = 2,5,10,30
             *     TestFunctions.Sphere:        -inf <= x_n <= inf,            Dim = 2,5,10,30,50
             *     TestFunctions.Beale:         -4.5 <= x,y <= 4.5,            Dim = 2
             *     TestFunctions.BunkinN6:      -15 <= x <= -5, -3 <= y <= 3   Dim = 2
             *     TestFunctions.Himmelblau:    -5 <= x,y <= 5,                Dim = 2
             */

            ArchimedesOptimization aoa = new ArchimedesOptimization(N: 40, I: 80, Dim: 2, Fun: TestFunctions.Himmelblau, Lb: [-5], Ub: [5]);
            double Fbest = aoa.Solve();
            double[] XBest = aoa.XBest;
            Console.WriteLine($"Result: f({string.Join(", ", XBest)}) = {Fbest}");
        }
    }
}
