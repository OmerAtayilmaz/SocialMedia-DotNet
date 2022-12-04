namespace VisualForm.Models;

public class User
{
    private int id;
    private string name;
    private string username;
    private string email;

    public User()
    {
    }

    public User(int id, string name, string username, string email)
    {
        this.id = id;
        this.name = name;
        this.username = username;
        this.email = email;
    }

    public int Id
    {
        get => id;
        set => id = value ;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Username
    {
        get => username;
        set => username = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Email
    {
        get => email;
        set => email = value ?? throw new ArgumentNullException(nameof(value));
    }
}