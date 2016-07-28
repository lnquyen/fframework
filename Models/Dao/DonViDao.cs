using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entity;

namespace Models.Dao
{

    public class DonViDao
    {
        QuanLyDaoTaoDbContext db = null;
        public DonViDao()
        {
            db = new QuanLyDaoTaoDbContext();
        }

        public List<DM_DON_VI> ListAll()
        {
            return db.DM_DON_VI.ToList();
        }
    }
}

