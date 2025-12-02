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
        static int value = 169;
        static char Yay = (char)value;
        
        //static int Ans;
        static string alias;
        static int score = 0;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.Blue;
            alias = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Quizit();
            
            WinLoss();


            Console.Write(Yay + " Hungry Lion Entertainment\n A devision of C.R.French Publishing" ); 
          


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
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{questions[i]}\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{answers[i]}"); //Calls to write the array items based on current value of 'i'
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n What is the correct answer? \n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    int Ans = Convert.ToInt32(Console.ReadLine());  //tried uing read to limit input to one character but was providing answer in ascii int  switched to readline to get code functional. will research alternate conversion method over xmas break
                    //Console.WriteLine(Ans);  //debugged issues with 3 not equaling 3 on input check  
                    //Console.ReadKey(true);
                    if (Ans == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n That is correct \n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(" Please press any key to get next question. \n");
                        score = score + 1;
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n Sorry that is incorrect \n ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(" Please press any key to get next question.\n ");
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
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"Name : "); 
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{alias}\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"Score : "); 
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{score}\n");
            Console.ResetColor();
        }

        //m3

        static void WinLoss()
        {

            if(score==10)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n As you see all answers were 3... a,b...C, you're pretty Sharp.  \n");
            }
            else if (score <=9 && score >=6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Not bad you know your stuff... good job. \n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n There is room for improvement here...\n");
            }

            Console.ResetColor();



        }



    }

          

}


