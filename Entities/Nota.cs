using System;
using System.Collections.Generic;
namespace curso.Objetos
{
    public class Notas
    {
        public string idNota { get; private set; }
        public double nota { get; set; }
        public Notas() => idNota = Guid.NewGuid().ToString();
    }
}