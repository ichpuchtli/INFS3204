﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.35312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicLINQWebApp
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
    using System.ServiceModel;
	using System;
    using System.Runtime.Serialization;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertClub(Club instance);
    partial void UpdateClub(Club instance);
    partial void DeleteClub(Club instance);
    partial void InsertMembership(Membership instance);
    partial void UpdateMembership(Membership instance);
    partial void DeleteMembership(Membership instance);
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Club> Clubs
		{
			get
			{
				return this.GetTable<Club>();
			}
		}
		
		public System.Data.Linq.Table<Membership> Memberships
		{
			get
			{
				return this.GetTable<Membership>();
			}
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
	}
	
    [DataContract]
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Club")]
	public partial class Club : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _RegistrationID;
		
		private string _Name;
		
		private System.DateTime _Founded;
		
		private System.Nullable<int> _WorldRanking;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRegistrationIDChanging(string value);
    partial void OnRegistrationIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFoundedChanging(System.DateTime value);
    partial void OnFoundedChanged();
    partial void OnWorldRankingChanging(System.Nullable<int> value);
    partial void OnWorldRankingChanged();
    #endregion
		
		public Club()
		{
			OnCreated();
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string RegistrationID
		{
			get
			{
				return this._RegistrationID;
			}
			set
			{
				if ((this._RegistrationID != value))
				{
					this.OnRegistrationIDChanging(value);
					this.SendPropertyChanging();
					this._RegistrationID = value;
					this.SendPropertyChanged("RegistrationID");
					this.OnRegistrationIDChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Founded", DbType="DateTime2 NOT NULL")]
		public System.DateTime Founded
		{
			get
			{
				return this._Founded;
			}
			set
			{
				if ((this._Founded != value))
				{
					this.OnFoundedChanging(value);
					this.SendPropertyChanging();
					this._Founded = value;
					this.SendPropertyChanged("Founded");
					this.OnFoundedChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorldRanking", DbType="Int")]
		public System.Nullable<int> WorldRanking
		{
			get
			{
				return this._WorldRanking;
			}
			set
			{
				if ((this._WorldRanking != value))
				{
					this.OnWorldRankingChanging(value);
					this.SendPropertyChanging();
					this._WorldRanking = value;
					this.SendPropertyChanged("WorldRanking");
					this.OnWorldRankingChanged();
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
	
    [DataContract]
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Membership")]
	public partial class Membership : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MembershipID;
		
		private string _PlayerID;
		
		private string _ClubID;
		
		private System.DateTime _StartDate;
		
		private System.Nullable<System.DateTime> _EndDate;
		
		private System.Nullable<int> _NumOfGames;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMembershipIDChanging(string value);
    partial void OnMembershipIDChanged();
    partial void OnPlayerIDChanging(string value);
    partial void OnPlayerIDChanged();
    partial void OnClubIDChanging(string value);
    partial void OnClubIDChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEndDateChanged();
    partial void OnNumOfGamesChanging(System.Nullable<int> value);
    partial void OnNumOfGamesChanged();
    #endregion
		
		public Membership()
		{
			OnCreated();
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MembershipID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MembershipID
		{
			get
			{
				return this._MembershipID;
			}
			set
			{
				if ((this._MembershipID != value))
				{
					this.OnMembershipIDChanging(value);
					this.SendPropertyChanging();
					this._MembershipID = value;
					this.SendPropertyChanged("MembershipID");
					this.OnMembershipIDChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PlayerID
		{
			get
			{
				return this._PlayerID;
			}
			set
			{
				if ((this._PlayerID != value))
				{
					this.OnPlayerIDChanging(value);
					this.SendPropertyChanging();
					this._PlayerID = value;
					this.SendPropertyChanged("PlayerID");
					this.OnPlayerIDChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClubID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ClubID
		{
			get
			{
				return this._ClubID;
			}
			set
			{
				if ((this._ClubID != value))
				{
					this.OnClubIDChanging(value);
					this.SendPropertyChanging();
					this._ClubID = value;
					this.SendPropertyChanged("ClubID");
					this.OnClubIDChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime2 NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime2")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumOfGames", DbType="Int")]
		public System.Nullable<int> NumOfGames
		{
			get
			{
				return this._NumOfGames;
			}
			set
			{
				if ((this._NumOfGames != value))
				{
					this.OnNumOfGamesChanging(value);
					this.SendPropertyChanging();
					this._NumOfGames = value;
					this.SendPropertyChanged("NumOfGames");
					this.OnNumOfGamesChanged();
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
	
    [DataContract]
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Player")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _RegistrationID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.Nullable<int> _PhoneNumber;
		
		private string _Address;
		
		private System.DateTime _DateOfBirth;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRegistrationIDChanging(string value);
    partial void OnRegistrationIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnPhoneNumberChanging(System.Nullable<int> value);
    partial void OnPhoneNumberChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnDateOfBirthChanging(System.DateTime value);
    partial void OnDateOfBirthChanged();
    #endregion
		
		public Player()
		{
			OnCreated();
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string RegistrationID
		{
			get
			{
				return this._RegistrationID;
			}
			set
			{
				if ((this._RegistrationID != value))
				{
					this.OnRegistrationIDChanging(value);
					this.SendPropertyChanging();
					this._RegistrationID = value;
					this.SendPropertyChanged("RegistrationID");
					this.OnRegistrationIDChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="Int")]
		public System.Nullable<int> PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
        [DataMember]
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="DateTime2 NOT NULL")]
		public System.DateTime DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
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
