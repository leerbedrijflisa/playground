using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa.BlueJay.Data.Entities
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DossierId { get; set; }

        public virtual Dossier Dossier { get; set; }
    }
}
