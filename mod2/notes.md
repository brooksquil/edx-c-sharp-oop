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

