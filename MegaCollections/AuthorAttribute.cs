namespace MegaCollections
{

    using System;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string v)
        {
        }
    }

}