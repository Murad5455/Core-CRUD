using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class Tv
    {
        [Key]
        public int ID { get; set; }
        public string Barcode { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
        public int DiscountPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool SmartTv { get; set; }
        public int Inch { get; set; }
        public bool HDMI { get; set; }
    }
}
