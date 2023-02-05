using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Aplicacion.UseCases;

public class ObtenerInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ObtenerInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public Inscripcion? Ejecutar(int id)
    {
        return _rInscripcion.GetInscripcion(id);
    }
}