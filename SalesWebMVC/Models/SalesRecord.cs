using SalesWebMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Range(1.0, 200000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Amount")]
        [DisplayFormat(DataFormatString = "US$ {0:F2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
        public int SellerId { get; set; }
        public string Product { get; set; }
       

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller, string product)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
            Product = product;
        }
    }
}
