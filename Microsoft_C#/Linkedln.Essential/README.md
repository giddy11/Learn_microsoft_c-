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


Classes:

Reference Types: Objects created from classes are reference types. When you pass a class instance to a method or assign it to another variable, you're dealing with references to the same underlying object.
Heap Allocation: Class instances are allocated on the heap, and they are garbage-collected when no longer referenced.
Mutable: By default, classes are mutable, meaning their state can be modified after creation unless explicitly marked as readonly or using other mechanisms.
Example:

public class MyClass
{
    // Class members and methods
}

MyClass obj = new MyClass();
Structs:

Value Types: Structs are value types. When you pass a struct to a method or assign it to another variable, you're working with a copy of the data, not a reference to the same instance.
Stack Allocation: Struct instances are usually allocated on the stack, providing better performance than heap-allocated reference types.
Immutable by Default: Structs are implicitly immutable unless members are explicitly marked as readonly.
Example:

public struct MyStruct
{
    // Struct members and methods
}

MyStruct obj = new MyStruct();
Records (Introduced in C# 9.0):

Value Types: Records are also value types, like structs.
Immutability: Records are designed to be immutable by default. They provide concise syntax for declaring read-only properties and automatically implement value-based equality.
Semantic Equality: Records compare their values rather than references, making it easier to work with immutable data structures and ensuring proper behavior with deconstruction and pattern matching.
Example:

public record MyRecord
{
    // Record properties
}

MyRecord obj = new MyRecord();


In summary, classes are reference types, structs are value types, and records are a special kind of value type introduced in C# 9.0 that emphasizes immutability and provides concise syntax for declaring types that are primarily used to store data. The choice between them depends on the specific requirements and characteristics of the data you're modeling.