using Microsoft.EntityFrameworkCore;

using Prueba.Aplicacion.Entidades;
using Prueba.Aplicacion.Interfaces;

namespace Prueba.Repositorios;

public class RepositorioCurso : IRepositorioCurso
{
    public void AgregarCurso(Curso curso)
    {
        using(var db = new InstitucionEducativaContext())
        {
            db.Add(curso);
            db.SaveChanges();
        }
    }

    public void ModificarCurso(Curso curso)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var cursoAModificar = db.Cursos.Where(
                c => c.Id == curso.Id).SingleOrDefault();
            
            if(cursoAModificar != null)
            {
                cursoAModificar.Titulo = curso.Titulo;
                cursoAModificar.Descripcion = curso.Descripcion;
                cursoAModificar.FechaDeInicio = curso.FechaDeInicio;
                cursoAModificar.FechaDeFin = curso.FechaDeFin;
            }
            db.SaveChanges();            
        }
    }

    public void EliminarCurso(int id)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var cursoAEliminar = db.Cursos.Where(
                c => c.Id == id).SingleOrDefault();
            
            if(cursoAEliminar != null)
            {
                db.Remove(cursoAEliminar);
            }
            db.SaveChanges();
        }
    }

    public Curso? GetCurso(int id)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var cursoBuscado = db.Cursos.Where(c => c.Id == id).SingleOrDefault();
            return cursoBuscado;
        }
        
    }

    public Curso? GetCurso(string titulo)
    {
        using (var db = new InstitucionEducativaContext())
        {
            var cursoBuscado = db.Cursos.Where(c => c.Titulo == titulo).SingleOrDefault();
            return cursoBuscado;
        }
    }

    public List<Curso> GetCursos()
    {
        using (var db = new InstitucionEducativaContext())
        {
            List<Curso> lista = db.Cursos.ToList();
            return lista;
        }
    } 

    public List<Curso> GetCursosPorEstudiante(int estudianteId)
    {
        using (var db = new InstitucionEducativaContext())
        {
            List<Curso> lista = new List<Curso>();
            var inscripciones = db.Inscripciones.Where(i => i.EstudianteId == estudianteId);
            var inscripcionesIterables = inscripciones.ToList();
            foreach(var i in inscripcionesIterables)
            {
                Curso? curso = this.GetCurso(i.CursoId);
                if(curso is not null)
                {
                    lista.Add(curso);
                }
            }
            return lista;
        }
    }
}