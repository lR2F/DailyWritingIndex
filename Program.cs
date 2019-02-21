using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.SQLite
{
    class Program
    {
        static void Main(string[] args)
        {   
            if(args.Length>0)
            {
            using(var db = new story())
            {

                foreach (var word in args)
                {
                     db.Words.Add(new Word{wordkey=word});
                }
             
              var count = db.SaveChanges();
              Console.WriteLine("{0} 记录保存到数据库" ,count);                                   
            }
            }else
            {
            using(var context =new story())
            {
                var WordRandom = context.Words
                     .FromSql("SELECT * FROM Words ORDER BY RANDOM() limit 3")
                     .ToList();
               foreach (var wd in WordRandom)
               {
                   Console.WriteLine("--:{0}",wd.wordkey);
               }
            }
            }  
        }
    }
}
