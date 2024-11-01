using System;

class Estudiante
{
    public int Cred{ get; set; }
    public int Est{ get; set; }
    public const decimal ValCNormal = 100000; 

    public decimal CMatricula()
    {
        decimal mBase;

        if (Cred <= 20)
        {
            mBase = Cred * ValCNormal;
        }
        else
        {
            mBase = (20 * ValCNormal) + ((Cred- 20) * ValCNormal * 2);
        }
        decimal desc= 0;
        switch (Est)
        {
            case 1:
                desc = mBase * 0.80m;
                break;
            case 2:
                desc = mBase * 0.50m; 
                break;
            case 3:
                desc = mBase * 0.30m;
                break;
        }
        return mBase - desc;
    }
    public decimal CalSub()
    {
        switch (Est)
        {
            case 1:
                return 200000; 
            case 2:
                return 100000; 
            default:
                return 0; 
        }
    }
}
class Program
{
    static void Main()
    {
        do
        {
            Console.Clear();
            Estudiante estudiante = new Estudiante();
            Console.WriteLine("Digite la cantidad de créditos: ");
            estudiante.Cred = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el numero del estrato (1, 2 o 3): ");
            estudiante.Est = int.Parse(Console.ReadLine());
            decimal matricula = estudiante.CMatricula();
            decimal subsidio = estudiante.CalSub();
            Console.WriteLine($"El valor a pagar es de: {matricula:C}, menos el valor de su subsidio cual es de: {subsidio:C}");
            Console.WriteLine("¿Desea calcular la matrícula de otro estudiante? (s/n): ");
        } while (Console.ReadLine().ToLower() == "s");
    }
}
