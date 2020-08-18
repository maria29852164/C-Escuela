using cursos.Util;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace curso.Objetos
{
    public class Escuela
    {
        public string name { get; set; }
        public int años { get; set; }
        public List<Cursos> cursos;
        public Escuela(List<Cursos> cursos)
        {
            this.cursos = cursos;
        }
        public void Stamp()
        {
            Console.Beep(600, 3000);
        }
        public void AddCurso(Cursos cursonew)  {
            cursos.Add(cursonew);

        }
  
        public void deleteArray(Cursos value)
        {
            cursos.RemoveAll(item=>item.nameCurso=="Castellano"); 

        }
        public void GetCursos()
        {
            for(int i=0; i<cursos.Count; i++)
            {
                Console.WriteLine($"element {i}: {cursos[i].nameCurso}");
                Printer.message(20, "Alumnos");
                GetAlumno(cursos[i]);
                //for (int j = 0; j < cursos[i].alumnos.Count; j++)
                //{
                //    Console.WriteLine($" nombre : {cursos[i].alumnos[j].name} y apellido: {cursos[i].alumnos[j].lastname}");
                //}


            }
        }
        public void GetAsignaturas()
        {
            foreach(Cursos curso in cursos)
            {
                Printer.message(20, "Asignaturas");
                foreach (Asignatura asignatura in curso.asignaturas)
                {
                    
                    Console.WriteLine($" la asignatura para el curso es: {asignatura.nameAsignatura}\n");
                    GetEvaluaciones(asignatura.evaluaciones);

                    
                }
            }
        }
        public void GetEvaluaciones(List<Evaluaciones> evaluaciones)
        {
            Printer.message(20, "Evaluaciones");
            foreach(Evaluaciones eval in evaluaciones)
            {
                Console.WriteLine($" la evaluacion es : {eval.nameEvaluaciones}\n");
            }
        }
        
        public void GetAlumno(Cursos curso)
        {
            
            for (int j = 0; j < curso.alumnos.Count; j++)
            {
                Console.WriteLine($" nombre : {curso.alumnos[j].name} y apellido: {curso.alumnos[j].lastname}\n");
                Printer.message(20, $"notas del alumno {curso.alumnos[j].name}");
                GetNotas(curso.alumnos[j]);
                
            }

        }
        public void GetNotas(Alumno alumno)
        {
         foreach(Evaluaciones eval in alumno.evaluaciones)
            {
                Console.WriteLine($" en la evaluacion: {eval.nameEvaluaciones} su nota fue : {eval.nota}");
            }   
        }
      


    }
}
