using System.Collections.Generic;

namespace Library.Models
{
  public class Copies
  {
    public Copies()
    {
      this.Books = new HashSet<AuthorBook>();
    }
    
    public int CopiesId { get; set; }
    public int BookId {get; set;}
    public int Count {get; set;}
    public ICollection<AuthorBook> Books {get; }
  }
}