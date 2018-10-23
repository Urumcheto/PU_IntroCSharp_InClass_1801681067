using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();
            Console.WriteLine($"My answer is: {answer} ");

            if (answer == "Yes")
            {
                Console.WriteLine("Playing music..!");

                using (SoundPlayer player = new SoundPlayer(@"C:\\ C:\Users\fmi\Desktop\Urumov week-3\PU_IntroCSharp_InClass_1801681067\Music\Eminem_-_Venom-8CdcCD5V-d8.wav")
                {
                    // Use PlaySync to load and then play the sound.
                    // ... The program will pause until the sound is complete.
                    player.PlaySync();
                }
            }
            else if(answer == "No")
            {
                    Console.WriteLine("Goodbye");

            }
             else 
            {
                    Console.WriteLine("Wrong input");
                
                   
                    }



            Console.WriteLine("Hello Urumov");


        }
    }
}
    