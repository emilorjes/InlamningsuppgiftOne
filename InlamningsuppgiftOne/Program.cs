using System;
using System.Collections.Generic;
using System.Linq;

namespace InlamningsuppgiftOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ändrar titeln och välkomnar användaren
            Console.Title = "My If Else Calculator + - * /";
            Console.WriteLine("Welcome to my calculator!");
            Console.WriteLine("You can choose betwen these operators:  +  -  *  /");

            // List<> och Variabler
            List<double> calcSumList = new List<double>();
            const string exit = "x";
            string continueOreExit = "";
            double calcSum = 0;
            string firstOperator, secondOperator;
            char firstOp, secondOp;
            double firstTerm, secondTerm, thirdTerm;

            // Loopar tills använder väljer att avsluta 
            while (continueOreExit != exit)
            {
                // Användaren får mata in räknesätt och tal
                UserInput(out firstOperator, out firstOp, out secondOperator, out secondOp, out firstTerm, out secondTerm, out thirdTerm);

                // Olika uträkningar beroende vilket räknesätt(operator) användaren matar in
                // Om första operatorn är addition
                calcSum = FirsOpAdd(calcSum, firstOp, secondOp, firstTerm, secondTerm, thirdTerm);

                // Om första operatorn är subtraktion
                calcSum = FirstOpSub(calcSum, firstOp, secondOp, firstTerm, secondTerm, thirdTerm);

                // Om första operatorn är multiplikation
                calcSum = FirstOpMul(calcSum, firstOp, secondOp, firstTerm, secondTerm, thirdTerm);

                // Om första operatorn är division
                calcSum = FirstOpDiv(calcSum, firstOp, secondOp, firstTerm, secondTerm, thirdTerm);


                // Lägger till summan av uträkningen till listan och skriver ut svaret av uträkningen
                AddSumToList(calcSumList, calcSum, firstOperator, secondOperator, firstTerm, secondTerm, thirdTerm);

                // Olika svar beroende på om calcSum är mindre, större eller lika med 100
                // Om användaren trycker 'x' stängs programmet ner och skriver ut summan de enskilda uträkningar och den totala summan av alla uträkningar tillsammans
                // Om användaren trycker "enter" börjar miniräknaren om från toppen av while loopen
                continueOreExit = CalcSumLessBiggEqual(calcSumList, exit, continueOreExit, calcSum);

            }
        }












        // Användaren får mata in räknesätt och tal
        private static void UserInput(out string firstOperator, out char firstOp, out string secondOperator, out char secondOp, out double firstTerm, out double secondTerm, out double thirdTerm)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter first operator: ");
            firstOperator = Console.ReadLine();
            firstOp = Convert.ToChar(firstOperator);
            Console.Write("Enter second operator: ");
            secondOperator = Console.ReadLine();
            secondOp = Convert.ToChar(secondOperator);
            Console.WriteLine();

            Console.Write("Enter first term: ");
            firstTerm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second term: ");
            secondTerm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third term: ");
            thirdTerm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }




        // Om första operatorn är addition och beroende vad den andra operatorn är sparas summan av talen i calcSum
        private static double FirsOpAdd(double calcSum, char firstOp, char secondOp, double firstTerm, double secondTerm, double thirdTerm)
        {
            if (firstOp == '+')
            {
                if (secondOp == '+')
                {
                    calcSum = firstTerm + secondTerm + thirdTerm;
                }
                else if (secondOp == '-')
                {
                    calcSum = firstTerm + secondTerm - thirdTerm;
                }
                else if (secondOp == '*')
                {
                    calcSum = firstTerm + secondTerm * thirdTerm;
                }
                else if (secondOp == '/')
                {
                    calcSum = firstTerm + secondTerm / thirdTerm;
                }

            }

            return calcSum;
        }




        // Om första operatorn är subtraktion och beroende vad den andra operatorn är sparas summan av talen i calcSum
        private static double FirstOpSub(double calcSum, char firstOp, char secondOp, double firstTerm, double secondTerm, double thirdTerm)
        {
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

            return calcSum;
        }




        // Om första operatorn är multiplikation och beroende vad den andra operatorn är sparas summan av talen i calcSum
        private static double FirstOpMul(double calcSum, char firstOp, char secondOp, double firstTerm, double secondTerm, double thirdTerm)
        {
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

            return calcSum;
        }




        // Om första operatorn är division och beroende vad den andra operatorn är sparas summan av talen i calcSum
        private static double FirstOpDiv(double calcSum, char firstOp, char secondOp, double firstTerm, double secondTerm, double thirdTerm)
        {
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

            return calcSum;
        }




        // Lägger till summan av uträkningen (calcSum) till listan och skriver ut svaret av uträkningen
        private static void AddSumToList(List<double> calcSumList, double calcSum, string firstOperator, string secondOperator, double firstTerm, double secondTerm, double thirdTerm)
        {
            calcSumList.Add(calcSum);
            Console.WriteLine($"Svar: {firstTerm} {firstOperator} {secondTerm} {secondOperator} {thirdTerm} = {calcSum}");
            Console.WriteLine();
        }




        // Olika svar beroende på om calcSum är mindre, större eller lika med 100
        // Om användaren trycker 'x' stängs programmet ner och skriver ut summan de enskilda uträkningar och den totala summan av alla uträkningar tillsammans
        // Om användaren trycker "enter" börjar miniräknaren om från toppen av while loopen
        private static string CalcSumLessBiggEqual(List<double> calcSumList, string exit, string continueOreExit, double calcSum)
        {

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

            return continueOreExit;

        }












    }
}
