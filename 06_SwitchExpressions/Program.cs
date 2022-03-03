//Syntax
//value being evaluated, often a variable
//the switch keyword
//a body that contains 'cases', called "expression arms" denoted by {}
//The commma separated by 'expression arms' are made up of three parts
    //1. the expected value, called a "pattern"
    //2. a "Fat Arrow", denoted as '=>'
    //3. the actual expression or value to be returned
//A discard pattern, denoted with an "_" which is the default

//-Swtich expressions
string userName = Console.ReadLine();
string greeting = userName switch 
{
    "Pete"=>"Hello Pete", //value that returns if variable userName has value of "Pete"
    _ =>"Who are you?" //return value for every other possible value for name
};

System.Console.WriteLine(greeting);

//real Example:
System.Console.WriteLine("How are you feeling today? (1-5)");
string feelingRating = Console.ReadLine();

switch (feelingRating)
{
    case "5":
        System.Console.WriteLine("That's great to hear!");
        break;

    case "4":
        System.Console.WriteLine("Good Stuff!");
        break;

    case "3":
        System.Console.WriteLine("Hope things improve!");
        break;

    case "2":
        System.Console.WriteLine("Oh, sorry to hear that!");
        break;

    case "1":
        System.Console.WriteLine("Dang. Hope your day gets better!");
        break;

    default:
        System.Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}

System.Console.WriteLine("How were you feeling yesterday? (1-5)");
string ratingInput = Console.ReadLine();

//we want to 'transform' ratingInput to an int
int  yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1=>"Dang. We hope today is a better day.",
    2=>"Oh, sorry to hear that",
    3=>"Hopefully things will get better this week",
    4=>"Good Stuff",
    5=>"That's great to hear",
    _ => "That's off the charts!"
};

System.Console.WriteLine(response);

//Challenge 
//We have 2 questions in our code:
//"How are you feeling today?
//"How were you feeling yesterday?

//we got 2 variables
//feelingRating
//yesterdayRating

//The challenge is to compare these two values and display how much better or worse 
//they are feeling today than yesterday.

//you don't have to use switch expressions for this challenge.
//use whatever works for you.

//Tools you should think about using:
//Converting strings to numbers
//Comparison Operators
//Conditionals