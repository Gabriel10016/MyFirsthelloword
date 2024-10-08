using System;

class ProgramaNotas
{
    static void Main()
    {
        bool ingresarOtroGrupo = true;

        while (ingresarOtroGrupo)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al sistema de clasificación de notas de estudiantes");

            int cantidadEstudiantes = 0;

            // Solicitar la cantidad de estudiantes
            Console.Write("Ingrese la cantidad de estudiantes: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadEstudiantes) || cantidadEstudiantes <= 0)
            {
                Console.Write("Por favor, ingrese un número válido de estudiantes: ");
            }

            int estudiantesGanaron = 0;
            int estudiantesPerdieron = 0;

            // Procesar cada estudiante
            for (int i = 1; i <= cantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nEstudiante {i}:");

                double sumaNotas = 0;
                int cantidadNotas = 0;

                // Ingresar notas del estudiante
                while (true)
                {
                    Console.Write("Ingrese una nota (o -1 para terminar): ");
                    double nota;
                    if (double.TryParse(Console.ReadLine(), out nota))
                    {
                        if (nota == -1)
                        {
                            break; // Salir del bucle si se ingresa -1
                        }
                        if (nota < 0 || nota > 5)
                        {
                            Console.WriteLine("La nota debe estar entre 0 y 5. Intente de nuevo.");
                            continue;
                        }
                        sumaNotas += nota;
                        cantidadNotas++;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese una nota válida.");
                    }
                }

                // Calcular promedio
                double promedio = cantidadNotas > 0 ? sumaNotas / cantidadNotas : 0;
                Console.WriteLine($"Promedio del estudiante {i}: {promedio:F2}");

                // Clasificar y contar ganados/perdidos
                if (promedio >= 4.5)
                {
                    Console.WriteLine("Categoría: Excelente");
                    estudiantesGanaron++;
                }
                else if (promedio >= 4.0)
                {
                    Console.WriteLine("Categoría: Sobresaliente");
                    estudiantesGanaron++;
                }
                else if (promedio >= 3.5)
                {
                    Console.WriteLine("Categoría: Bueno");
                    estudiantesGanaron++;
                }
                else
                {
                    Console.WriteLine("Categoría: Insuficiente");
                    estudiantesPerdieron++;
                }
            }

            // Mostrar resultados finales
            Console.WriteLine($"\nEstudiantes que ganaron: {estudiantesGanaron}");
            Console.WriteLine($"Estudiantes que perdieron: {estudiantesPerdieron}");

            // Preguntar si desea ingresar otro grupo
            Console.Write("\n¿Desea ingresar otro grupo de estudiantes? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            ingresarOtroGrupo = respuesta == "s";
        }

        Console.WriteLine("Gracias por usar el sistema. ¡Hasta la próxima!");
    }
}
