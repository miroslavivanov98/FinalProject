using FinalProject.DB.Entities;
using FinalProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    class UserService : BaseService<User>
    {
        private UserRepository repository;

        public UserService()
        {
            repository = new UserRepository();
        }

        public new List<User> GetAll()
        {
            return repository.GetAll();
        }

        public new User GetByID(int id)
        {
            return repository.GetByID(id);
        }

        public new void Save(User user)
        {
            if (IsValidEmail((string)user.Email))
                repository.Save(user);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
