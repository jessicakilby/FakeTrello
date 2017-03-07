using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//Entity is our Object Relational Mapper (ORM) So it knows how to interpret this information

namespace FakeTrello.Models
{
    public class TrelloUser
    {
        [Key] //help tell db system what constraints to take, applies to first property it hits going down
        public int TrelloUserId { get; set; } //Primary Key

        //stacking of properties applies multiple annotations
        //to the following property. failed = database failed constraint
        [MinLength(10)]  
        [MaxLength(50)]
        public string Email { get; set; }
        
        [MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public ApplicationUser BaseUser { get; set; } // creates one to one relationship to another table

        public List<Board> Boards { get; set; } // 1 to many (boards) relationship. Navigation property. Does join sql statement for you. Entity knows how to interpret that relationship.

    }
}