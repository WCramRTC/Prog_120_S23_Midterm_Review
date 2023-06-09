﻿namespace Prog_120_S23_Midterm_Review
{
    internal class Program
    {
        // Global variable - Meaning Everything inside the Program CONTEXT can see this variable
        static string name = "David";

        static void Main(string[] args)
        {
            //double rateCheck = 72 / 5.0;
            //Console.WriteLine(rateCheck);

            Menu();
        } // ----------------

        // Midterm Practice

        // Making a small menu that the user can choose an option from

        public static void Menu()
        {
            // Ask the user for their location information, return the result
            //string userLocation = ReturnUserLocation();
            string userLocation = FormatLocation("Starbucks", "Seattle"); // Remember to remove

            // Greeting
            Console.WriteLine(StringGreeting(userLocation));
            Console.WriteLine("--------------------------------------");

            string choice1 = "Peach Green Tea";
            double price1 = 3.75;


            string choice2 = "Black Ice Tea";
            double price2 = 3.25;

            // I want to display my menu ATLEAST once
            // So i will wrap my code in a do while
            // because a DO While loop is guanenteed to run atleast once
            string userContinue;
            double total = 0;
            do
            {
                // Start my loop here
                Console.WriteLine($"Your local store is {userLocation}");
                Console.WriteLine("What would you like to buy today?");
                Console.WriteLine($"1 - {choice1}");
                Console.WriteLine($"2 - {choice2}");
                Console.Write("Which would you like?");
                string userChoice = Console.ReadLine();

                // Condition
                // Let the user CHOOSE which drink to buy
                

                if (userChoice == "1") // If they choose the green tea
                {
                    Console.WriteLine($"You have chosen {choice1}");
                    total += DrinkPrice(price1);
                }
                else if (userChoice == "2") // if they choose the black tea
                {
                    Console.WriteLine($"You have chosen {choice2}");
                    total += DrinkPrice(price2);

                }
                else // if they put the wrong drink
                {
                    Console.WriteLine("You have entered an invalid choice");
                }

                Console.WriteLine($"Your drink costs {total.ToString("c")}");

                DisplayTotal(total);


                Console.WriteLine("Would you like anything else today? Type n to exit");
                userContinue = Console.ReadLine();
                // End my loop here
            } while (userContinue != "n");

            


            // I was testing to make sure that it recognizes when the user says NO, i dont' want another drink
            //if (userContinue != "n")
            //{
            //    Console.WriteLine("Ask for another drink");
            //}
            //else
            //{
            //    Console.WriteLine("Exit the app");
            //}
            

        } // 

        public static void DisplayTotal(double amount)
        {
            // Display after tax

            double tax = .11;
            double drinkTax = amount * tax;
            double totalAmount = amount + drinkTax;

            Console.WriteLine($"Your drink comes to a total of  {totalAmount.ToString("c")}: The tax was {drinkTax.ToString("c")}");

        }

        public static double DrinkPrice(double amount)
        {
            // I want to write code for the size
            Console.WriteLine("What size would you like?");
            Console.WriteLine("1 - Tall");
            Console.WriteLine("2 - Grande");
            Console.WriteLine("3 - Vente");
            string userSizeChoice = Console.ReadLine();

            // Now I'm keeping track of a price
            double total = 0;

            if (userSizeChoice == "1")
            {
                total += amount;
            }
            else if (userSizeChoice == "2")
            {
                total += amount + (amount * .25);
            }
            else if (userSizeChoice == "3")
            {
                total += amount + (amount * .5);
            }

            return total;
        } // DrinkPrice

        public static string ReturnUserLocation()
        {
            // Displaying a greeting
            Console.Write("Where are you located: "); // Output - Display the question to the user
            string location = Console.ReadLine(); // Input - Getting the user information
            Console.Write("What store are you visiting: "); // Output - Display question
            string store = Console.ReadLine(); // Input - Get the users store location

            // Variable and operation : Formatting the string and saving the value
            return FormatLocation(store, location);
        }

        // It will loop as long as the user wants it to
        // when they make a choice it will keep track of the choices made
        // total the cost of the users choices
        // it will display a total

        // 6 fundamentals
        // inputs
        // outputs
        // loops
        // conditions
        // variables
        // operations

        // -------------------------------

        public static void MethodExample()
        {
            // We call a method by its NAME and passing in arguments
            //GreetingExample("Sams Club");
            //GreetingExample("Costco");
            //GreetingExample("Costco", "Tukwila");
            string location = "Issaquah";
            string store = "Costco";
            string formattedLocation = FormatLocation(store, location); // This would be "Issaquah Costco"

            Console.WriteLine(StringGreeting(formattedLocation));


            //Console.WriteLine(FormatLocation("Fred Meyer", "Benson Plaza"));
        }

        // Methods - Code blocks, that do one specific task / process / action / function
        // They are a block of code, given a name, that runs the block of code when called
        // public static Return Type - Name - Parameters - Code Block
        // Return type - tells the computer what TYPE of data is coming out of your method
        // VOID : If nothing is being returned
        // Common Error
        // There is no information being passed into it, and nothing coming out of it
        public static void VoidReturnExample()
        {
            // Nothing is being returned, it just performs an Action
            Console.WriteLine("Welcome to Auburn Sams Club");
        }

        // In the parentheses I'm going to pass in a string value
        public static void GreetingExample(string companyName, string location)
        {
            // String literal
            string formatConCatenate = "Welcome to the " + location + " " + companyName;

            // \n to go to next line inside double quotes
            // The \n is an escape character
            // These are special characters inside our strings, that format information
            // \n - For new line
            // \t - For Tab
            // \\ - To show the \
            string formatStringLiteral = $"Welcome to the {location} {companyName}";
            Console.WriteLine(formatStringLiteral);
        }

        public static string StringGreeting(string storeAndLocation)
        {
            string formatted = $"Greetings! And welcome to the {storeAndLocation}";
            // use the return key word
            return formatted;

        }

        public static string FormatLocation(string companyName, string location)
        {
            return $"{location} {companyName}";
        }


        static void Loop()
        {
            //string userInput = Console.ReadLine();

            //while(userInput != "Will")
            //{
            //    Console.WriteLine("Please enter a valid name.");

            //    userInput = Console.ReadLine();
            //}

            //Console.WriteLine("Thank you for logging in");

            // --------------------

            while (false) // While checks the condition FIRST before running
            {
                Console.WriteLine("This is a while loop");
            }

            do // Do while will RUN once before checking the condition
            {
                Console.WriteLine("This is a do while");
            } while (false);




            //int count = 0;

            //// Just a condition that runs over and over while true
            //while (count < 100) // runs until false
            //{
            //    Console.WriteLine(count);
            //    count = count + 1; // Changing our condition, by adding 1 to count, so eventually it will be greater than or equal to 100, which then makes it false
            //}


            //Console.WriteLine("After our loop");
        }

        static void ConditionExample()
        {
            // Conditions
            double humidity = 50;
            double humidityWhenMuggy = 45;
            double humidtyWhenRaining = 70;
            bool isMuggy = humidity > humidityWhenMuggy;
            bool isRaining = humidity >= humidtyWhenRaining;

            if (isRaining) // NEEDS boolean
            {
                Console.WriteLine("Is raining");
            }
            else if (isMuggy)
            {
                Console.WriteLine("Is Muggy");
            }
            else
            {
                Console.WriteLine("It is NOT raining");
            }
        }

        static void MathExample()
        {
            // PEMDAS
            // Parenthese
            // Exponents
            // Multiply
            // Divide
            // Add
            // Subtract

            int result = 12 * 435 / 123 + 2345 - 234 * 234 - (42 / 3);
            Console.WriteLine(result);
            // 42.45 + 2345 - 54756 - 14
            int sum = 10 + 10;
            // Step 1 : ( 42 / 3 ) = 14
            // Step 2 : 12 * 435 = 5220
            // Step 3 : 5220 / 123 = 42.45
            // Step 4 = 234 * 234 = 54,756
            // -52,382.55
        }

      

        static void Example()
        {
            MethodExample(); // Calling a method means running the code block
            // This is done by using the method name
            // Adding Parentheses, and passing in any arguments

            name = "Will"; // If it's DECLARED insid of main, only main and others INSIDE of main can see it

            MethodExample();

            //Console.WriteLine("Hello, World!");

        } // Example

    } // class

} // namespace

// 6 Fundamentals

// Outputs - WRITING INFORMATION - The way we deliever information to the world
// -- Console.WriteLine() -- It Displays information to the console, then moves to the next line
// -- Console.Write()

// Inputs -- READING INFORMATION
// Console.ReadLine()
// 

// ----------------------------------------

// Variables -- Memory - Our way of saving information in memory
// How to declare a variable
// Type variableName = value
// string stringName = ""; -- This creates a string variable
// int wholeNumber = 42; -- this holds a whole number
// double, decimal, float = 42.00; -- This holds a number with a decimal value
// bool trueFalse = true; -- This holds either true or false

// Scope


// TYPE TYPE TYPE TYPE TYPE - WHAT IS THIS TYPE HE KEEPS ASKING ABOUT

// Operations - Actions that the computer performs

// Assignment Operator : single = : Equal Sign : It assigns a value to a variable name
// Ex string name = "Hannah"; <-------- = means we are assign HANNAH to NAME
// ----------------------------------------------
// Comparsion Operator : <, >, <=, >= , !=, == 
// These are used to compare two values, and return how they are related to one another
// These ALL return true or false, or a boolean
// Two are used for ALL types ( including strings )

// Double Equals : == : Means two are EXACTLY the same : Can only be true ONCE

// Ex "Will" == "Hannah" // Returns False
// Ex "Hannah" == "Hannah" // Return True ( Only if both sides of the operator are the same )
// Ex "hannah" == "Hannah" // False, because it is CASE SENSTIVE

// Not Equals : != : Compares two types and returns if they are NOT the same : Can only be False ONCE
// Ex "Will" != "Hannah"; // Returns True
// Ex "Hannah" != "Hannah"; // Returns False ( Because they ARE the same )

// ----------------------------------------

// < > <= >= : ONLY WORK ON NUMBERS
// Then are used to check ranges
// number < 10 : true -------------------| 10 >---------- False
// 10 < 10 : Is FALSE, because 10 DOES NOT EQUAL 10
// 10 <= 10 : Is TRUE, because 10 IS EQUAL to 10


// ----------------------------------------
// Math Operator
// - + % * /
// You use MATH operators to return a NUMBER value ( unless it's two string and a + )
// 5 + 5; This would RETURN a result of 10, that is an int
// 10 * 20; Returns 200, as in int
// 12.25 * 19.20; // It RETURNS A Number that is a double
// 
// Mod : % : It returns the REMAINDER in divison, as a whole number
// When you DIVIDE a number, it returns a decimal
// When you MOD a number, it returns the REMAINDER as a whole value. 
// ----------------------------------------
// Real World
// Finding Even or Odd
// NUMBER % 2 == 0; // This is the EQUATION for finding an even number
// 2 % 2 == 0; // This is true, and means that 2 is an even number
// 123353451328 % 2 == 0; // True, this is an even number
// 3 % 2 == 0; // This results in 1, so it is false, meaning odd
// 532545 == % 0 // This results in 1, so it is false, meaning odd

// Compound Operator : Because they do the work of two different operators
// Math and Assignment
// +=, -=, *=, /= , %=
// int a = 5;
// int b = 10;
// Long Way: a = a + b; a = 5 + 10
// Short Way a += b;

// -------------------------------------

// Conditions - The CHOICES of the computer
// Run Different blocks of code
// If / Else If / Else
// ALL USE BOOLEANS ( True or False )
// if (true) { 
//   // This code block will run
//}
// if (false) }
// this code block WONT run
// }

// Loops
// While and Do While
// 