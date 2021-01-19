using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    public class Gradebook
    {
        private string _name;
        private NameChangedEventArgs args;
        public event NameChangedDelegate NameChanged;
        public Gradebook(string name)
        {
            Name = name;
            Grades = new List<double>();
        }

        public string Name
        {
            get => _name;
            set
            {
                args.oldValue = _name;
                args.newValue = value;
                _name = value;
                NameChanged?.Invoke(this, args);
            }
        }

        public List<double> Grades { get; set; }
    }
}
