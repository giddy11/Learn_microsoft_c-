namespace EventsExample
{
    public class FuncClass
    {
        public event Func<int, int, int> myEvent;

        public int RaiseEvent(int a, int b)
        {
            //raise event
            if (myEvent != null)
            {
                return myEvent(a, b);
            }
            return 0;
        }
    }
}
