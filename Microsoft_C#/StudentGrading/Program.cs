

// create object of sample class
using DelegateExample;
using EventsExample;

var s = new Class1();

//create delegate object or delegate and add method reference to delegate
//MyDelegateType myDelegate = new MyDelegateType(s.Add); //Or
MyDelegateType myDelegate = s.Add;


//invoke method using delegate object
myDelegate.Invoke(3, 4);

Console.WriteLine("Multi cast delegate");

var s2 = new Class2();

MyDelegateType2 myDelegateType2 = s2.Add;
myDelegateType2 += s2.Multiply;

//myDelegateType2.Invoke(23, 45);


//Events
var pub = new Publisher();
var sub = new Subscriber();

//handle the event or subscribe to event
//pub.MyEvent += sub.Add;
//pub.MyEvent += delegate (int a, int b)
//{
//    Console.WriteLine(a + b);
//};

//pub.MyEvent += (a, b) =>
//{
//    return a + b;
//};

pub.MyEvent += (a, b) => a + b;

//invoke the event
Console.WriteLine(pub.RaiseEvent(23, 4));