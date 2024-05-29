using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate.Models;
namespace FluentNHibernate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap() {
            Table("product");
            Id(p=>p.Id);
            Map(p=>p.Name);
            Map(p=>p.Units);
            Map(p=>p.Price);
        }
    }
}
