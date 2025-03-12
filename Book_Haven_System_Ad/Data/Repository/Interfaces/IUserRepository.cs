using Book_Haven__Application.Data.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Data.Repository.Interfaces
{
    internal interface IUserRepository
    {

        void AddUser(UserModel user);
        UserModel GetUserByUsername(string username);
        List<UserModel> GetAllUsers();
        void SoftDeleteUser(string username);
        public void UpdateUserByUsername(string newUsername, string passwordHash, string role);

    }
}
