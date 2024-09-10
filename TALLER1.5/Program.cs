internal class TALLER1
{        static void Main()
        //diseñado par calcular y ordenar los numeros de mayor a menor
    {
        Console.WriteLine("Ingrese un Número cualquira:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese un segundo Número cualquira:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese un tercer Número cualquira:");
        double num3 = Convert.ToDouble(Console.ReadLine());
        double[] numeros = { num1, num2, num3 };
        Array.Sort(numeros);
        Array.Reverse(numeros);
        Console.WriteLine("Los números ordenados de mayor a menor son:");
        foreach (double num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}
//GABRIEL ENRIQUE CARPIO REYES 