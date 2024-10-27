using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Data.Entity
{
    public class StoreLocation
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
