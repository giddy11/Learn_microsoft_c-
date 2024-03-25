namespace EventsExample
{
    public class ActionClass
    {
        public event Action<int, int> myEvent;

        public void RaiseEvent(int a, int b)
        {
            //raise event
            if (myEvent != null)
            {
                myEvent(a, b);
            }
        }
    }
}
