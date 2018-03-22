# Using Anonymous Classes

**Anonymous Classes -** Class without a name

+ easy way to encapsulate read-only properties into single object without defining a type.
+ type of each property included in class will be inferred by compiler.

```CSharp
var anAnonoymousObject = new { Name = "Tom", Age = 65 };
```
+ the class has 2 public fields: Name & Age
+ once instantiatied fields can be accessed via dot notation

```CSharp
Console.WriteLine("Name: {0} Age: {1}"), anAnonymousObject.Name, an anonymousObject.Age);
```
+ once created other instances of the same class can be instantiated with different values

```CSharp
var secondAnonymousObject = new { Name = "Hal", Age = 46 };
```
+ The compiler will compare the two instances to see if they are the same type
+ if they are the same type they can be assigned to each other

```CSharp
secondAnonymousObject = anAnonymousObject
```
**Restrictions on the content of anonymous class:**
+ only public fields
+ all fields must be initialized
+ no static fields
+ cannot define methods for them

# Introducing Inheritance

+ You can use inheritance as an aspect of code reuse by defining different classes that will contain common features and have a relationship to one another.
+ Inheritance allows you to create a base class containing the core, shared attributes, and then each different class of employee would inherit these attributes whole extending them for their own special needs. 
+ The class that inherits from the base class is referred to as the derived class but also commonly referred to as a subclass. 

**Applying Inheritance -**
+ derived class can only inherit from one base class

ex. 
```CSharp
class Manager : Employee
{
    private char payRateIndicator;
    private Employee[] emps;
}
```

**Abstract Classes -** 
+ cannot be instantiated
+ can partially or fully not implement behavior
+ requires the subclass to implement functionality

ex.
```CSharp
abstract class Employee
{
    private string empNumber;
    private string firstName;
    private string lastName;
    private string address;

    //..........

    public virtual void Login()
    {
    }

    public virtual void LogOff()
    {
    }

    public abstract void EatLunch();
    
}
```
+ once created, decide which methods "must" be implemented in the subclasses and which "can" be implemented or over ridden in the sub class

***constraints -***
+ An abstract method cannot exist in non-abstract class
+ An abstract method is not permitted to have any implementation including curly braces
+ An abstract method signature must end in a semi-colon
+ An abstract method must be implemented in any sub class

**Sealed Classses -**
+ prevents inheritance
+ structs are also sealed in a similiar way and cannot be inherited

**Interfaces -**
+ like a class without implementation
+ when a class implements an interface, the class provides implementation for each member of the interface
+ A class implements an interface as opposed to inheriting a base class

***Creating Interfaces***
+ 
