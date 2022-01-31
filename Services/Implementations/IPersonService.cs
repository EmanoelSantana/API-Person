using RestWithAspNet.Models;
using System.Collections.Generic;

namespace RestWithAspNet.Services.Implementations
{
    public interface IPersonService
    {
        Person create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void delete(long id);
    }
}
