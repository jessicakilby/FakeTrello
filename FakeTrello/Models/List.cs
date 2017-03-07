using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class List
    {
        [Key]
        public int ListId { get; set; }

        [MaxLength(50)]
        public string ListName { get; set; }

        //does this need to be added?
        public Board BelongsToBoard { get; set; }

        public List<Card> Cards { get; set; }
    }
}