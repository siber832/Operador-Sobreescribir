using System;

namespace sobreescribirOperador {
    class Program {
        static void Main(string[] args) {
            Person person1 = new Person("pepe");
            Person person2 = new Person("juan");
            Console.WriteLine(person1 == person2);
            person1 = new Person("juan");
            Console.WriteLine(person1 == person2);
            Console.WriteLine(String.Concat("Prueba de suma: ", person1 + person2));
        }
    }
}