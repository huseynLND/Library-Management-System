namespace librar
{
    internal class Book : LibraryItem
    {
        public Book(string title, int? publicationYear) : base(title, publicationYear)
        {
        }

        public string Genre { get; set; }
        public int LibraryLocation { get; set; }
        public object Location { get; private set; }

        public override void DisplayInfo() => Console.WriteLine($"Book: {Title}, Genre: {Genre}, Year: {PublicationYear}, Location: Aisle {Location.Aisle}, Shelf {Location.Shelf}");
    }
}

