namespace CreatingClasses
{
    class Book
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

    }
}