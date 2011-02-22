using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.IO;

namespace com.jajago.Biz
{
    public class MobileManager
    {
        private static MobileManager theInstance = null;
        int standard_id = 0;
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

        public IQueryable<Mobile> GetList(string filter = null)
        {
            if (filter==null || filter.Trim().Length<1) 
                return from r in ent.Mobiles select r;
            var result = from r in ent.Mobiles
                         where r.title.Contains(filter)
                         select r;
            return result;
        }

        public IQueryable<Mobile> GetPriceList(int i,int j)
        {
            return from r in ent.Mobiles
                   where i<r.price_shop&&r.price_shop<j
                   select r;
        }

        public Mobile GetMobile(int id)
        {
            if (ent.Mobiles.Count() == 0) return null;
            return ent.Mobiles.First( m => m.id == id );
        }

        public List<KeyValuePair<string,string>> GetAttributes(long mobile_id)
        {
            var result =
                from ma in ent.MobileInAttributes
                where ma.mobile_id == mobile_id
                join a in ent.MobileAttributes on ma.attribute_id equals a.id
                select new { attr = a.title, val = ma.title };
            List<KeyValuePair<string, string>> props = new List<KeyValuePair<string, string>>();
            foreach (var p in result)
            {
                props.Add(new KeyValuePair<string,string>(p.attr, p.val));
            }
            return props;
        }

        public string MobileProp(long mobile_id, long prop_id)
        {
            MobileInAttribute ma = ent.MobileInAttributes.FirstOrDefault(m => m.mobile_id==mobile_id && m.attribute_id == prop_id);
            if (ma != null)
                return ma.title;
            else
                return null;
        }

        public string MobileStandard(long mobile_id)
        {
            if (standard_id==0)
            {
                MobileAttribute ma = ent.MobileAttributes.First(m => m.title == "原装标配");
                if (ma!=null) standard_id = (int)ma.id;
                else standard_id = -1;
            }
            return (standard_id>0) ? MobileProp(mobile_id,standard_id) : "";
        }

        public void SaveChanges()
        {
            ent.SaveChanges();
        }

    }

    public class MobileProperty
    {

    }
    
}
