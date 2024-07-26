namespace Library.Domain;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public ushort Year { get; set; }

    public Book(int id, string title, string author, ushort year)
    {
        Id = id;
        Title = title;
        Author = author;
        Year = year;
    }
}