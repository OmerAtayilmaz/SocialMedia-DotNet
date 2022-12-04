namespace VisualForm.Models;

public class Post
{
    private int id;
    private int userId;
    private string title;
    private string body;

    public Post(int id, int userId, string title, string body)
    {
        this.id = id;
        this.userId = userId;
        this.title = title;
        this.body = body;
    }

    public Post()
    {
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public int UserId
    {
        get => userId;
        set => userId = value;
    }

    public string Title
    {
        get => title;
        set => title = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Body
    {
        get => body;
        set => body = value ?? throw new ArgumentNullException(nameof(value));
    }
}