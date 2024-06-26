﻿// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ProtectedWeb.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string? Avatar { get; set; }
        public Role Role { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public User()
        {
            Reviews = new List<Review>();
        }
    }
}
