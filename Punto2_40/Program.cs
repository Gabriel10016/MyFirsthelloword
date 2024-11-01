internal class NOTAS

{
    static void Main()
    {
        bool SG = true;

        while (SG)
        {
            List<double> prom = new List<double>();
            int EG = 0;
            int EP = 0;

            Console.WriteLine("Digite los estudiantes a promediar:");
            int CE = int.Parse(Console.ReadLine());

            for (int i = 1; i <= CE; i++)
            {
                Console.WriteLine($"Digite la nota del estudiante numero {i}:");
                double N = double.Parse(Console.ReadLine());

                prom.Add(N);
            }

            foreach (double pro in prom)
            {
                string cat;
                if (pro >= 4.5)
                {
                    cat = "Excelente";
                    EG++;
                }
                else if (pro >= 4.0)
                {
                    cat = "Sobresaliente";
                    EG++;
                }
                else if (pro >= 3.5)
                {
                    cat = "Bueno";
                    EG++;
                }
                else
                {
                    cat = "Insuficiente";
                    EP++;
                }

                Console.WriteLine($"El promedio del estudiante es: {pro}");
            }

            Console.WriteLine($"\nLos estudiantes que ganaron son: {EG}");
            Console.WriteLine($"Los estudiantes que perdieron son: {EP}");

            Console.WriteLine("\nSi deseas calcular otros estuciantes preciona (S) de otro modo (N)");
            string R = Console.ReadLine().ToLower();
            SG = (R== "s");
        }
    }
}