using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0_CharacterAndText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 3.0: Character and Text");
            Console.WriteLine("*****************************************************");

            /*
             *  Check ASCII Char Table and Codes!
             *  Link: https://www.rapidtables.com/code/text/ascii-table.html
             */

            //  VAR
            char firstCharacter;
            char secondCharacter;
            char thirdCharacter;
            char fourthCharacter;
            string title;
            string programingCourses;
            string programingCourses2;

            firstCharacter = 'a';
            Console.WriteLine("First Character: " + firstCharacter);

            secondCharacter = (char)65;
            Console.WriteLine("Second Char (converted): " + secondCharacter);

            thirdCharacter = (char)(secondCharacter + 1);
            Console.WriteLine("Third Char (converted): " + thirdCharacter);

            fourthCharacter = ' ';
            Console.WriteLine("Fourth Char (converted): " + fourthCharacter);

            Console.WriteLine("*****************************************************");

            title = "Alura Academy 2022!";
            Console.WriteLine("String: " + title);

            //  Line Break: 1st Example
            programingCourses =
                  "\n" + "* .Net;"
                + "\n" + "* Javascript;"
                + "\n" + "* Vue.js;";
            Console.WriteLine("Programing Courses: " + programingCourses);

            //  Line Break: 2nd Example
            programingCourses2 = "\n" +
@"* .Net;
* Javascrip;
* Vue.js;";
            Console.WriteLine("Programing Courses2: " + programingCourses2);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
