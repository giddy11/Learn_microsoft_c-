using Essential.Learning2.Generics;

namespace DefiningGenerics
{
    public class CustomerToPersonMapper : IMapper<Customer, Person>
    {
        public Person Map(Customer source)
        {
            return new Person
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName
            };
        }
    }
}
