using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DownloadFile.Models;

namespace DownloadFile.Data
{
    public class DownloadFileContext : DbContext
    {
        public DownloadFileContext (DbContextOptions<DownloadFileContext> options)
            : base(options)
        {
        }

        public DbSet<DownloadFile.Models.Movie> Movie { get; set; } = default!;
    }
}
