using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            //Playing with Strings
                        string name = "Duck Academy";//Concatenation
                        Console.WriteLine(name);//printing length
                        Console.WriteLine(name.Length);//finding Length
                        Console.WriteLine(name.ToUpper());//uppercase
                        Console.WriteLine(name.Contains("Duck"));//Check whetheer the string have the value or not.
                        Console.WriteLine(name[2]);//Check and print the words.
                        Console.WriteLine(name.IndexOf("Academy"));//academy starts at index 5.i.e array[5]="a";
                        Console.WriteLine(name.Substring(5));//only prints academy  i.e starts to print form 5th index.
                        Console.WriteLine(name.Substring(5, 5));//prints from 5th index and upto 5th index only i.e 10th for full array*/




            /*            //Working With numbers
                        *//*int a = 6;decimal b = 4;//two type of datatypes for numbers*/
            /*a--;//decrement*//*
            Console.WriteLine(Math.Abs(-90));//Gives absolute value i.e. 40;
            Console.WriteLine(Math.Pow(2.2,2));//Takes first as value and second as power.
            Console.WriteLine(Math.Round(4.5));
            Console.ReadKey();*/

            /*            //Getting input from users.
                        Console.Write("Enter Your Name: ");
                        string name=Console.ReadLine();
                        Console.Write("Enter your Age:");
                        int age=int.Parse(Console.ReadLine());
                        Console.WriteLine($"Hello {name}! You are {age} years old.");
                        Console.ReadLine();*/

            //Building Mad lib



            /*            string color, plural, cel;
                        Console.Write("Enter a color:");
                        color= Console.ReadLine();
                        Console.Write("Enter a Plural:");
                        plural= Console.ReadLine();
                        Console.Write("Enter your fav cel:");
                        cel= Console.ReadLine();

                        Console.WriteLine($"Roses are {color}");
                        Console.WriteLine($"{plural} are blue");
                        Console.WriteLine($"I love {cel}");
            */



            //Arrays:
            /*            int [] luckyNumber = {4,8,15,16,23,42};
                        luckyNumber[1] = 900;
                        string[] friends = new string[10];
                        friends[0] = "Ayush";
                        friends[1] = "Kelly";

                        Console.WriteLine(luckyNumber[1]);//printing indiv value;
                        for (int i = 0; i < luckyNumber.Length; i++)
                        {
                            Console.WriteLine(luckyNumber[i]);
                        }

            */
            //Calling Method
            /*            Greet();
                        Add(1, 2);

            */


            //Return Statements:
            /*            Console.WriteLine(Cube(5));
                        Console.WriteLine(Hello("Namaste"));*/



            //If Statement

            /*            int age = 61;
                        if(age<18 || age>50)
                        {
                            Console.WriteLine("Not Allowed");
                        }
                        else if(age>=18)
                        {
                            Console.WriteLine("Allowed");
                        }
            */


            //if statement(con't)
            /*    Console.WriteLine(GetMax(100,101,2));*/



            //Switch Statement
            /*       Console.WriteLine(GetDay(100));*/


            //While Loop
            /*            int index = 1;
                        while(index < 5){
                            Console.WriteLine(index);
                            index++;
                        }*/
            //SPLIT
            /*            //in string
                        string test = "This is really fun.I'm learning .net .";
                        foreach (var a in test.Split('.'))
                        {
                            Console.WriteLine(a);
                        }
                        //in split array
                        string name = "Ayush^,Robina&,Kismat,Shirshak!";
                        Console.WriteLine("Before Split:");
                        Console.WriteLine(name);
                        Console.WriteLine("___________________");
                        Console.WriteLine("After Split:");
                        char[] sym = new char[] { ',', '!', '^', '&' };
                        string[] names = name.Split(sym, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var a in names)
                        {
                            Console.WriteLine($"{a}");
                        }*/

            //CompareTo
            int val1 = 10;
            int val2 = 20;
            Console.WriteLine(val1.CompareTo(val2));//prints -1 cause the value are different
            val1 = 20;
            Console.WriteLine(val1.CompareTo(val2));//prints 0 cause the value are same
            string name = "Ayush";
            string str = "ayush";
            Console.WriteLine(name.CompareTo(str));//prints 1 cause of only lowercase and uppercase differences

            
            
            //For Loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("_________________");
            //for loop for array
            int[] nums = { 4, 8, 2, 2, 1, 12, 4, 2, 2, 2, 2 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("_________________");
            //2d array;
            int[,] numberGrid = { { 1, 2, 3},
            { 3,4,6 } };
            Console.WriteLine(numberGrid[0, 1]);//prints 2 from 0th index and 1st index from array inside of array
            Console.WriteLine(numberGrid[1,2]);//prints 6
            Console.WriteLine("_________________");
            //inserting in array
            string[,] nicks=new string[2,2];//creating array using new to define rows and column
            nicks[0,1] = "duck,hok";
            nicks[1, 1] = "neva,hiva";
            Console.WriteLine(nicks[0,1]);
            Console.WriteLine("_________________");
            //Comments
            Console.WriteLine("Comments are fun");
            




            Console.ReadKey();
        }




        //Return
        /*     static int Cube(int num)
         {
             int result = num*num*num;
             return result;
         }
         static string Hello(string lang)
         {
             return $"Hello {lang}";
         }*/





        //getmaxfor if
        /*        static int GetMax(int num1,int num2,int num3) {
                    int result;
                    if(num1 > num2 && num1>num3) {
                    result=num1;
                            }
                    else if ( num2>num1 && num2>num3 )
                    {
                        result=num2;
                    }
                    else {
                        result = num3;

                    }

                    return result;
                }

        */








        //method
 /*       public static void Greet()
        {
            string name;
            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Namaste {name}!");
        }
        //Method with Parameters and arguement
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1+num2;
        }
*/



            //Switch Case
            /*static string GetDay(int dayNum)
                    {
                        string dayName;
                        switch (dayNum)
                        {
                            case 1:
                                dayName = "Sunday";
                                break;
                            case 2:
                                dayName = "Monday";
                                break;

                            case 3:
                                dayName = "Tuesday";
                                break;
                            case 4:
                                dayName = "Wednesday";
                                break;
                            case 5:
                                dayName = "Thursday";
                                break;
                            case 6:
                                dayName = "Friday";
                                break;
                            case 7:
                                dayName = "Saturday";
                                break;
                            default:
                                return "Invalid";
                        }        


                        return $"Today is {dayName}";
                    }*/
        }
    }
