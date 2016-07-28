using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace QuanLyDaoTao.Models
{
    public class DonViDao
    {
        private QLDTContext db = null;

        public DonViDao()
        {
            db = new QLDTContext();
        }

        public List<DonViViewModel> ListAll(string sortParam, string order)
        {
            var list = (from c in db.DM_DON_VI
                        select new DonViViewModel
                        {
                            DV_ID = c.DV_ID,
                            DV_MA = c.DV_MA,
                            DV_TEN = c.DV_TEN,
                            DV_GHI_CHU = c.DV_GHI_CHU
                        }).AsQueryable();

            string orderDerection = (order == "asc") ? "ascending" : "descending";
            return list.OrderBy(sortParam + " " + orderDerection).ToList();
        }

        public bool Insert(DM_DON_VI entity)
        {
            try
            {
                db.DM_DON_VI.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(DM_DON_VI entity)
        {
            try
            {
                var dv = db.DM_DON_VI.Find(entity.DV_ID);
                dv.DV_MA = entity.DV_MA;
                dv.DV_TEN = entity.DV_TEN;
                dv.DV_GHI_CHU = entity.DV_GHI_CHU;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(long id)
        {
            try
            {
                var dv = db.DM_DON_VI.Find(id);
                db.DM_DON_VI.Remove(dv);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool isExist(string MaDV)
        {
            bool has = db.DM_DON_VI.Any(ma => ma.DV_MA == MaDV);
            return has;
        }

        public bool isExistWhenUpdate(string MaDV, long id)
        {
            bool has = db.DM_DON_VI.Any(dv => dv.DV_MA == MaDV && dv.DV_ID != id);
            return has;
        }
    }
}