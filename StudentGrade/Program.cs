using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int manyStudent = 1;
            int[] Mscore, Fscore, Sscore;
            string[] SN;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How many students? : ");
            manyStudent = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            // Secondly, re-allocating array sizing.
            SN = new string[manyStudent];
            Mscore = new int[manyStudent];
            Fscore = new int[manyStudent];
            Sscore = new int[manyStudent];

            // Thirdly, The user key each student information.
            Console.WriteLine(":: Student Information ::");
            for (int Loop = 0; Loop < manyStudent; Loop++)
                {
                    // User feild student name, middle and final score information.
                    Console.Write($"\nPlease key student({Loop + 1} of {manyStudent}) name : ");
                    SN[Loop] = Console.ReadLine();

                    Console.Write($"Please key {SN[Loop]}'s middle score : ");
                    Mscore[Loop] = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Please key {SN[Loop]}'s final score : ");
                    Fscore[Loop] = Convert.ToInt32(Console.ReadLine());

                    // Score summation 
                    Sscore[Loop] = Mscore[Loop] + Fscore[Loop];
                }

                // Fourthly, We have to grades processing from each people's 'sumScore[]'. 
                Console.WriteLine("\n:: List of students and grades ::");
                int _Loop = 0;

                while (_Loop < manyStudent)
                {
                    float gradesScore = 0.0f;   // This is the local variables in 'do..while' statement.

                    #region Writng an if..else..if code without curly brackets type 1. 

                    // For example, we use this region as defualt code.
                    if (Sscore[_Loop] <= 49) gradesScore = 0f;
                    else if (Sscore[_Loop] <= 54) gradesScore = 1f;
                    else if (Sscore[_Loop] <= 59) gradesScore = 1.5f;
                    else if (Sscore[_Loop] <= 64) gradesScore = 2f;
                    else if (Sscore[_Loop] <= 69) gradesScore = 2.5f;
                    else if (Sscore[_Loop] <= 74) gradesScore = 3f;
                    else if (Sscore[_Loop] <= 79) gradesScore = 3.5f;
                    else if (Sscore[_Loop] >= 80) gradesScore = 4f;

                    #endregion

                    #region Writing an if..else..if code with curly brackets.

                    if (Sscore[_Loop] <= 49)
                    {
                        gradesScore = 0f;
                    }
                    else if (Sscore[_Loop] <= 54)
                    {
                        gradesScore = 1f;
                    }
                    else if (Sscore[_Loop] <= 59)
                    {
                        gradesScore = 1.5f;
                    }
                    else if (Sscore[_Loop] <= 64)
                    {
                        gradesScore = 2f;
                    }
                    else if (Sscore[_Loop] <= 69)
                    {
                        gradesScore = 2.5f;
                    }
                    else if (Sscore[_Loop] <= 74)
                    {
                        gradesScore = 3f;
                    }
                    else if (Sscore[_Loop] <= 79)
                    {
                        gradesScore = 3.5f;
                    }
                    else if (Sscore[_Loop] >= 80)
                    {
                        gradesScore = 4f;
                    }

                    #endregion

                    Console.WriteLine($"{_Loop + 1}. {SN[_Loop]} have a" +
                                    $" total {Sscore[_Loop]} score or {gradesScore} grades.");
                    _Loop++;
                } while (_Loop < manyStudent);

                Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}

