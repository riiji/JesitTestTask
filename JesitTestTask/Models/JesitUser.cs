using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace JesitTestTask.Models
{
    public class JesitUser : IdentityUser
    {
        public List<Book> Books { get; set; }
    }
}