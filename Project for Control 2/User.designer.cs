﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_for_Control_2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GESTION_DENTAL_CLINIC")]
	public partial class UserDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InserttbUser(tbUser instance);
    partial void UpdatetbUser(tbUser instance);
    partial void DeletetbUser(tbUser instance);
    #endregion
		
		public UserDataContext() : 
				base(global::Project_for_Control_2.Properties.Settings.Default.GESTION_DENTAL_CLINICConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public UserDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbUser> tbUser
		{
			get
			{
				return this.GetTable<tbUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbUser")]
	public partial class tbUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _Login;
		
		private string _address;
		
		private string _phone;
		
		private string _role;
		
		private System.DateTime _Dateofbirth;
		
		private string _password;
		
		private System.Nullable<System.DateTime> _Created_at;
		
		private string _Created_by;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnLoginChanging(string value);
    partial void OnLoginChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    partial void OnDateofbirthChanging(System.DateTime value);
    partial void OnDateofbirthChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnCreated_atChanging(System.Nullable<System.DateTime> value);
    partial void OnCreated_atChanged();
    partial void OnCreated_byChanging(string value);
    partial void OnCreated_byChanged();
    #endregion
		
		public tbUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				if ((this._Login != value))
				{
					this.OnLoginChanging(value);
					this.SendPropertyChanging();
					this._Login = value;
					this.SendPropertyChanged("Login");
					this.OnLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dateofbirth", DbType="Date NOT NULL")]
		public System.DateTime Dateofbirth
		{
			get
			{
				return this._Dateofbirth;
			}
			set
			{
				if ((this._Dateofbirth != value))
				{
					this.OnDateofbirthChanging(value);
					this.SendPropertyChanging();
					this._Dateofbirth = value;
					this.SendPropertyChanged("Dateofbirth");
					this.OnDateofbirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Created at]", Storage="_Created_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> Created_at
		{
			get
			{
				return this._Created_at;
			}
			set
			{
				if ((this._Created_at != value))
				{
					this.OnCreated_atChanging(value);
					this.SendPropertyChanging();
					this._Created_at = value;
					this.SendPropertyChanged("Created_at");
					this.OnCreated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Created by]", Storage="_Created_by", DbType="VarChar(50)")]
		public string Created_by
		{
			get
			{
				return this._Created_by;
			}
			set
			{
				if ((this._Created_by != value))
				{
					this.OnCreated_byChanging(value);
					this.SendPropertyChanging();
					this._Created_by = value;
					this.SendPropertyChanged("Created_by");
					this.OnCreated_byChanged();
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