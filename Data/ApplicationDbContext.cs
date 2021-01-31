using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AplikacijaZaPrijavuOstecenjaSisMosZup.Models;

namespace AplikacijaZaPrijavuIzgradnjeKuca.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AplikacijaZaPrijavuOstecenjaSisMosZup.Models.Prijavitelj> Prijavitelj { get; set; }
    }
}
