using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_TrivaGame_ChrisFrench0259182
{
    internal class Program
    {
        static string filepathQ = "QuizQuestions.txt";
        static string filepathA = "QuizAnswers.txt";
        static string[] questions;
        static string[] answers;
       
        //static int Ans;
        static string alias;
        static int score = 0;
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your name?");
            alias = Console.ReadLine();
            Console.Clear();

          
            Quizit();


            Console.ReadKey(true);
          
        }
       
        
        //m1
        static void Quizit()
        {
            Directory.GetCurrentDirectory();
            try
            {
                questions = File.ReadAllLines(filepathQ);
                answers = File.ReadAllLines(filepathA);


                for (int i = 0; i < questions.Length; i++)  // defines variable int i for advancing through the arras one entry at a time and defining its length?
                {
                    hud();

                    Console.WriteLine($"{questions[i]} \n{answers[i]}"); //Calls to write the array items based on current value of 'i'

                    Console.WriteLine(" What is the correct answer? ");
                    int Ans = Convert.ToInt32(Console.ReadLine());  //tried uing read to limit input to one character but was providing answer in ascii int  switched to readline to get code functional. will research alternate conversion method over xmas break
                    //Console.WriteLine(Ans);  //debugged issues with 3 not equaling 3 on input check  
                    //Console.ReadKey(true);
                    if (Ans == 3)
                    {
                        Console.WriteLine(" That is correct ");
                        score = score + 1;
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine(" Sorry that is incorrect  ");
                        Console.WriteLine(" Please press any key to get next question. ");
                        Console.ReadKey(true);
                    }
                   
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



    }

          

}


