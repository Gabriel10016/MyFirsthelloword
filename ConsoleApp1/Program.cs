internal class Program

{
    

    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int menor = Math.Min(num1, num2);
        int mayor = Math.Max(num1, num2);

        Console.WriteLine($"Los números entre {menor} y {mayor} son:");
        for (int i = menor + 1; i < mayor; i++)
        {
            Console.WriteLine(i);
        }
    }
}