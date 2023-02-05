using Prueba.Aplicacion.UseCases;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.Entidades;

public class Inscripcion
{
    public int Id { get; set; }
    public int EstudianteId { get; set; }
    public int CursoId { get; set; }
    public DateTime FechaDeInscripcion { get; set; }

    public Inscripcion(int estudianteId, int cursoId, DateTime fec)
    {
        EstudianteId = estudianteId;
        CursoId = cursoId;
        FechaDeInscripcion = fec;
    }
    public Inscripcion(){}
}