using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Text.RegularExpressions;
using Shell32;
namespace com.jajago.Biz
{
    public class ResourceTaxonomyNode
    {
        public Taxonomy taxonomy { get; set; }
        public Regex regex { get; set; }
    }
 
    public class ResourceManager
    {
        private static ResourceManager theInstance = null;
        ResourcesEntities ent = new ResourcesEntities();
        public List<ResourceTaxonomyNode> AllTaxonomies = new List<ResourceTaxonomyNode>();
        ShellClass osShell = new ShellClass();
        public event EventHandler ShowStatusText;

        private ResourceManager()
        {
            foreach (Taxonomy t in ent.Taxonomies)
            {
                ResourceTaxonomyNode node = new ResourceTaxonomyNode();
                node.taxonomy = t;
                if (t.pattern!=null) node.regex = new Regex(@"\.(" + t.pattern + ")$");
                AllTaxonomies.Add(node);
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

        public void StatusText(string text)
        {
            if (ShowStatusText != null) ShowStatusText(text, null);
        }


        // 读取资源列表
        public IQueryable<object> GetList(string taxonomy_id)
        {
            switch (taxonomy_id)
            {
                case "MUSIC":
                    return from r in ent.ResMusics select r;
                case "IMG":
                    return from r in ent.ResImages select r;
                default:
                    return from r in ent.Resources
                            where r.taxonomy_id == taxonomy_id
                            select r;
            }
            
        }
        public Resource GetResource(string id)
        {
            return ent.Resources.First(m => m.id == id);
        }

        public void AddResource(FileInfo f)
        {
            string rest = FileResourceType(f);
            if (rest != null)
            {
                Resource res = new Resource();
                res.name = f.Name;
                res.id = Guid.NewGuid().ToString();
                res.taxon_id = "0";
                res.taxonomy_id = rest;
                res.path = f.FullName;
                res.size = f.Length;
                res.created_at = DateTime.Now;
                ent.AddToResources(res);

                switch(rest)
                {
                    case "MUSIC":
                        ent.AddToResMusics(GetMusicDetail(res.id,f));
                        break;
                    case "IMG":
                        ent.AddToResImages(GetImageDetail(res.id, f));
                        break;
                }
                ent.SaveChanges();
            }
        }

        private string FileResourceType(FileInfo file)
        {
            foreach (ResourceTaxonomyNode t in AllTaxonomies)
            {
                if (t.regex != null && t.regex.IsMatch(file.Extension))
                    return t.taxonomy.id;
            }
            return null;
        }

        private ResImage GetImageDetail(string res_id, FileInfo file)
        {
            ResImage img = new ResImage();
            Folder folder = osShell.NameSpace(file.DirectoryName);
            FolderItem folderitem = folder.ParseName(file.Name);
            img.id = res_id;
            img.filename = folder.GetDetailsOf(folderitem, 0);
            img.fileext = folder.GetDetailsOf(folderitem, 2);
            img.filesize = folder.GetDetailsOf(folderitem, 1);
            img.filetype = img.fileext;
            img.width = folder.GetDetailsOf(folderitem, 26);
            img.height = folder.GetDetailsOf(folderitem, 28);
            img.dpi = folder.GetDetailsOf(folderitem, 22);
            img.thumb = ImageManager.BinaryThumbnail(file.FullName, 100);
            return img;
        }

        private ResMusic GetMusicDetail(string res_id, FileInfo file)
        {
            ResMusic music = new ResMusic();
            Folder folder = osShell.NameSpace(file.DirectoryName);
            FolderItem folderitem = folder.ParseName(file.Name);
            music.id = res_id;
            music.title = folder.GetDetailsOf(folderitem, 10);
            music.artist = folder.GetDetailsOf(folderitem, 9);
            music.album = folder.GetDetailsOf(folderitem, 17);
            music.publish = folder.GetDetailsOf(folderitem, 4);
            music.music_type = folder.GetDetailsOf(folderitem, 2);
            return music;
        }

        public string ConfigSearchPath
        {
            get
            {
                if (ent.Configs.Count() == 0) return null;
                Config cf = ent.Configs.First(c => c.id == "search_path");
                if (cf != null) return cf.value;
                return null;
            }
            set
            {
                Config cf = null;
                if (ent.Configs.Count() == 0)
                {
                    Config ncf = new Config();
                    ncf.id = "search_path";
                    ncf.value = value;
                    ent.AddToConfigs(ncf);
                } else 
                {
                    cf = ent.Configs.First(c => c.id == "search_path");
                    if (cf == null)
                    {
                        Config ncf = new Config();
                        ncf.id = "search_path";
                        ncf.value = value;
                        ent.AddToConfigs(ncf);
                    }
                    else
                    {
                        cf.value = value;
                    }
                }
                
                ent.SaveChanges();
            }
       }

    }
}
