namespace DataGridDemo.Models;

public enum Gender
{
    Male,
    Female
}

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
}