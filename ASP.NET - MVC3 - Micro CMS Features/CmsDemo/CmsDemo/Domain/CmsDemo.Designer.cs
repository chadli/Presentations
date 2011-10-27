﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 7/27/2011 7:54:23 PM
namespace CmsDemo.Domain
{
    
    /// <summary>
    /// There are no comments for CmsDemoEntities in the schema.
    /// </summary>
    public partial class CmsDemoEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new CmsDemoEntities object using the connection string found in the 'CmsDemoEntities' section of the application configuration file.
        /// </summary>
        public CmsDemoEntities() : 
                base("name=CmsDemoEntities", "CmsDemoEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CmsDemoEntities object.
        /// </summary>
        public CmsDemoEntities(string connectionString) : 
                base(connectionString, "CmsDemoEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CmsDemoEntities object.
        /// </summary>
        public CmsDemoEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "CmsDemoEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Pages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<Page> Pages
        {
            get
            {
                if ((this._Pages == null))
                {
                    this._Pages = base.CreateQuery<Page>("[Pages]");
                }
                return this._Pages;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<Page> _Pages;
        /// <summary>
        /// There are no comments for PageContents in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<PageContent> PageContents
        {
            get
            {
                if ((this._PageContents == null))
                {
                    this._PageContents = base.CreateQuery<PageContent>("[PageContents]");
                }
                return this._PageContents;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<PageContent> _PageContents;
        /// <summary>
        /// There are no comments for Pages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToPages(Page page)
        {
            base.AddObject("Pages", page);
        }
        /// <summary>
        /// There are no comments for PageContents in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToPageContents(PageContent pageContent)
        {
            base.AddObject("PageContents", pageContent);
        }
    }
    /// <summary>
    /// There are no comments for CmsDemoModel.Page in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PageId
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="CmsDemoModel", Name="Page")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Page : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Page object.
        /// </summary>
        /// <param name="pageId">Initial value of PageId.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="content">Initial value of Content.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static Page CreatePage(int pageId, string title, string content)
        {
            Page page = new Page();
            page.PageId = pageId;
            page.Title = title;
            page.Content = content;
            return page;
        }
        /// <summary>
        /// There are no comments for property PageId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int PageId
        {
            get
            {
                return this._PageId;
            }
            set
            {
                this.OnPageIdChanging(value);
                this.ReportPropertyChanging("PageId");
                this._PageId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("PageId");
                this.OnPageIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _PageId;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnPageIdChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnPageIdChanged();
        /// <summary>
        /// There are no comments for property Title in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this.ReportPropertyChanging("Title");
                this._Title = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Title");
                this.OnTitleChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Title;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnTitleChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for property Content in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Content
        {
            get
            {
                return this._Content;
            }
            set
            {
                this.OnContentChanging(value);
                this.ReportPropertyChanging("Content");
                this._Content = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Content");
                this.OnContentChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Content;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnContentChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnContentChanged();
    }
    /// <summary>
    /// There are no comments for CmsDemoModel.PageContent in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="CmsDemoModel", Name="PageContent")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class PageContent : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new PageContent object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="content">Initial value of Content.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static PageContent CreatePageContent(int id, string title, string content)
        {
            PageContent pageContent = new PageContent();
            pageContent.Id = id;
            pageContent.Title = title;
            pageContent.Content = content;
            return pageContent;
        }
        /// <summary>
        /// There are no comments for property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _Id;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnIdChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for property Title in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this.ReportPropertyChanging("Title");
                this._Title = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Title");
                this.OnTitleChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Title;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnTitleChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for property Content in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Content
        {
            get
            {
                return this._Content;
            }
            set
            {
                this.OnContentChanging(value);
                this.ReportPropertyChanging("Content");
                this._Content = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Content");
                this.OnContentChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Content;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnContentChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnContentChanged();
    }
}
