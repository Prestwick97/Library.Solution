namespace Library.Models
{
  public class AuthorBook
  {
    public int CopiesId { get; set; }
    public int AuthorBookId {get; set;}
    public int AuthorId {get; set;}
    public int BookId {get; set;}
    public Book Book {get; set;}
    public Author Author {get; set;}
    public Copies Copies {get; set;}
  }
}