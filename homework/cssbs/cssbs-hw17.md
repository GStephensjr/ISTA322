### Title: cssbs-hw17
#### Author: Greg Stephens
#### Date: 20 Aug, 2019
###### Read chapter 17, pages 369 – 398 in the C# Step by Step book.
___
##### 1. What is a type parameter?
a type parameter is a placeholder for a specific type that a client specifies when they create an instance of the generic type

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-type-parameters
##### 2. What does a type parameter do?
- type parameters specify the types of the objects they operate on. Class is an example of a generic parameter type.

- generates a new class specialized under the type specified


##### 3. How many type parameters can a generic class have?
depends on your memory

##### 4. What is the difference between a generic class and a generalized class?
- generic class only uses type parameters that are specified by the user
- a generalized class is designed to take parameters that can be cast to different types.

pg. 387

##### 5. What is a constraint? How do you specify a constraint?
    public class PrintableCollection<T> where T : IPrintable

##### 6. What is a generic method? How do you define a generic method?
- a method that defers the parameter data type until the method is called
- public class PrintableCollection<T> where T : IPrintable

##### 7. What do we mean when we cay that a generic type interface is invariant?
pg. 404:

This code compiles but will fail at runtime with an InvalidCastException exception. The problem is that although all strings are objects, the converse is not true. If this statement were allowed, you could write code like this, which ultimately attempts to store a Circle object in a string field:

    IWrapper<object> storedObjectWrapper = (IWrapper<object>)stringWrapper;
    Circle myCircle = new Circle();
    storedObjectWrapper.SetData(myCircle);

The `IWrapper<T>` interface is said to be invariant. You cannot assign an `IWrapper<A>` object to a reference of type `IWrapper<B>`, even if type A is derived from type B. By default, C# implements this restriction to ensure the type safety of your code.

##### 8. What do we mean when we cay that a generic type interface is covariant?
Covariance permits a method to have a more derived return type than that defined by the generic type parameter of the interface.

##### 9. Does covariance work with value types? Does it work with reference types?
Variance in generic interfaces is supported for reference types only. Value types do not support variance.

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/variance-in-generic-interfaces

##### 10. What do we mean when we cay that a generic type interface is contravariant?
Contravariance permits a method to have argument types that are less derived than that specified by the generic parameter of the interface
