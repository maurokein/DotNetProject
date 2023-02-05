using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class AgregarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public AgregarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar(Inscripcion inscripcion)
    {
        _rInscripcion.AgregarInscripcion(inscripcion);
    }
}