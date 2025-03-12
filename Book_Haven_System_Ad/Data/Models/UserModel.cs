using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven__Application.Data.Models
{
    internal class UserModel
    {
        public Guid UserID { get; set; }  
        public string Username { get; set; }  
        public string PasswordHash { get; set; } 
        public string Role { get; set; }  
        public DateTime DateCreated { get; set; }  
        public bool IsDeleted { get; set; }


    }
}
