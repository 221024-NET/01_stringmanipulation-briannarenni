using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your message and press Enter: ");
            string userInputString = Console.ReadLine();

            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            int elementNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            string userFullName = $"{firstName}{lastName}";

            Console.WriteLine("For which character should I search in your original message?");
            char userChar = Convert.ToChar(Console.ReadLine());



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
            throw new NotImplementedException("StringToUpper method not implemented.");

        }

        // This method has one string parameter.
        // It will:
        // 1) trim the whitespace from before and after the string,
        // 2) print the result to the console and
        // 3) return the new string.
        public static string StringTrim(string x){
            throw new NotImplementedException("StringTrim method not implemented.");

        }

        // This method has two parameters, one string and one integer.
        // It will:
        // 1) get the substring based on the integer received,
        // 2) print the result to the console and
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            throw new NotImplementedException("StringSubstring method not implemented.");

        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            throw new NotImplementedException("SearchChar method not implemented.");
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            throw new NotImplementedException("ConcatNames method not implemented.");
        }



    }//end of program
}
