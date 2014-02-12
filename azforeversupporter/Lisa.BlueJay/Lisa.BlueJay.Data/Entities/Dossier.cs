using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa.BlueJay.Data.Entities
{
    public class Dossier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        public virtual ICollection<User> Parents { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
