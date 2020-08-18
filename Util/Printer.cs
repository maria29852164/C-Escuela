
using System;

namespace cursos.Util
{
    public static class Printer
    {
        public static void Line(int Tam=17)
        {
            string message = "".PadLeft(Tam, '=');
            Console.WriteLine(message);
        }
        public static void message(int tam,string msg="Cursos")
        {
            string mess = "".PadLeft(tam, '=') + msg + "".PadRight(tam, '=');
            Console.WriteLine(mess);
            
        }
        
    }
}