using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Converters
{
    public static class PriceConverter
    {
        //From DAL to DTO
        public static PriceDTO ToDTO(Price p)
        {
            return new PriceDTO()
            {
                priceId = p.priceId,
                sheetTypeId = p.sheetTypeId,
                selfDesign = p.selfDesign,
                price1 = p.price1
            };

        }

        ////From DTO to DAL
        public static Price ToDAL(PriceDTO p)
        {
            return new Price()
            {
                priceId = p.priceId,
                sheetTypeId = p.sheetTypeId,
                selfDesign = p.selfDesign,
                price1 = p.price1
            };
        }
        //From DAL List to DTO List
        public static List<PriceDTO> ToDTOList(List<Price> dalList)
        {
            List<PriceDTO> dtoList = new List<PriceDTO>();
            dalList.ForEach(p => dtoList.Add(ToDTO(p)));
            return dtoList;

        }

        //From DTO List to DAL List
        public static List<Price> ToDALList(List<PriceDTO> dtoList)
        {
            List<Price> dalList = new List<Price>();
            dtoList.ForEach(p => dalList.Add(ToDAL(p)));
            return dalList;
        }
    }
}
