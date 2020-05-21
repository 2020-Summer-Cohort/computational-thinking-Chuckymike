using System;
using System.Transactions;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Numbers the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Write a console application to ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here

            // Ask user for 1st integer
            Console.WriteLine("Enter an integer: ");

            // Save integer in a variable
            string firstInteger = Console.ReadLine();
            Console.WriteLine(firstInteger);

            // Ask user for 2nd interger
            Console.WriteLine("Enter another integer: ");

            //Save integer in a variable
            string secondInteger = Console.ReadLine();

            // Compare the integers
            bool isEqual = firstInteger == secondInteger;
            // Console.WriteLine(isEqual);


            // If they are equal, print "they are equal"
            if(isEqual)
            {
                Console.WriteLine("They are equal");
            }


            // Else, print "they are not equal"
            else
            {
                Console.WriteLine("They are not equal");

            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Write a console application that asks the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            Console.WriteLine("Pick a number");
            string numberAsString = Console.ReadLine();
            int number = Convert.ToInt32(numberAsString);
            bool isEven = ((number % 2) == 0);
            Console.WriteLine(isEven);

            if (isEven)
            {
                Console.WriteLine("Even");
             


            }
            else
            {
                Console.WriteLine("Odd");

                
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Write a console application to check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Is your letter a vowel or consonant?");
            string letter = Console.ReadLine();
            string vowel = "a e i o u y";
            bool aVowel = vowel.Contains(letter);
            //Console.WriteLine(aVowel);
            if (aVowel)
            {
                Console.WriteLine("This letter is a vowel");
            }
            else
            {
                Console.WriteLine("This letter is a consonant");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Write a console application that prompts the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Pick a number ");
            string firstNumber = Console.ReadLine();
            int number1 = Convert.ToInt32(firstNumber);
            Console.WriteLine("Pick a second number ");
            string secondNumber = Console.ReadLine();
            int number2 = Convert.ToInt32(secondNumber);
            
            if (number1 > number2)
            {
            Console.WriteLine(number1 + " is the largest");
                Console.ReadLine();
            }
            else if (number1 == number2)
            {
                Console.WriteLine("They're Equal");

            }
            else
            {
                Console.WriteLine(number2);

            }


            




            
          

            
            
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("\nEnter a number");
            string userNumber = Console.ReadLine();
            int num = Convert.ToInt32(userNumber);
            bool number1 = num % 3 == 0;
            if (number1)
            {
                Console.WriteLine("This number is divisible by 3");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("This number is not divisible by 3");
                Console.ReadLine();
            }
            
            

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.
            
            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here
            Console.WriteLine("How many people are dining?");
            string numberOfPeople = Console.ReadLine();
            int number = Convert.ToInt32(numberOfPeople);
            Console.WriteLine("What is the cost per person?");
            string costPerPerson = Console.ReadLine();
            int number2 = Convert.ToInt32(costPerPerson);
            int total = number * number2;
            Console.WriteLine(total + " is your total bill");

            if (total >= 50)
            {
                Console.WriteLine("You get 10% discount :)");
            }
            else
            {
                Console.WriteLine("You get a 5% discount :/");
            }
            Console.ReadLine();



            
            





            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
                    // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here
            Console.Write("Enter you age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge <= 2 && userAge >= 0)
            {
                Console.WriteLine("Still in mamas arms");
            }
            else if (userAge <= 4 && userAge >= 3)
            {
                Console.WriteLine("Preschool maniac");
            }
            else if (userAge >= 5 && userAge <= 11)
            {
                Console.WriteLine("Elemantary School");
            }
            else if (userAge >= 12 && userAge <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (userAge >=15 && userAge <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (userAge >=19 && userAge <= 22)
            {
                Console.WriteLine("College");
            }
            else if (userAge >= 23 && userAge <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if (userAge >= 66 && userAge <= 100)
            {
                Console.WriteLine("Golden years");
            }
            else  Console.WriteLine("this program is for humans");
            
            
                Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
