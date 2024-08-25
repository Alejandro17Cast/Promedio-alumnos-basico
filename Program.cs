

internal class Program
{
    private static void Main(string[] args)
    {
        int tamaño;

        Console.WriteLine("Ingrese la cantidad de Alumnos");
        tamaño = int.Parse(Console.ReadLine());
        string[] nombres = new string[tamaño];
        double[] promedio = new double[tamaño];

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("Ingrese el nombre del estudiante " + (1 + i));
            nombres[i] = Console.ReadLine();
            Console.WriteLine("Ingrese el promedio de " + nombres[i]);
            promedio[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < nombres.Length; i++)
        {
            if (promedio[i] > 100 || promedio[i] < 0)
            {
                Console.WriteLine(nombres[i]+": INGRESA UN PROMEDIO EN EL RANGO DE 0 A 100");

            }
            else
            {
                Console.WriteLine("\n INFORMACIÓN DE LOS ESTUDIANTES");
                Console.WriteLine("EL promedio del estudiante " + nombres[i] + " es de " + promedio[i]+ "%");
            }

        }




    }
}