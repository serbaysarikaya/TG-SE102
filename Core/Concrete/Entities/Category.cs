using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class Category :BaseEntity
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}
