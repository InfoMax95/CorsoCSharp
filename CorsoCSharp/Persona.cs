using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsoCSharp
{
    internal class Persona
    {
        private string _name;
        private string _surname;
        private int _age;
        // per poter settare a null le variabili serve mettere il punto interrogativo dopo il tipo
        private string? _email = null;
        private string? _phone = null;
        private string? _address = null;
        private string? _city = null;

        // dichiaro il costruttore
        public Persona(string name, string surname, int age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
        }
        
        // dichiaro il metodo saluta, virtual serve per poter sovrascrivere il metodo in una classe derivata
        public virtual void Saluta()
        {
            Console.WriteLine($"Ciao mi chiamo {this._name} {this._surname} e ho {this._age} anni");
        }


    }
}
