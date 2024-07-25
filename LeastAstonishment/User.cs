namespace LeastAstonishment;

public class User
{
  public string Username { get; set; }
  
  public string Email { get; set; }
  
  public string Password { get; set; }
  
  public Role Role { get; set; }

  public User(string username, string email, string password)
  {
    Username = username;
    Email = email;
    Password = password;
    Role = Role.User;
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
