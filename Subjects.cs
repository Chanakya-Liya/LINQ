using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestFile
{
    internal class Subjects
    {
        public int id;
        public int PersonId;
        public string subjectName { set; get; }
        public int marks;

        public Subjects(int id, int PersonID, string subjectName, int marks)
        {
            this.id = id;
            this.PersonId = PersonID;
            this.subjectName = subjectName;
            this.marks = marks;
        }
    }
}
