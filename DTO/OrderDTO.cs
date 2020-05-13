using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class OrderDTO
    {
        public int orderId { get; set; }
        public int userId { get; set; }
        public System.DateTime orderDate { get; set; }
        public int branchId { get; set; }
        public int statusId { get; set; }
        public decimal totalPrice { get; set; }
        //From DAL to DTO
        public OrderDTO(Order o)
        {
            this.orderId = o.orderId;
            this.userId =o.userId;
            this.orderDate = o.orderDate;
            this.branchId = o.branchId;
            this.statusId = o.statusId;
            this.totalPrice = o.totalPrice;
        }

        ////From DTO to DAL
        public Order Parse(OrderDTO user)
        {
            return new Order(

             orderId = this.orderId,
            userId = this.userId,
            orderDate = this.orderDate,
            branchId = this.branchId,
            statusId = this.statusId,
            totalPrice = this.totalPrice);



        }
    }
}
