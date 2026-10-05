using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Lights turned on");
        }

        public void Off()
        {
            Console.WriteLine("Lights turned off");
        }

        public void Dim(int value)
        {
            Console.WriteLine("Lights are dimmed");
        }
    }
}
