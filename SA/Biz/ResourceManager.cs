using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.IO;

using System.Text.RegularExpressions;
using System.Configuration;
using System.Collections.Specialized;

namespace com.jajago.SA.Biz
{
    public class ResourceTaxonomy
    {
        public string name { get; set; }
        public string search_pattern { get; set; }
        public Regex regex {get;set;}
    }
   
    public class ResourceManager : JajagoBiz
    {
        public List<ResourceTaxonomy> taxonomy = new List<ResourceTaxonomy>();
        jajagoEntities ent = new jajagoEntities();

        public ResourceManager()
        {
            NameValueCollection taxons = (NameValueCollection)ConfigurationManager.GetSection("taxonomy");
            foreach (string t in taxons.AllKeys)
            {
                ResourceTaxonomy rt = new ResourceTaxonomy();
                rt.name = t;
                rt.search_pattern = taxons[t];
                rt.regex = new Regex(@"\.("+ taxons[t] +")$");
                taxonomy.Add(rt);
            }
        }

        public ObjectSet<Taxonomy> Catalog()
        {
            return ent.Taxonomies;
        }

        public IQueryable<Resource> GetList(string taxonomy)
        {
            return from r in ent.Resources
                    where r.taxonomy_id == taxonomy
                    select r;
        }
        public void scan(DirectoryInfo dir)
        {
            try
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo di in dirs)
                {
                    scan(di);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                add_to_db(f);
            }
        }

        private void add_to_db(FileInfo f)
        {
            foreach (ResourceTaxonomy rt in taxonomy)
            {
                if (rt.regex.IsMatch(f.Extension))
                {
                    Resource res = new Resource();
                    res.name = f.Name;
                    res.id = Guid.NewGuid().ToString();
                    res.taxon_id = null;
                    res.taxonomy_id = rt.name;
                    res.path = f.FullName;
                    res.created_at = DateTime.Now;
                    ent.AddToResources(res);
                    ent.SaveChanges();

                    break;

                }
            }
        }


    }
}
