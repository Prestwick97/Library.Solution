namespace Library.Models
{
  public class BookCopy
  {
    public int CopiesId { get; set; }
    public int AuthorBookId {get; set;}
    public int AuthorId {get; set;}
    public int BookId {get; set;}
    public int Count {get; set;} 
    public Book Book {get; set;}
    public Author Author {get; set;}
    public Copies Copies {get; set;}
  }
}