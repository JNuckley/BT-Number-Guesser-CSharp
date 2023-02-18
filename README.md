# C# for beginners - Brad Traversy

## Notes

- create a new template app in the folder you want with `dotnet new console --framework net6.0`
- populate the Program.cs file with your desired namespace

````using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}```

### Basics
- classes are used to create objects from
- static void main is the entry point of the application and void simply means that it doesn't return anything and static means we don't have instances of it, we are referring just to the function itself
````

- WriteLine pops the the message on its own line and Write just puts it on the same line as the previous.

#### strings and integers

- ````string name = "Jo";
            int age = 12;
            // start here
            Console.WriteLine("My name is " + name+". I am "+age+" years old!");```
  ````

- `````string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "JN";

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion,appAuthor);````
  `````

### built in methods and objects used

### methods

- ToUpper() - this does what you would expect!
- ReadLine() - to read user input
- TryParse() - to check that input was the type expected and pass it to the output variable
- Int32.Parse(var) - takes a variable from input (string) and parses it to Integer.
- Random() object - use this to create a random number between 1 and 10 with random.Next(1, 10)
- ForegroundColor and ResetColor() to change the text colour and then reset it
