using RestWithASPNET.Model;
using RestWithASPNET.Service;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
           List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }
        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Vandi",
                LastName = "Moreno",
                Address = "Rua jasmin - SP",
                Gender = "Female"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LasName" + i,
                Address = "Some Address" + i,
                Gender = "Female"
            };
        }
        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
    
}
