using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

namespace StoreAPI.Service
{
  public class CardCramContext : DbContext
  {
    public DbSet<Deck> Deck { get; set; }
    public DbSet<Cards> Card { get; set; }

    public CardCramContext(DbContextOptions<CardCramContext> options) : base(options) {}
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("Server=cardcramserver.database.windows.net;Initial Catalog=cardcramdb;Persist Security Info=False;User ID=sqladmin;Password=Password12345");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Deck>().HasKey(d => d.EntityId);
      builder.Entity<Card>().HasKey(c => c.EntityId);
      SeedData(builder);
    }

    protected void SeedData(ModelBuilder builder)
    {
      builder.Entity<Deck>().HasData(
        new Deck()
        {
          EntityId = 1,
          Cards = new List<Card>()
          {
            new Card() { EntityId = 1, Question = "Who was the first president?", Answer = "George Washington"}
          }
        }
      );
    }
  }
}