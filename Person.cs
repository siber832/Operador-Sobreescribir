using System;

namespace sobreescribirOperador {
    public class Person {

        private String name;
        private String surname;
        
        public Person(String name, String surname) {
            this.name = name;
            this.surname = surname;
        }
        public Person(String name) : this(name, "") {}
        
        public override bool Equals(System.Object ob) {
            if (ob.GetType() == this.GetType()) {
                Person p = (Person) ob;
                return (name == p.name) && (surname == p.surname);
            } else {
                return false;
            }
        }

        public static bool operator == (Person a, System.Object b) {
           return Person.Equals(a, b);
        }

        public static bool operator != (Person a, System.Object b) {
            return !Person.Equals(a, b);
        }

        public static String operator + (Person a, Person b) {
            return String.Concat(a.name, b.name);
        }
    }
}