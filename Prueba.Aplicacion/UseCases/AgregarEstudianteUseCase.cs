using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class AgregarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public AgregarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar(Estudiante estudiante)
    {
        _rEstudiante.AgregarEstudiante(estudiante);
    }
}