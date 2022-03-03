//Ternary Expressions
//conditional operator
//composed of three parts

//The syntax looks like this:
        //1         //2                   //3
//boolean expression ? expression if true : expression if false;

//3parts
//1. boolean expression to be evaluated
//2. separates the boolean and the true result
//3. separates the true and false results

//ex:
System.Console.WriteLine("Enter your age");
string response = Console.ReadLine();
int age = int.Parse(response);

//output
string output = (age >=18) ? "You can vote!" : "You're too young to vote";


Console.WriteLine(output);