using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.DataAccess.DataContract
{
    public class DatabaseContext:DbContext
    {
        public class OptionBuild
        {
            public DbContextOptionsBuilder<DatabaseContext> opsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> MyProperty { get; set; }
            private AppConfiguration settings { get; set; }
        }
    }
}
