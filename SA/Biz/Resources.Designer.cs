﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace com.jajago.SA.Biz
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class jajagoEntities : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“jajagoEntities”部分中的连接字符串初始化新 jajagoEntities 对象。
        /// </summary>
        public jajagoEntities() : base("name=jajagoEntities", "jajagoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 jajagoEntities 对象。
        /// </summary>
        public jajagoEntities(string connectionString) : base(connectionString, "jajagoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 jajagoEntities 对象。
        /// </summary>
        public jajagoEntities(EntityConnection connection) : base(connection, "jajagoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Resource> Resources
        {
            get
            {
                if ((_Resources == null))
                {
                    _Resources = base.CreateObjectSet<Resource>("Resources");
                }
                return _Resources;
            }
        }
        private ObjectSet<Resource> _Resources;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Taxonomy> Taxonomies
        {
            get
            {
                if ((_Taxonomies == null))
                {
                    _Taxonomies = base.CreateObjectSet<Taxonomy>("Taxonomies");
                }
                return _Taxonomies;
            }
        }
        private ObjectSet<Taxonomy> _Taxonomies;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Taxon> Taxons
        {
            get
            {
                if ((_Taxons == null))
                {
                    _Taxons = base.CreateObjectSet<Taxon>("Taxons");
                }
                return _Taxons;
            }
        }
        private ObjectSet<Taxon> _Taxons;

        #endregion
        #region AddTo 方法
    
        /// <summary>
        /// 用于向 Resources EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToResources(Resource resource)
        {
            base.AddObject("Resources", resource);
        }
    
        /// <summary>
        /// 用于向 Taxonomies EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToTaxonomies(Taxonomy taxonomy)
        {
            base.AddObject("Taxonomies", taxonomy);
        }
    
        /// <summary>
        /// 用于向 Taxons EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToTaxons(Taxon taxon)
        {
            base.AddObject("Taxons", taxon);
        }

        #endregion
    }
    

    #endregion
    
    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="jajagoModel", Name="Resource")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Resource : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Resource 对象。
        /// </summary>
        /// <param name="id">id 属性的初始值。</param>
        /// <param name="taxonomy_id">taxonomy_id 属性的初始值。</param>
        public static Resource CreateResource(global::System.Int64 id, global::System.Int64 taxonomy_id)
        {
            Resource resource = new Resource();
            resource.id = id;
            resource.taxonomy_id = taxonomy_id;
            return resource;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int64 _id;
        partial void OnidChanging(global::System.Int64 value);
        partial void OnidChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 taxonomy_id
        {
            get
            {
                return _taxonomy_id;
            }
            set
            {
                Ontaxonomy_idChanging(value);
                ReportPropertyChanging("taxonomy_id");
                _taxonomy_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("taxonomy_id");
                Ontaxonomy_idChanged();
            }
        }
        private global::System.Int64 _taxonomy_id;
        partial void Ontaxonomy_idChanging(global::System.Int64 value);
        partial void Ontaxonomy_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> taxon_id
        {
            get
            {
                return _taxon_id;
            }
            set
            {
                Ontaxon_idChanging(value);
                ReportPropertyChanging("taxon_id");
                _taxon_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("taxon_id");
                Ontaxon_idChanged();
            }
        }
        private Nullable<global::System.Int64> _taxon_id;
        partial void Ontaxon_idChanging(Nullable<global::System.Int64> value);
        partial void Ontaxon_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String path
        {
            get
            {
                return _path;
            }
            set
            {
                OnpathChanging(value);
                ReportPropertyChanging("path");
                _path = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("path");
                OnpathChanged();
            }
        }
        private global::System.String _path;
        partial void OnpathChanging(global::System.String value);
        partial void OnpathChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String created_at
        {
            get
            {
                return _created_at;
            }
            set
            {
                Oncreated_atChanging(value);
                ReportPropertyChanging("created_at");
                _created_at = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("created_at");
                Oncreated_atChanged();
            }
        }
        private global::System.String _created_at;
        partial void Oncreated_atChanging(global::System.String value);
        partial void Oncreated_atChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="jajagoModel", Name="Taxon")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Taxon : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Taxon 对象。
        /// </summary>
        /// <param name="id">id 属性的初始值。</param>
        /// <param name="parent_id">parent_id 属性的初始值。</param>
        /// <param name="taxonomy_id">taxonomy_id 属性的初始值。</param>
        public static Taxon CreateTaxon(global::System.Int64 id, global::System.Int64 parent_id, global::System.Int64 taxonomy_id)
        {
            Taxon taxon = new Taxon();
            taxon.id = id;
            taxon.parent_id = parent_id;
            taxon.taxonomy_id = taxonomy_id;
            return taxon;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int64 _id;
        partial void OnidChanging(global::System.Int64 value);
        partial void OnidChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 parent_id
        {
            get
            {
                return _parent_id;
            }
            set
            {
                Onparent_idChanging(value);
                ReportPropertyChanging("parent_id");
                _parent_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("parent_id");
                Onparent_idChanged();
            }
        }
        private global::System.Int64 _parent_id;
        partial void Onparent_idChanging(global::System.Int64 value);
        partial void Onparent_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 taxonomy_id
        {
            get
            {
                return _taxonomy_id;
            }
            set
            {
                Ontaxonomy_idChanging(value);
                ReportPropertyChanging("taxonomy_id");
                _taxonomy_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("taxonomy_id");
                Ontaxonomy_idChanged();
            }
        }
        private global::System.Int64 _taxonomy_id;
        partial void Ontaxonomy_idChanging(global::System.Int64 value);
        partial void Ontaxonomy_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="jajagoModel", Name="Taxonomy")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Taxonomy : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Taxonomy 对象。
        /// </summary>
        /// <param name="id">id 属性的初始值。</param>
        public static Taxonomy CreateTaxonomy(global::System.Int64 id)
        {
            Taxonomy taxonomy = new Taxonomy();
            taxonomy.id = id;
            return taxonomy;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int64 _id;
        partial void OnidChanging(global::System.Int64 value);
        partial void OnidChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> position
        {
            get
            {
                return _position;
            }
            set
            {
                OnpositionChanging(value);
                ReportPropertyChanging("position");
                _position = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("position");
                OnpositionChanged();
            }
        }
        private Nullable<global::System.Int32> _position;
        partial void OnpositionChanging(Nullable<global::System.Int32> value);
        partial void OnpositionChanged();

        #endregion
    
    }

    #endregion
    
}
