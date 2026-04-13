using System;
using System.Collections.Generic;

namespace CyberBot
{
    public class human_interraction
    {
        string name;

        // RESPONSE LISTS
        List<string> phishingAnswers = new List<string>();
        List<string> passwordAnswers = new List<string>();
        List<string> browsingAnswers = new List<string>();
        List<string> ignoring = new List<string>();

        Random rand = new Random();

        //  CONSTRUCTOR (LIKE YOUR voice_greeting CLASS)
        public human_interraction()
        {
            LoadResponses(); // auto-load when object is created
        }

        public void Start()
        {
            AskName();
            WelcomeUser();
            Chat();
        }

        // LOAD RESPONSES
        void LoadResponses()
        {
            //SAFE WAYS ABOUT  PHISHING
            phishingAnswers.Add("Phishing is when scammers pretend to be trusted sources to steal your information.");
            phishingAnswers.Add("Phishing attacks often come through fake emails or messages.");
            phishingAnswers.Add("Never click suspicious links or share personal details online.");
            phishingAnswers.Add("Phishing can lead to identity theft and financial loss.");

            // SAFE WAYS ABOUT PASSWORDS
            passwordAnswers.Add("Use strong passwords with at least 8 characters.");
            passwordAnswers.Add("Avoid using the same password for multiple accounts.");
            passwordAnswers.Add("Include numbers, symbols, and uppercase letters.");
            passwordAnswers.Add("Enable two-factor authentication for extra security.");

            // SAFE WAYS ABOUT BROWSING
            browsingAnswers.Add("Always check if a website uses HTTPS.");
            browsingAnswers.Add("Avoid downloading files from unknown sources.");
            browsingAnswers.Add("Be careful of deals that seem too good to be true.");
            browsingAnswers.Add("Unsafe browsing can lead to malware infections.");

            // WORDS TO IGNORE 

            ignoring.Add("what");
            ignoring.Add("is");
            ignoring.Add("about");
            ignoring.Add("tell");
            ignoring.Add("me");

            //ignoring questions
            ignoring.Add("a");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");
        }

        void AskName()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter your name: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Name cannot be empty. Try again: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                name = Console.ReadLine();
            }
        }

        void WelcomeUser()
        {
            BotReply("Hello " + name );

            BotReply("I'm the Cybersecurity Awareness Bot — your personal guide to staying safe online.");

            BotReply("You can ask me about passwords, phishing and safe browsing");

        }

        void Chat()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n" + name + ": ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    BotReply("Please ask a question or type (exit).");
                }
                else if (input == "exit")
                {
                    BotReply("Goodbye " + name);
                    break;
                }
                else
                {
                    Answer(input);
                }
            }
        }

        void BotReply(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("CyberBot: ");
            Console.ResetColor();

            AsciiLogo.TypeText(message);
        }

        public void Answer(string input)
        {
            string[] words = input.Split(' ');

            //  GREETINGS (FIXED)
            foreach (string word in words)
            {
                if (word == "hello" || word == "hi" || word == "hey")
                {
                    BotReply("Hello " + name + "! How can I assist you today?");
                    return;
                }
            }

            //  HOW ARE YOU (KEEP THIS BEFORE LOOP)
            if (input.Contains("how are you"))
            {
                BotReply("I'm fine how can I help you?");

                return;
            }

            

          

            //  MAIN LOGIC
            foreach (string word in words)
            {
                
                if (ignoring.Contains(word)) continue;

                if (word.Contains("phishing"))
                {
                    BotReply(GetRandom(phishingAnswers));
                    return;
                }
                else if (word.Contains("password"))
                {
                    BotReply(GetRandom(passwordAnswers));
                    return;
                }
                else if (word.Contains("browsing") || word.Contains("safe"))
                {
                    BotReply(GetRandom(browsingAnswers));
                    return;
                }
            }

            BotReply("I didn't quite understand " + input+ ",  Could you rephrase?");
        }
        string GetRandom(List<string> list)
        {
            return list[rand.Next(list.Count)];
        }
    }
}