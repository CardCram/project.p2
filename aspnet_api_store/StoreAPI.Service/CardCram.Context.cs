using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Service.Models;

namespace StoreAPI.Service
{
    public class CardCramContext : DbContext
  {
    public DbSet<Deck> Deck { get; set; }
    public DbSet<Card> Card { get; set; }

    public CardCramContext(DbContextOptions<CardCramContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {

      builder.UseSqlServer("Server=tcp:cardcramserver.database.windows.net,1433;Initial Catalog=cardcramdb;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Deck>().HasKey(d => d.EntityId);
      builder.Entity<Deck>().HasMany(deck => deck.Cards).WithOne(Card => Card.Deck);
      builder.Entity<Card>().HasKey(c => c.EntityId);
      SeedData(builder);
    }

    protected void SeedData(ModelBuilder builder)
    {
      builder.Entity<Deck>().HasData(
        new Deck()
        {
          EntityId = 1, 
          Name = "Math"
        }
      );

      builder.Entity<Card>().HasData(
        new Card()
        {
          EntityId=1, Question = "1x1", Answer = "1", DeckEntityId = 1
        }
      );
    }
  }
}