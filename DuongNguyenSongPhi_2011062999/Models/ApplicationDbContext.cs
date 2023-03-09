using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DuongNguyenSongPhi_2011062999.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private DbSet<Course> courses;
        private DbSet<Category> categories;

        public DbSet<Course> Courses { get => courses; set => courses = value; }
        public DbSet<Category> Categories { get => categories; set => categories = value; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}