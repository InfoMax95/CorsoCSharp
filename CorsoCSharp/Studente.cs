using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsoCSharp
{

    // creo la classe studente ed estendo da persona 
    internal class Studente : Persona
    {
        private string _corso;

        // nel costruttore è necessario inserire :base per potergli fare ereditare le proprietà
        public Studente(string name, string surname, int age, string corso) : base(name, surname, age)
        {
            _corso = corso;
        }

        // con override sovrascrivo il metodo Saluta
        public override void Saluta()
        {
            base.Saluta();
            Console.WriteLine($"Ciao sono uno studente e frequento il corso di {this._corso}");
        }
    }
}
