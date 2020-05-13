namespace Trails3D
{

    using System;
    using System.Text;

    internal class Trails
    {
        private static string ConvertCommands(string path)
        {
            var result = new StringBuilder();

            //if slow refactor 
            path.Replace("M", " M ");
            path.Replace("L", " L ");
            path.Replace("R", " R ");

            var separatedPaths = path.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string lastNumber = null;

            for (var i = 0; i < separatedPaths.Length; i++)
            {
                if (separatedPaths[i] == "L" || separatedPaths[i] == "R")
                {
                    result.Append(separatedPaths[i]);
                }
                else if (separatedPaths[i] == "M")
                {
                    if (lastNumber == null)
                    {
                        result.Append("M");
                    }
                    else
                    {
                        var number = int.Parse(lastNumber);
                        result.Append(new string('M', number));
                        lastNumber = null;
                    }
                }
                else
                {
                    lastNumber = separatedPaths[i];
                }
            }

            result.Replace("LM", "L");

            return result.ToString();
        }

        private static void Main()
        {
            var xyz = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var x = int.Parse(xyz[0]);
            var y = int.Parse(xyz[1]);
            var z = int.Parse(xyz[2]);

            // check if player can turn multiple times on one game cycle

            var redCommands = ConvertCommands(Console.ReadLine());
            var blueCommands = ConvertCommands(Console.ReadLine());
        }
    }

}