namespace GenericLibrary
{
    internal class Class2
    {
    }

    public class Calculate<T>
    {
        public Calculate(T value)
        {
            _value = value;
        }
        public T GetValue()
        {
            return _value;
        }
        private T _value { get; set; }
    }
}
