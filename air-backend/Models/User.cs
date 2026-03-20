using System;

namespace air_backend.Models;

public class User
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }

}
