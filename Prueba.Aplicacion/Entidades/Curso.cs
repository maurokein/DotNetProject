namespace Prueba.Aplicacion.Entidades;

public class Curso
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descripcion { get; set; } 
    public DateTime FechaDeInicio { get; set; }
    public DateTime FechaDeFin { get; set; }

    public List<Inscripcion>? Inscripciones { get; set; }

    public Curso(string titulo, string descripcion, DateTime fechaInicio, DateTime fechaFin)
    {
        Titulo = titulo;
        Descripcion = descripcion;
        FechaDeInicio = fechaInicio;
        FechaDeFin = fechaFin;
    }
    public Curso(){}
}