using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validator Practice");

            // Pin Validator 
            // between 4 and 8 digits, numbers only, return true if valid

            Console.WriteLine("Enter a new pin.  Pin must be between 4 and 8 digits, numbers only:");
            var userPin = Console.ReadLine();
            var validPin = false;
            while (!validPin)
            {
                if (userPin.Length >= 4 && userPin.Length <= 8)
                {
                    try
                    {
                        var pinInput = int.Parse(userPin);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You entered an invalid pin, please be sure to enter a pin with 4 to 8 digits, numbers only.");
                        userPin = Console.ReadLine();
                    }
                    Console.WriteLine($"You entered a valid pin: {userPin}");
                    validPin = true;
                }
                else
                {
                    Console.WriteLine("You entered an invalid pin, please be sure to enter a pin with 4 to 8 digits, numbers only.");
                    userPin = Console.ReadLine();
                }
            }

            // Phone Number Validator; 
            // 10 digits required; can include spaces dashes or parenthesis; does not start with 555

            Console.WriteLine("Enter your phone number:");
            var userPhoneEntry = Console.ReadLine();
            var phoneIsValid = false;

            while (!phoneIsValid)
            {
                char[] separator = { '(', ')', ' ', '-', };
                String[] strlist = userPhoneEntry.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                var numberOnly = "";
                foreach (var item in strlist) numberOnly += item;
                var firstThree = numberOnly.Substring(0, 3);

                if (numberOnly.Length == 10)
                {
                    if (firstThree != "555")
                    {
                        try
                        {
                            var userNumber = Int64.Parse(numberOnly);
                            phoneIsValid = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("You entered an invalid phone number, please try again.");
                            userPhoneEntry = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered an invalid phone number, please try again.");
                        userPhoneEntry = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You entered an invalid phone number, please try again.");
                    userPhoneEntry = Console.ReadLine();
                }
            }
            Console.WriteLine("You entered a valid phone number");


            // TODO: Email Valid;
            // one @ symbol; one dot after @; something before @; domain after the @; top level domain after dot

            Console.WriteLine("Please enter your email");
            var userEmailEntry = Console.ReadLine();
            var validEmail = false;
            string[] topLevelDomains = new string[] { "com", "edu", "org", "net" };

            while (!validEmail)
            {
                if (userEmailEntry.IndexOf('@') != -1 && userEmailEntry.IndexOf('@') >= 1)
                {
                    var dotCount = 0;
                    foreach (var item in userEmailEntry)
                    {
                        if (item == '.') dotCount++;
                    }

                    if (dotCount == 1 && userEmailEntry.IndexOf('.') > userEmailEntry.IndexOf('@') + 1)
                    {
                        var lastThreeChars = userEmailEntry.Substring(userEmailEntry.IndexOf('.') + 1);
                        if (Array.IndexOf(topLevelDomains, lastThreeChars) != -1)
                        {
                            Console.WriteLine("Valid Email");
                            validEmail = true;
                        }
                        else
                        { 
                             Console.WriteLine("Not a valid email, try again.");
                             userEmailEntry = Console.ReadLine();
                        }
                    }
                        
                }
            }

            // TODO: Check is name is valid Power Ranger
            Console.WriteLine("Enter a valid Power Ranger Name");
            var userRangerEntry = Console.ReadLine();
            string[] powerRangerNames = new string[] { "Jason", "Zack", "Trini", "Kimberly", "Billy" };
            var rangerEntryIsValid = false;

            while (!rangerEntryIsValid)
            {
                if (Array.IndexOf(powerRangerNames, userRangerEntry) != -1)
                {
                    Console.WriteLine("This Ranger is Valid!");
                    rangerEntryIsValid = true;
                }
                else
                {
                    Console.WriteLine("Not a valid Ranger, please try again.");
                    userRangerEntry = Console.ReadLine();
                }
            }


            // TODO: Is input a palindrome
            Console.WriteLine("Enter a word you would like to check if it is a palindrome");
            var userPalindromeEntry = Console.ReadLine();
            string[] splitWord = userPalindromeEntry.Split(' ');
            var reversedWord = string.Join(" ", splitWord);
            Console.WriteLine(userPalindromeEntry);
            Console.WriteLine(reversedWord);


            if (reversedWord == userPalindromeEntry)
            {
                Console.WriteLine("It is indeed a palindrome!");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }

            Console.WriteLine("You have completed the program.  Press enter to exit.");
            Console.ReadLine();

        }
    }
}
