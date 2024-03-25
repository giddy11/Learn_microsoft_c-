namespace COnsole
{
    public class EventHandlerClass : EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public class PublisherEvent
    {
        public event EventHandler<EventHandlerClass> myEvent;

        public void RaiseEvent(object sender, int a, int b)
        {
            //raise event
            if (myEvent != null)
            {
                EventHandlerClass eventHandlerClass = new EventHandlerClass() { a = a, b = b };
                myEvent(sender, eventHandlerClass);
            }
        }

        public void DoWork()
        {
            var eventHandPub = new PublisherEvent();

            eventHandPub.myEvent += (sender, e) =>
            {
                Console.WriteLine(e.a + e.b);
            };
            eventHandPub.RaiseEvent(this, 4, 5);
        }
    }
}
