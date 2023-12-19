using System;
using System.Diagnostics;

namespace resultandgpa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            string[] subject = new string[length];
            int[] marks = new int[length];
            double total = 500;
            double totalMarks = 0;
            double percentage;
            double[] individualPercentage=new double[length];
            double[] individualGPA=new double[length];
            double gpa;

            //For subject
            for (int i = 0; i < subject.Length; i++)
            {
                Console.Write("Enter the Subject Name:");
                
                subject[i] = Console.ReadLine();
            }
            Console.Clear();


            //Listing Subject
            Console.WriteLine("List of Subject:");
            for(int i = 0;i < subject.Length; i++)
            {
                Console.WriteLine(subject[i]);
            }
            Console.WriteLine("______________________");


            //For Marks
            for (int i=0;i<subject.Length;i++) {
            Console.Write($"Enter your Marks for {subject[i]}:");
            marks[i]=int.Parse(Console.ReadLine());
            }


            //Adding Marks of each subject
            for(int i=0;i<marks.Length;i++) {
                totalMarks+= marks[i];
                }
            Console.Clear();


            //Finding percentage 
            percentage=(totalMarks/total)*100;
  


            //finding individual Percentage
            for(int i = 0; i < subject.Length; i++)
            {
                individualPercentage[i] = (marks[i]);
            }


            //Finding Individal GPA
            for(int i = 0; i < subject.Length; i++)
            {
                individualGPA[i] = (individualPercentage[i] / 100) * 4;
            }
            
            //Total GPA
            gpa=(percentage/100)*4;


           
            Console.WriteLine("Subject\t\t|Mark\t\t|GPA");
            Console.WriteLine("---------------------------------------------");
            for(int i = 0;i<subject.Length;i++)
            {

                Console.WriteLine($"{subject[i]}\t\t|{marks[i]}\t\t|{individualGPA[i]} ");
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Total Marks:{totalMarks}");
            Console.WriteLine($"Percentage:{percentage} %");
            Console.WriteLine($"Average GPA:{gpa}");
            Grade(gpa);
            Console.ReadKey();
        }
        static void Grade(double gpa)
        {
            if (gpa >= 0 && gpa < 0.8)
            {
                Console.WriteLine("Grade: E");
            }
            else if (gpa >= 0.8 && gpa < 1.2)
            {
                Console.WriteLine("Grade: D");
            }
            else if (gpa >= 1.2 && gpa < 1.6)
            {
                Console.WriteLine("Grade: D+");
            }
            else if (gpa >= 1.6 && gpa < 2.0)
            {
                Console.WriteLine("Grade: C");
            }
            else if (gpa >= 2.0 && gpa < 2.4)
            {
                Console.WriteLine("Grade: C+");
            }
            else if (gpa >= 2.4 && gpa < 2.8)
            {
                Console.WriteLine("Grade: B");
            }
            else if (gpa >= 2.8 && gpa < 3.2)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (gpa >= 3.2 && gpa < 3.6)
            {
                Console.WriteLine("Grade: A");
            }
            else
            {
                Console.WriteLine($"Your Grade is A+");
            }
        }
    }
}
