using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }

        [MaxLength(50)]
        public string BoardName { get; set; }

        [MaxLength(50)]
        public string URL { get; set; }

        // Auxiliary = not required to drive/define relationship
        public TrelloUser Owner { get; set; }

        public List<List> Lists { get; set; }
    }
}