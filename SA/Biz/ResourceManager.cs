using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Text.RegularExpressions;

namespace com.jajago.SA.Biz
{
 
    public class ResourceManager : JajagoBiz
    {
        private static ResourceManager theInstance = null;

        jajagoEntities ent = new jajagoEntities();
        public List<Taxonomy> AllTaxonomies = new List<Taxonomy>();

        private ResourceManager()
        {
            foreach (Taxonomy t in ent.Taxonomies)
            {
                AllTaxonomies.Add(t);
            }

        }

        public static ResourceManager Instance
        {
            get 
            {
                if (theInstance == null) theInstance = new ResourceManager();
                return theInstance;
            }
        }

        // 读取资源列表
        public IQueryable<object> GetList(string taxonomy_id)
        {
            switch (taxonomy_id)
            {
                case "MUSIC":
                    return from r in ent.Musics select r;
                case "IMG":
                    return from r in ent.Images select r;
                default:
                    return from r in ent.Resources
                            where r.taxonomy_id == taxonomy_id
                            select r;
            }
            
        }

        public event EventHandler OnAddResource;
        public void AddResource(FileInfo f)
        {
            foreach (Taxonomy t in AllTaxonomies)
            {
                if (t.pattern != null)
                {
                    Regex regex = new Regex(@"\.(" + t.pattern + ")$");
                    if (regex.IsMatch(f.Extension))
                    {
                        Resource res = new Resource();
                        res.name = f.Name;
                        res.id = Guid.NewGuid().ToString();
                        res.taxon_id = null;
                        res.taxonomy_id = t.id;
                        res.path = f.FullName;
                        res.created_at = DateTime.Now;
                        ent.AddToResources(res);

                        if (t.id == "MUSIC")
                        {
                            Music music = new Music();
                            music.id = res.id;

                            ent.AddToMusics(music);
                        }
                        else if (t.id == "IMG")
                        {
                            Image image = new Image();
                            image.id = res.id;
                            image.thumb = ImageManager.BinaryThumbnail(res.path, 100);
                            ent.AddToImages(image);
                        }

                        ent.SaveChanges();
                        if (OnAddResource != null) OnAddResource(res, null);
                        break;

                    }
                }
            }
        }

        public IQueryable<SearchPath> GetSearchPath()
        {
            return from r in ent.SearchPaths
                    select r;
        }

        public void ClearSearchPath()
        {
            var o = from r in ent.SearchPaths
                    select r;
            foreach (var oo in o)
                ent.DeleteObject(oo);

            ent.SaveChanges();
        }

        public void AddSearchPath(string path)
        {
            SearchPath sp = new SearchPath();
            sp.path = path;
            sp.count = 0;
            sp.updated_at = DateTime.Now;
            ent.AddToSearchPaths(sp);
            ent.SaveChanges();
        }

    }
}
