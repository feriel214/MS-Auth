namespace WebApi.Entities;

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class User
{
  
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }

    [Required]
    public string Username { get; set; }
    public Role Role { get; set; }

    [Required]
    public string PasswordHash { get; set; }

}