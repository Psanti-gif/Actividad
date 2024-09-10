
public class Program
{
    public static void Main(string[] args)
    {
        double n1, n2, n3;

        Console.WriteLine("Ingrese Primer Número: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese Segundo Número: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese Tercer Número: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        double num_mayor, num_medio, num_menor;

        if (n1 > n2 && n1 > n3)
        {
            num_mayor = n1;

            if (n2 > n3)
            {
                num_medio = n2;
                num_menor = n3;
            }
            else
            {
                num_medio = n3;
                num_menor = n2;
            }
        }
        else if (n2 > n1 && n2 > n3)
        {
            num_mayor = n2;

            if (n1 > n3)
            {
                num_medio = n1;
                num_menor = n3;
            }
            else
            {
                num_medio = n3;
                num_menor = n1;
            }
        }
        else
        {
            num_mayor = n3;

            if (n1 > n2)
            {
                num_medio = n1;
                num_menor = n2;
            }
            else
            {
                num_medio = n2;
                num_menor = n1;
            }
        }

        Console.WriteLine($"El Número Mayor es: {num_mayor}");
        Console.WriteLine($"El Número Medio es: {num_medio}");
        Console.WriteLine($"El Número Menor es: {num_menor}");
    }
}
