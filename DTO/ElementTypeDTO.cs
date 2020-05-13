using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ElementTypeDTO
    {
        public int typeId { get; set; }
        public string type { get; set; }
        //From DAL to DTO
        public ElementTypeDTO(ElementsType e)
        {
            this.typeId = e.typeId;
            this.type = e.type;
          
        }

        ////From DTO to DAL
        public ElementsType Parse(ElementTypeDTO user)
        {
            return new ElementsType(

             typeId = this.typeId,
            type = this.type
           );



        }
    }
}
