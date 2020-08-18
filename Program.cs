using curso.Class;
using curso.Objetos;
using cursos.Engine;
using cursos.Util;
using System;
using System.Collections.Generic;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            EscuelaEngine engine = new EscuelaEngine();

            engine.Inicializa();
            Printer.Line(80);
            Printer.message(20);
           engine.escuelaPrimary.GetCursos();
            engine.escuelaPrimary.GetAsignaturas();
            
           
           
        }
    }
    class Publicador
    {
        public delegate void Delegado(string nameEvent);
        public  event Delegado Evento;
        public void Sumar(int a ,int b)
        {
            if(Evento!=null)
            Console.WriteLine($"la suma es : {a + b}");
        }
    }
    class Susbcriptor
    {
        public int A, B;
        public Publicador pub;
        public void EventoaPasar(string name="nameEvent")
        {
            Console.WriteLine($"hola este es el handlerEvent {name}");
        }
        public Susbcriptor(int a, int b)
        {
            pub = new Publicador();
            A = a;
            B = b;
            pub.Evento += EventoaPasar;


            
        }
        public void SumarSub()
        {
            pub.Sumar(A,B);
        }
    }
    

}
