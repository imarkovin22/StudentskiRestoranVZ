using StudentskiResoranVŽ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Repositories
{
    public class UserRepository
    {
        private List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();

            AddUser(new User(1, "student", "test", "user1@example.com"));
            AddUser(new User(2, "profesor", "test", "user2@example.com"));
        }

        private void AddUser(User user)
        {
            _users.Add(user);
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public User GetUserById(int userId)
        {
            return _users.Find(u => u.UserId == userId);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}
