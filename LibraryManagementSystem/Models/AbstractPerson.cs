namespace LibraryManagementSystem.Models;

public abstract class AbstractPerson
{
  public int Id { get; }
  public string Name { get; }

  protected AbstractPerson(int id, string name)
  {
    Id = id;
    Name = name;
  }
  public abstract void DisplayInfo();
}