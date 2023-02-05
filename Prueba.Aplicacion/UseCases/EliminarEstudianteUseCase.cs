using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class EliminarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public EliminarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar(int id)
    {
        _rEstudiante.EliminarEstudiante(id);
    }
}