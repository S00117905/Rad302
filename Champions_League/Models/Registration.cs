using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Champions_League.Models
{
    public enum Division
    {
        A, B, C
    }

    public class Registration
    {
        [Key]
        public int RegistrationID { get; set; }
        public int LeagueID { get; set; }
        public int TeamID { get; set; }
        public Division? Division { get; set; }

        public virtual League League { get; set; }
        public virtual Team Team { get; set; }
    }
}