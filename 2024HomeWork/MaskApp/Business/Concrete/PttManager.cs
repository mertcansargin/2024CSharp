using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class PttManager:ISupplierService
	{
		private IApplicantService _applicantService;
		  
		public PttManager(IApplicantService applicantService)//constractor new yapıldığında çalışır
		{
			_applicantService = applicantService;
		}
		public void GiveMask(Person person)
		{

			PttManager pttManager = new PttManager(new PersonManager());
			if (personManager.CheckPerson(person)) 
			{
				//ekrana yazıldı verildi diye
			}
		}
	}
}
