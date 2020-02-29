using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validator Practice");

            // TODO: Pin Checker; 
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

            // TODO: Phone Number Valid;  
            // 10 digits required; can include spaces dashes or parenthesis; does not start with 555

            // TODO: Email Valid;
            // one @ symbol; one dot after @; something before @; domain after the @; top level domain after dot

            // TODO: Check is name is valid Power Ranger

            // TODO: Is input a palindrome

            // TODO: Spongebob mocking???

            Console.ReadLine();

        }
    }
}
