using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Get user inputs
            Console.WriteLine("Please enter your message and press Enter: ");
            string userInputString = StringTrim(Console.ReadLine());

            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            int elementNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName} {lastName}";

            Console.WriteLine("For which character should I search in your original message?");
            char userChar = Convert.ToChar(Console.ReadLine());

            // Implement methods
            string fullNameUpper = Program.StringToUpper(fullName);
            string fullNameLower = Program.StringToLower(fullName);

            Console.WriteLine("Here are your results!");
            Console.WriteLine($"Full name: ");
            Console.WriteLine(ConcatNames(firstName, lastName));
            Console.WriteLine("\n");

            Console.WriteLine($"Uppercase: ");
            Console.WriteLine(StringToUpper(fullName));
            Console.WriteLine("\n");
             Console.WriteLine($"Lowercase: ");
            Console.WriteLine(StringToLower(fullName));
            Console.WriteLine("\n");

            Console.WriteLine($"Your message was: ");
            Console.WriteLine(userInputString);
            Console.WriteLine("\n");

            Console.WriteLine($"Substring: ");
            Console.WriteLine(StringSubstring(userInputString, elementNum));
            Console.WriteLine("\n");

            Console.WriteLine($"You chose the char: {userChar}");
            Console.WriteLine("Found at index: ");
            Console.WriteLine(SearchChar(userInputString, userChar));
            Console.WriteLine("\n");

        }

        // This method has one string parameter.
        // It will:
        // 1) change the string to all upper case,
        // 2) print the result to the console and
        // 3) return the new string.
        public static string StringToUpper(string x){
            return x.ToUpper();
        }

        // This method has one string parameter.
        // It will:
        // 1) change the string to all lower case,
        // 2) print the result to the console and
        // 3) return the new string.
        public static string StringToLower(string x){
            return x.ToLower();
        }

        // This method has one string parameter.
        // It will:
        // 1) trim the whitespace from before and after the string,
        // 2) print the result to the console and
        // 3) return the new string.
        public static string StringTrim(string x){
            return x.Trim();

        }

        // This method has two parameters, one string and one integer.
        // It will:
        // 1) get the substring based on the integer received,
        // 2) print the result to the console and
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            return x.Substring(0, elementNum);
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x) {
            return userInputString.IndexOf(x);
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            return fName + " " + lName;
        }



    }//end of program
}
