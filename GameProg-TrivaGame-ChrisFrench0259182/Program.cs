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
        static int Ans;
        static string alias;
        static int score = 0;
        static void Main(string[] args)
        {
           
                Console.WriteLine("What is your name?");
                 alias = Console.ReadLine();
            Console.Clear();

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


                for (int i = 0; i < questions.Length; i++)
                {
                    Console.WriteLine($"{questions[i]} \n{answers[i]}");

                    Console.WriteLine(" What is the correct answer? ");
                    Ans = Convert.ToInt32(Console.Read());


                    if (Ans == 3)
                    {
                        Console.WriteLine(" That is correct ");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine(" Sorry that is incorrect please try again. ");
                    }
                    Console.Clear();
                    Console.WriteLine(" Please press any key to get next question. ");
                    Console.ReadKey(true);

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

                //m2

                static void hud()
                {
                    Console.Clear();
                    Console.WriteLine($"Name : {alias}");
                    Console.WriteLine($"Score : {score}");

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

          

        }


