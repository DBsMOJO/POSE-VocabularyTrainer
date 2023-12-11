/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 27.11.2023
 *--------------------------------------------------------------
 * Description:
 * An educational game to test your vocabulary knowledge
 *--------------------------------------------------------------
*/

using System;

namespace VocabularyTrainer
{
    class Program
    {
        public static void Main()
        {
            string enWord,
                deWord,
                input = "";
            int counter = 0;

            // Entry Expert

            Console.Clear();

            Console.WriteLine("x ------------------------------------- x");
            Console.WriteLine("x             Vokabeltrainer            x");
            Console.WriteLine("x ------------------------------------- x");
            Console.WriteLine("x           Expertenabschnitt           x");
            Console.WriteLine("x ------------------------------------- x");

            // Input Expert
            Console.Write("Englisches Wort: ");
            enWord = Console.ReadLine();
            Console.Write("Deutsche Übersetzung: ");
            deWord = Console.ReadLine();

            Console.Clear();

            // Entry Pupils
            Console.WriteLine("x ------------------------------------- x");
            Console.WriteLine("x             Vokabeltrainer            x");
            Console.WriteLine("x ------------------------------------- x");
            Console.WriteLine("x            Schülerabschnitt           x");
            Console.WriteLine("x ------------------------------------- x");
            Console.WriteLine("Gib die deutsche Übersetzung für {0} an: ", enWord);

            for (int i = 1; i <= 10 && deWord != input; ++i)
            {
                Console.Write("Versuch {0}: ", i);
                input = Console.ReadLine();
                counter = i;
            }

            // Output
            // if cascade instead of cascaded if branching, due to readability.
            if (counter == 1)
            {
                Console.WriteLine("Ausgezeichnet, sofort gewusst!");
            }
            else if (counter > 1 && counter <= 3)
            {
                Console.WriteLine("Gut gemacht, nur {0} Versuche!", counter);
            }
            else if (counter > 3 && counter <= 5)
            {
                Console.WriteLine("Ein bisschen üben, das wird schon.");
            }
            else if (counter > 5 && counter < 10)
            {
                Console.WriteLine("Üben, üben, üben!");
            }
            else
                Console.WriteLine("Das war wohl nichts!");
        }
    }
}
