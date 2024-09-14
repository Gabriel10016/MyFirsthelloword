internal class PARCIAL_P2

{
    static void Main()
    {     
        decimal A, B, x;

        Console.Write("Digite un numero para A: ");
        A = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite un numero para B: ");
        B = Convert.ToDecimal(Console.ReadLine());

        if (A == 0)
        {
            if (B == 0)
            {
                Console.WriteLine("Esta operación tiene varias soluciones.");
            }
            else
            {
                Console.WriteLine("Esta operación no tiene soluciones.");
            }
        }
        else
        {
            x = -B / A;
            Console.WriteLine($"Esta operación tiene como solución x = {x}");
        }
    }
}
