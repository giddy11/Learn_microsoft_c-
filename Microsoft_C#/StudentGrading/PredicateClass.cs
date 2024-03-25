namespace COnsole
{
    public class PredicateClass
    {
        public Predicate<int> myEvent;

        public bool RaiseEvent(int a)
        {
            //raise event
            if (myEvent != null)
            {
                bool result = myEvent(a);
                return result;
            }
            return false;
        }
    }
}
