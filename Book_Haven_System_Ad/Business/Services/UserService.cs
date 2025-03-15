using Book_Haven__Application.Business.Interfaces;
using Book_Haven__Application.Data.Models;
using Book_Haven__Application.Data.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Book_Haven_System_Ad.Data.Repository.Interfaces;

namespace Book_Haven__Application.Business.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public bool AdminUserExists()
        {
            List<UserModel> users = _userRepository.GetAllUsers();
            return users.Any(user => user.Role == "Admin");
        }


        public void CreateInitialAdminUser()
        {
            if (!AdminUserExists())
            {
                string adminUsername = "admin";
                string adminPassword = "admin12345"; 
                string adminRole = "Admin";

                string hashedPassword = HashPassword(adminPassword);

                UserModel adminUser = new UserModel
                {
                    UserID = Guid.NewGuid(),
                    Username = adminUsername,
                    PasswordHash = hashedPassword,
                    Role = adminRole,
                    DateCreated = DateTime.Now,
                    IsDeleted = false
                };

                _userRepository.AddUser(adminUser); 
                Console.WriteLine("Initial Admin user created.");
            }
            else
            {
                Console.WriteLine("Admin user already exists.");
            }
        }
        public void RegisterUser(string username, string password, string role)
        {
            string hashedPassword = HashPassword(password);

            UserModel user = new UserModel
            {
                UserID = Guid.NewGuid(),
                Username = username,
                PasswordHash = hashedPassword,
                Role = role,
                DateCreated = DateTime.Now,
                IsDeleted = false
            };

            _userRepository.AddUser(user);
        }

        public bool ValidateUser(string username, string password)
        {
            UserModel user = _userRepository.GetUserByUsername(username);
            if (user != null && VerifyPassword(password, user.PasswordHash))
            {
                return true;
            }
            return false;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte byteValue in bytes)
                {
                    builder.Append(byteValue.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool VerifyPassword(string inputPassword, string storedPasswordHash)
        {
            string inputPasswordHash = HashPassword(inputPassword);
            return inputPasswordHash == storedPasswordHash;
        }

        public List<UserModel> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public void SoftDeleteUser(string username)
        {
            _userRepository.SoftDeleteUser(username);
        }
        public void UpdateUserByUsername(string username, string password, string role)
        {
            string passwordHash = string.IsNullOrEmpty(password) ? null : HashPassword(password);
            _userRepository.UpdateUserByUsername(username, passwordHash, role);
        }


        public string Login(string username, string password)
        {
            UserModel user = _userRepository.GetUserByUsername(username);
            if (user != null && VerifyPassword(password, user.PasswordHash))
            {
                return user.Role; // Return the role for dashboard redirection
            }
            else
            {
                return null; // Invalid credentials
            }
        }
        public Guid? GetUserIdByName(string username)
        {
            UserModel user = _userRepository.GetUserByName(username);
            if (user != null)
            {
                return user.UserID;
            }
            else
            {
                return null;
            }
        }
        public (int totalUserCount, Dictionary<string, int> roleWiseUserCount) GetUserCounts()
        {
            return _userRepository.GetUserCounts();
        }

    }
}
