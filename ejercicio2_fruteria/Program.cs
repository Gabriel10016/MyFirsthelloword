internal class Program
{
    private static void Main(string[] args)
    {
        const decimal pk = 1;
        decimal desc, pb, pd, pn;

        Console.WriteLine("Hello, World!");
        Console.Write("Ingrese cuantos Kilos desea llevar")
        double km = Convert.ToDouble(Console.ReadLine());

        if (km >= 0 && km <= 2)
        {
            desc = 0
        }
        else if (km > 2 && km <= 5)
        {
            desc = 10;
        }
        else if (km > 10 && km <= 15)
        { 
            desc = 15;
        }
        else
        {
            desc = 20;
        }

        pb = km * pk;
        pd = pb * (desc / 100);
        pn = pb - pd;



    }
}
