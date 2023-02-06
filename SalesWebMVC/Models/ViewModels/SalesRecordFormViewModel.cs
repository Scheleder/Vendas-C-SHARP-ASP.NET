using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMVC.Models.ViewModels
{
    public class SalesRecordFormViewModel
    {
        public SalesRecord SalesRecord { get; set; }
        public ICollection<Seller> Sellers { get; set; }
        // necessaro para relacionar os dados dos vendedores
    }
}
