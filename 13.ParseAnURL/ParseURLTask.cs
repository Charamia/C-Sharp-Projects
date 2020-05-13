namespace _13.ParseAnURL
{

    using System;

    internal class ParseURLTask
    {
        private const char forwardSlapsh = '/';
        private const char colon = ':';

        private static string ExtractResource(string ulrString)
        {
            var resource = string.Empty;

            var firstSlashIndex = ulrString.IndexOf(forwardSlapsh);
            var midUrl = ulrString.Substring(firstSlashIndex + 2);
            var lastSlashIndex = midUrl.IndexOf(forwardSlapsh);


            if (lastSlashIndex != -1)
            {
                resource = midUrl.Substring(lastSlashIndex);
            }

            return resource;
        }

        private static string ExtractServer(string ulrString)
        {
            var firstSlashIndex = ulrString.IndexOf(forwardSlapsh);
            var midUrl = ulrString.Substring(firstSlashIndex + 2);
            var lastSlashIndex = midUrl.IndexOf(forwardSlapsh);

            return midUrl.Substring(0, lastSlashIndex);
        }

        private static string ExtractProtocol(string ulrString)
        {
            var protocol = string.Empty;
            var indexOfFirstSlash = ulrString.IndexOf(forwardSlapsh);
            var indexOfFirstColon = ulrString.IndexOf(colon);


            if (indexOfFirstSlash != -1)
            {
                protocol = ulrString.Substring(0, indexOfFirstColon);
            }

            return protocol;
        }

        private static void Main()
        {
            var urlString = "http://www.cnn.com/video/pesho";

            var resource = ExtractResource(urlString);
            var server = ExtractServer(urlString);
            var protocol = ExtractProtocol(urlString);

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }

}