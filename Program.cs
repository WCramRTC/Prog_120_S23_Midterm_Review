namespace Prog_120_S23_Midterm_Review
{
    internal class Program
    {
        // Global variable - Meaning Everything inside the Program CONTEXT can see this variable
        static string name = "David";

        static void Main(string[] args)
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

        static void MethodExample()
        {
            Console.WriteLine(name);
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