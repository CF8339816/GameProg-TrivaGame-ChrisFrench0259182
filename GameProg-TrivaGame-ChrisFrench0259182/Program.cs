using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_TrivaGame_ChrisFrench0259182
{
    internal class Program
    {
        static string filepathQ = "QuizQuestions.txt";
        static string filepathA = "QuizAnswers.txt";
        static string[] questions;// =new string[1];
        static string[] answers;// =new string[];
        //static List <string, string> Trivia = new List<Question, Answer>;
        static string Answer = Console.ReadLine();

        static void Main(string[] args)
        {
            hud();
            Quizit();

           // answerstest();
        }

        static void Quizit()
        {
            Directory.GetCurrentDirectory();
            try
            {
                questions = File.ReadAllLines(filepathQ);
                answers = File.ReadAllLines(filepathA);




                //for (string Question in questions = new String[10])
                //    {
                //    for (string Answer in answers = new String[10])
                //        {
                //        Console.WriteLine(Question[0]+Answer[0]);


                //        }

                //    }


                for (int i=0; i< questions.Length; i++)
                {
                    Console.WriteLine($"{questions[i]} \n{answers[i]}");
                    Console.WriteLine(" What is the correct answer? ");
                    string Answer = Console.Readline(); 


                }








                //foreach (string Question in questions) //&& (string Answer in answers))

                //{
                //    foreach (string Answer in answers)
                //    //List <string, string> Trivia = new List <Question,Answer >;

                //    {
                //        string[] trivias = new string[] { Question, Answer };
                //        foreach (string Trivia in trivias)
                //        {

                //            Console.WriteLine(Trivia);
                //            //Console.WriteLine(Question+Answer);
                //        }
                //    }
                //}
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


        //static void answerstest()
        //{
        //    Directory.GetCurrentDirectory();
        //    try
        //    {
                  //answers = File.ReadAllLines(filepathA);

                  //foreach (string Answer in answers)
        //        {
        //            Console.WriteLine(Answer);
        //            //foreach (string Ans in Answer)
        //            //{
        //            //    Console.WriteLine(Ans);
        //            //}
        //        }
        //    }

        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine($"Error: The file '{filepathA}' was not found.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred: {ex.Message}");
        //    }

        //}

    }
}
