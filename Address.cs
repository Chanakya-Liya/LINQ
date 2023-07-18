using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestFile
{
    internal class Address
    {
        public int id;
        public int PersonId;
        public string addressLine { get; set; }
        
        public Address(int id, int PersonId, string address)
        {
            this.id = id;
            this.PersonId = PersonId;
            this.addressLine = address;
        }

    }
}
