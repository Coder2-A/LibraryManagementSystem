namespace LibraryManagementSystem.Models;

public class Member : AbstractPerson
{
  private List<Book> BorrowedBooks { get; set; }

  public Member(int id, string name) : base(id, name)
  {
    BorrowedBooks = new List<Book>();
  }

  public override void DisplayInfo()
  {
    Console.WriteLine($"Member ID: {Id}");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine("Borrowed Books:");
    if (BorrowedBooks.Count == 0)
    {
      Console.WriteLine("No books borrowed.");
    }
    else
    {
      foreach (var book in BorrowedBooks)
      {
        Console.WriteLine($"- {book.Title} by {book.AuthorName}");
      }
    }
  }
  public void BorrowBook(Book book)
  {
    if (book.IsAvailable)
    {
      BorrowedBooks.Add(book);
      book.IsAvailable = false;
      Console.WriteLine($"Book '{book.Title}' borrowed successfully.");
    }
    else
    {
      Console.WriteLine($"Book '{book.Title}' is not available for borrowing.");
    }
  }
  public void ReturnBook(Book book)
  {
    if (BorrowedBooks.Contains(book))
    {
      BorrowedBooks.Remove(book);
      book.IsAvailable = true;
      Console.WriteLine($"Book '{book.Title}' returned successfully.");
    }
    else
    {
      Console.WriteLine($"You have not borrowed the book '{book.Title}'.");
    }
  }

  public void DisplayBorrowedBooks()
  {
    Console.WriteLine($"Borrowed books for member {Name}:");
    if (BorrowedBooks.Count == 0)
    {
      Console.WriteLine("No books borrowed.");
    }
    else
    {
      foreach (var book in BorrowedBooks)
      {
        book.DisplayInfo();
      }
    }
  }
}