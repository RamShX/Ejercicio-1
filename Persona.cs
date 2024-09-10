public abstract class Persona
{
    private string nombre;

    //contructor
    public Persona(string Nombre)
    {
        this.nombre = Nombre;
    }

    // Método get y set
    public string Nombre
    {
        get 
        { 
            return nombre; 
        }
        set 
        {
            
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }
            
            nombre = value;
        }
    }
}
