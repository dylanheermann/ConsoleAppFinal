using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Story
    {
        //Properties
        public string Narrative { get; set; }
        public string Noun { get; set; }
        public string Verb { get; set; }
        public string Adjective { get; set; }
        public string Place { get; set; }
        public string ProperNoun { get; set; }
        public bool PlayAgain { get; set; }

        //Methods

        //Constructor
        public Story(string noun, string verb, string adjective, string place, string properNoun, bool playAgain)
        {
            this.Noun = noun;//Must have the above Properties before I can use this.Property function
            this.Verb = verb;
            this.Adjective = adjective;
            this.Place = place;
            this.ProperNoun = properNoun;
            this.PlayAgain = playAgain;
        }


    }
}
