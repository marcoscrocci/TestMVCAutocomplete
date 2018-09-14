using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVCAutocomplete.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}