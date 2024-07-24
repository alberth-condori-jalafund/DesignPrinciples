namespace LeastAstonishment;

public class User
{
  public string Username { get; set; }
  
  public string Email { get; set; }
  
  public string Password { get; set; }
  
  public string Role { get; set; }

  public User(string username, string email, string password, string role = "User")
  {
    Username = username;
    Email = email;
    Password = password;
    Role = role;
  }

  public void UpdatePassword(string newPassword)
  {
    if (string.IsNullOrWhiteSpace(newPassword))
    {
      throw new ArgumentException("New password cannot be empty.");
    }

    Password = newPassword;
  }
}
