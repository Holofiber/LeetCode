using System.Collections.Generic;
using System.Linq;

namespace LeatCodeTasks
{
    public class LC2038_RemoveColoredPieces
    {
        public bool WinnerOfGame(string colors)
        {
            char[] array = colors.ToCharArray();

            if (!array.Contains('A') || array.Length <3)
                return false;

            return FoundNeibor(array.ToList());
        }

        private bool FoundNeibor(List<char> list)
        {
            bool continueGame = true;
            bool result = false;
            bool isAturn = true;
            char colorToRemove = 'A';

            // added iterals for fix time issues
            int lastAiteral = 0;
            int lastBiteral = 0;


            while (continueGame)
            {
                for (int i = 1; i < list.Count - 1; i++)
                {
                    if (list[i - 1] == list[i] && list[i] == list[i + 1])
                    {
                        var AB = list[i];

                        if (!AB.Equals(colorToRemove))
                            continue;

                        if (colorToRemove == 'A')
                            lastAiteral = i;
                        else
                            lastBiteral = i;

                        list.RemoveAt(i);
                        isAturn = !isAturn;
                        colorToRemove = isAturn ? 'A' : 'B';
                        result = AB == 'A';

                        if (lastAiteral >= 1)
                            lastAiteral--;

                        if (lastBiteral >= 1)
                            lastBiteral--;

                        i = colorToRemove == 'A' ? lastAiteral : lastBiteral;
                    }

                    continueGame = false;
                }
            }

            return result;
        }
    }
}
