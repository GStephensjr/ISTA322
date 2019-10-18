# Title: cssbs-hw15
### Author: Greg Stephens
### Date: 16 Aug, 2019

###### Read chapter 15, pages 329 – 352 in the C# Step by Step book.


##### 1. What is the difference between a property and a field?
- Fields are normal variable members of a class. Generally, you should declare your fields as private, then use Properties to get and set their values.
- They are actually special methods called “accessors”. Properties are called accessors because they offer a way to get and set a field if you have a private field.
- fields are private, properties are public

##### 2. What is the difference between a property and a method?
properties are really just a special way to write methods, there is little functional difference

- Properties are a useful way of expressing a feature of an object, allowing get/set in a common way that can be used by APIs like data-binding, reflection and serialization.
- Methods are better for expressing things that either change the state, or which have an expectation of taking some time and not necessarily being reproducible. They don't tend to work in binding / serialization etc.

`properties have implimentation. methods have implementation and parameters. variables have neither.`

https://stackoverflow.com/questions/2544707/difference-between-property-and-method


##### 3. What is your understanding of encapsulation?
encapsulation is using a method to package your code as a single unit, protecting it from the rest of your code, to deploy it as a behavior/function/procedure

##### 4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter. C# is case sensitive.

###### - What implications does this have regarding the naming of variables, methods, and other identifiers?


###### - Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?
yes. i did it once on accident.

##### 5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.
- if you need to ensure your property value will never be changed from the outside, but you need to be able to change it from inside your class code, use a "Get-only" property.
- people dont like write only so there arent a lot of examples of it outside the book

https://docs.microsoft.com/en-us/visualstudio/code-quality/ca1044-properties-should-not-be-write-only?view=vs-2019

##### 6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.

if you need to ever do it, just make a private field

##### 7. What are restrictions on the use of properties?
pgs 346-347 have the list of restrictions

##### 8. What is an object initializer? What is the syntax for an object initializer?
Object initializers create an object and initialize the values from the properties as parameters

Object initializers let you assign values to any accessible fields or properties of an object at creation time without having to invoke a constructor followed by lines of assignment statements. The syntax for the object initializer is declaring the object with no parameters or arguments and then in the curly brackets we assign values to all or some of the properties.
