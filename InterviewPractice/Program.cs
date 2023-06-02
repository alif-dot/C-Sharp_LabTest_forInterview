using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

             //Check whether two integers are equal or not
             int int1, int2;
             Console.Write("Check whether two integers are equal or not:\n");
             Console.Write("-----------------------------------------\n\n");

             Console.Write("Input 1st number:");
             int1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input 2nd number:");
             int2 = Convert.ToInt32(Console.ReadLine());

             if(int1 == int2)
             Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
             else
             Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);



             //Check whether a number is even or odd
             int num1, rem1;
             Console.Write("Check whether a number is even or odd \n");
             Console.Write("------------------------------------------- \n\n");
             Console.Write("Input an integer:");
             num1 = Convert.ToInt32(Console.ReadLine());
             rem1 = num1 % 2;
             if(rem1 == 0)
             Console.WriteLine("{0} is even integer.\n", num1);
             else
             Console.WriteLine("{0} is Odd integer.\n", num1);
             
            

            //Check whether a number is positive or negative
            int num;
            Console.WriteLine("Check whether a number is positive or negative \n");
            Console.WriteLine("-----------------------------\n");
            Console.WriteLine("Input an Integer");
            num = Convert.ToInt32(Console.ReadLine());

            if(num >= 0)
                Console.WriteLine("{0} is positive number.\n", num);
            else
                Console.WriteLine("{0} is negative number.\n", num);
            

            //Check whether a given year is a leap year or not
            int chk_year;
            Console.WriteLine("Check whether a given year is a leap year or not");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Input an year");
            chk_year = Convert.ToInt32(Console.ReadLine());

            if((chk_year % 400) == 0)
                Console.WriteLine("{0} is Leap year. \n", chk_year);
            if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is Leap year. \n", chk_year);
            if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is Leap year. \n", chk_year);
            else
                Console.WriteLine("{0} is not a Leap year. \n", chk_year);
            

            //Check a specific age is eligible for casting the vote
            int vote_age;
            Console.WriteLine("Detrermine a specific age is eligible for casting the vote. \n");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Input the age of the candidate: \n");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if(vote_age < 18)
            {
                Console.WriteLine("Sorry, You are not eligible to caste your vote. \n");
                Console.WriteLine("You would be able to caste your vote after {0} year. \n", 18 - vote_age);
            }
            else
                Console.WriteLine("Congratulation! You are eligible for casting your vote. \n");
            

            //Find the largest of three numbers
            int n1, n2, n3;
            Console.WriteLine("Find the largest of three numbers. \n");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Input 1st number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 3rd number");
            n3 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2)
            {
                if(n1 > n3)
                {
                    Console.WriteLine("The 1st number is the greatest among three. \n");
                }
                else 
                { 
                    Console.WriteLine("The 3rd Number is the greatest among three.\n");
                }
            }
            else if(n2 > n3)
                Console.WriteLine("The 2nd Number is the greatest among three. \n");
            else
                Console.WriteLine("The 3rd Number is the greatest among three. \n");
            

            //Check whether a triangle can be formed by a given value
            int t1, t2, t3, sum;
            Console.WriteLine("Check whether a triangle can be formed by a given value. \n");
            Console.WriteLine("--------------------- \n");

            Console.WriteLine("Input angle 1 of triangle:");
            t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input angle 2 of triangle:");
            t2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input angle 3 of triangle:");
            t3 = Convert.ToInt32(Console.ReadLine());

            sum = t1 + t2 + t3;

            if(sum == 180)
            {
                Console.WriteLine("The triangle is valid. \n");
            }
            else
            {
                Console.WriteLine("The triangle is not valid. \n");
            }
            

            //Calculate profit and loss
            int cprice, sprice, plamt;
            Console.WriteLine("Calculate profit and loss. \n");
            Console.WriteLine("------------------------- \n");

            Console.WriteLine("Input cost price:");
            cprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Selling price:");
            sprice = Convert.ToInt32(Console.ReadLine());
            
            if(sprice > cprice)
            {
                plamt = sprice - cprice;
                Console.WriteLine("\nYou can booked your profit amount : {0}\n", plamt);
            }
            else if(cprice > sprice)
            {
                plamt = cprice - sprice;
                Console.WriteLine("\nYou got a loss of amount : {0}\n", plamt);
            }
            else
            {
                Console.WriteLine("\nYou are running in no profit no loss condition.\n");
            }

            

            //Input the day number and display its equivalent day name in the word

            int dayno;
            Console.WriteLine("Input the day number and display its equivalent day name in the word. \n");
            Console.WriteLine("------------------------- \n");

            Console.WriteLine("Input day no:");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1: Console.WriteLine("Monday \n");
                    break;
                case 2: Console.WriteLine("Tuesday \n");
                    break;
                case 3: Console.WriteLine("Wednesday \n");
                    break;
                case 4: Console.WriteLine("Thursday \n");
                    break;
                case 5: Console.WriteLine("Friday \n");
                    break;
                case 6: Console.WriteLine("Saturday \n");
                    break;
                case 7: Console.WriteLine("Sunday \n");
                    break;
                default: Console.WriteLine("Inalid day number. \n Please try again.... \n");
                    break;
            }

            Console.ReadLine();

        }
    }
}
