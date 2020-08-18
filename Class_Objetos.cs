
using System;
namespace curso.Class
{
	public class School
	{
		public string name { get; set; }
		public string address { get; set; }
		public School()
		{
		}
		public void Stamp(int hz,int duration)
        {
			Console.Beep(hz, duration);
        }

	}
}
