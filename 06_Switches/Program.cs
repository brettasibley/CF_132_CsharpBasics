//Has 3 parts
// 'switch' keyword

//a value that is being evaluated

// 'case' keyword, indicate a new block of code to be executed if the
// value matches the given case

//'break' keyword, indicates the end of the case

//'default' keyword, which will run if "all else fails"

//example
string name = Console.ReadLine();

//we are going to 'swtich' on the value 'name'
switch (name)
{
    case "Pete" :
        //code that runs if name == "Pete"
        System.Console.WriteLine("Hi, Pete!");
        break;

    //so if its anything other than Pete...
    default:
        //code that runs if all else fails
        System.Console.WriteLine("Invalid Option!");
        break;
}

//real example:
System.Console.WriteLine("How are you feeling today? (1-5)");
string feelingRating = Console.ReadLine();

switch(feelingRating)
{
    case "5":
    System.Console.WriteLine("That's great to hear");
    break;

    case "4":
    System.Console.WriteLine("Good Stuff");
    break;

    case "3":
    System.Console.WriteLine("Hope things improve");
    break;

    case "2":
    System.Console.WriteLine("Oh, sorry to hear that");
    break;

    case "1":
    System.Console.WriteLine("Dang. Hope your day gets better");
    break;

    default:
    System.Console.WriteLine("Sorry, we dont understand. Please try again later");
    break;
}

//Challenge 
//Creating a switch statement
//want to output discriptions for a few of your friends
Console.WriteLine("What is your friends name?");
//Prompt the user's input to enter a friends name
//Take in a user's input from the Console
string ans = Console.ReadLine();
//If the input is one of the listed friends write a fact about that person to the Console
switch (ans)
{
    //Extra Challenge:
    // what can you do with cases like "Paul" and "paul" as these are different values
    case "Paul":
    case "paul":
        System.Console.WriteLine("stupid");
        break;
    case "teddy":
    System.Console.WriteLine("laid back");
    break;
    case "jill":
    System.Console.WriteLine("Awesome person");
    break;
    default:
        System.Console.WriteLine("INvAliD!");
        break;
}
