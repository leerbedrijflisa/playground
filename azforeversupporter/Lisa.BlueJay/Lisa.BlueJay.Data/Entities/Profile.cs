using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa.BlueJay.Data.Entities
{
    public class Profile
    {
        [Key, ForeignKey("Dossier")]
        public int Id { get; set; }

        public virtual Dossier Dossier { get; set; }
    }
}
