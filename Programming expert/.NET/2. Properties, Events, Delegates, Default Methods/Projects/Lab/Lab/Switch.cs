using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class Switch
    {
        public bool IsOn { get; set; }

        public void Flip(LightBulb lightBulb)
        {
            lightBulb.IsOn = !lightBulb.IsOn;
            IsOn = !IsOn;
            if (IsOn) Console.WriteLine("The lightbulb switches on.");
            if (!IsOn) Console.WriteLine("The lightbulb switches off.");
        }
    }
}
