﻿namespace CoreProject1.Models;

public class User
{
    public string? Fullname { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}