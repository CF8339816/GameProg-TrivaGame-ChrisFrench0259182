using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_TrivaGame_ChrisFrench0259182
{
    internal class Program
    {
        static string filepathQ = "QuizQuestions.txt";
        static string filepathA = "QuizAnswers.txt";
        static string[] questions;
        static void Main(string[] args)
        {
            Quizit();

            answerstest();
        }

        static void Quizit()
        {
            Directory.GetCurrentDirectory();
            try
            {
                questions = File.ReadAllLines(filepathQ);

                foreach (string Question in questions)
                {
                    Console.WriteLine(Question);

                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file '{filepathQ}' was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }


        static void answerstest()
        {
            Directory.GetCurrentDirectory();
            try
            {
                questions = File.ReadAllLines(filepathA);

                foreach (string Question in questions)
                {
                    Console.WriteLine(Question);

                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file '{filepathA}' was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

    }
}
