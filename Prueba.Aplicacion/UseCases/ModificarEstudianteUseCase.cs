using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ModificarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ModificarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar(Estudiante estudiante)
    {
        _rEstudiante.ModificarEstudiante(estudiante);
    }
}