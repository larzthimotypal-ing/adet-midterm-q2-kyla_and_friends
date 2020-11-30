using System;
using app.domain;
using Microsoft.EntityFrameworkCore;

namespace app.repository
{
    public class StudentPortalDbContext : DbContext
    {
        public StudentPortalDbContext(DbContextOptions<StudentPortalDbContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<GradesPerItem> GradesPerItems { get; set; }
        public DbSet<GradesPerTerm> GradesPerTerms { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAdminRelationship> StudentAdminRelationships { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
