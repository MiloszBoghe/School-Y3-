using System;

namespace Lab
{
    class Program
    {
        public delegate void Flip();
        static void Main(string[] args)
        {
            //ex1
            var lightbulb = new LightBulb();
            var switch1 = new Switch();
            Flip flip = switch1.Flip(lightbulb);
            flip();
            flip();
            
            //ex2
            var switch2 = new Switch();

        }
    }
}
