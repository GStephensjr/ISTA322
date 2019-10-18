### Title: mvc-hw04
#### Author: Greg Stephens
#### Date: 21 Aug, 2019

###### Read chapter 4, pages 67 – 94 in the Pro ASP.NET MVC 5 book.
___
##### 1. Using automatic properties is a shortcut that avoids several explicit steps. List the steps that the use of automatic properties avoids.
- allows an initial value to be set without using a constructor
- This feature allows me to define properties without having to implement the get and set bodies. Using the auto-implemented property feature means that defining a property

##### 2. Using the object initializer syntax is a shortcut that avoids several explicit steps. List the steps that the use of object initializers avoids.
- Without this feature, I would have to call the Product constructor and then use the newly created object to set each of the properties


##### 3. What is the purpose of creating extension methods?
Extension methods are a convenient way of adding methods to classes that you do not own and cannot
modify directly, like if it were from a third party and i didnt have the source code or it were part of the system.

##### 4. What is the one feature of extension methods that will always allow you to identify a method as an extension method?
"this" keyword pg. 86

##### 5. How do you create an extension method that filters the results returned by the method on a user specified criterion?
use the yield keyword to apply selection criteria to items in the source data to produce a reduced set of
results pg 88-89

##### 6. Explain the syntax of a lambda expression. The term “lambda expression” originates in the lambda calculus developed by the mathematician Alonzo Church in the 1930’s. There is a class of programming languages that are based on the fundamental ideas of lambda calculus.
a lambda expression can have either:
- an expression as its body

`(input-parameters) => expression`

- a statement block as its body

`(input-parameters) => { <sequence-of-statements> }`


##### 7. This will require some outside research. What is the distinction between an anonmously typed variable and a dynamically typed variable?
https://stackoverflow.com/questions/391529/anonymous-type-vs-dynamic-type

- An anonymous type is a real, compiler-generated type that is created for you. The good thing about this is that the compiler can re-use this type later for other operations that require it as it is a POCO.
- My understanding of dynamic types is that they are late-bound, meaning that the CLR (or DLR) will evaluate the object at execution time and then use duck typing to allow or disallow member access to the object.

##### 8. You are having a discussion about C# with a friend of yours that uses another language. You are telling him about C#’s LINQ library. How would you describe to him the difference between LINQ’s SQL-like notation and LINQ’s dot notation?
- query expression notation is that sql-like notation that reads more like english. it mirrors a lot of what you would see in sql server
- dot notation looks a lot more like classic C# notation where the origin of your objects and parameters are notated as objects from different classes

you can see the difference here:

    SomeDataContext dc = new SomeDataContext();

    var queue = from q in dc.SomeTable
            where q.SomeDate <= DateTime.Now && q.Locked != true
            orderby (q.Priority, q.TimeCreated)
            select q;

    var queue2 = dc.SomeTable
            .Where( q => q.SomeDate <= DateTime.Now && q.Locked != true )
            .OrderBy(q => q.Priority)
            .ThenBy(q => q.TimeCreated);

https://stackoverflow.com/questions/630045/linq-dot-notation-vs-query-expression

##### 9. What, exactly, does the await keyword do?
The await operator is applied to a task in an asynchronous method to insert a suspension point in the execution of the method until the awaited task completes. The task represents ongoing work. await can only be used in an asynchronous method modified by the async keyword.

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/await



##### 10. What is the connection between await and the async keywords?

await can only be used in an asynchronous method modified by the async keyword.

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/await
