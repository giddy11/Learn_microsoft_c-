namespace EventsExample
{
    //public delegate void MyDelegateType3(int a, int b);
    public delegate int MyDelegateType3(int a, int b);

    public class Publisher
    {
        /*
        // private delegate
        private MyDelegateType3 _myDelegateType3;
        //create events
        public event MyDelegateType3 myEvent
        {
            add
            {
                _myDelegateType3 += value;
            }
            remove
            {
                _myDelegateType3 -= value;
            }
        }

        public void RaiseEvent(int a, int b)
        {
            //raise event
            if (_myDelegateType3 != null)
            {
                _myDelegateType3(a, b);
            }
        }
        */

        /*Auto implemented Events*/
        public event MyDelegateType3 MyEvent;

        public int RaiseEvent(int a, int b)
        {
            //raise event
            if (MyEvent != null)
            {
                return MyEvent(a, b);
            }
            return 0;
        }
    }
}
