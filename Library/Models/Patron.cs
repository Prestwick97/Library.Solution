using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public int PatronId {get; set;}
    public int BookId {get; set;}
    public string Title {get; set;}
    public virtual ApplicationUser User { get; set; }
    public ICollection<Checkout> UserBooks {get; }
  }
}