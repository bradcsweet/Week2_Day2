using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops

            //for(int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int counter = 50; counter<= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greeting = "My name is Little Bill";
            //string[] words = greeting.Split();

            //for(int i =0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            //do it
            //string[] daysWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //for (int i = 0; i < daysWeek.Length; i++)
            //{
            //    Console.WriteLine(daysWeek[i]);
            //}

            //string beGinning = "Once upon a time";
            //string[] storyWords = beGinning.Split();
            //Array.Reverse(storyWords);

            //for ( int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}


            //Foreach loop

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };

            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            ////}

            //string[] bands = { "John Mayer", "Vulpeck", "KNOWER", "Womantra", "Space Funeral" };

            //foreach(string band in bands)
            //{
            //    Console.WriteLine(band);
            //}

            //string[] favFoods = { "Cheeseburger", "Steak", "Mushrooms", "Celery", "Pickles", "Cole Slaw" };

            //foreach (string favfood in favFoods)
            //{
            //    Console.WriteLine(favfood);
            //}

            //double[] luckyNumbers = { 3, 3.16, 7, 1.618, 15 };

            //foreach (double luckyNumber in luckyNumbers)
            //{
            //    Console.WriteLine("Your lucky number is " + luckyNumber);
            //}

            //for(int i = 0; i <= 10; i++)
            //{
            //    //Console.WriteLine(i);

            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //   // Console.WriteLine(counter);
            //}

            //string greetings = "My name is Brad";
            //string[] words = greetings.Split();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            //for(int i = 10; i>0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Do you want to play a game? (YES/NO");
            //string playAgain = Console.ReadLine();

            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine();
            //} 

            //Console.WriteLine(" Would you like to check in the patient in for their appointment?");
            //string userAnswer = Console.ReadLine().ToUpper();

            //while(userAnswer == "YES")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Whats your full name");
            //    Console.ReadLine();
            //    Console.WriteLine("Whats your 6 digit patient ID");
            //    Console.ReadLine();
            //    Console.WriteLine("What appointmnet time?");
            //    Console.ReadLine();
            //    Console.WriteLine("Would you like to check in the patient for their appointment?");
            //    userAnswer = Console.ReadLine().ToUpper();
            //}

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");

            //Console.WriteLine("Thanks for playing the game.");


            //string calcuGPA;

            //do
            //{
            //    Console.WriteLine("What class would you like to add to your GPA calculation?");
            //    Console.ReadLine();
            //    Console.WriteLine("What letter grade did you get for the class? (omit + and -)");
            //    Console.ReadLine();
            //    Console.WriteLine("Do you have another class to add to the GPA calculation");
            //    calcuGPA = Console.ReadLine().ToUpper();
            //}
            //while (calcuGPA == "YES");

            //break and continue

            //for(int i = 1; i <= 20; i++)
            //{
            //    if(i % 13 == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("The loop has finished.");


            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        Console.Write(j);   //Columns
            //    }
            //    Console.WriteLine();    //Next row
            //}

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row<= n; row++)
            {
                for(int col = 1; col<= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }


        





            //Tutoring

            //Console.WriteLine("Pick a number one through five.");
            //Console.WriteLine("Enter a number and I'll tell you what your favorite  superhero is");
            //Console.WriteLine("Enter your number now!");

            //int userNumber = int.Parse(Console.ReadLine());
            //string bestHero = "";

            //switch (userNumber)
            //{
            //    case 1:
            //        bestHero = "Wonder Woman";
            //        break;
            //    case 2:
            //        bestHero = "Spider-Man";
            //        break;
            //    case 3:
            //        bestHero = "Wolverine";
            //        break;
            //    case 4:
            //        bestHero = "Batgirl";
            //        break;
            //    case 5:
            //        bestHero = "Batman";
            //        break;
            //    default:
            //        Console.WriteLine("No, I said 1-5!");
            //        break;
            //}
            //Console.WriteLine(bestHero);

            //Console.WriteLine("What is your favorite CDMRW animal?");
            //Console.WriteLine("If you dont know what cdmrw stands for, type help");

            //string faveAnimal = Console.ReadLine().ToLower();
            //string snack;

            //while(faveAnimal == "help")
            //{
            //    Console.WriteLine("Cat\tDog\tMonkey\tReindeer\tWhale");
            //    Console.WriteLine("Please enter your favorite CDMRW animal");
            //    Console.ReadLine();

            //    switch(faveAnimal)
            //    {
            //        case "cat":
            //            snack = "tuna";
            //            break;
            //        case "dog":
            //            snack = "bacon";
            //            break;
            //        case "monkey":
            //            snack = "banana";
            //            break;
            //        case "reindeer":
            //            snack = "kale chips";
            //            break;
            //        case "whale":
            //            snack = "krill";
            //            break;
            //        default:
            //            snack = "twinkies";
            //            break;
            //     }

            //    Console.WriteLine("Your healthy snack is " + snack);

        }

    }
}