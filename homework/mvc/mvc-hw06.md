### Title: mvc-hw06
#### Author: Greg Stephens
#### Date: 28 Aug, 2019

###### Read chapter 6, pages 119 – 154 in the Pro ASP.NET MVC 5 book.
___
##### 1. What is the primary idea that underlies Dependency Injection?
dependency injection allows the controller constructor to access the application's repository through the interface without having any need to know which implementation class has been configured

the idea behind inversion of control is that, rather than tie the classes in your application together and let classes “new up” their dependencies, you switch it around so dependencies are instead passed in during class construction
http://www.siddharthpandey.net/use-ninject-for-dependency-injection-in-asp-net-mvc-application/
##### 2. Describe the role of interfaces in implementing a dependency injection container.
the constructor accesses the repositories using the interface

##### 3. List the three stages of building basic Ninject functionality, and briefly define each stage.
http://codeclimber.net.nz/archive/2009/02/05/how-to-use-ninject-with-aspnet-mvc/
1. you need to register the controller factory with the application
  - `ControllerBuilder.Current.SetControllerFactory(typeof(NinjectControllerFactory));` in the service module class
2. you need to configure the IoC container for all your controllers and dependencies
  - you have to configure each controller, specifying under which condition the given class should be initialized
3. you need to initialize the container
  - the setup goes into the Global.asax.cs file of your application, and you need to provide the configuration inside the method `CreateKernel`

##### 4. What is the purpose of a custom dependency resolver?
- It allows you to abstract away from Dependency Injection implementation. Later if you decide to switch from Unity to Windsor, you can do it much easier without having to re-write lots of code
- It means that you can resolve your instances using this code:

        DependencyResolver.Current.GetService<IMyController>();

##### 5. What is the purpose of conditional binding? Describe how it works.
conditional bindings specify which classes the kernel should use to respond to requests for particular interfaces

##### 6. Why is setting the object scope important when using dependency injection?


##### 7. Briefly describe the Test Driven Development approach in developing an application.
an application feature is written and then tested to make sure it works as required. This is popular because most developers think about application code first and testing comes second

##### 8. Consider the Assert class. How do you access the methods of that class?
usint the "that" property

##### 9. Why is it useful to mock objects when developing software?
mock objects are useful to test functions that are dependent on other functions or objects that havent been written yet. the mock object resembles what the function will eventually be working with

##### 10. Briefly describe the two main issues that arise when attempting to do Unit Tests without the aid of some sort of mocking library
in order to use fake objects to test your equipment, you have to make them every time you test a functions
