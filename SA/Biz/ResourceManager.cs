using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;


namespace com.jajago.SA.Biz
{
   
    public class ResourceManager : JajagoBiz
    {
        public ObjectSet<Taxonomy> Catalog()
        {
            jajagoEntities ent = new jajagoEntities();
            return ent.Taxonomies;
        }
        public int Scan(string path)
        {
            return 0;
        }

    }
}
