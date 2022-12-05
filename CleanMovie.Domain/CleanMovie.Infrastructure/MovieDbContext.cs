﻿using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanMovie.Infrastructure
{
   public class MovieDbContext :DbContext
    {

        public MovieDbContext(DbContextOptions<MovieDbContext> options):base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one To Many (member and Rentals)
            modelBuilder.Entity<Member>()
                .HasOne<Rental>(s => s.Rental)
                .WithMany(r => r.Members)
                .HasForeignKey(s => s.RentalId);

            //Many To Many (rental and Movie)
            modelBuilder.Entity<MovieRental>()
                .HasKey(g => new { g.RentalId, g.MovieId });

            //Handle Decimals to avoid precisionn Loss


            modelBuilder.Entity<Rental>()
                .Property(p => p.TotalCost)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Movie>()
                .Property(p => p.RentalCost)
                .HasColumnType("decimal(18,2)");

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }


    }
}
