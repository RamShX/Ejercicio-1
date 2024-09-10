using System.Data.Common;

public class Estudiante : Persona
{
    private int ID;
    
    //contructor
    public Estudiante(string nombre , int id)
        : base(nombre)   
    {
        this.ID = id;
    }

    //método get y set
    public int id
    {
        get
        {
            return ID;
        }

        set 
        {
            if(value <= 0)
            {
                throw new ArgumentException("El ID debe ser un número positivo.");
            }

            ID = value;       
        }
    }

}