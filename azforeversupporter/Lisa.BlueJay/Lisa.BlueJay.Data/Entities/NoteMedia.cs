using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa.BlueJay.Data.Entities
{
    public class NoteMedia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string MediaLocation { get; set; }

        [Required]
        public int NoteId { get; set; }
        public virtual Note Note { get; set; }
    }
}
