using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ListarEstudiantesConCursoEnProcesoUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesConCursoEnProcesoUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public List<Dato> Ejecutar()
    {
        return _rEstudiante.GetEstudiantesConCursoEnProceso();
    }
}