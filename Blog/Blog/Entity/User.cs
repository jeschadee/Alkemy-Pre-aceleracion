﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    public class User
    {
        private int userId;
        private string name;
        private string password;
        private string email;
        private ICollection<Posts> posts;
        private ICollection<Comments> comments;

        public User(string name, string password, string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }
        [Key]
        public int Id { get => userId; set => userId = value;}
        [MaxLength(40)]
        public string Name { get => name; set => name = value;}
        [MaxLength(9)]
        public string Password { get => password; set => password = value;}
        [MaxLength(40)]
        public string Email { get => email; set => email = value;}
        public ICollection<Posts> Posts { get => posts; set => posts = value;}
        public ICollection<Comments> Comments { get => comments; set => comments = value;}
    }
}
