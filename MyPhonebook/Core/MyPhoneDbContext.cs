using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPhonebook.Core
{
    public class MyPhoneDbContext: DbContext
    {
        public DbSet<ContactModel> MyPhonebook { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\MyPhonebookRepo.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
