using System;

namespace DelegateExample
{
    class Program
    {
        //public delegate void Write(string message);
        static void Main(string[] args)
        {
            Gradebook book = new Gradebook("Punten van Floor");
            book.NameChanged += OnNameChanged;
            book.Name = "Punten van Sofie";
            book.NameChanged += OnNameChanged2;
            book.Name = "Punten van Lieven";

            //var logger = new Logger();
            //var write = new Write(logger.Log);
            //Write write = logger.Log;
            //write += Call;
            //write("test");
        }

        static void OnNameChanged(string oldValue, string newValue)
        {
            Console.WriteLine($"Name changed from {oldValue} to {newValue}");
        }
        static void OnNameChanged2(string oldValue, string newValue)
        {
            Console.WriteLine($"Name changed from {oldValue} to {newValue}");
        }
        static void Call(string message)
        {
            Console.WriteLine($"Call: {message}");
        }
    }
}
