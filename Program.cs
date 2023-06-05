internal class Program
{
    private static void Main(string[] args)
    {
        string[] provincias ={"Santa Fe", "Tierra del fuego", "Chubut", "Río Negro", "La Pampa",
                            "Neuquen", "La Rioja", "Buenos Aires", "Entre Ríos", "Corrientes",
                            "Santiago del Estero", "Tucuman", "Córdoba", "San Luis", "Catamarca",
                            "Chaco", "Formosa", "Jujuy", "Salta", "Misiones", "Santa Cruz",
                            "Mendoza", "San Juan" };

        var misProvincias = from p in provincias where p.StartsWith("S")||p.StartsWith("T") select p;

        
        foreach(var prov in misProvincias)
        {
            Console.WriteLine(prov);
        }

        Console.ReadKey();
    }
}