using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCContVersion.Models.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Desc { get; set; }

        //Relational Properties
        public List<Product> Products { get; set; }
    }
}