
namespace LMS.Domain.Enums
{
    public class UserEntity : SoftDeletableEntity
    {
        public string UserName {get; private set;}
        public string PasswordHash {get; private set;}
        public UserRole Role {get; set;} 

        protected User(){ }

        public User(string userName, string PasswordHash)
        {
            UserName = userName;
            PasswordHash = PasswordHash;
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
    }
}