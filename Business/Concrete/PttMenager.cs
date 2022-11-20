using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttMenager:ISupplierService
    {
        private IapplicantService _applicantService;
        public PttMenager(IapplicantService applicantService)
        { // constructor new yapıldığında çalışır

            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            PersonMenager personMenager = new PersonMenager();
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine ("MASKE VERİLMEDİ...!!!!!");   
            }
        }
    }
}
