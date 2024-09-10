public class Clase
{
    //La clases contienen docentes y estudiantes
    private string Identificador {get; set;}
    private List<Profesor> Docentes {get; set;}
    private List<Estudiante> Estudiantes {get; set;}

    //Contructor
    public Clase(string identificador)
    {
        this.Identificador = identificador;
        Docentes = new List<Profesor>();
        Estudiantes = new List<Estudiante>();
    }
}