namespace part3.data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class defaultDbcontext : DbContext
    {
        public defaultDbcontext()
            : base("name=defaultDbcontext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostComment> PostComments { get; set; }
        public virtual DbSet<PostRate> PostRates { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleFunctionRelationship> RoleFunctionRelationships { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRoleRelationship> UserRoleRelationships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
