using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Learning_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RunExerciseFourteen();
                            break;
                        case 18:
                            RunExerciseEighteen();
                            break;
                        case 19:
                            RunExerciseNineteen();
                            break;
                        case 21:
                            RunExerciseTwentyOne();
                            break;
                        case 25:
                            RunExerciseTwentyFive();
                            break;
                        case 26:
                            RunExerciseTwentySix();
                            break;
                        case 27:
                            RunExerciseTwentySeven();
                            break;
                        case 28:
                            RunExerciseTwentyEight();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }


        private static void RunExerciseOne()
        {
            var firstName = "Andreas"; 
            var lastName = "Lönnermark";
            Console.WriteLine("Hello {0} {1}! I'm glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);
            Console.WriteLine("You successfully ran exercise one!");
        }

        private static void RunExerciseTwo()
        {
            var todayDate = DateTime.Now;
            var tomorrowDate = todayDate.AddDays(1);
            var yesterdayDate = todayDate.AddDays(-1);
            Console.WriteLine("Todays date is " + todayDate);
            Console.WriteLine("Tomorrows date is " + tomorrowDate);
            Console.WriteLine("Yesterdays date was " + yesterdayDate);
            Console.WriteLine("You successfully ran exercise two!");
        }

        private static void RunExerciseThree()
        {
            string firstName, lastName;
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Your name is: " + firstName + " " + lastName);
        }

        private static void RunExerciseFour()
        {
            String str = "The quick fox Jumped Over the DOG";
            String nstr;
            Console.WriteLine(str);
            nstr = str.Replace("J", "j");
            nstr = nstr.Replace("O", "o");
            nstr = nstr.Replace("D", "d");
            nstr = nstr.Replace("G", "g");
            Console.WriteLine(nstr);
            nstr = nstr.Insert(nstr.IndexOf(" d"), " lazy");
            Console.WriteLine(nstr);
        }

        private static void RunExerciseFive()
        {
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            String nstr = str.Substring(str.IndexOf("["), str.Length - str.IndexOf("["));
            Console.WriteLine(nstr);
            nstr = nstr.Remove(nstr.IndexOf("2"), 4);
            Console.WriteLine(nstr);
            nstr = nstr.Replace("]", ",6,7,8,9,10]");
            Console.WriteLine(nstr);
        }

        private static void RunExerciseSix()
        {
            int number1, number2;
            Console.Write("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Biggest number: " + Math.Max(number1, number2));
            Console.WriteLine("Smallest number: " + Math.Min(number1, number2));
            int sum = number1 + number2;
            Console.WriteLine("Sum: " + sum);
            int diff = number1 - number2;
            Console.WriteLine("Difference: " + diff);
            int product = number1 * number2;
            Console.WriteLine("Product: " + product);
            int ratio = number1 / number2;
            Console.WriteLine("Ratio: " + ratio);
        }

        private static void RunExerciseSeven()
        {
            Console.Write("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine().Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture);
            double areaCircle = Math.PI * Math.Pow(radius, 2);
            double areaSphere = 4 * Math.PI * Math.Pow(radius, 2);
            double volumeSphere = 4 * Math.PI * Math.Pow(radius, 2) / 3;
            Console.WriteLine("Area of the circle: " + areaCircle);
            Console.WriteLine("Area of the sphere: " + areaSphere);
            Console.WriteLine("Volume of the sphere: " + volumeSphere);
        }

        private static void RunExerciseEight()
        {
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine().Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture);
            Console.WriteLine("Squareroot: " + Math.Sqrt(number));
            Console.WriteLine("Square: " + Math.Pow(number, 2));
            Console.WriteLine("Power of ten: " + Math.Pow(number, 10));
        }

        private static void RunExerciseNine()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("Welcome {0}! What year where you born? ", name);
            int birthYear = int.Parse(Console.ReadLine() ?? "");
            int age = DateTime.Now.Year - birthYear;
            string answer;

            if (age >= 18)
            {
                Console.Write("Would you like a beer (y/n)? ");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Beer has been served!");
                }
                else
                {
                    Console.Write("Would you like a coke (y/n)? ");
                    answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("Coke has been served!");
                    }
                    else
                    {
                        Console.WriteLine("No more options available.");
                    }
                }
            }
            else
            {
                Console.Write("Would you like a coke (y/n)? ");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Coke has been served!");
                }
                else
                {
                    Console.WriteLine("No more options available.");
                }
            }
        }

        private static void RunExerciseTen()
        {
            Console.Write("Choose one of three options: ");
            int choice = int.Parse(Console.ReadLine() ?? "");
            switch (choice)
            {
                case 1:
                    Division();
                    break;
                case 2:
                    RunExerciseFour();
                    break;
                case 3:
                    if (Console.ForegroundColor == ConsoleColor.Green)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }

        private static void RunExerciseEleven()
        {
            int number;
            Console.Write("Enter an integer above zero: ");
            number = int.Parse(Console.ReadLine() ?? "");
            if (number <= 0)
            {
                Console.WriteLine("Number must be greater than zero!");
            }
            else
            {
                for (int i = 0; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(i);
                }
                Console.WriteLine("------------------------------------------------");
                for (int i = number; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(i);
                }
            }
        }

        private static void RunExerciseTwelve()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= 10; j++)
                {
                    if (i > 0)
                    {
                        Console.Write(i * j + "\t");
                    }
                    else
                    {
                        Console.Write(j + "\t");
                    }
                }
                Console.Write("\n");
            }
        }

        private static void RunExerciseThirteen()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 500);
            int guess = 0;
            int numberofGuesses = 0;
            Console.Write("Guess an integer between 1 and 500: ");
            do
            {
                String input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    guess = Convert.ToInt32(input);
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("{0} is correct!", guess);
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess was too small.");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess was too big.");
                    }
                    numberofGuesses++;
                }
                else
                {
                    Console.WriteLine("Input must be an integer.");
                }

            }
            while (guess != randomNumber);
            Console.WriteLine("Number of guesses: {0}", numberofGuesses);
        }

        private static void RunExerciseFourteen()
        {
            double sum = 0, number = 0, average, count = 0;
            while (number != -1)
            {
                number = GetNumberFromUser();
                if (number >= 0)
                {
                    sum += number;
                    count++;
                }
                
            }
            average = sum / count;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
        }

        private static void RunExerciseEighteen()
        {
            int[] intArray = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                intArray[i] = random.Next(1, 1000);
            }

            double[] doubleArray = new double[10];
            for (int i = 0; i < 10; i++)
            {
                doubleArray[i] = 1 / Convert.ToDouble(intArray[i]);
            }

            foreach (int value in intArray)
            {
                Console.WriteLine(value);
            }

            foreach (double value in doubleArray)
            {
                Console.WriteLine(value);
            }
        }

        private static void RunExerciseNineteen()
        {
            Random random = new Random();
            int price = random.Next(10000), change;
            int[] priceUnits = new int[10];

            Console.WriteLine("Money to pay: " + price + " kr.");
            Console.Write("Enter the sum to pay: ");
            change = int.Parse(Console.ReadLine() ?? "") - price;
            Console.WriteLine("Calculated change: " + change);

            priceUnits[0] = change / 1000;
            change %= 1000;
            priceUnits[1] = change / 500;
            change %= 500;
            priceUnits[2] = change / 200;
            change %= 200;
            priceUnits[3] = change / 100;
            change %= 100;
            priceUnits[4] = change / 50;
            change %= 50;
            priceUnits[5] = change / 20;
            change %= 20;
            priceUnits[6] = change / 10;
            change %= 10;
            priceUnits[7] = change / 5;
            change %= 5;
            priceUnits[8] = change / 2;
            change %= 2;
            priceUnits[9] = change / 1;

            Console.WriteLine("1000 bills = " + priceUnits[0]);
            Console.WriteLine("500 bills = " + priceUnits[1]);
            Console.WriteLine("200 bills = " + priceUnits[2]);
            Console.WriteLine("100 bills = " + priceUnits[3]);
            Console.WriteLine("50 bills = " + priceUnits[4]);
            Console.WriteLine("20 bills = " + priceUnits[5]);
            Console.WriteLine("10 coins = " + priceUnits[6]);
            Console.WriteLine("5 coins = " + priceUnits[7]);
            Console.WriteLine("2 coins = " + priceUnits[8]);
            Console.WriteLine("1 coins = " + priceUnits[9]);
        }

        private static void RunExerciseTwentyOne()
        {
            Console.Write("Enter a string of numbers separated by commas: ");
            String input = Console.ReadLine();
            String[] sanInput = input.Split(",");
            List<int> numbers = new List<int>();
            int sum = 0;
            foreach (String value in sanInput)
            {
                numbers.Add(int.Parse(value ?? ""));
            }

            numbers.Sort();
            foreach (int value in numbers)
            {
                sum += value;
            }

            int average = sum / numbers.Count;
            Console.WriteLine("Min: " + numbers[0]);
            Console.WriteLine("Max: " + numbers[numbers.Count - 1]);
            Console.WriteLine("Average: " + average);
        }

        private static void RunExerciseTwentyFive()
        {
            int num, den = 0;
            double ratio = 0;

            num = GetIntegerFromUser();
            while (den == 0)
            {
                try
                {
                    den = GetIntegerFromUser();
                    ratio = Convert.ToDouble(num) / Convert.ToDouble(den);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Denominator can not be zero, please try again");
                }
            }
            Console.WriteLine("Ratio: " + ratio);
        }

        private static void RunExerciseTwentySix()
        {
            Console.WriteLine("My documents: " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine("My pictures: " + Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            Console.WriteLine("Program files (x86): " + Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            Console.WriteLine("Cookies: " + Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            Console.WriteLine("Current directory: " + Environment.CurrentDirectory);

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\text.txt";
            var file = File.Create(filePath);
            file.Close();
            Console.WriteLine("File created successfully!");
        }

        private static void RunExerciseTwentySeven()
        {
            try
            {
                using (StreamReader sr = new StreamReader("MyName.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File could not be read.");
                Console.WriteLine(e.Message);
            }
        }

        private static void RunExerciseTwentyEight()
        {
            String[] names1 = new String[] { "Andreas", "Anders", "Anne", "Johanna", "Adam" };
            String[] names2 = new String[] { "Tobias", "Axel", "Jesper", "Martin", "Nick" };
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\text.txt";

            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        foreach (String name in names1)
                        {
                            sw.WriteLine(name);
                        }
                        sw.Close();
                    }

                    using (StreamWriter sw = new StreamWriter(filePath, false))
                    {
                        foreach(String name in names2)
                        {
                            sw.WriteLine(name);
                        }
                        sw.Close();
                    }
                    Console.WriteLine("File saved succesfully!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong.");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        private static int GetIntegerFromUser()
        {
            int number = 0;
            bool success = false;
            string input;

            while (!success)
            {
                try
                {
                    Console.Write("Enter an integer: ");
                    input = Console.ReadLine();
                    //success = int.TryParse(input ?? "", out number);
                    number = int.Parse(input ?? "");
                    success = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("No input received, please try again.");
                }
            }
            return number;
            
        }

        private static double GetNumberFromUser()
        {
            double number = 0;
            bool success = false;
            string input;

            while (!success)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
                success = double.TryParse(input.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out number);
                if (!success)
                {
                    Console.WriteLine("Invalid input, please write a number.");
                }
            }
            return number;
        }
        private static void Division()
        {
            double num, den, ratio;
            Console.WriteLine("Divide two numbers");
            num = GetNumberFromUser();
            do
            {
                den = GetNumberFromUser();
                if (den == 0)
                {
                    Console.WriteLine("Denominator can not be 0, please try again.");
                }
            }
            while (den == 0);

            ratio = num / den;
            Console.WriteLine("Ratio: " + ratio);
        }
    }
}
