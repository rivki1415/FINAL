using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class StatusDTO
    {
        public int statusId { get; set; }
        public string statusDescription { get; set; }
        //From DAL to DTO
        public StatusDTO(Status s)
        {
            this.statusId = s.statusId;
            this.statusDescription = s.statusDescription;
        
        }

        ////From DTO to DAL
        public Status Parse(StatusDTO user)
        {
            return new Status(

             statusId = this.statusId,
            statusDescription = this.statusDescription,
           );



        }
    }
}
