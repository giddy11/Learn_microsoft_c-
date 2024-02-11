namespace ClassLibrary2
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            var per = (Person)obj;
            if(this.Name == per.Name)
                return true;

            return false;
        }
    }
}
