using System.Collections.Generic;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> nationalities;
        void initList()
        {
            nationalities = new List<string>()
    {
        "French",
        "Italian",
        "Cambodian",
        " Australian ",
        "Mongolian",
        " Russian ",
        " Austrian ",
        " Brazilian ",
    };
        }
        initList();
        nationalities.Sort();
        foreach (string nationality in nationalities) Console.WriteLine(nationality);
    }
}