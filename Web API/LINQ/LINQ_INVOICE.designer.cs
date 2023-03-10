#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_API.LINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="InvoiceSystem")]
	public partial class LINQ_INVOICEDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCoffee(Coffee instance);
    partial void UpdateCoffee(Coffee instance);
    partial void DeleteCoffee(Coffee instance);
    #endregion
		
		public LINQ_INVOICEDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["InvoiceSystemConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ_INVOICEDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ_INVOICEDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ_INVOICEDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ_INVOICEDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Coffee> Coffees
		{
			get
			{
				return this.GetTable<Coffee>();
			}
		}
		
		public System.Data.Linq.Table<CoffeeView> CoffeeViews
		{
			get
			{
				return this.GetTable<CoffeeView>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Coffee")]
	public partial class Coffee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CoffeeTypeId;
		
		private string _CoffeeTypeName;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<bool> _Active;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCoffeeTypeIdChanging(string value);
    partial void OnCoffeeTypeIdChanged();
    partial void OnCoffeeTypeNameChanging(string value);
    partial void OnCoffeeTypeNameChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    #endregion
		
		public Coffee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoffeeTypeId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CoffeeTypeId
		{
			get
			{
				return this._CoffeeTypeId;
			}
			set
			{
				if ((this._CoffeeTypeId != value))
				{
					this.OnCoffeeTypeIdChanging(value);
					this.SendPropertyChanging();
					this._CoffeeTypeId = value;
					this.SendPropertyChanged("CoffeeTypeId");
					this.OnCoffeeTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoffeeTypeName", DbType="NVarChar(50)")]
		public string CoffeeTypeName
		{
			get
			{
				return this._CoffeeTypeName;
			}
			set
			{
				if ((this._CoffeeTypeName != value))
				{
					this.OnCoffeeTypeNameChanging(value);
					this.SendPropertyChanging();
					this._CoffeeTypeName = value;
					this.SendPropertyChanged("CoffeeTypeName");
					this.OnCoffeeTypeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CoffeeView")]
	public partial class CoffeeView
	{
		
		private string _CoffeeTypeId;
		
		private string _CoffeeTypeName;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<bool> _Active;
		
		public CoffeeView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoffeeTypeId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CoffeeTypeId
		{
			get
			{
				return this._CoffeeTypeId;
			}
			set
			{
				if ((this._CoffeeTypeId != value))
				{
					this._CoffeeTypeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoffeeTypeName", DbType="NVarChar(50)")]
		public string CoffeeTypeName
		{
			get
			{
				return this._CoffeeTypeName;
			}
			set
			{
				if ((this._CoffeeTypeName != value))
				{
					this._CoffeeTypeName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
