using System;
using System.Drawing;
using System.Media;
using System.Text;
using System.Threading;

namespace CyberBot

{//start of namespace
    public  class AsciiLogo

    {//start of public class
        public AsciiLogo()
        {//start of ascii logo
            ShowHeader();
        }//end ascii logo

        // Show ASCII + colors
        private void ShowHeader()
        {//start of void showheader


            //path of the logo [ where the logo is ]
            string path = string.Empty;

            //auto get the full path
            string fullpath = AppDomain.CurrentDomain.BaseDirectory;

            //now combine the paths
            path = fullpath.Replace(@"bin\Debug\", "CyberBotimage.jpg");

            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 75;
            int height = 35; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiChars = "@#S%?*+;:,. ";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {//then for each line of the height
                //then width
                for (int x = 0; x < resized.Width; x++)
                {//then for each pixel of the width
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }//end of for loop for width

                Console.WriteLine();
            }// end of for loop for height

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================**********************************====================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("            [ Welcome To NormTech CyberBot ]          ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================**********************************====================");
            Console.ResetColor();
        }//end of void showheader



        // Typing effect 
        public static void TypeText(string text)

        {//start of void TypeText

            foreach (char c in text)

            {//start of foreach

                Console.Write(c);
                Thread.Sleep(30);

            }//end of foreach

            Console.WriteLine();

        }//end of void TypeText
    }//end of public class
}//end of namespace