# CAB201 Programming Principles

# Git Guide

_Skip this section if you know what you're doing 😎_

<details>
 <summary>Click here to open / close guide.</summary>

## Download the template

To download the template, open a terminal in a desired location. Then execute

```
git clone https://github.com/autumnssuns/CAB201_Prac_9_Classes.git
```

A `CAB201_Prac_9_Classes` folder will be created. Open the folder and execute the
`CAB201_Prac_9_Classes.sln` file and all your projects should load up.

## Get the solution

The solution in your current workshop and the workshop answers are stored
in a structure call `branch`.

The workshop answers can be found [here](https://github.com/autumnssuns/CAB201_Prac_9_Classes/tree/solution). This will
be updated every Monday.

## Update live solution (Advanced)

To sync your project the current workshop's solution, apply the following steps:

1. In your terminal, execute `git stash`. This will save your current version.
1. Afterwards, you can switch to any other branch using `git checkout <branch-name>`. Replace the branch name with either"
    
    `monday-dan-3-5pm` if you are in the 3-5pm workshop, or
    
    `monday-dan-5-7pm` if you are in the 5-7pm workshop.
1. If you want to revert back to your solution, execute `git checkout master && git stash pop`. This will 
    bring you back to your version and applied the changes you saved in step (1).

_It's never too early to learn Git, it is tremendously helpful and there are plenty of online resources, like [W3Schools](https://www.w3schools.com/git/default.asp?remote=github)._

</details>


# Worksheet 9: Inheritance

This week we are looking at inheritance. We will begin by looking at inheritance, before
talking about protected visibility, override and the object methods. We will conclude with a
section on incorporating inheritance into your class diagrams.

## Inheritance

1. Download the **Letter.zip** from Blackboard. It contains a **MyDate** and a **Letter** class
    which contains the name of the recipient and the date mailed.

    Create a CertifiedLetter as a subclass to Letter that also contains a tracking number
    for each letter.

    Create a TestLetter class that creates multiple Letter and CertifiedLetter objects and
    prints their values out to the screen.

2. Create a class named **Class**. It should contain a field called Name. Write a **TestClass**
    that should test the Class.
    Create a class called **SubClass** , which is a subclass of Class. It should contain a field
    called _Age_. In your TestClass write code to test Subclass.
    Create a class called **SubSubClass** , which is a subclass of SubClass. It should contain a
    field called _Location_. In your TestClass write code to test SubSubclass.

## Protected Visibility

3. Download the **Person.zip** from Blackboard. It contains a **Person** class which should
    contain a property called name, along with _get_ and _set_ properties for name.

    Create a class called Worker, which inherits the Person class. Worker should contain
    a protected s alary and a private lunch Apply appropriate get and set properties for
    salary and lunch.

    Create a second class called CEOWoker , which inherits from Worker.

    Create a class called TestWorker. Create a version of CEOWorker in TestWorker, and
    print all of its details. What are you able to access?

    Create GetSalary and GetLunch in Worker. File them with appropriate code.

    Go back to TestWorker and print out all of the details of your CEO Worker.

    Go back into Worker and add a SetSalary and SetLuch and fill them with appropriate
    code (feel free to make them up!). Go back to TestWorker and print out all of the
    details of your CEO Worker.

    Copy and paste the GetSalary, GetLunch, SetSalary and SetLunch from Worker to
    CEOWorker. Which ones will it not allow you to do?

4. Create a **BiscuitOrder** class. The class should accept the following parameters: order
    number, customer name, cookie type (for example: Chocolate Chip) and number of
    dozens ordered. Also include a price. Make sure that each of them has a protected
    access. Create a method that sets the price at $15 per dozen for the first 2 orders
    and $13 per dozen for the rest. Write a DisplayOrder which prints out all of the
    order’s details.
    
    Write a **TestBiscuitOrder** class that tests the BiscuitOrder classes.
    
    Write a **SpecialCookOrder** class which includes a field that describes why it’s a
    special order (for example gluten free). Override the price method and add $15 if the
    price is less than $50 and $25 if the price is greater than $50.
    Modify the TestBiscuitOrder to test the SpecialCookOrder class.

## Override

5. Download Photo.zip from Blackboard. It contains a **Photo** class for use in a company
    that develop photos. It has a constructor that accepts the length and width of photo.
    
    Create a subclass of Photo called **MattedPhoto** that holds a string field to represent
    a colour (for example: black). Add a _DisplayPhoto_ method to print out all the fields.
    
    Create a subclass called **FramedPhoto** that holds a field for the frame’s material
    (such as silver) and style (such as modern). Add a _DisplayPhoto_ method to print out
    all the fields.
    
    Create a **TestPhoto** class to test the MattedPhoto and the FramedPhoto.


6. Download a **HospitalPerson.zip** from Blackboard. It contains a class that holds
    information about a **Person** , such as their name. It should also contain a _Details_
    method that outputs their name.

    Create a Doctor class which inherits HospitalPerson. It should contain their
    speciality. It should also contain a Details method which will output their name and
    their speciality.

    Create a Patient class which inherits HospitalPerson. It should contain their height
    and weight. The Details method should output their name, height and weight.

    Create a DayPatient which will contain the reason that they are in hospital. The
    Details method should output their name, height, weight and the reason.

    Create a TestHospitalPerson which will test the Doctor, Patient and DayPatent.

## Object Methods

7. Download the **RealEstate.zip** from Blackboard. It contains a RealEstate class that
    contains the street number, street, and post code.

    Write a class called House. The constructor should take two additional parameters,
    whether the house has a pool or a tennis court. Write a ToString() method that will
    print out all of the fields.

    Write a class called Unit , which should inherit from RealEastate. The constructor
    should add a unit number. Write a ToString() method that will print out all of the
    fields.

    Write a class called TestRealEstate. It should import both House and Unit. Write
    enough information to test all of the classes.

8. Create an application called **JobDemo**. It should include **Job** objects. Each Job should
    have properties that include a job number, customer name, estimate hours and price
    for the job. Create a constructor that contains all of the parameters except for price,
    which is calculated at $45 per hour.

    Create the following methods :

    - A GetHashCode() method that returns the base hash code;
    - An Equals() method that determines if two Jobs are equal if they have the same
        job number;
    - A ToString() method that returns a strong containing all of their job information.
    Write a class called **RushJob**. It has a premium of $150 which will add to the cost of a
    job.
    
    Write a class called **TestJob**. It will import both Job and RushJob. Write enough
    information to test all of the classes.

## Class Diagram and Inheritance

9. Display each of the application for questions 7 and 8, RealEstate and JobDemo, with
    a class diagram.

## Homework

1. You are to create a set of classes called **TyreDemo**. Create a class called **Tyre** that
    contains a field called name. Have name set to the value “Tyre”. Add permissions to
    access it publicly, but only have it set via its children. Make two subclass for Tyre,
    one called **ScooterTyre** which will set the name to “Scooter” and **CarTyre** which will
    set the name to “Car”. Write a class called TestTyre, which will test the three classes.
2. Display the classes in the TyreDemo with a class diagram.
3. Create and application called MyOrder, which contains an order that sells item for
    $19.95. You should create an **Order** class that contains the fields for order number,
    customer name, quantity order. It should also contain a number for the order price.
    
    You should also create the following:
       - An _Equals_ method that determines if two Orders are equal if they have the
          same order price
       - A _GetHashCode_ method that returns the order number
       - A _ToString_ method that returns a string containing all order information
    
    You should also write a **ShippedOrder** class. This class will be a sub class of Order
    and have a $4.00 shipping fee. Override any methods, parameters or properties of
    the parent class as necessity.
    
    Write a **TestOrder** class. It should test all of the methods. In particular, create classes
    to test the _Equals_ method.


4. Image that you have the following User Stores:
    - As a game player I would like to play a game for my enjoyment
    - As a game player I would like to know how many people can play a game so I
       can invite my friends over to play
    - As a game player I would like to have a separate game that has a time limit so
       that I know how long to play the game for
    - As a game player I would like to see the name of the game, how many people
       can play it and if possible, how long the game would be played for so that I
       know the details of the game.

    You are to implement the following for Game and GameWithTimeLimit. Design the
    appropriate Class Diagram and the write the code.


