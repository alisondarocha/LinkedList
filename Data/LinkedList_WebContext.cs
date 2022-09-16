using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LinkedList_Web.Models;

    public class LinkedList_WebContext : DbContext
    {
        public LinkedList_WebContext (DbContextOptions<LinkedList_WebContext> options)
            : base(options)
        {
        }

        public DbSet<LinkedList_Web.Models.Text> Text { get; set; } = default!;
    }
