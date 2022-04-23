using System;

namespace lab2
{

    public class Excel : Doc
    {

        private string Columns { get; set; }
        private string Rows { set; get; }

        public Excel(string Name, string Creator, string Tags, string Theme, string Path, string columns, string rows) : base(Name, Creator, Tags, Theme, Path)
        {

            Columns = columns;
            Rows = rows;
        }

        public override void GetInfo()
        {

            base.GetInfo();
            Console.WriteLine($"Amount of columns: {Columns}");
            Console.WriteLine($"Amount of rows: {Rows}");
        }
    }
}