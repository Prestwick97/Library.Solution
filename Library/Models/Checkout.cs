namespace Library.Models
{
  public class Checkout
  {
    public int CheckoutId { get; set; }
    public int BookId {get; set;}
    public int CopyId {get; set;}
    public Book Book {get; set;}
    public Author Author {get; set;}
  }
}