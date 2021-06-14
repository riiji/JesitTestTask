using System;
using System.Collections.Generic;

namespace JesitTestTask.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public List<JesitUser> Users { get; set; }
    }
}