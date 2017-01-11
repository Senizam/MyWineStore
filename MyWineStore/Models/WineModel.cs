using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWineStore.Models
{
    public class WineModel
    {
        public int Id { get; set; }
        public string Name { get;  set; }
        public int Quantity { get; set; }
        public string WineType { get; set; }
    }
}