using Microsoft.EntityFrameworkCore;

using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;
using Prueba.Aplicacion.UseCases;

namespace Prueba.Repositorios;

public class RepositorioInscripcion : IRepositorioInscripcion
{
    public void AgregarInscripcion(Inscripcion inscripcion)
    {
        using (var db = new InstitucionEducativaContext())
        {                        
            IRepositorioEstudiante validarEstudiante = new RepositorioEstudiante();
            IRepositorioCurso validarCurso = new RepositorioCurso();
            Estudiante? est = validarEstudiante.GetEstudiante(inscripcion.EstudianteId);
            Curso? cur = validarCurso.GetCurso(inscripcion.CursoId);
            if(est is null || cur is null)
            {
                throw new Exception();
            }
            else 
            {
                db.Add(inscripcion);
                db.SaveChanges();
            }   
        }
    }

    public void ModificarInscripcion(Inscripcion inscripcion)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var inscripcionAModificar = db.Inscripciones.Where(i => i.Id == inscripcion.Id).SingleOrDefault();
            
            if(inscripcionAModificar != null)
            {
                inscripcionAModificar.EstudianteId = inscripcion.EstudianteId;
                inscripcionAModificar.CursoId = inscripcion.CursoId;
                inscripcionAModificar.FechaDeInscripcion = inscripcion.FechaDeInscripcion;
            }
            db.SaveChanges();
        }
    }

    public void EliminarInscripcion(int id)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var inscripcionAEliminar = db.Inscripciones.Where(i => i.Id == id).SingleOrDefault();
            
            if(inscripcionAEliminar != null)
            {
                db.Remove(inscripcionAEliminar);
            }
            db.SaveChanges();
        }
    }

    public Inscripcion? GetInscripcion(int id)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var inscripcionBuscada = db.Inscripciones.Where(i => i.Id == id).SingleOrDefault();
            return inscripcionBuscada;
       }
    }

    public List<Dato> GetInscripciones()
    {
        using (var db = new InstitucionEducativaContext())
        {
            List<Dato> data = new List<Dato>();
            ObtenerEstudianteUseCase buscarEstudiante = new ObtenerEstudianteUseCase(new RepositorioEstudiante());
            ObtenerCursoUseCase buscarCurso = new ObtenerCursoUseCase(new RepositorioCurso());
            List<Inscripcion> lista = db.Inscripciones.ToList();
            Estudiante? est;
            Curso? cur;
            foreach(Inscripcion i in lista)
            {
                est = buscarEstudiante.Ejecutar(i.EstudianteId);
                cur = buscarCurso.Ejecutar(i.CursoId);
                if(i is not null && est is not null && cur is not null)
                {
                    int? id = null;
                    string? nombre = null; 
                    string? apellido = null;
                    string? titulo = null;
                    DateTime? fecha = null; 
                    id = i.Id;
                    if(est.Nombre != null)
                    {
                        nombre = est.Nombre;
                    }
                    if(est.Apellido != null)
                    {
                        apellido = est.Apellido;
                    }
                    if(cur.Titulo != null)
                    {
                        titulo = cur.Titulo;
                    }
                    fecha = i.FechaDeInscripcion;
                    if(id is not null && nombre is not null && apellido is not null && titulo is not null && fecha is not null)
                    {
                        data.Add(new Dato(i.Id, est.Nombre, est.Apellido, cur.Titulo, i.FechaDeInscripcion));
                    }
                }
            }
            return data;
        }
    }
}