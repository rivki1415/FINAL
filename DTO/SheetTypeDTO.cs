using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SheetTypeDTO
    {
        public int sheetTypeId { get; set; }
        public string Description { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public int pagesInPackage { get; set; }
        //From DAL to DTO
        public SheetTypeDTO(sheetsType s)
        {
            this.sheetTypeId = s.sheetTypeId;
            this.Description = s.Description;
            this.height = s.height;
            this.width = s.width;
            this.pagesInPackage = s.pagesInPackage;
           
        }

        ////From DTO to DAL
        public Status Parse(StatusDTO user)
        {
            return new Status(

             sheetTypeId = this.sheetTypeId,
            Description = this.Description,
            height = this.height,
            width = this.width,
            pagesInPackage = this.pagesInPackage
          );



        }
    }
}
