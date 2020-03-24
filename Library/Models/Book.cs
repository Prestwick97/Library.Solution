using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
    }

    public int BookId {get; set;}
    public string Title {get; set;}
    public virtual ApplicationUser User { get; set; }
    public ICollection<AuthorBook> Authors {get; }

  }
}