using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a program that will work like Mad Libs.
            
            //This is the basic example
            Console.WriteLine("Welcome to Mab Libs v2.9. I need to ask you a few questions. ");
            Console.WriteLine("Here is the narrative:");
            Console.WriteLine("Narrative: \n" +
                "Two Minds, both alike in dignity,\n" +
                "In fair Wyoming, where we lay our scene,\n" +
                "From ancient Road break to new mutiny,\n" +
                "Where civil blood makes civil hands unclean.\n" +
                "From forth the fatal loins of these two foes\n" +
                "A pair of star-cross`d Dice take their life;\n" +
                "Whole misadventured piteous overthrows\n" +
                "Do with their Peninsula bury their parents` strife.\n" +
                "The fearful passage of their Preferred love,\n" +
                "Which, but their children`s end, nought could Snow,\n" +
                "Is now the 1558 hours` traffic of our stage;\n" +
                "The which if you with Eligible Finger attend,\n" +
                "What here shall Chirp, our toil shall strive to mend.\n");
            
            Console.Clear();
           


            Console.WriteLine("Enter a noun: " );
            string noun = Console.ReadLine();
            Console.WriteLine(noun);
            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.WriteLine(verb);
            Console.WriteLine("Enter a adjective: ");
            string adjective = Console.ReadLine();
            Console.WriteLine(adjective);
            Console.WriteLine("Enter a place: ");
            string place = Console.ReadLine();
            Console.WriteLine(place);
            Console.WriteLine("Enter a proper noun: ");
            string properNoun = Console.ReadLine();
            Console.WriteLine(properNoun);
            bool playAgain = true;
            Console.Clear();

            System.Threading.Thread.Sleep(1000); //sleep 1 second
            
            Console.WriteLine("Narrative: \n" +
                $"Two {noun}, both alike in dignity,\n" +
                $"In fair {properNoun}, where we lay our scene,\n" +
                $"From {adjective} Road break to new mutiny,\n" +
                $"Where civil blood {verb} civil hands unclean.\n" +
                $"From forth the fatal loins of these two foes\n" +
                $"A pair of star-cross`d {place} take their life;\n");








                /*
                $"Whole misadventured piteous overthrows\n" +
                $"Do with their Peninsula bury their parents` strife.\n" +
                $"The fearful passage of their Preferred love,\n" +
                $"Which, but their children`s end, nought could Snow,\n" +
                $"Is now the 1558 hours` traffic of our stage;\n" +
                $"The which if you with Eligible Finger attend,\n" +
                $"What here shall Chirp, our toil shall strive to mend.\n");
                */




            //   Structure of Narrative:
            // {Adjective} {properNoun} walked for 3 days up to {verb} her dog to a {place}.
            // After that, {properNoun} {verb} from taking her dog to a {place}.
            //This is a class example
            Story s = new Story(noun, verb, adjective, place, properNoun, playAgain);
            Console.ReadLine();
        }
    }
}
