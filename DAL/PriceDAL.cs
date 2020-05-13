using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class PriceDAL
    {
        public static List<Price> GetAll()
        {
            try
            {
                using (MekoritDBEntities db = new MekoritDBEntities())
                {
                    return db.Prices.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Price Add(Price price)
        {
            try
            {
                using (MekoritDBEntities db = new MekoritDBEntities())
                {
                    price = db.Prices.Add(price);
                    db.SaveChanges();
                    return price;
                }
            }
            catch
            {
                throw;
            }
        }
        public static Price Update(Price price)
        {
            try
            {
                using (MekoritDBEntities db = new MekoritDBEntities())
                {
                    db.Prices.Attach(price);
                    db.Entry(price).State = EntityState.Modified;
                    db.SaveChanges();
                    return price;
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Update(int priceId)
        {
            try
            {
                using (MekoritDBEntities db = new MekoritDBEntities())
                {
                    db.Prices.Remove(db.Prices.Find(priceId));
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
