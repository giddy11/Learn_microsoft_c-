

// create object of sample class
using DelegateExample;

var s = new Class1();

//create delegate object or delegate and add method reference to delegate
MyDelegateType myDelegate = new MyDelegateType(s.Add);

//invoke method using delegate object
myDelegate.Invoke(3, 4);