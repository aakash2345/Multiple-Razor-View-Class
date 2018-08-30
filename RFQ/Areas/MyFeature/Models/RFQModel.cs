using System;
using System.Collections.Generic;
using System.Text;

namespace RFQ.Areas.MyFeature.Models
{
    public class RFQModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public int Age { get; set; }
        public decimal City { get; set; }

        public RFQModel()
        {
            FirstName = "parker";
            LastName = "Hannifin";
            Age = 100;

        }
    }

}
