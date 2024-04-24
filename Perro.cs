class Perro {
    //Atributos
    public string Nombre { get; private set; }
    public int Edad { get; set; }
    public double Altura { get; set; } 
    public int Energia { get; private set; }

    //Constructor
    public Perro(string nombre) {
        Nombre = nombre;
        Energia = 100;
    }

    //Metodo Correr
    public void Correr(int kilometros){
        if(Energia > 0)
            Energia = Math.Max(Energia - kilometros, 0);
    }

    //Metodo Comer
    public void Comer(int cantidadGranos){
        if(Energia < 100)
            Masticar();
        Energia = Math.Min(Energia + cantidadGranos, 100);
    }

    //Metodo PRIVADO Masticar
    //Solo puede ser llamado desde la clase Perro
    private void Masticar()
    {
        Console.WriteLine("Miam");
    }

}