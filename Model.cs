using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ConsoleApp.SQLite
{
    public class  story : DbContext
    {
        public DbSet<Word> Words {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=storydb.db");
        }
    }
    

    public class Word
    {
        public int wordid{get;set;}
        public string wordkey{get;set;}
        
    }
}
