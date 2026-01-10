using LMS.Domain.Enums;

namespace LMS.Domain.Entities
{
    public class User : SoftDeletableEntity
    {
        public string Name {get; private set;}

        public string Email{get; private set;}
        public string PasswordHash {get; private set;}
        public UserRole Role {get; private set;} 

        protected User(){}

        public User(string name,string email, string passwordHash)
        {
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Role = UserRole.Member;
        }

        public void PromoteToLibrarian()
        {
            Role = UserRole.Librarian;
        }

        public void PromoteToAdmin()
        {
            Role = UserRole.Admin;
        }
        public void ChangePassword(string newPasswordHash)
        {
            PasswordHash = newPasswordHash;
        }

        public void ChangeName(string name)
        {
            Name = name;
        }
    }
}