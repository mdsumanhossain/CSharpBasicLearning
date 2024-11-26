using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Hello World \n");
            Console.WriteLine("I;m sumon Hossain");
            Console.WriteLine("Age 23 year old");
            Console.WriteLine("i;m learning a C# basic");
            

            int num = 10;
            int num1 = 20;
            double num2 = 10.5;
            string name = "Md.Suman Hossain";
            bool cow = true;

           string name1 = "hamin";
            //type casting
            int num3 = num + (int)num2;
            Console.WriteLine(num3);
            Console.WriteLine(num2);
            Console.WriteLine(name);
            Console.WriteLine(cow);
            Console.WriteLine(name1);
            

            //type casting babohar implecity automatic korbe
            int n = 1233;
            //string convert
            string name2 = Convert.ToString(n);
            Console.WriteLine(name2);
           

            //perse and tryPerse method use and ata string k convert kore take integer jeta boolean true false result dibe
            //manual vabe type casting korbo jeta explecity bole
            string a = "10";
            int c;

            bool b = int.TryParse(a, out c);
            Console.WriteLine($"b number is = "+b);
            Console.WriteLine($"c numbe is = "+c);


            //user input kaj
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Your name is = "+name);
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is = "+age);

            int n1, n2;
            Console.WriteLine("Eneter Your N1 Value : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your N2 Sufiyum Sujatayumalue: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            int result;

            result = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {result}");
            result = n1 - n2;
            Console.WriteLine($"{n1} - {n2} = {result}");
            result = n1 * n2;
            Console.WriteLine($"{n1} * {n2} = {result}");
            result = n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {result}");
            result = n1 % n2;
            Console.WriteLine($"{n1} % {n2} = {result}");*/


            //Console.WriteLine("Sumon");
            // string n = "Shuvo";
            // Console.WriteLine(sbyte.MaxValue);
            //Console.WriteLine(sbyte.MinValue);
            // sbyte n1 = 128;
            // Console.WriteLine(n);
            //Sbyte
            /* sbyte n1 = -126;
             sbyte n2 = 126;
             Console.WriteLine(n1);
             //Console.WriteLine(n2);
             sbyte temperature = -10;
             Console.WriteLine("Initial Temperature: " + temperature);
             //short
             short s = -172;
             Console.WriteLine(s);
             Console.WriteLine(short.MaxValue);
             Console.WriteLine(short.MinValue);
             //integer
             int i = 54255669;
             Console.WriteLine(i);
             //double
             double d = 24575;
             Console.WriteLine(d);
             i = Convert.ToInt32(d);
             Console.WriteLine(i);

             int n3 = Convert.ToInt32(Console.ReadLine());
             int n4 = Convert.ToInt32(Console.ReadLine());
             int n5 = Convert.ToInt32(Console.ReadLine());
             int sum = n3 + n4 + n5;
             Console.WriteLine($"{n3} + {n4} + {n5} = {sum}");
             int avg = sum / 3;
             Console.WriteLine(avg);
             int sub = n3 - n4 - n5;
             Console.WriteLine($"{n3} - {n4} - {n5} = {sub}");
            //Traiangle 
            Console.WriteLine("Enter your base : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height : ");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * b * height;
            Console.WriteLine("Triange area is = "+area);
            //Circle 
            Console.WriteLine("Enter your R number : ");
            double r = Convert.ToDouble(Console.ReadLine());
            double r_area = 3.1416 * r * r;
            Console.WriteLine("Circle area is ="+r_area);
            //rectangle
            Console.WriteLine("Enter your weight : ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your lenght");
            double lenght = Convert.ToDouble(Console.ReadLine());
            double ract_area = weight * lenght;
            Console.WriteLine("Rectangle area is = "+ract_area);
            //Celcius
            Console.WriteLine("Ehetr your faranheight F : ");
            double f = Convert.ToDouble(Console.ReadLine());
            double celcius = (f - 32) / 1.8;
            Console.WriteLine($"celcius is : {celcius}");
            //Farenheight
            Console.WriteLine("Enter your celcius C : ");
            double c = Convert.ToDouble(Console.ReadLine());
            double farhenheight = 1.8 * c + 32;
            Console.WriteLine($"Farenheigt is = {farhenheight}");

            Console.WriteLine("Currency excence program");
            Console.WriteLine($"1.vietnam Dolar :");
            Console.WriteLine($"2.Indian Rupe : ");
            Console.WriteLine($"3.USD : ");
            Console.WriteLine($"4.Singapur D : ");
            Console.WriteLine($"5.Pakistan Rupe :");

            Console.Write($"Enter your Excence Dolar Country : ");
            double excence = Convert.ToDouble(Console.ReadLine());
            switch (excence)
            {
                case 1:
                    {
                        Console.Write("Enter Vietnam Dolar :");
                        double v_usd = Convert.ToDouble(Console.ReadLine());
                        if (v_usd >= 0)
                        {
                            Console.WriteLine($"vietnam {v_usd} dolar to bangladesh {v_usd * 0.0047} tk");
                        }
                        else
                        {
                            Console.WriteLine($"invalid dolar");
                        }
                    }
                    break;
                case 2:
                    {
                        Console.Write("Enter your India rupe : ");
                        double rupe = Convert.ToDouble(Console.ReadLine());
                        if (rupe >= 0)
                        {
                            Console.WriteLine($"Indian {rupe} Rupe to Bangladesh {rupe * 1.42} tk");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid rupe");
                        }
                    }
                    break;
                case 3:
                    {
                        Console.Write("Enter American USD :");
                        double usd = Convert.ToDouble(Console.ReadLine());
                        if(usd >= 0)
                        {
                            Console.WriteLine($"American {usd} dolar bangladeshi {usd * 119.12} tk");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid Dolar");
                        }
                    }
                    break;
                case 4:
                    {
                        Console.Write("Enter Singapur dolar :");
                        double s_usd = Convert.ToDouble(Console.ReadLine());
                        if(s_usd >= 0)
                        {
                            Console.WriteLine($"Singapur {s_usd} dolar to Bangladeshi {s_usd * 90.47} tk");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid dolar");
                        }
                    }
                    break;
                case 5:
                    {
                        Console.Write("Enter Pakistan Rupe : ");
                        double p_rupe = Convert.ToDouble(Console.ReadLine());
                        if(p_rupe >= 0)
                        {
                            Console.WriteLine($"Pakistan {p_rupe} to Bangladesh {p_rupe * 0.43} tk");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid Rupe");
                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine($"Invalid Number Enter plz Current Number Enter plz.");
                    }
                    break;




            }
            //Assingment operator use

            int x = 10;
           // x += 5;
           //Assing to
            int y = x;
            int z = 30;
            // add and assign
            //z += x += y;
            int a = z;
            //remiander assign
            z %= y;
            

           // Console.WriteLine(x);
            Console.WriteLine(z);
            // Console.WriteLine(a);

            //increment and decrement operator\
            //post-incress
            int v1 = 10;
            int v2 = v1++;
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            //pree-incress
            v2 = ++v1;
            Console.WriteLine(v2);
            Console.WriteLine(v1);
            //decrement
            //post-decress
            v2 = v1--;
            Console.WriteLine(v2);
            Console.WriteLine(v1);
            //pree-decrement
            v2 = --v1;
            Console.WriteLine(v2);
            Console.WriteLine(v1);

            //coprission oparator
            int a1 = 10;
           int a2 = 20;
            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 > a2);
            Console.WriteLine(a1 < a2);
            Console.WriteLine(a1 != a2);
            Console.WriteLine(a1 >= a2);
            Console.WriteLine(a1 <= a2);

            //Logical oparator
            bool c1 = true;
            bool c2 = false;
            //bitwase & and |
            Console.WriteLine(c1 & c2);
            Console.WriteLine(c1 | c2);
            //logical operator
            Console.WriteLine(c1 && c2);
            Console.WriteLine(c1 || c2);

            //Concatonation oparator
            string n = "Md.Suman";
            string m = "Hossain";

            Console.WriteLine(n + m);
            Console.WriteLine($"kmn aso {n} {m} vai");

            //turnary oparator
            string n1 = "mamun";
            string n2 = "zakir";

            string result = n1 == n2 ? "rana" : "islam";

            Console.WriteLine("hello"+ result);

            int age = Convert.ToInt32(Console.ReadLine());
            bool nid = true;
           // bool n = (bool)nid;

            String accessing = age >= 18 && nid == true ? "You can access ours website" : "Your are not eligible";
            Console.WriteLine(accessing);

            double buyeN = 120;
            double discount = buyeN >= 100 ? 10 : 0;
            Console.WriteLine(discount);
            double n = buyeN + buyeN * (discount / 100);
            Console.WriteLine($"Your total sell is ${n}");
            Console.WriteLine($"Profit is {n - buyeN}");

            //if ,else conditon
            //check Odd or Even number
            Console.WriteLine("Enter Num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            if(num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is Even");
            }
            else
            {
                Console.WriteLine($"{num1} is Odd");
            }

            //if,else-if and else working

            int n = 10;

            if (n > 0)
            {
                Console.WriteLine($"{n} is positive");
            }else if(n < 0)
            {
                Console.WriteLine($"{n} is nagetive");
            }
            else if(n == 0)
            {
                Console.WriteLine($"{n} is zero");
            }
            else
            {
                Console.WriteLine($"{n} is not a number");
            }

            //Digit spelling program
            Console.WriteLine("Enter the digit spellinig number 0 to 9 : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num == 0)
            {
                Console.WriteLine($"{num} is zero");
            }
            if (num == 2)
            {
                Console.WriteLine($"{num} is two");
            }
            if (num == 3)
            {
                Console.WriteLine($"{num} is three");
            }
            if (num == 4)
            {
                Console.WriteLine($"{num} is Four");
            }
            if (num == 5)
            {
                Console.WriteLine($"{num} is five");
            }
            if (num == 6)
            {
                Console.WriteLine($"{num} is six");
            }
            if (num == 7)
            {
                Console.WriteLine($"{num} is seven");
            }
            if (num == 8)
            {
                Console.WriteLine($"{num} is Eight");
            }
            else if (num == 9)
            {
                Console.WriteLine($"{num} is nine");
            }
            else
            {
                Console.WriteLine($"{num} is not valid number");
            }
            //condition comporision operator use
           

            Console.WriteLine("Enter mark : ");
            double mark = Convert.ToDouble(Console.ReadLine());

            char grd;
            if(mark>=0 &&   mark<=100)
            {
                if(mark >= 80)
                {
                    grd = 'A';
                }else if(mark >= 70)
                {
                    grd = 'A';
                }else if(mark >= 60)
                {
                    grd = 'A';
                }else if(mark >= 50)
                {
                    grd = 'B';
                }else if(mark >= 40)
                {
                    grd = 'C';
                }
                else
                {
                    grd = 'F';
                }
                Console.WriteLine($"The Result if {grd}");
                
            }
            else
            {
                Console.WriteLine($"Invalid numbers");
            }*/

            //turnary operator use and find leap year
            /*
                        int leap;
                        Console.Write("Enter your year :");
                        leap = Convert.ToInt32(Console.ReadLine());

                        string year = leap % 400 == 0 || (leap % 4 == 0 && leap % 100 == 0) ? $"{leap} is a leap year" : $"{leap} is not a leap year";
                        Console.WriteLine(year);

                        //Capital and small letter check turnary case

                        Console.WriteLine("Enter your character : ");
                        char c = Convert.ToChar(Console.ReadLine());

                        string chr = c >= 'A' && c <= 'Z' ? $"{c} is Capital Character" : $"{c} is a small character";

                        Console.WriteLine(chr);

                        //Vowel check */

            /* Console.WriteLine("Enter your charater : ");
             char c1 = Convert.ToChar(Console.ReadLine());

             switch (c1)
             {
                 case 'a':
                     Console.WriteLine($"{c1} is a vowel");
                     break;
                 case 'e':
                     Console.WriteLine($"{c1} is vowel");
                     break;
                 case 'i':
                     Console.WriteLine($"{c1} is vowel");
                     break;
                 case 'o':
                     Console.WriteLine($"{c1} is vowel");
                     break;
                 case 'u':
                     Console.WriteLine($"{c1} is vowel");
                     break;
                 default:
                     Console.WriteLine($"{c1} is a not vowel");
                     break;

             }

             //weekday and weekend day find

             Console.WriteLine("Enter your Day : ");
             string day = Console.ReadLine();

             switch (day.ToLower())
             {
                 case "monday":
                 case "tuesday":
                 case "wednesday":
                 case "thursday":
                 case "friday":
                     Console.WriteLine($"{day} is a weekday");
                     break;
                 case "saturday":
                 case "sunday":
                     Console.WriteLine($"{day} is a weekend");
                     break;
                 default:
                     Console.WriteLine($"{day}invalid day");
                     break;
             }
            //Problem:01
            Console.Write("Enter Radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area_circle = 3.1416 * radius * radius;
            Console.WriteLine($"Circle area is = {area_circle}");

            //Problem:02
            Console.Write("Enter Feet : ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter inche : ");
            double inch = Convert.ToDouble(Console.ReadLine());

            double centrimeter = (feet * 30.48) + (inch * 2.54);

            Console.WriteLine($"A man height is {centrimeter}");

            //problem:03
            Console.Write("Enter nearest Number :");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 1000 >= 500 ? number + 1000 - number % 1000 : number - number % 1000;
            Console.WriteLine($"The Nearest Number thousand numbder is {result}");

            //problem:04
            Console.WriteLine("Enter the Second : ");
            int second = Convert.ToInt32(Console.ReadLine());


            int s_1_day = 24 * 3600;// we know 1 minuets = 60 second .. 1 hours = 60 minutes...24 hours = 1440m ...24 hours = 86400 second

            int year_1 = 365 * s_1_day;

            int year = second / year_1;
           // Console.WriteLine($"total year is {year}");
            second = second % year_1 ;

            int day = second / s_1_day;
           // Console.WriteLine($"Total day is {day}");

            second = second % s_1_day;

            int hours = second / 3600;
            //Console.WriteLine($"total hours {hours}");

            second = second % 3600;
            int minutes = second / 60;

            second = second % 60;

            int seconds = second;
            Console.WriteLine($"Years = {year}, " +
                $"Day = {day}, " +
                $"Hours = {hours}, " +
                $"Minutes = {minutes}, " +
                $"Seconds = {seconds}");

            /*Problem: 05
            double inch = Convert.ToDouble(Console.ReadLine());

            if(inch >= 60)
            {
                Console.WriteLine($"{inch} is A category of height");
            }else if(inch >= 50)
            {
                Console.WriteLine($"{inch} is B category of height");

            }
            else
            {
                Console.WriteLine($"{inch} is Midget category of height");

            }

            //Problem:06

            Console.Write("Enter Num1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2 :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num3 :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine($"{num1} is lergest number");
                }
                else
                {
                    Console.WriteLine($"{num3 } is lergest number");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"{num2} is lergest number");
                }
                else
                {
                    Console.WriteLine($"{num3} is lergest number");
                }
            }

            //Switch sorthand type

            int num = 10;

            int result = num switch
            {
                int => "integer",
                double => "double",
                string => "String",
                float => "Float",
                long => "Long",
                _ => "unKnow type",
            };
            Console.WriteLine(result);

            //switch e condition use
            Console.WriteLine("Enter number : ");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                //akane bola hoyece je akta range bole deo hoye ce
                // case e num k int n modde raka holo and oita when pore use kora holo karon amara sorasori num k use korte parbona
                case int n when n > 1 || n < 10:
                    Console.WriteLine("out of rang");
                    break;
                case int n when n % 2 == 0:
                    Console.WriteLine("Even number");
                    break;
                case int n when n % 2 != 0:
                    Console.WriteLine("Odd Number");
                    break;

                default:
                    Console.WriteLine("invalid number");
                    break;

            }

            //CALCULATOR PROJECT===>>
             while (true)
            {
                Console.WriteLine("Welcome to Calculator Convesion");
                Console.WriteLine("Choice 1. Addition");
                Console.WriteLine("Choice 2.Substractor");
                Console.WriteLine("Choice 3.Multripication");
                Console.WriteLine("Choice 4.Devission");
                Console.WriteLine("Choice 5.Mudulas");

                Console.Write("Enter your Choice : ");
                int number = Convert.ToInt32(Console.ReadLine());


                switch (number)
                {
                    case 1:
                        Console.Write("Enter first Num :");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second Num:");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double add = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {add}");
                        break;
                    case 2:
                        Console.Write("Enter first Num:");
                        double s1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter first Num:");
                        double s2 = Convert.ToDouble(Console.ReadLine());
                        double sub = s1 - s2;
                        Console.WriteLine($"{s1} - {s2} = {sub}");
                        break;
                    case 3:
                        Console.Write("Enter first Num:");
                        double m1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter first Num:");
                        double m2 = Convert.ToDouble(Console.ReadLine());

                        double mul = m1 * m2;
                        Console.WriteLine($"{m1} * {m2} = {mul}");
                        break;
                    case 4:
                        Console.Write("Enter first Num:");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter first Num:");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        double div = d1 / d2;
                        Console.WriteLine($"{d1} / {d2} = {div}");
                        break;
                    case 5:
                        Console.Write("Enter first Num:");
                        double mud1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter first Num:");
                        double mud2 = Convert.ToDouble(Console.ReadLine());
                        double mud = mud1 % mud2;
                        Console.WriteLine($"{mud1} % {mud2} = {mud}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            int n = 5;
            for(int i = 1;i<=n; i++)
            {
                Console.WriteLine($"{i} er gorer namta");
                for (int j = 1; j <= n; j++)
                {
                    int namta = i * j;
                    Console.WriteLine($"{i }*{ j} = {namta}");
                }
                
            }
            //PROJECT====>
            //simple tempereture project

            Console.WriteLine("Tempereture Checking");
            Console.WriteLine("Choice 1. Fahrenheit to Celcisus");
            Console.WriteLine("Choice 2. Celcisus to Fahrenheit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter your Fahrenheit tempereture :");
                    double fahrenheite = Convert.ToDouble(Console.ReadLine());
                    double celcisus = (fahrenheite - 32) / 1.8;
                    Console.WriteLine($"Tempereture is Celcisus : {celcisus:F2}");
                    break;
                case 2:
                    Console.WriteLine("Enter your Celcisus tempereture :");
                    double cels = Convert.ToDouble(Console.ReadLine());
                    double farh = 1.8 * cels + 32;
                    Console.WriteLine($"Tempereture is Fahrenheit : {farh}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            int n = 1;
            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine("Hello World");
            }
            int j = 1;
            //while loop
            while ( j <= n)
            {
                Console.WriteLine("hlw");
                j++;
            }
            //do while loop

            int k = 1;
            do
            {
                Console.WriteLine("hi");
                k++;

            } while (k <= n);
             while (true)
            {
                Console.WriteLine("1. number:");
                Console.WriteLine("2  number:");
                Console.WriteLine("3. number:");

                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.Write("enter first number:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for(int i=n; i <= n; i++)
                        {
                            for(int j=1; j<=10; j++)
                            {
                                int r = i * j;
                                Console.WriteLine($"{i} * {j} = {r}");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("enter first number:");
                        int m = Convert.ToInt32(Console.ReadLine());
                        for (int k = m; k <= m; k++)
                        {
                            for (int l = 1; l <= 10; l++)
                            {
                                int e = k * l;
                                Console.WriteLine($"{k} * {l} = {e}");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("enter first number:");
                        int o = Convert.ToInt32(Console.ReadLine());
                        for (int a = o; a <= o; a++)
                        {
                            for (int b = 1; b <= 10; b++)
                            {
                                int c = a * b;
                                Console.WriteLine($"{a} * {b} = {c}");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }

            }
            
             */

            /*/nested for loop
            string flag = "";

            while (flag != "exit")
            {    
                Console.Write("input:");
                string num = Console.ReadLine();
                flag = num;
                if (num !="exit")
                {

                    int m = int.Parse(num);
                    for (int j = 1; j <= 10; j++)
                    {
                        int num1 = m * j;
                        Console.WriteLine($"{m} * {j} = {num1}");
                    }
                }
            }*/
            /*/
            string f = " ";
            while (f !="exit")
            {
                Console.WriteLine("Enter Input:");
                string flag = Console.ReadLine();
                f = flag;
                if (flag == "exit")
                {
                    Console.WriteLine("exit");
                }
                else
                {
                    int num = int.Parse(flag);
                    for (int j = 1; j <= 10; j++)
                    {
                        int num1 = num * j;
                        Console.WriteLine($"{j} * {num} = {num1}");
                    }
                }
            }
            //

            Console.WriteLine("Hello:");
            Console.WriteLine("Md.Suman Hossain");
            int a = 10;
            int b= 20;
            int c = a+b;
            Console.WriteLine(c);
            int n = 10;
            int m = 20;
            int temp = n;
            n = m;
            m = temp;
            Console.WriteLine($"{n} {m}");
            /*/


            /*/Avarage number

            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;
            int sum = a+b+c+d;
            int avg = sum / 4;
            Console.WriteLine(avg);
            /
            int n = 5;
            for (int i = 0; i <= 10; i++) { 
                int num = n*i;
                Console.WriteLine($"{n} * {i} = {num}");
            }
             */

            //Console.Write("First:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Second:");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("third:");
            //int c = int.Parse(Console.ReadLine());

            //int result = (a + b) * c;
            //Console.WriteLine(result);
            //int result1 = (a * b) + (b * c);
            //Console.WriteLine(result1);

            //Console.WriteLine("Enter age :");
            //int d = int.Parse(Console.ReadLine());
            //if (d == 20)
            //{
            //    Console.WriteLine($"You look older then {d}");
            //}

            //Console.ReadKey();
            /////////////QuickSort/////////////////////////////////////////////////
            //int[] nums = { 6, 10, 3, 39, 20 };
            //int l = nums.Length;
            //quickSort(nums, 0, l - 1);
            ////sortArrayP(nums, l);
            //foreach (int val in nums)
            //{
            //    Console.Write(val + " ");
            //}

            //Console.WriteLine("h");
            //Console.Write("Enter Print Number : ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write(number);
            //Console.Write(" ");
            //Console.Write(number);
            //Console.Write(" ");
            //Console.Write(number);
            //Console.Write(" ");
            //Console.Write(number);
            //Console.WriteLine();

            //Console.Write(number);
            //Console.Write(number);
            //Console.Write(number);
            //Console.Write(number);
            //Console.WriteLine();

            //Console.WriteLine($"{number} {number} {number} {number}");
            //Console.WriteLine($"{number}{number}{number}{number}");

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        if (i == 1 || i == 5 || j == 1 || j == 3 )
            //        {
            //            Console.Write(n);
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine() ;
            //}

            //Console.Write("Enter print Number:");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{a}{a}{a}");
            //Console.WriteLine($"{a} {a}");
            //Console.WriteLine($"{a} {a}");
            //Console.WriteLine($"{a} {a}");
            //Console.WriteLine($"{a}{a}{a}");


            //Console.WriteLine("Enter Censius : ");
            //double censius = double.Parse(Console.ReadLine());

            //double farenheigt = censius * 1.8 + 32;
            //Console.WriteLine($"Farenheight is {farenheigt}");

            //double kelvin = censius + 273.15;
            //Console.WriteLine($"Kelvin is {kelvin}");

            //int n = 30;
            //int sum = 0, result;
            //for(int i=1; i <= n; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //         sum = sum + i;
            //        result = sum;
            //        Console.WriteLine($"{sum} + {i} = {result}");
            //    }
               
            //}
            //Console.WriteLine($"Total even sum Of = {sum}");

            //FACTORIAL NUMBER

            Console.Write("Enter Factorial Number :");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadKey();


        }
        //Bulle Sort///////////////////////////////////////////////////////////
        //static void sortArray(int[] nums, int len)
        //{
        //    for (int i = 0; i < len - 1; i++)
        //    {
        //        int temp = 0;
        //        for (int j = 0; j < len - i - 1; j++)
        //        {
        //            if (nums[j] > nums[j + 1])
        //            {
        //                temp = nums[j];
        //                nums[j] = nums[j + 1];
        //                nums[j + 1] = temp;

        //            }

        //        }

        //    }
        //}
        //static void sortArrayP(int[] num, int l)
        //{
        //    for (int i = 0; i <= l; i++)
        //    {
        //        Console.Write(num[i ]);
        //    }
        //}
        /////METHOD OF QUICKSOT
        //static void quickSort(int[] nums, int l, int h)
        //{

        //    if (l < h)
        //    {
        //        int p = Partition(nums, l, h);
        //        quickSort(nums, l, p - 1);
        //        quickSort(nums, p + 1, h);
        //    }

        //}
        //static int Partition(int[] arr, int low, int high)
        //{

        //    // Choose the pivot
        //    int pivot = arr[high];

        //    // Index of smaller element and indicates 
        //    // the right position of pivot found so far
        //    int i = low - 1;

        //    // Traverse arr[low..high] and move all smaller
        //    // elements to the left side. Elements from low to 
        //    // i are smaller after every iteration
        //    for (int j = low; j <= high - 1; j++)
        //    {
        //        if (arr[j] < pivot)
        //        {
        //            i++;
        //            Swap(arr, i, j);
        //        }
        //    }

        //    // Move pivot after smaller elements and
        //    // return its position
        //    Swap(arr, i + 1, high);
        //    return i + 1;
        //}

        //// Swap function
        //static void Swap(int[] arr, int i, int j)
        //{
        //    int temp = arr[i];
        //    arr[i] = arr[j];
        //    arr[j] = temp;
        //}






    }
}
