using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class PersonManager:IApplicantService
	{

		// Bu yanlış kullanımdır sürdürülebilirsiliği yoktur.
		//bu kullanımda yeni bir eklemede program direkt patlar ve düzeltmemiz gereken bir sürü yer ortaya çıkar

		// public void ApplyForMask(string name,string lastname) { }
		//public void BaskaMethod() { ApplyForMask("mert",sargın); }



		//Encapsulation
		//Doğru kullanım SOLID e uygun
		public void ApplyForMask(Person person) { }
		public void BaskaMethod() { ApplyForMask(new Person()); }
		public bool CheckPerson(Person person) { return true; }

		public List<Person> GetList()
		{
			throw new NotImplementedException();
		}
	}
}
