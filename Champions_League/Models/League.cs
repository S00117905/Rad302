using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Champions_League.Models
{
    public class League
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int LeagueID { get; set; }
        public string Title { get; set; }
        public int Members { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}