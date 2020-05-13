namespace ExtenssionMethods2
{

    public static class ExtensionHelper
    {
        public static int GetWordCount(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return str.Split(' ').Length;
            }

            return 0;
        }
    }

}