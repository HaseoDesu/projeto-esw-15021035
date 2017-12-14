using System;
using System.Data.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace project_sw.Models {
    public class ProjectContext : DbContext {
        public ProjectContext (DbContextOptions<ProjectContext> options) : base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Aluno> alunos { get; set; }
        public DbSet<Docente> docentes { get; set; }
        public DbSet<User> users {get;set;}
    }
}