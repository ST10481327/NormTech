using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot

{//start of namespace
    public class Program

    {//start of public class
        static void Main(string[] args)

        {//start of main method

            new voice_greeting() { };     // Playing voice greeting
            new AsciiLogo();    // Showing ASCII + title

            human_interraction collect_chats = new human_interraction();

            human_interraction bot = new human_interraction();
            bot.Start();            // Starting chatbot

            
        }///end of the main method
    }//end of public class
}//start of namespace
