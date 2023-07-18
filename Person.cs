using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestFile
{
    internal class Person
    {
        public int id;
        public string fName { get; set; }

        public string lName { get; set; }
        public int age { get; set; }

        public Person(int id, string name, string lName, int age)
        {
            this.id = id;
            this.fName = name;
            this.lName = lName;
            this.age = age;
        }

        public Person() { }


    }
}
