using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ListarEstudiantesUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantes();
    }
}