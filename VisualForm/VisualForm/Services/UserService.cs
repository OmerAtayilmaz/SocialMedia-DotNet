using VisualForm.Models;

namespace VisualForm.Services;

public class UserService
{

    public static async Task<List<User>> getUserData()
    {
        // Get Reqeust
        HttpClient req = new HttpClient();
        var content = await req.GetAsync("https://jsonplaceholder.typicode.com/users");
        var result= content.Content.ReadFromJsonAsync<List<User>>().Result;
        return result;
    }

    public static async Task<List<Post>> getUserPosts()
    {
        HttpClient req = new HttpClient();
        var content = await req.GetAsync("https://jsonplaceholder.typicode.com/posts");
        var result = content.Content.ReadFromJsonAsync<List<Post>>().Result;
        return result;
    }

    public static async Task<User> getUserById(int id)
    {
        HttpClient req = new HttpClient();
        var content = await req.GetAsync("https://jsonplaceholder.typicode.com/users/" + id);
        var result = content.Content.ReadFromJsonAsync<User>().Result;
        return result;
    }
    
}