namespace WebApi.Models.Users;

using WebApi.Entities;

public class AuthenticateResponse
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public Role Role { get; set; }
    public string Token { get; set; }

    public AuthenticateResponse(User user, string token)
    {
        Id = user.Id;
        FullName = user.FullName;
        Email = user.Email;
        Username = user.Username;
        Role = user.Role;
        Token = token;
    }
}