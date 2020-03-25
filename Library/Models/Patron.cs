using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public int BookId {get; set;}
    public string Title {get; set;}
    public virtual ApplicationUser User { get; set; }

  }
}