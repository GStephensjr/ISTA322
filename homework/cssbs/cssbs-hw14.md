# Name: cssbs-hw14
### Author: Greg Stephens
#### Date: 12 August 2019

##### 1. What is the difference between a managed resource and an unmanaged resource?
From what I understand managed resources are "pure," from the CLR
- unmanaged resources are what operate outside of that and they need to be dropped for disposal.

##### 2. When is memory for an object (reference type) allocated? When is the memory deallocated?
When you create the new object using the new keyword a chunk of raw memory is carved out of the heap. The memory is deallocated once the object is out of scope. You can do this yourself with a destructor.

##### 3. What is a destructor?
It is a special method of a class that is used to destroy the object or instance of a class when it is no longer needed.

##### 4. What is the difference in syntax between a constructor and a destructor?
The tilde(~) followed by the name of the class is the symbol for a destructor. Also the constructor is in the beginning when an instance of a class is created versus the destructor which comes at the end when the object or instance is no longer needed.

##### 5. Give some examples of scarce resources. Why would you want to manage scarce resources?
Memory and database connections, you need to manage this because they are too valuable to be sitting around waiting for a macchine to release them.

##### 6. What is exception-safe disposal?
It is a way of ensuring that objects are disposed of at the end of a block of code even if an exception is thrown.

##### 7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.
It provides a way to ensure that the object is disposed of once the using block finishes so you don't have to worry about accidentally accessing it later in your code.

##### 8. What ill effects could result from attempting to dispose of a resource more than once?
You don't always know when the GC is going to run on it's own and if you call a dispose method and they run simultaneously you can lose data and application performance as an example.

##### 9. We look at threads later on in the term. For now what is your understanding of how threads interact with resource management? A good guess is a sufficient answer to this question.
Threads are paths executing code that can run concurrently while you work or on an application. The GC is one of them. It can run as long as the last reference has disappeared while the application or code is still executing forward.

##### 10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?
It seems that according to the book you run the risk of losing data, memory, you can compromise the logical integrity of your application. It doesn't seem that there is an exception but the book did mention about using lock to implement overloaded versions of the dispose method.
