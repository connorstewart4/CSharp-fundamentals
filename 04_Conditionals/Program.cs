// ! IF

bool userIsHungry = true;

if ( userIsHungry ) // Value within parans need to equal true
{
    System.Console.WriteLine("Eat Something"); // Because userIsHungry is true, it will run this WriteLine 
}
// If userIsHunry was false, it would skip this If conditional.

//! Using Operators
int hoursWorking = 1;
if(hoursWorking < 8)
{
    System.Console.WriteLine("Are you even working?");
}

//! ELSE 
bool choresAreDone = false;

if(choresAreDone)
{
    System.Console.WriteLine("Have fun at the movies!");
}
else
{
    System.Console.WriteLine("You need to stay home and finish your chores.");
    // When the IF is False, it runs the ELSE. An Else is a great way to catch various errors through user input.
}

string input = "7";
int totalHours = int.Parse(input); // If the string cannot be read as an int, an error will be thrown.

if(totalHours >= 8)
{
    System.Console.WriteLine("You should be well rested.");
}
else
{
    System.Console.WriteLine("You might be tired this afternoon...");

    if (totalHours < 4)
    {
        System.Console.WriteLine("You need to get more sleep!");
    }
}

/*
    A person age
        <18: You are just a kid
        18: adult
        21: drinking age
        25: Insurance lowers / Rent Car
*/

int age = 23;
if (age >= 25)
{
    System.Console.WriteLine("Insurance lowers!You can rent a c!ar");
}
else if (age >= 21)
{
    System.Console.WriteLine("Drinking age");
}
else if (age >= 18)
{
    System.Console.WriteLine("You're an adult");
}
else
{
    System.Console.WriteLine("You're just a kid");
}

/*
!     SWITCH CASES  
        - Allow us to check against a case depending on the value passed, and returns a result.
*/

int intInput = 4;
string order;

switch (intInput)
{
    case 1:
        order = "burger and fries";
        break;
    case 2: 
        order = "chicken sandwhich";
        break;
    case 3: 
        order = "tacos";
        break;
    case 4:
        order = "bean burrito";
        break;
    default:
        order = "cup of water";
        break;
}
System.Console.WriteLine(order);



string sampleInput = "test";
switch (sampleInput)
{
    case "test":
        System.Console.WriteLine("This is a test");
        break;
    default:
        System.Console.WriteLine("Not a test");
        break;
}

string today = "Saturday";

switch (today)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        System.Console.WriteLine("Office is open");
        break;
    default:
        System.Console.WriteLine("Office is closed");
        break;
}

//! Switch Expression:
order = intInput switch
{
    1 => "burger and fries",
    2 => "chicken sandwhich",
    3 or 4 => "burrito",
    _=> "cup of water"
};
System.Console.WriteLine(order);

//! Ternary Expression
/*
    - shorthand for i/else conditional
    - meant to assign a value to a variable.
*/

int userAge = 71;
bool isAdult = (userAge > 17) ? true : false;

string ticketType = (userAge >= 18) ? "Adult" : "Child";
System.Console.WriteLine(ticketType);

//* Compound Ternary
string otherTicketType = userAge >= 18 ? userAge > 65 ? "Senior" : "Adult" : "Child";
System.Console.WriteLine(otherTicketType);