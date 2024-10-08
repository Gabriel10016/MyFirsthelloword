internal class NOTAS

{
    static void Main()
    {
        bool Grupo = true;

        while (Grupo)
        {
            Console.Clear();
            Console.WriteLine("Calificación de notas de estudiantes");

            int E = 0;

            Console.Write("Digite los de estudiantes: ");
            while (!int.TryParse(Console.ReadLine(), out E) || E <= 0)
            {
                Console.Write("Digite los número válido de estudiantes: ");
            }

            int EG = 0;
            int EP = 0;

            for (int i = 1; i <= E; i++)
            {
                Console.WriteLine($"\nEstudiante {i}:");

                double SM = 0;
                int CN = 0;

                while (true)
                {
                    Console.Write("Ingrese una nota (o -1 para terminar): ");
                    double N;
                    if (double.TryParse(Console.ReadLine(), out N))
                    {
                        if (N == -1)
                        {
                            break; // Salir del bucle si se ingresa -1
                        }
                        if (N < 0 || N > 5)
                        {
                            Console.WriteLine("Error La nota debe ser entre 0 y 5. Intente de nuevo.");
                            continue;
                        }
                        SM += N;
                        CN++;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese una nota válida.");
                    }
                }

                double pro = CN > 0 ? SM/ CN : 0;
                Console.WriteLine($"El promedio del estudiante {i}: {pro:F2}");

                if (pro>= 4.5)
                {
                    Console.WriteLine("Excelente");
                    EG++;
                }
                else if (pro >= 4.0)
                {
                    Console.WriteLine("Sobresaliente");
                    EG++;
                }
                else if (pro >= 3.5)
                {
                    Console.WriteLine("Bueno");
                    EG++;
                }
                else
                {
                    Console.WriteLine("Insuficiente");
                   EG++;
                }
            }

            Console.WriteLine($"\n los estudiantes que ganaron: {EG}");
            Console.WriteLine($" los estudiantes que perdieron: {EG}");

            Console.Write("\n¿Desea ingresar otro grupo de estudiantes? precione (s), para si y (n), para no ");
            string R = Console.ReadLine().ToLower();
            Grupo = R == "s";
        }

        Console.WriteLine("Hasta pronto");
    }
}
