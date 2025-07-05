namespace LibraryManagementSystem.Services;

using LibraryManagementSystem.Models;

public class Library
{
  private List<Book> books = new List<Book>();
  private List<AbstractPerson> members = new List<AbstractPerson>();

  public void AddBook(Book book)
  {
    if (book != null && !books.Any(b => b.Id == book.Id))
    {
      books.Add(book);
      Console.WriteLine($"Book '{book.Title}' added successfully.");
    }
    else
    {
      Console.WriteLine($"Book with ID {book.Id} already exists or is null.");
    }
  }
  public void AddMember(AbstractPerson member)
  {
    if (member != null && !members.Any(m => m.Id == member.Id))
    {
      members.Add(member);
      Console.WriteLine($"Member '{member.Name}' added successfully.");
    }
    else
    {
      Console.WriteLine($"Member with ID {member.Id} already exists or is null.");
    }
  }
  public Book FindBookById(int id)
  {
    return books.FirstOrDefault(b => b.Id == id);
  }

  public AbstractPerson FindMemberById(int id)
  {
    return members.FirstOrDefault(m => m.Id == id);
  }
  public void DisplayAllBooks()
  {
    Console.WriteLine("--- All Books ---");
    if (books.Count == 0)
    {
      Console.WriteLine("No books available.");
    }
    else
    {
      foreach (var book in books)
      {
        book.DisplayInfo();
      }
    }
  }
  public void DisplayAllMembers()
  {
    Console.WriteLine("--- All Members ---");
    if (members.Count == 0)
    {
      Console.WriteLine("No members available.");
    }
    else
    {
      foreach (var member in members)
      {
        member.DisplayInfo();
      }
    }
  }
}