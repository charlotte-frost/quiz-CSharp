using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "How many oscars did the Titanic movie got?", "What is the house number of the Simpsons?","Who played Phoebe Buffay in ‘Friends’?", "Who played Jay Pritchett in ‘Modern Family’?","ANAGRAM-- Menu Doubter", "ANAGRAM-- Advancing Yeast","Which UK TV game shows have been hosted by each of these celebrities Roy Walker, Nick Weir, Mark Curry and Stephen Mulhern?", "Who narrates/narrated the UK TV show Love Island?", "Who narrates/narrated the UK TV show Dragons’ Den?","In which reality TV shows did Gemma Collins first make her names?","In which reality TV shows did Will Young first make his names?","In which year was ‘Coronation Street’ first broadcast?", "What is the name of the character played by Sean Bean in ‘Game of Thrones’?","Who directed Jaws(1975)?", " Which English stand-up comedian and presenter narrates the E4 show ‘Celebs Go Dating’?","Who presents The Chase?", "What was the name of the character played by  Simon Bird in ‘The Inbetweeners’?","Which film series had a fourth movie called ‘Ghost Protocol’?", " A 1999 Scooby-Doo! Film has the word ghost in the title – what is it called?","”Now this is a story all about how my life got flipped, turned upside down.”  Can you identify the program?" };
            string[] answers = { "11", "742", "Lisa Kudrow", "Ed O’Neill", "Outnumbered", "Gavin and Stacey", "Catchphrase","Iain Stirling", "Evan Davis", "The Only Way is Essex", "Pop Idol", "1960", "Eddard “Ned” Stark", "Steven Spielberg", "Rob Beckett", "Bradley Walsh", "Will McKenzie", "Mission Impossible", "Scooby-Doo and the Witch’s Ghost", "The Fresh Prince of Bel Air" };
            int count = 0;
            int score = 0;
            int arrayLength = questions.Length;
            getQuestion(questions, answers, count, score, arrayLength);
        }

        static void getQuestion(string[] questions, string[] answers, int count, int score, int arrayLength)
        {
            count = count + 1;
            Random rand = new Random();
            int position = rand.Next(0, arrayLength);
            string currentQ = questions[position];
            string currentAns = answers[position];

            //int loopFor = hearts.Length - positionDelete;
            for (int i = position; i < questions.Length - 1; i++)
            {
                questions[i] = questions[i + 1];
                answers[i] = answers[i + 1];
            }
            questions[questions.Length - 1] = "";
            answers[answers.Length - 1] = "";
            arrayLength = arrayLength - 1;
            getAnswer(questions, answers, count, score, currentQ, currentAns, arrayLength);
        }
        static void getAnswer (string[]questions, string[]answers, int count, int score, string currentQ, string currentAns, int arrayLength)
        {
            Console.WriteLine(currentQ);
            string usersAns = Console.ReadLine();
            if (usersAns.ToLower() == currentAns.ToLower())
            {
                score = score + 1;
            }
            if (count == 20 )
            {
                Console.WriteLine("You have scored " +score+"/20");
                Console.ReadLine();
            }
            else
            {
                getQuestion(questions, answers, count, score, arrayLength);
            }
        }

    }
}
