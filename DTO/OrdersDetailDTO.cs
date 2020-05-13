using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class OrdersDetailDTO
    {
        public int orderId { get; set; }
        public int designedItemId { get; set; }
        public int quantity { get; set; }
        //From DAL to DTO
        public OrdersDetailDTO(OrdersDetail o)
        {
            this.orderId = o.orderId;
            this.designedItemId = o.designedItemId;
            this.quantity = o.quantity;
            
        }

        ////From DTO to DAL
        public OrdersDetail Parse(OrdersDetailDTO user)
        {
            return new OrdersDetail(

             orderId = this.orderId,
            designedItemId = this.designedItemId,
            quantity = this.quantity
           );



        }
    }
}
