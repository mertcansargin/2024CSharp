using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Person
	{
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public DateTime BornDate { get; set; }
        public DateTime DieDate { get; set;}
        public string City { get; set; }

    }
}
