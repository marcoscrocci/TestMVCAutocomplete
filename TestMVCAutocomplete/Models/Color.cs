using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVCAutocomplete.Models
{
    public class Color
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}