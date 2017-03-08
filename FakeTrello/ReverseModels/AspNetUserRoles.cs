using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.ReverseModels
{
    public class AspNetUserRoles
    {
        //this really doesn't exist, but the relationship does.
        [Key]
        [MaxLength(128)]
        public string UserId { get; set; }

        [Key]
        [MaxLength(128)]
        public string RoleId { get; set; }
    }
}