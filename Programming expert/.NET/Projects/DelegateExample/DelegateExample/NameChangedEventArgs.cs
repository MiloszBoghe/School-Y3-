using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    public class NameChangedEventArgs
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }
}
