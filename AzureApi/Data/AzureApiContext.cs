using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureApi.Models;

namespace AzureApi.Models
{
    public class AzureApiContext : DbContext
    {
        public AzureApiContext (DbContextOptions<AzureApiContext> options)
            : base(options)
        {
        }

        public DbSet<AzureApi.Models.Account> Account { get; set; }

        public DbSet<AzureApi.Models.Song> Song { get; set; }
    }
}
