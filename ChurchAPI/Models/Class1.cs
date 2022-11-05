using ChurchAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ChurchApi.Models
{
    public class MemberContext : DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; } = null!;
    }
}