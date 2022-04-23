using System;

namespace lab2
{   
    public class Pdf : Doc
    {
        private string Pages { get; set; }
        public Pdf(string Name, string Creator, string Tags, string Theme, string Path, string pages) : base(Name, Creator, Tags, Theme, Path)
        
        {
            Pages = pages;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Amount of pages: {Pages}");
        }
    }
}
