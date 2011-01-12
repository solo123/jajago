using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jajago.SA.Biz
{
    public class MobileManager
    {
        private static MobileManager theInstance = null;

        jajagoEntities1 ent = new jajagoEntities1();

        private MobileManager()
        {
        }
        public static MobileManager Instance
        {
            get
            {
                if (theInstance == null) theInstance = new MobileManager();
                return theInstance;
            }
        }

        public IQueryable<object> GetList()
        {
            return from r in ent.Mobiles
                    select r;

        }

        public Mobile GetMobile(int id)
        {
            return ent.Mobiles.First(r => r.id==id);
        }

    }
    
}
