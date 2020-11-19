using System;
using System.Collections.Generic;
using System.Linq;

namespace InlamningsuppgiftOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My If Else Calculator";
            Console.WriteLine("You can choose betwen these operators:  +  -  *  /");
            List<double> calcSumList = new List<double>();
            const string exit = "x";
            string continueOreExit = "";
            double calcSum = 0;

            while (continueOreExit != exit)
            {
                // Användaren får mata in räknesätt och tal
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Enter first operator: ");
                string firstOperator = Console.ReadLine();
                char firstOp = Convert.ToChar(firstOperator);
               
                Console.Write("Enter second operator: ");
                string secondOperator = Console.ReadLine();
                char secondOp = Convert.ToChar(secondOperator);
                Console.WriteLine();

                Console.Write("Enter first term: ");
                double firstTerm = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second term: ");
                double secondTerm = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter third term: ");
                double thirdTerm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                
                // Olika uträkningar beroende vilket räknesätt(operator) användaren matar in
                if(firstOp == '+')
                {
                    if(secondOp == '+')
                    {
                        calcSum = firstTerm + secondTerm + thirdTerm;
                    }
                    else if(secondOp == '-')
                    {
                        calcSum = firstTerm + secondTerm - thirdTerm;
                    }
                    else if(secondOp == '*')
                    {
                        calcSum = firstTerm + secondTerm * thirdTerm;
                    }
                    else if(secondOp == '/')
                    {
                        calcSum = firstTerm + secondTerm / thirdTerm;
                    }

                }
                if (firstOp == '-')
                {
                    if (secondOp == '+')
                    {
                        calcSum = firstTerm - secondTerm + thirdTerm;
                    }
                    else if (secondOp == '-')
                    {
                        calcSum = firstTerm - secondTerm - thirdTerm;
                    }
                    else if (secondOp == '*')
                    {
                        calcSum = firstTerm - secondTerm * thirdTerm;
                    }
                    else if (secondOp == '/')
                    {
                        calcSum = firstTerm - secondTerm / thirdTerm;
                    }

                }
                if (firstOp == '*')
                {
                    if (secondOp == '+')
                    {
                        calcSum = firstTerm * secondTerm + thirdTerm;
                    }
                    else if (secondOp == '-')
                    {
                        calcSum = firstTerm * secondTerm - thirdTerm;
                    }
                    else if (secondOp == '*')
                    {
                        calcSum = firstTerm * secondTerm * thirdTerm;
                    }
                    else if (secondOp == '/')
                    {
                        calcSum = firstTerm * secondTerm / thirdTerm;
                    }

                }
                if (firstOp == '/')
                {
                    if (secondOp == '+')
                    {
                        calcSum = firstTerm / secondTerm + thirdTerm;
                    }
                    else if (secondOp == '-')
                    {
                        calcSum = firstTerm / secondTerm - thirdTerm;
                    }
                    else if (secondOp == '*')
                    {
                        calcSum = firstTerm / secondTerm * thirdTerm;
                    }
                    else if (secondOp == '/')
                    {
                        calcSum = firstTerm / secondTerm / thirdTerm;
                    }

                }
                // Lägger till summan av uträkningen till listan och skriver ut svaret av uträkningen
                calcSumList.Add(calcSum);
                Console.WriteLine($"Svar: {firstTerm} {firstOperator} {secondTerm} {secondOperator} {thirdTerm} = {calcSum}");
                Console.WriteLine();

                // Olika svar beroende på om calcSum är mindre, större eller lika med 100
                // Om användaren trycker 'x' stängs programmet ner och skriver ut summan de enskilda uträkningar och den totala summan av alla uträkningar tillsammans
                // Om användaren trycker "enter" börjar miniräknaren om från toppen av while loopen
                if (calcSum < 100)
                {
                    Console.WriteLine("\"The sum is less than a hundred\"");
                    Console.Write("Another Try?    Continue = [enter]    ||    Exit = x: ");
                    continueOreExit = Console.ReadLine();
                    Console.WriteLine();
                    if (continueOreExit == exit)
                    {
                        Console.WriteLine($"Sum of each calculation: {string.Join('+', calcSumList)}");
                        Console.WriteLine();
                        Console.Write($"Thank you for playing. The sum of all calculations is {calcSumList.Sum()}. Bye, have a nice day!");
                        Console.WriteLine();
                    }
                }
                else if (calcSum > 100)
                {
                    Console.WriteLine("\"The sum is more than a hundred\"");
                    Console.Write("Another Try?    Continue = [enter]    ||    Exit = x: ");
                    continueOreExit = Console.ReadLine();
                    Console.WriteLine();
                    if (continueOreExit == exit)
                    {
                        Console.WriteLine($"Sum of each calculation: {string.Join('+', calcSumList)}");
                        Console.WriteLine();
                        Console.Write($"Thank you for playing. The sum of all calculations is {calcSumList.Sum()}. Bye, have a nice day!");
                        Console.WriteLine();
                    }
                }
                else if (calcSum == 100)
                {
                    Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                    Console.Write("Another Try?    Continue = [enter]    ||    Exit = x: ");
                    continueOreExit = Console.ReadLine();
                    Console.WriteLine();
                    if (continueOreExit == exit)
                    {
                        Console.WriteLine($"Sum of each calculation: {string.Join('+', calcSumList)}");
                        Console.WriteLine();
                        Console.Write($"Thank you for playing. The sum of all calculations is {calcSumList.Sum()}. Bye, have a nice day!");
                        Console.WriteLine();
                    }

                }





            }
        }
    }
}
