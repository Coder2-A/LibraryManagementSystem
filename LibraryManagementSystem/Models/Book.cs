namespace LibraryManagementSystem.Models;

public class Book
{
  public int Id { get; }

  public string Title { get; }

  public bool IsAvailable { get; set; }
  public string AuthorName { get; }

  public Book(int id, string title, string authorName)
  {
    Id = id;
    Title = title;
    IsAvailable = true;
    AuthorName = authorName;
  }

  public void DisplayInfo()
  {
    Console.WriteLine($"Book ID: {Id}");
    Console.WriteLine($"Title: {Title}");
    Console.WriteLine($"Author: {AuthorName}");
    Console.WriteLine($"Available: {IsAvailable}");
    Console.WriteLine("-----------------------------");
  }
}