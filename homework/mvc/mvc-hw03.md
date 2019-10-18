### Title: mvc-hw03
#### Author: Greg Stephens
#### Date: 21 Aug, 2019
###### Read chapter 3, pages 51 – 66 in the Pro ASP.NET MVC 5 book.
___
##### 1. The book states, “Interactions with an MVC application follow a natural cycle of user actions and view updates, where the view is assumed to be stateless.” What does it mean for the view to be stateless?
- Means that every request sent it is treated as it's own individual request there are no relations between even two successive requests


##### 2. The book identifies two kinds of models. Briefly desdribe each of them.
- View Models which just represent data passed from the controller to the view, and Domain Models which contain the data in a businessdomain along with the operations, transformations, and rules for creating, storing, and manipulating that data, collectively referred to as the model logic.

##### 3. Give an example of separation of concerns from your own life experience. This should be a simple, everyday example.
I separate the data from my bills by priority, first go the big three: food, mortgage, vehicles. Then come the utilities and cellphone, then come what I call the luxuries little league, cheerleading, gym membership, going out, etc. I encapsulate the different priorities and they are completely independent of eachother the big three get paid first no matter what data presents itself from the other bills.

##### 4. What is a view engine?
A view engine for MVC specifically is Razor but what it does is it presents the end product that we see on the interface.

##### 5. The book notes that the three-tier structure, or n-tier model, is “the most widely used pattern for business applications.” Why do you think that this is true? An answer like, “Because it works well,” is not a sufficient answer to this question.
Because it is a way for the customers whoever they may refer to in that instance can send requests which go through the model to the data access layer and then get sent back to the user interface without being overly complicated, which to me says that from a business aspect for implementation, training, and customer usability this is the optimal program.

##### 6. This question requires some outside research. When we study UWP, you will see that the UWP design pattern is the Model-View-ViewModel (MVVM). What is the difference between MVC and MVVM that makes the first good for ASP.NET MVC and the second good for UWP?
Unlike the MVC method, the ViewModel isn’t a controller. It instead acts as a binder that binds data between the view and model.
Whereas the MVC format is specifically designed to create a separation of concerns between the model and view, the MVVM format with data-binding is designed specifically to allow the view and model to communicate directly with each other.

##### 7. Describe the two parts of the dependency injection (DI) design pattern.
You have the client object, dependency resolver. The client wants something for a specific instance rather than create it, it asks for it uses it and diregards it the dependency resolver decides what it needs.

##### 8. Give an example of loose coupling from your own life experience. This should be a simple, everyday example.
when i was in the unit, my boss mike and i had a routine worked out where we completed separate objectives that coincided with the same projects

##### 9. What are the two types of testing discussed in the book?
Black Box Testing is a software testing method in which the internal structure/ design/ implementation of the item being tested is NOT known to the tester. White Box Testing is a software testing method in which the internal structure/ design/ implementation of the item being tested is known to the tester.

##### 10. What are the seven steps of the test driven development (TDD) workflow, as stated in the book?
- Before writing any code, devise a use case for the part of the software that you are building.
- Write the unit test for your use-case.
- Write only enough code to cause the test to pass, and no more than that.
- Write a test for the next use case in the same manner as the first test case.
- Write only enough code to cause all existing tests, and your newest test to pass, and no more than that.
- Refactor your code to clean up your code base as needed.
- Repeat steps 4-6 until the story you are working on is complete.
