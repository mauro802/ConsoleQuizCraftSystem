using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuizCraftSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-10) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                    case "8":
                        Question8();
                        break;
                    case "9":
                        Question9();
                        break;
                    case "10":
                        Question10();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }

        public static void Question1()
        {
            string choice;

            Console.WriteLine("Please choose a number below:");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.Write("Write the number here: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Calculate area");
                    break;

                case "2":
                    Console.WriteLine("Calculate volume");
                    break;

                case "3":
                    Console.WriteLine("Calculate surface area");
                    break;

                case "4":
                    Console.WriteLine("Exit the program");
                    break;

                default:
                    Console.WriteLine("ERROR: Invalid choice");
                    break;
            }
        }

        public static void Question2()
        {
            int firstInteger, secondInteger, addition, subtraction, multiplication;
            char character;

            Console.Write("Please enter the first integer: ");
            firstInteger = Convert.ToInt32(Console.ReadLine());

            Console.Write("Now enter the second integer: ");
            secondInteger = Convert.ToInt32(Console.ReadLine());

            Console.Write("Finally enter a Character: ");
            character = Convert.ToChar(Console.ReadLine());

            if (character == 'A')
            {
                addition = firstInteger + secondInteger;
                Console.WriteLine($"The addition of the two integers is: {addition}");
            }
            else if (character == 'S')
            {
                subtraction = secondInteger - firstInteger;
                Console.WriteLine($"The subtraction of the second integer from the first is: {subtraction}");
            }
            else
            {
                multiplication = firstInteger * secondInteger;
                Console.WriteLine($"The multiplication of the integers is: {multiplication}");
            }
        }

        public static void Question3()
        {
            int courseNumber, totalCost;
            string residencyStatus;

            const int domesticCost = 325;
            const int internationalCost = 1375;

            Console.Write("How many courses are you going to take this semester?: ");
            courseNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Are you international or domestic student?: ");
            residencyStatus = Console.ReadLine();

            if (string.Compare(residencyStatus, "domestic", true) == 0)
            {
                totalCost = domesticCost * courseNumber;
                Console.WriteLine($"The total cost of your course will be: {totalCost:c}");
            }
            else if (string.Compare(residencyStatus, "international", true) == 0)
            {
                totalCost = internationalCost * courseNumber;
                Console.WriteLine($"The total cost of your courses will be: {totalCost:c}");
            }
            else
            {
                Console.WriteLine($"You need to enter if you are a domestic o international student");
            }
        }

        public static void Question4()
        {
            string choice;

            Console.WriteLine("Choose one of the days of the week below:");
            Console.WriteLine("    Sun");
            Console.WriteLine("    Mon");
            Console.WriteLine("    Tue");
            Console.WriteLine("    Wed");
            Console.WriteLine("    Thu");
            Console.WriteLine("    Fri");
            Console.WriteLine("    Sat");

            Console.Write("Write here the three first leters of the day you have chosen: ");
            choice = Console.ReadLine();

            if (string.Compare(choice, "Mon", true) == 0 ||
                string.Compare(choice, "Tue", true) == 0 ||
                string.Compare(choice, "Thu", true) == 0 ||
                string.Compare(choice, "Fri", true) == 0 ||
                string.Compare(choice, "Sat", true) == 0)
            {
                Console.WriteLine("You have to go to Work");
            }
            else if (string.Compare(choice, "Sun", true) == 0 || string.Compare(choice, "Wed", true) == 0)
            {
                Console.WriteLine("Cool it is your free day you can stay at Home");
            }


        }

        public static void Question5()
        {
            string option, optionUpper;

            const int pinePrice = 100;
            const int oakPrice = 125;
            const int mahoganyPrice = 310;

            Console.WriteLine("Please choose one of the three wood options for your furniture: Pine, Oak or Mahogany");
            Console.Write("write your selection here: ");
            option = Console.ReadLine();
            optionUpper = option.ToUpper();

            switch (optionUpper)
            {
                case "PINE":
                    Console.WriteLine($"Pine tables cost {pinePrice:c}");
                    break;

                case "OAK":
                    Console.WriteLine($"Oak tables cost {oakPrice:c}");
                    break;

                case "MAHOGANY":
                    Console.WriteLine($"Mahogany tables cost {mahoganyPrice:c}");
                    break;
            }
        }

        public static void Question6()
        {
            decimal hourlyPayRate;

            Console.Write("Enter your hourly pay rate: ");
            hourlyPayRate =Convert.ToDecimal(Console.ReadLine());

            if (hourlyPayRate < 5.65m)
            {
                Console.WriteLine($"Error message: your hourly pay rate of {hourlyPayRate:c2} is not acceptable");
            }
            else
            {
                Console.WriteLine($"your hourly pay rate of {hourlyPayRate:c2} is acceptable");
            }

        }

        public static void Question7()
        {
            decimal firstHourlyRate, secondHourlyRate, firstWeeklyRate, secondWeeklyRate;

            Console.Write("Enter your hourly pay rate: ");
            firstHourlyRate = Convert.ToDecimal(Console.ReadLine());

            if (firstHourlyRate < 5.65m || firstHourlyRate > 49.99m)
            {
                Console.Write("You have to prompt again: ");
                secondHourlyRate = Convert.ToDecimal(Console.ReadLine());

                if (secondHourlyRate < 5.65m || firstHourlyRate > 49.99m)
                {
                    Console.WriteLine("Error message: Your hourly pay rate was not between acceptable ranges");
                }
                else
                {
                    secondWeeklyRate = secondHourlyRate * 40m;
                    Console.WriteLine($"Your weekly rate is: {secondWeeklyRate:c2}");
                }
            }
            else
            {
                firstWeeklyRate = firstHourlyRate * 40m;
                Console.WriteLine($"Your weekly rate is: {firstWeeklyRate:c2}");
            }
        }

        public static void Question8()
        {
            decimal gradeAvarege, testScore;

            Console.WriteLine("Enter your numeric high school grade point average: ");
            gradeAvarege = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter your admision test score: ");
            testScore = Convert.ToDecimal(Console.ReadLine());

            if (gradeAvarege >= 3.0m && testScore >= 60)
            {
                Console.WriteLine("Accept");
            }
            else if (gradeAvarege < 3.0m && testScore >= 80)
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Reject");
            }
        }

        public static void Question9()
        {
            decimal hourlyPayRate, hoursWorked, grossPay, netPay, withHoldingTax;

            Console.WriteLine("Enter your hourly pay rate: ");
            hourlyPayRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter your hours worked: ");
            hoursWorked = Convert.ToDecimal(Console.ReadLine());

            grossPay = hoursWorked * hourlyPayRate;

            if (grossPay <= 300.00m)
            {
                const decimal HoldingTax = 0.10m;
                withHoldingTax = grossPay * HoldingTax;
                netPay = grossPay - withHoldingTax;
                Console.WriteLine($" Your gross pay is: {grossPay:c2}");
                Console.WriteLine($" Your withholding tax is: {withHoldingTax:c2}");
                Console.WriteLine($" Your net pay is: {netPay:c2}");
            }
            else if (grossPay > 300.01m)
            {
                const decimal HoldingTax = 0.12m;
                withHoldingTax = grossPay * HoldingTax;
                netPay = grossPay - withHoldingTax;
                Console.WriteLine($" your gross pay is:{grossPay:c2}");
                Console.WriteLine($" your withholding tax is: {withHoldingTax:c2}");
                Console.WriteLine($" your net pay is:{netPay:c2}");
            }
        }

        public static void Question10()
        {
            decimal length, width, area, totalFee;

            const int lawnSeason = 20;

            Console.WriteLine("enter the length of the area: ");
            length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("enter the width of the area: ");
            width = Convert.ToDecimal(Console.ReadLine());

            area = length * width;

            if (area < 400)
            {
                const int weeklyFee = 25;
                totalFee = area * lawnSeason * weeklyFee;
                Console.WriteLine($"The weekly fee is: {weeklyFee:c2} and the total fee is: {totalFee:c2} ");

            }
            else if (area <= 400 && area < 600)
            {
                const int weeklyFee = 35;
                totalFee = area * lawnSeason * weeklyFee;
                Console.WriteLine($"The weekly fee is: {weeklyFee:c2} and the total fee is: {totalFee:c2} ");
            }
            else if (area >= 600)
            {
                const int weeklyFee = 50;
                totalFee = area * lawnSeason * weeklyFee;
                Console.WriteLine($"The weekly fee is: {weeklyFee:c2} and the total fee is: {totalFee:c2} ");
            }
        }
    }
}
