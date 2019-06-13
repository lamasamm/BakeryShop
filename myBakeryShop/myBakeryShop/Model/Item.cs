using System;
using System.Collections.Generic;
using System.Text;

namespace myBakeryShop.Model
{
   public class Item
    {
      
        public String ItemName{ get; set;}
        public String Price { get; set; }
        public String Image {get; set;  }
        public String Calories { get; set; }
        public String Discription { get; set; }


        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public double Address_lat{ get; set; }
        public double Address_lang { get; set; }


    }
}
