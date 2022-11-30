using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.models
{
    [DebuggerDisplay("{Name} ({Id}), Country = {CountryId}")]
    [Table("Städer")]
    class City
    {
        public int Id { get; set; }
        [Column("Namn")]
        public string Name { get; set; }

        [Column("LandId")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
