﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        //Auxilliary: given a card instance, return the list it belongs to.
        public List BelongsTo { get; set; }

        public TrelloUser Contributor { get; set; }

        public TrelloUser Owner { get; set; }
    }
}