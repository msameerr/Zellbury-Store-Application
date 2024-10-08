﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Data;

namespace ZellburyStoreApplication.Models
{
    public class PurchaseRecordVM
    {

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }



        public CustomerVM Customer { get; set; }
        public String CustomerId { get; set; }


       
        public ProductVM Product { get; set; }
        public int ProductId { get; set; }

    }


    public class CartVM
    {
        public List<ProductVM> productVMs { get; set; }

    }

}
