using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZellburyStoreApplication.Data
{
    public class PurchaseRecord
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }



        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public String CustomerId { get; set; }


        [ForeignKey("ProductId")]
        Product Product { get; set; }
        public int ProductId { get; set; }

    }
}
