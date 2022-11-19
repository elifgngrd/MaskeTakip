using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IapplicantService
    {
         void ApplyForMask(Person person)
       {


        }
        List<Person> GetList()
        {
            return null;
        }

        bool CheckPerson(Person person)
        {
            return true;
        }
    }
}
