﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Logical Programs.");
            Console.WriteLine("\n1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n5.Coupon Number\n6.Stimulate Stopwatch\n7.Notes Vending Machine\n8.Days Of Week\n9.Temperature Conversion\n10.Monthly Payment\n11.Square Root\n12.Decimal To Binary");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Series();
                    break;

                case 2:
                    PerfectNumber.Number();
                    break;

                case 3:
                    PrimeNumber.Number();
                    break;  

                case 4:
                    ReverseNumber.Number();
                    break;

                case 5:
                    CouponNumber.Number();
                    break;

                case 6:
                    StopWatch.GetElapsedTime();
                    break;

                case 7:
                    VendingMachine.GetNotes();
                    break;

                case 8:
                    DayOfWeek.Days();
                    break;

                case 9:
                    TemperatureConversion.TempConvert();
                    break;

                case 10:
                    MonthlyPayment.GetPayment();
                    break;

                case 11:
                    SquareRoot.GetSquareRoot();
                    break;

                case 12:
                    ToBinary.GetBinary();
                    break;

                default:
                    Console.WriteLine("Choose from above options only.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
