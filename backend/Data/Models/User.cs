using Microsoft.AspNetCore.Identity;

namespace S11.Data.Models;

public class User : IdentityUser<int>
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
}