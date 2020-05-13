namespace Paths_in_Labyrinth
{

    using System;

    internal class PathsInlabyrinth
    {
        private static void Main()
        {
            char[,] lab =
            {
                {' ', ' ', ' ', '*', ' ', ' ', ' '},
                {'*', '*', ' ', '*', ' ', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', '*', '*', '*', '*', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', 'e'}
            };

            var labirinth = new Labirinth(lab);
            labirinth.FindPaths(0, 0);
        }
    }

    internal class Labirinth
    {
        private readonly char[,] lab;

        public Labirinth(char[,] lab)
        {
            this.lab = lab;
        }


        internal void FindPaths(int row, int col)
        {
            FindExit(row, col, 0);
        }

        private void FindExit(int row, int col, int steps)
        {
            if (row < 0 || row >= lab.GetLength(0) ||
                col < 0 || col >= lab.GetLength(1))
            {
                return;
            }

            if (lab[row, col] == 'e')
            {
                Console.WriteLine(steps);
            }


            if (lab[row, col] != ' ')
            {
                return;
            }


            lab[row, col] = 'v';
            FindExit(row - 1, col, steps + 1); // up
            FindExit(row, col + 1, steps + 1); // right
            FindExit(row + 1, col, steps + 1); // down
            FindExit(row, col - 1, steps + 1); // left


            lab[row, col] = ' ';
        }
    }

}