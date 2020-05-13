using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PriceDTO
    {
        public int priceId { get; set; }
        public int sheetTypeId { get; set; }
        public bool selfDesign { get; set; }
        public decimal price1 { get; set; }

    }
}
