## Title: mvc-hw02
### Author: Greg Stephens
### Date: 14 Aug, 2019
###### Read chapter 2, pages 11 – 50 in the Pro ASP.NET MVC 5 book.
##### 1. Describe what a controller does in the MVC design pattern.
In the MVC pattern, incoming requests are handled by controllers. In ASP.NET Core MVC, controllers are just C# classes (usually inheriting from the Microsoft.AspNetCore.Mvc.Controller class, which is the built-in MVC controller base class). Each public method in a controller is known as an action method, meaning you can invoke it from the Web via some URL to perform an action.

##### 2. What is the ASP.NET MVC convention in naming controllers? What does HomeController.cs do?
when you see a file called HomeController.cs, you know that it contains a controller called Home, which is the default controller that is used in MVC applications.

##### 3. What is the name of the routing configuration file? Where is it located?
- HomeController’s Index method  -- microsoft documents label this as a HomeController.Index file https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/asp-net-mvc-routing-overview-cs
- on the home controller

pg 20

##### 4. What is Razor? How does Razor treat an expression beginning with the at symbol (@)?
- Razor is a markup syntax that lets you embed server-based code (Visual Basic and C#) into web pages. https://www.w3schools.com/asp/razor_intro.asp
- When you display content in a page using the @ character, as in the preceding examples, ASP.NET HTML-encodes the output. This replaces reserved HTML characters (such as < and > and &) with codes that enable the characters to be displayed as characters in a web page instead of being interpreted as HTML tags or entities. https://docs.microsoft.com/en-us/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c

##### 5. How do View methods work?
you call view methods, specifying the name of the view you want from the homecontroller.cs file. the method generates an object that is a rendered views
pg 20

##### 6. What is the purpose of MVC models?
the models represent the objects, processes, and rules that define the domain of the application.
pg 26

##### 7. What is a strongly typed view and why do we use strongly typed views?
a strongly typed view is HTML with a @model razor expression. its intended to render a specific model type to the user

##### 8. What is the purpose of setting a start page URL?


##### 9. Describe the differences between HTTP GET and HTTP POST.
- HTTPPost method hides information from URL and does not bind data to URL. It is more secure than HttpGet method but it is slower than HttpGet. It is only useful when you are passing sensitive information to the server.

- https://www.completecsharptutorial.com/asp-net-mvc5/asp-net-mvc-5-httpget-and-httppost-method-with-example.php

##### 10. Describe the two approaches to validation in web applications.
- The data submitted by the user is sent to the server before it is validated, which is known as serverside validation and for which MVC has excellent support.
- server-side validation is usually complemented by client-side validation, where JavaScript is used to check the values that the user has entered before the form data is sent to the server.
pg 292

##### 11. What is the role of Cascading Style Sheets (CSS) in web development?
CSS is the language for describing the presentation of Web pages, including colors, layout, and fonts. It allows one to adapt the presentation to different types of devices, such as large screens, small screens, or printers. CSS is independent of HTML and can be used with any XML-based markup language. 
