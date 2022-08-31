using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsoCSharp
{
    internal class Operation
    { 
        public ArrayList negNumbers = new ArrayList();
        public int Sum(int[] numbers)
        {
            // proviamo operatori logici con cicli
            int sum = 0;
            foreach(int number in numbers)
            {
                if (number >= 0) sum += number;
                else negNumbers.Add(number);  
            }
            return sum;
        }
    }
}
