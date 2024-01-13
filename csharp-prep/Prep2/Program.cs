using System;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        //User input of grade in percentage
        Console.WriteLine("Please enter your grade percentage: ");
        string answer = Console.ReadLine();
        int grade_percent = int.Parse(answer);

        string grade_letter ="";
        string grade_sign ="";
        string result="";
        string final_result = "";

        //Determine the grade in letters
        if (grade_percent >= 90)
            {
                grade_letter = "A";
            }
        else if (grade_percent >= 80)
            {
                grade_letter = "B";            
            }
        else if (grade_percent >= 70)
            {
                grade_letter = "C";            
            }
        else if (grade_percent >= 60)
            {
                grade_letter = "D";            
            }
        else
            {
                grade_letter = "F";
            }
        
        //Determine if passed or failed
        if (grade_percent>=70)
            {
                result = ("Congratulations, You Passed!");
            }
        else
            {
                result = ("Do your best and try again");
            }

        //Determine the sign
        if ((grade_percent % 10) >= 7)
            {
                grade_sign = "+";
            }
        else if ((grade_percent%10) < 3)
            {
                grade_sign = "-";
            }

        if (grade_letter == "A" && grade_sign == "+")
            {
                final_result = "A";
            }

        else if (grade_letter == "F" && (grade_sign == "+" || grade_sign == "-"))
            {
                final_result = "F";
            }
        else
            {
                final_result = grade_letter + grade_sign;
            }
        Console.WriteLine($"Your grade is {final_result}. {result} ");
    }


}