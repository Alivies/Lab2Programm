using System;

namespace lab2
{

    public class Word : Doc
    {

        private string Words { get; set; }

        public Word(string Name, string Creator, string Tags, string Theme, string Path, string words) : base(Name, Creator, Tags, Theme, Path)
        {

            Words = words;
        }

        public override void GetInfo()
        {

            base.GetInfo();
            Console.WriteLine($"Amount of words: {Words}");
        }
    }
}