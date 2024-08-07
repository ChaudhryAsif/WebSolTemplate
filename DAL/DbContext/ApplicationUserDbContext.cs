﻿using DAL.DomainEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.DbContext
{
    public class ApplicationUserDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationUserDbContext(DbContextOptions<ApplicationUserDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
