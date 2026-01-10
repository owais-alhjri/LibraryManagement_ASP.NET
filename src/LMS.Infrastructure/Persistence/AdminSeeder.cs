
using LMS.Application.Security;
using LMS.Domain.Entities;

namespace LMS.Infrastructure.Persistence
{
    public class AdminSeeder
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher _passwordHasher;

        public AdminSeeder(AppDbContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task SeedAsync()
        {
            if(_context.Users.Any())
                return;

            var admin = new User(
                name: "System Admin",
                email: "admin@lms.local",
                passwordHash:_passwordHasher.Hash("Admin@123")
            );

            admin.PromoteToAdmin();

            _context.Users.Add(admin);
        }
        

    }
}