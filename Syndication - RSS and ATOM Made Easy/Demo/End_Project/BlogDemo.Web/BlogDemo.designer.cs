﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogDemo.Web
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="BlogDemo")]
	public partial class BlogDemoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAuthor(Author instance);
    partial void UpdateAuthor(Author instance);
    partial void DeleteAuthor(Author instance);
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertComment(Comment instance);
    partial void UpdateComment(Comment instance);
    partial void DeleteComment(Comment instance);
    partial void InsertPostCategoryMapper(PostCategoryMapper instance);
    partial void UpdatePostCategoryMapper(PostCategoryMapper instance);
    partial void DeletePostCategoryMapper(PostCategoryMapper instance);
    #endregion
		
		public BlogDemoDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogDemoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDemoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDemoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDemoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDemoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Author> Authors
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<Post> Posts
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Comment> Comments
		{
			get
			{
				return this.GetTable<Comment>();
			}
		}
		
		public System.Data.Linq.Table<PostCategoryMapper> PostCategoryMappers
		{
			get
			{
				return this.GetTable<PostCategoryMapper>();
			}
		}
	}
	
	[Table(Name="dbo.Authors")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AuthorID;
		
		private string _Name;
		
		private System.DateTime _CreatedOn;
		
		private string _CreatedBy;
		
		private System.DateTime _ModifiedOn;
		
		private string _ModifiedBy;
		
		private bool _IsDeleted;
		
		private string _Email;
		
		private EntitySet<Post> _Posts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAuthorIDChanging(int value);
    partial void OnAuthorIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnIsDeletedChanging(bool value);
    partial void OnIsDeletedChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Author()
		{
			this._Posts = new EntitySet<Post>(new Action<Post>(this.attach_Posts), new Action<Post>(this.detach_Posts));
			OnCreated();
		}
		
		[Column(Storage="_AuthorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					this.OnAuthorIDChanging(value);
					this.SendPropertyChanging();
					this._AuthorID = value;
					this.SendPropertyChanged("AuthorID");
					this.OnAuthorIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_IsDeleted", DbType="Bit NOT NULL")]
		public bool IsDeleted
		{
			get
			{
				return this._IsDeleted;
			}
			set
			{
				if ((this._IsDeleted != value))
				{
					this.OnIsDeletedChanging(value);
					this.SendPropertyChanging();
					this._IsDeleted = value;
					this.SendPropertyChanged("IsDeleted");
					this.OnIsDeletedChanged();
				}
			}
		}
		
		[Column(Storage="_Email", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Association(Name="Author_Post", Storage="_Posts", ThisKey="AuthorID", OtherKey="AuthorID")]
		public EntitySet<Post> Posts
		{
			get
			{
				return this._Posts;
			}
			set
			{
				this._Posts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Author = this;
		}
		
		private void detach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Author = null;
		}
	}
	
	[Table(Name="dbo.Posts")]
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PostID;
		
		private string _Title;
		
		private string _PostContent;
		
		private System.Nullable<System.DateTime> _PostDate;
		
		private int _AuthorID;
		
		private System.DateTime _CreatedOn;
		
		private string _CreatedBy;
		
		private System.DateTime _ModifiedOn;
		
		private string _ModifiedBy;
		
		private bool _IsDeleted;
		
		private EntitySet<Comment> _Comments;
		
		private EntitySet<PostCategoryMapper> _PostCategoryMappers;
		
		private EntityRef<Author> _Author;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostIDChanging(int value);
    partial void OnPostIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnPostContentChanging(string value);
    partial void OnPostContentChanged();
    partial void OnPostDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPostDateChanged();
    partial void OnAuthorIDChanging(int value);
    partial void OnAuthorIDChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnIsDeletedChanging(bool value);
    partial void OnIsDeletedChanged();
    #endregion
		
		public Post()
		{
			this._Comments = new EntitySet<Comment>(new Action<Comment>(this.attach_Comments), new Action<Comment>(this.detach_Comments));
			this._PostCategoryMappers = new EntitySet<PostCategoryMapper>(new Action<PostCategoryMapper>(this.attach_PostCategoryMappers), new Action<PostCategoryMapper>(this.detach_PostCategoryMappers));
			this._Author = default(EntityRef<Author>);
			OnCreated();
		}
		
		[Column(Storage="_PostID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[Column(Storage="_Title", DbType="VarChar(255)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_PostContent", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string PostContent
		{
			get
			{
				return this._PostContent;
			}
			set
			{
				if ((this._PostContent != value))
				{
					this.OnPostContentChanging(value);
					this.SendPropertyChanging();
					this._PostContent = value;
					this.SendPropertyChanged("PostContent");
					this.OnPostContentChanged();
				}
			}
		}
		
		[Column(Storage="_PostDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> PostDate
		{
			get
			{
				return this._PostDate;
			}
			set
			{
				if ((this._PostDate != value))
				{
					this.OnPostDateChanging(value);
					this.SendPropertyChanging();
					this._PostDate = value;
					this.SendPropertyChanged("PostDate");
					this.OnPostDateChanged();
				}
			}
		}
		
		[Column(Storage="_AuthorID", DbType="Int NOT NULL")]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					if (this._Author.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorIDChanging(value);
					this.SendPropertyChanging();
					this._AuthorID = value;
					this.SendPropertyChanged("AuthorID");
					this.OnAuthorIDChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_IsDeleted", DbType="Bit NOT NULL")]
		public bool IsDeleted
		{
			get
			{
				return this._IsDeleted;
			}
			set
			{
				if ((this._IsDeleted != value))
				{
					this.OnIsDeletedChanging(value);
					this.SendPropertyChanging();
					this._IsDeleted = value;
					this.SendPropertyChanged("IsDeleted");
					this.OnIsDeletedChanged();
				}
			}
		}
		
		[Association(Name="Post_Comment", Storage="_Comments", ThisKey="PostID", OtherKey="PostID")]
		public EntitySet<Comment> Comments
		{
			get
			{
				return this._Comments;
			}
			set
			{
				this._Comments.Assign(value);
			}
		}
		
		[Association(Name="Post_PostCategoryMapper", Storage="_PostCategoryMappers", ThisKey="PostID", OtherKey="PostID")]
		public EntitySet<PostCategoryMapper> PostCategoryMappers
		{
			get
			{
				return this._PostCategoryMappers;
			}
			set
			{
				this._PostCategoryMappers.Assign(value);
			}
		}
		
		[Association(Name="Author_Post", Storage="_Author", ThisKey="AuthorID", OtherKey="AuthorID", IsForeignKey=true)]
		public Author Author
		{
			get
			{
				return this._Author.Entity;
			}
			set
			{
				Author previousValue = this._Author.Entity;
				if (((previousValue != value) 
							|| (this._Author.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Author.Entity = null;
						previousValue.Posts.Remove(this);
					}
					this._Author.Entity = value;
					if ((value != null))
					{
						value.Posts.Add(this);
						this._AuthorID = value.AuthorID;
					}
					else
					{
						this._AuthorID = default(int);
					}
					this.SendPropertyChanged("Author");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Comments(Comment entity)
		{
			this.SendPropertyChanging();
			entity.Post = this;
		}
		
		private void detach_Comments(Comment entity)
		{
			this.SendPropertyChanging();
			entity.Post = null;
		}
		
		private void attach_PostCategoryMappers(PostCategoryMapper entity)
		{
			this.SendPropertyChanging();
			entity.Post = this;
		}
		
		private void detach_PostCategoryMappers(PostCategoryMapper entity)
		{
			this.SendPropertyChanging();
			entity.Post = null;
		}
	}
	
	[Table(Name="dbo.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryID;
		
		private string _CategoryName;
		
		private string _Description;
		
		private System.DateTime _CreatedOn;
		
		private string _CreatedBy;
		
		private System.DateTime _ModifiedOn;
		
		private string _ModifiedBy;
		
		private bool _IsDeleted;
		
		private EntitySet<PostCategoryMapper> _PostCategoryMappers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnIsDeletedChanging(bool value);
    partial void OnIsDeletedChanged();
    #endregion
		
		public Category()
		{
			this._PostCategoryMappers = new EntitySet<PostCategoryMapper>(new Action<PostCategoryMapper>(this.attach_PostCategoryMappers), new Action<PostCategoryMapper>(this.detach_PostCategoryMappers));
			OnCreated();
		}
		
		[Column(Storage="_CategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_CategoryName", DbType="VarChar(50)")]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
				}
			}
		}
		
		[Column(Storage="_Description", DbType="VarChar(200)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_IsDeleted", DbType="Bit NOT NULL")]
		public bool IsDeleted
		{
			get
			{
				return this._IsDeleted;
			}
			set
			{
				if ((this._IsDeleted != value))
				{
					this.OnIsDeletedChanging(value);
					this.SendPropertyChanging();
					this._IsDeleted = value;
					this.SendPropertyChanged("IsDeleted");
					this.OnIsDeletedChanged();
				}
			}
		}
		
		[Association(Name="Category_PostCategoryMapper", Storage="_PostCategoryMappers", ThisKey="CategoryID", OtherKey="CategoryID")]
		public EntitySet<PostCategoryMapper> PostCategoryMappers
		{
			get
			{
				return this._PostCategoryMappers;
			}
			set
			{
				this._PostCategoryMappers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PostCategoryMappers(PostCategoryMapper entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_PostCategoryMappers(PostCategoryMapper entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[Table(Name="dbo.Comments")]
	public partial class Comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CommentID;
		
		private int _PostID;
		
		private System.DateTime _CommentDate;
		
		private string _Author;
		
		private string _CommentText;
		
		private System.DateTime _CreatedOn;
		
		private string _CreatedBy;
		
		private System.DateTime _ModifiedOn;
		
		private string _ModifiedBy;
		
		private bool _IsDeleted;
		
		private EntityRef<Post> _Post;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCommentIDChanging(int value);
    partial void OnCommentIDChanged();
    partial void OnPostIDChanging(int value);
    partial void OnPostIDChanged();
    partial void OnCommentDateChanging(System.DateTime value);
    partial void OnCommentDateChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnCommentTextChanging(string value);
    partial void OnCommentTextChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnModifiedOnChanging(System.DateTime value);
    partial void OnModifiedOnChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnIsDeletedChanging(bool value);
    partial void OnIsDeletedChanged();
    #endregion
		
		public Comment()
		{
			this._Post = default(EntityRef<Post>);
			OnCreated();
		}
		
		[Column(Storage="_CommentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CommentID
		{
			get
			{
				return this._CommentID;
			}
			set
			{
				if ((this._CommentID != value))
				{
					this.OnCommentIDChanging(value);
					this.SendPropertyChanging();
					this._CommentID = value;
					this.SendPropertyChanged("CommentID");
					this.OnCommentIDChanged();
				}
			}
		}
		
		[Column(Storage="_PostID", DbType="Int NOT NULL")]
		public int PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					if (this._Post.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[Column(Storage="_CommentDate", DbType="DateTime NOT NULL")]
		public System.DateTime CommentDate
		{
			get
			{
				return this._CommentDate;
			}
			set
			{
				if ((this._CommentDate != value))
				{
					this.OnCommentDateChanging(value);
					this.SendPropertyChanging();
					this._CommentDate = value;
					this.SendPropertyChanged("CommentDate");
					this.OnCommentDateChanged();
				}
			}
		}
		
		[Column(Storage="_Author", DbType="VarChar(255)")]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[Column(Storage="_CommentText", DbType="VarChar(255)")]
		public string CommentText
		{
			get
			{
				return this._CommentText;
			}
			set
			{
				if ((this._CommentText != value))
				{
					this.OnCommentTextChanging(value);
					this.SendPropertyChanging();
					this._CommentText = value;
					this.SendPropertyChanged("CommentText");
					this.OnCommentTextChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedOn", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[Column(Storage="_IsDeleted", DbType="Bit NOT NULL")]
		public bool IsDeleted
		{
			get
			{
				return this._IsDeleted;
			}
			set
			{
				if ((this._IsDeleted != value))
				{
					this.OnIsDeletedChanging(value);
					this.SendPropertyChanging();
					this._IsDeleted = value;
					this.SendPropertyChanged("IsDeleted");
					this.OnIsDeletedChanged();
				}
			}
		}
		
		[Association(Name="Post_Comment", Storage="_Post", ThisKey="PostID", OtherKey="PostID", IsForeignKey=true)]
		public Post Post
		{
			get
			{
				return this._Post.Entity;
			}
			set
			{
				Post previousValue = this._Post.Entity;
				if (((previousValue != value) 
							|| (this._Post.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Post.Entity = null;
						previousValue.Comments.Remove(this);
					}
					this._Post.Entity = value;
					if ((value != null))
					{
						value.Comments.Add(this);
						this._PostID = value.PostID;
					}
					else
					{
						this._PostID = default(int);
					}
					this.SendPropertyChanged("Post");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dbo.PostCategoryMapper")]
	public partial class PostCategoryMapper : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PostID;
		
		private int _CategoryID;
		
		private EntityRef<Category> _Category;
		
		private EntityRef<Post> _Post;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostIDChanging(int value);
    partial void OnPostIDChanged();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    #endregion
		
		public PostCategoryMapper()
		{
			this._Category = default(EntityRef<Category>);
			this._Post = default(EntityRef<Post>);
			OnCreated();
		}
		
		[Column(Storage="_PostID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					if (this._Post.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[Column(Storage="_CategoryID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[Association(Name="Category_PostCategoryMapper", Storage="_Category", ThisKey="CategoryID", OtherKey="CategoryID", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.PostCategoryMappers.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.PostCategoryMappers.Add(this);
						this._CategoryID = value.CategoryID;
					}
					else
					{
						this._CategoryID = default(int);
					}
					this.SendPropertyChanged("Category");
				}
			}
		}
		
		[Association(Name="Post_PostCategoryMapper", Storage="_Post", ThisKey="PostID", OtherKey="PostID", IsForeignKey=true)]
		public Post Post
		{
			get
			{
				return this._Post.Entity;
			}
			set
			{
				Post previousValue = this._Post.Entity;
				if (((previousValue != value) 
							|| (this._Post.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Post.Entity = null;
						previousValue.PostCategoryMappers.Remove(this);
					}
					this._Post.Entity = value;
					if ((value != null))
					{
						value.PostCategoryMappers.Add(this);
						this._PostID = value.PostID;
					}
					else
					{
						this._PostID = default(int);
					}
					this.SendPropertyChanged("Post");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
