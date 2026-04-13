using System;
using System.Media;

namespace CyberBot
{
    public class voice_greeting
    {
        public voice_greeting()
        {//start of voice_greeting constructor

            //calls the the method Playsound

            sound_greeting();

        }//end of voice_greetig constructor

        public void sound_greeting()

        {//start of void PlaySound

            Console.WriteLine("Sound is playing...");

            try
            {//start of try method

                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.PlaySync();

              


            }//end of try method

            catch

            {//start of catch method

                Console.WriteLine("Sound file missing.");

            }//end of catch method

        }//end of void PlaySound
    }
}