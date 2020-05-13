namespace LoopsDemo17
{

    internal class LoopsDemo17
    {
        private static void Main()
        {
            for (var i = 0; i < 10; i++)
            {
                var shouldBreak = false;
                for (var j = 0; j < 10; j++)
                {
                    shouldBreak = true;
                }

                if (shouldBreak)
                {
                    break;
                }
            }
        }
    }

}