

public class Profesor : Persona
{
    private List<Curso> Cursos {get; set;}

    //Contructor
    public Profesor(string nombre)
    : base(nombre)
    {
        Cursos = new List<Curso>();
    }
}