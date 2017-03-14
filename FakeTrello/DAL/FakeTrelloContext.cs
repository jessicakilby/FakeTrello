using FakeTrello.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FakeTrello.DAL
{
    public class FakeTrelloContext : ApplicationDbContext
    {
        //creating some entry points
        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Card> Cards { get; set; }

    }
}