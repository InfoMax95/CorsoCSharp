using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsoCSharp
{
    internal class Studente : Persona
    {
        private string _corso;

        public Studente(string name, string surname, int age, string corso) : base(name, surname, age)
        {
            _corso = corso;
        }

        public override void Saluta()
        {
            Console.WriteLine($"Ciao sono uno studente e frequento il corso di {this._corso}");
        }
    }
}
