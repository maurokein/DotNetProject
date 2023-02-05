namespace Prueba.Aplicacion.Entidades;

public class Estudiante
{
    public int Id { get; set; }
    public int Dni { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Email { get; set; }

    public List<Inscripcion>? Inscripciones { get; set; } 


    public Estudiante(int dni, string nombre, string apellido, string email)
    {
        Dni = dni;
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
    }
    public Estudiante(){}
}