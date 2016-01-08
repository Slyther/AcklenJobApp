using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AcklenAveApplication.Entities;

namespace AcklenAveApplication.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("AcklenJobApp") { }
        public DbSet<SecretPayload> Secrets { get; set; }
    }
}