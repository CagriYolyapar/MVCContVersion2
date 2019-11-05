using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCContVersion.Models.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }


        //Relational Properties

        public Category Category { get; set; }
    }
}