using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForum.DAL
{
    public class DataContextFactory : IDesignTimeDbContextFactory<MyForumDBcontext>
    {
        public MyForumDBcontext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyForumDBcontext>();

        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyForumEnitDataBase;Trusted_Connection=True;MultipleActiveResultSets=true");
        return new MyForumDBcontext(optionsBuilder.Options);
    }
}
}
