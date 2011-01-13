using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jajago.Biz
{
    public class MobileManager
    {
        private static MobileManager theInstance = null;

        MobilesEntities ent = new MobilesEntities();

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
            MobilesEntities ent = new MobilesEntities();
            if (ent.Mobiles.Count() == 0) return null;
            return ent.Mobiles.First( m => m.id == id );
        }

    }
    
}
