using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    public class Gradebook
    {
        private string _name;
        public NameChangedDelegate NameChanged;
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
                string old = _name;
                _name = value;
                NameChanged?.Invoke(old, _name);
            }
        }

        public List<double> Grades { get; set; }
    }
}
