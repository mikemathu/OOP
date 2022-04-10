using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Book
    {
        //Instanct Variables
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        //Constructor. Allows the user of this class to instanciate the instant variables and give them a starting state/initial values
        public Book(string title, string author)
        {
            //class level titile = method level title;
            this.title = title;
            this.author = author;
        }
        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        //Methods
        //Retrive the current title of the book
        public string GetTitle()
        {
            return title;
        }
        //Specify the new title for the book(Change)
        public void SetTitle(string title)
        {
            this.title = title;
        }
        //Supply the text of the book and update the word count accordingly
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
    }
}
