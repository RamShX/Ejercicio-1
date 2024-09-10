public class Curso
{
    private string Nombre {get; set;}
    private int Recuentro_Ejercicios {get; set;}
    private int Recuentro_Clases {get; set;}

    //contructor
    public Curso(string nombre, int recuentro_Ejercicios, int recuentro_Clases)
    {
        this.Nombre = nombre;
        this.Recuentro_Ejercicios = recuentro_Ejercicios;
        this.Recuentro_Clases = recuentro_Clases;
    }
    
}