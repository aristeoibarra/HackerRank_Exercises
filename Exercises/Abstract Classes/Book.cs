namespace Abstract_Classes
{
    abstract class Book
    {
        protected string title;
        protected string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public abstract void Display();
    }
}