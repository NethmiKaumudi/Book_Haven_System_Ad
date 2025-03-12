using Book_Haven__Application.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven__Application.Business.Interfaces
{
    internal interface IUserService
    {
        void RegisterUser(string username, string password, string role);  
        bool ValidateUser(string username, string password);
        List<UserModel> GetAllUsers();
        void SoftDeleteUser(string username);
        void UpdateUserByUsername( string newUsername, string password, string role);
        string Login(string username, string password);
    }
}
