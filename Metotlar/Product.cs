﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Product
    {

        //Property - Özellik demek, asagidakilerin hepsi property'dir. 
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
       
    }
}
