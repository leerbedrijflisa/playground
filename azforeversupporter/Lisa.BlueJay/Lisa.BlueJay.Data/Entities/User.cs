using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lisa.BlueJay.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DefaultValue("PARENT")]
        public string Type { get; set; }

        public virtual ICollection<Dossier> Dossiers { get; set; }
    }
}
