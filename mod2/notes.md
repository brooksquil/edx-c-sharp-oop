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

# Sealed Classses -
+ prevents inheritance
+ structs are also sealed in a similiar way and cannot be inherited

# Interfaces -
+ like a class without implementation
+ when a class implements an interface, the class provides implementation for each member of the interface
+ A class implements an interface as opposed to inheriting a base class

***Creating Interfaces -***
+ think of as a contract = by implementing a particular interface a class guarantees it will provide specific functionlity through specific members

ex.
```CSharp
public interface IBeverage
{
    //methods, props, events, and indexers go here
}
```
+ all interface names begin with "I"
+ can include and access modifier
    + **public -** able to run code in any assembly
    + **internal -** available to any code in the assembly but not in a different assembly *this is the default value

**Adding Interface Members -** 
+ defines signature of method but does not include implementation details

+ define method with name, return type and any parameters

ex.
```CSharp
int GetServingTemperature(bool includesMilk);
```
+ to define property, specify name, type, accessors

ex.
```CSharp
bool IsFairTrade { get; set; }
```
+ define event with event keyword, handler delegate, name of event

ex. 
```CSharp
event EventHandler OnSoldOut;
```
+ define and indexer, specify return type & accessors

ex. 
```CSharp
string this[int index] { get; set; }
```
+ they do not include access modifiers
+ purpose is to define the members that an implementing class should expose to consumers so that interface members are public
+ DO NOT include fields, constants, operators, constructors

ex.
```CSharp
//defining an interface
public interface ILoyaltyCardHolder
{
    int TotalPoints { get; }
    int AddPoints(decimal transactionValue);
    void ResetPoints();
}
```
ex. 
```CSharp
// implements above interface
public class Customer : ILoyaltyCardHolder
{
    private int totalPoints;
    public int TotalPoints
    {
        get { return totalPoints; }
    }
    public int AddPoints(decimal transactionValue)
    {
        int points = Decimal.ToInt32(transactionValue);
        totalPoints += points;
        return totalPoints;
    }
    public void ResetPoints()
    {
        totalPoints = 0;
    }
    // Other members of the Customer class
}
```

**Implcit & Explicit Implementation -**
+ implicitly - implement each interface member with a signature that matches the member definition in the interface
+ explicitly - fully qualify each member name so that it is clear that the member belongs to a particular interface

ex.
```CSharp
// implementing an interface explicitly
public class coffee : IBeverage
{
    private int servingTempWithoutMilk { get; set; }
    private int servingTempWithMilk { get; set; }
    public int IBeverage.GetServingTemperature(bool includesMilk)
    {
        if(includesMilk)
        {
            return servingTempWithMilk;
        }
        else
        {
            return servingTempWithMilk;
        }

    }
    public bool IBeverage.IsFairTrade { get; set; }
    // other non-interface members
}
```
+ *The only scenario in which you must use explicit interface implementation is if you are implementing two interfaces that share a member name. 

# Interface Ploymorphism

+ y

