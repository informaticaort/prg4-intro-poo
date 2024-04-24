internal class Program
{
    private static void Main(string[] args)
    {
        //Ingreso de datos
        int kilometros = IngresoEnteroPositivo("Ingrese la cantidad de kilometros que correrá el perro");
        int cantidadGranos = IngresoEnteroPositivo("Ingrese la cantidad de granos que comerá el perro");
       
        //TODO: Completar el resto de los ingresos de datos
        string nombre = IngresoCadena("Ingrese el nombre del perro:");

        //Instancio al perro1
        Perro perro1 = new Perro(nombre);

        Perro perro2 = new Perro("Tincho");

        //Le doy la orden al perro1 de correr y comer
        perro1.Correr(kilometros);
        perro1.Comer(cantidadGranos);

        //Obtengo el valor del atributo Energia y lo muestro por consola
        Console.WriteLine($"{perro1.Nombre} tiene {perro1.Energia}% de energia");
        Console.WriteLine($"{perro2.Nombre} tiene {perro2.Energia}% de energia");

        //perro1.Energia = -50;
        //OJO!! Esta sentencia no es correcta!! El setter está privado!!

        List<Perro> listaPerros = new List<Perro>();

        listaPerros.Add(perro1);
        listaPerros.Add(perro2);

        listaPerros.Add(new Perro("juancito"));

        listaPerros[2].Altura = 1.40;

        foreach(Perro unPerro in listaPerros) {
            int km = IngresoEnteroPositivo($"Ingrese km que recorre {unPerro.Nombre}:");
            unPerro.Correr(km);
        }

        Console.ReadLine();
    }

    static string IngresoCadena(string mensaje) {
        Console.WriteLine(mensaje);
        return Console.ReadLine();
    }

    static int IngresoEnteroPositivo(string mensaje)
    {
        int numero;
        Console.WriteLine(mensaje);
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.WriteLine("Error, ingrese un número válido");
        }
        return numero;
    }
}