using Properties;

namespace CreatingClasses
{
    class Program
    {
       static void Main(string[] args)
        {
            //New instance of the Book class
            //using the 1st constructor
            Book book = new Book("Harry Potter", "J.K Rowling");

            //Using the 2nd constructor
            //Book book = new Book("Harry Potter", "J.K Rowling", 25, 1000 );

            //Changed my mind. Let's use the full name.
            book.SetTitle("Harry Potter and the Half-Blood Price");

            //Now I forgot.What was the title again?
            //Console.WriteLine(book.GetTitle());

            



            String name = "Mi";

            char[] a = name.ToCharArray();
            System.Array.Reverse(a);
            string r = new string(a);

            int wordCount = name.Split(' ').Length;
            Console.WriteLine(r);



        }
    }
}