### Title: mvc-hw05
#### Author: Greg Stephens
#### Date: 27 Aug, 2019

###### Read chapter 5, pages 95 – 118 in the Pro ASP.NET MVC 5 book.
___
##### 1. What is a view engine?
a component used to produce the content sent to clients

##### 2. What is Razor?
The default view engine is called Razor, and it processes annotated HTML files for instructions that insert dynamic content into the output sent to the browser.

##### 3. What do views do? List two specific things in your answer to this question.
View is a user interface. View displays data from the model to the user and also enables them to modify the data
https://www.tutorialsteacher.com/mvc/mvc-view
##### 4. How does Razor respond when it encounters statements that begin with the at character (@)? Be specific.
Razor uses the @ symbol to transition from HTML to C#. Razor evaluates C# expressions and renders them in the HTML output
https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-2.2
##### 5. How does Razor respond when it encounters statements that begin with the at character followed by the colon (@:)? Be specific.
the @: symbol pulls you out of a code block to print plain ascii text
https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-2.2
##### 6. Describe how you implement a standard formatting for all pages in an ASP.NET application.
you would define a layout page that contains the markup for all of your pages to keep a consistent look
https://docs.microsoft.com/en-us/aspnet/web-pages/overview/getting-started/introducing-aspnet-web-pages-2/layouts

##### 7. What is the difference in using Razor to interpolate data values as stand-alone HTML elements and as attributes to HTML elements. What is the similarity?


##### 8. What is a view start file and where is it located?
a view start file is generally located in the views folder. its a cshtml file that contains code that needs to run before each page or full view
https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout?view=aspnetcore-2.2
##### 9. What is a Razor code block? What is the syntax of a Razor code block?
a razor code block is a block of code embedded in html within a razor view with the syntax @mycodehere

##### 10. Describe the different roles of action methods and views.


##### 11. Describe the use of the @using statement. Give an example of how you would use it.
an @using statement brings the view of a particular page into scope, allowing you to use the methods and values within.
a good example of this would be the models brought into scope for an html page or a layout implemented to format all of your pages
