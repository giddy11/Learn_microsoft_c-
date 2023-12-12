**Records**
They are intended for scenarios where you want to have immutable objects. They don't have to be immutable or unchangeable,
but they can. Used as maybe a data object meaning you're passing it between service layers or btw application layers, and it's primarily
about creating an object with  state and passing it around.
it can have inheritance, struct


**Value Types**
They can implement interfaces but can't have a base class
They only derive from value type


**Init**
This can only be set with the value changed when initialized


**Reference Type**
Reference types are types that don't directly contain their data but instead store a reference (memory address) to the location 
where the data is stored. This means that when you assign a reference type to another variable, you're essentially creating a reference 
to the same underlying data. Changes made through one reference affect all references pointing to the same data.

Class Types: Objects of user-defined classes are reference types.
public class MyClass
{
    // class members
}

MyClass obj1 = new MyClass();
MyClass obj2 = obj1; // obj2 now references the same object as obj1


Interface Types: Interfaces are reference types.
public interface IMyInterface
{
    // interface members
}

IMyInterface obj1 = new SomeClass(); // assuming SomeClass implements IMyInterface
IMyInterface obj2 = obj1; // obj2 now references the same object as obj1


Delegate Types: Delegates are reference types.
public delegate void MyDelegate();

MyDelegate del1 = SomeMethod;
MyDelegate del2 = del1; // del2 now references the same delegate as del1

Array Types: Arrays in C# are reference types.
int[] array1 = { 1, 2, 3 };
int[] array2 = array1; // array2 now references the same array as array1

Reference types are typically used when you want to work with shared or mutable data. Keep in mind that when you pass a reference 
type to a method, you are passing a reference to the object, not a copy of the object, 
which can affect the behavior of your code.