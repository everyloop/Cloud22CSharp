using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.models
{
    [DebuggerDisplay("{Name} ({Id})")]
    [Table("Länder")]
    class Country
    {

        public int Id { get; set; }
        [Column("Namn")]
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
