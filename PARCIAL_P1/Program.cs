internal class PARCIAL_1
{
    static void Main()
    {
        const decimal SBasico = 1500000m, OV = 1000000m, BE = 100000m, PCom = 0.10m;
        decimal com1, com2, com3, v1, v2, v3, TSR, MCom, TV, TCom, ProCom;
        bool SPO;

        Console.Write("Digite el primer monto vendio: ");
        v1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite el segundo monto vendio: ");
        v2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite el tercer monto vendio: ");
        v3 = Convert.ToDecimal(Console.ReadLine());

        com1 = v1 * PCom;
        com2 = v2 * PCom;
        com3 = v3 * PCom;

        TV = v1 + v2 + v3;
        TCom = com1 + com2 + com3;
        ProCom = TCom / 3;
        MCom = Math.Max(com1, Math.Max(com2, com3));
        TSR = SBasico + TCom;
        SPO = TV >= OV;

        
        Console.WriteLine($"Usted comisiono por las tres ventas un total de: {TCom:C}");
        Console.WriteLine($"Su sueldo a devengar incluyendo comiciones y sueldo basico es un total de): {TSR:C}");
        Console.WriteLine($"Su venta cual gano la mayor comisión fue de: {MCom:C}");
        Console.WriteLine($"El promedio en sus comisiones es de: {ProCom:C}");

        if (SPO)
        {
            Console.WriteLine($"¡En hora buena has ganado el beneficio extra de {BE:C}!");
        }
        else
        {
            Console.WriteLine("No ganó el beneficio extra.");
        }
    }
}
