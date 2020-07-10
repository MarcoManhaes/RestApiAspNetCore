using RestApiAspNetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiAspNetCore.Services
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        
        Person FindById(int id);
        
        List<Person> FindAll();
        
        Person Update(Person person);

        void Delete(int id);
    }
}
