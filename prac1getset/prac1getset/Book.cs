using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1getset
{
    internal class Book
    {
        
        public string title;
        public string author;
        public int pages;
        private string series;
        public Book(string title, string author, int pages ,string series)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            Series = series;
        }
        public string Series
        {
            get { return series; }
            set {
            if(value== "Action" || value == "PG" || value == "PG-13" || value == "18+")
                {
                    series = value;
                }
                else
                {
                    series="N/A";
                }
            }
        }



    }
}
