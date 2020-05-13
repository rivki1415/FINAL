using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class OpeningHourDTO
    {
        public int branchId { get; set; }
        public int fromDay { get; set; }
        public int toDay { get; set; }
        public System.TimeSpan fromHour { get; set; }
        public System.TimeSpan toHour { get; set; }
        //From DAL to DTO
        public OpeningHourDTO(OpeningHour o)
        {
            this.branchId =o.branchId;
            this.fromDay = o.fromDay;
            this.toDay = o.toDay;
            this.fromHour = o.fromHour;
            this.toHour = o.toHour;
          
        }

        ////From DTO to DAL
        public OpeningHour Parse(OpeningHourDTO user)
        {
            return new OpeningHour(

             branchId = this.branchId,
            fromDay = this.fromDay,
            toDay = this.toDay,
            fromHour = this.fromHour,
            toHour = this.toHour,
           );



        }    }
}
