using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ModificarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ModificarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar(Inscripcion inscripcion)
    {
        _rInscripcion.ModificarInscripcion(inscripcion);
    }
}