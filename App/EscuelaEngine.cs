using curso.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace cursos.Engine
{
    public class EscuelaEngine
    {
        public Escuela escuelaPrimary { get; set; }
        public EscuelaEngine()
        {

        }
        public List<Cursos> Courses()
        {
            Cursos curso1 = new Cursos()
            {
                nameCurso = "septimo",
                jornada = TipoJornada.Tarde
            };
            Cursos curso2 = new Cursos()
            {
                nameCurso = "quinto",
                jornada = TipoJornada.Mañana

            };
            List<Cursos> cursosList = new List<Cursos>()
            {
                curso1,curso2
            };
            Random random = new Random();
            foreach (Cursos curso in cursosList)
            {
                int numeroAleatorio = random.Next(2, 25);
                int asignaturas = random.Next(5, 12);

                curso.asignaturas = CargarAsignaturas(asignaturas);
                curso.alumnos = CargarAlumnos(numeroAleatorio);
                foreach (Asignatura asig in curso.asignaturas)
                {

                    CargarEvaluacionesEnAlumnos(asig.evaluaciones, curso.alumnos);

                }

                
            }
            {

            }

            return cursosList;






        }
     
       
        public void CargarEvaluacionesEnAlumnos(List<Evaluaciones> evaluaciones,List<Alumno> alumnos)
        { 
            foreach(Alumno al in alumnos)
            {
              
                al.evaluaciones = CargarNotasEnEvaluaciones(evaluaciones);
            }
        }
         public List<Evaluaciones> CargarNotasEnEvaluaciones(List<Evaluaciones> evaluaciones)
        {
            Random rnd = new Random();
           
            foreach(Evaluaciones eval in evaluaciones)
            {
                eval.nota =(float)( rnd.NextDouble()*5);
            }
            return evaluaciones ;
        }
        public List<Asignatura> CargarEvaluacionesEnAsignaturas(List<Asignatura> asignaturas)
        {
            
            foreach(Asignatura asig in asignaturas)
            {
                asig.evaluaciones = CargarEvaluaciones();   
            }
            return asignaturas;
        }
      
       
        public List<Evaluaciones> CargarEvaluaciones()
        {
            string[] evaluaciones= { "Exposicion", "Debate", "Prueba Escrita I", "Prueba Escrita II", "Examen",
                "Analisis","Defensa" ,"Trabajo Escrito","Infografia"};

            var listEvaluaciones = from eval in evaluaciones select new Evaluaciones() { nameEvaluaciones = eval };
            return orderByEvaluaciones(listEvaluaciones);
        }
       
        public List<Evaluaciones> orderByEvaluaciones(IEnumerable<Evaluaciones> evaluaciones)
        {
            Random rnd = new Random();
            return evaluaciones.OrderBy(eval => eval.idEvaluaciones).Take(rnd.Next(5, 8)).ToList();
        }
        public List<Alumno> orderByAlumnos(IEnumerable<Alumno> listAlumnos, int cant)
        {
            return listAlumnos.OrderBy(alumno => alumno.idAlumno).Take(cant).ToList();
        }
        
        public List<Asignatura> CargarAsignaturas(int cant)
        {
            string[] asignaturas = {"matematica","castellano","historia","deporte","geografia","biologia","ciencias",
                "quimica","fisica","valores","contabilidad"};
            var listAsignaturas = from asignatura in asignaturas select new Asignatura() { nameAsignatura=asignatura};
            return  CargarEvaluacionesEnAsignaturas(orderAsignatura(listAsignaturas,cant));

        }
        public List<Asignatura> orderAsignatura(IEnumerable<Asignatura> EnumerableAsignatura,int cant)
        {
            return EnumerableAsignatura.OrderBy(asig => asig.idAsignatura).Take(cant).ToList();
        }
        public List<Alumno> CargarAlumnos(int cant)
        {
            string[] nombres = { "Maria", "Luis", "Diego", "Marcos", "Jesus", "Matias", "Teresa","Pablo","Juan","Omar" };
            string[] apellidos = { "Ramirez", "Guerrero", "Porras", "Mendez", "Martinez", "Carbajal", "Contreras" };
            var listAlumnos = from n in nombres
                              from a in apellidos
                              select new Alumno()
                              {
                                  name=n,
                                  lastname=a
                              };
            
            return orderByAlumnos(listAlumnos,cant);


        }
      
        public void Inicializa()
        {
            var courses = Courses();
            escuelaPrimary = new Escuela(courses)
            {
                name="platzi course",
                años=34
            };


        }
    }
}